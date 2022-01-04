using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConcertTicketsApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConcertTicketsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConcertTicketsApiController : ControllerBase
    {
        private readonly IConcertsTicketsRepository concertTicketsRepository;

        public class ConcertTicketsApiController(IConcertsTicketsRepository concertTicketsRepository)
        {
            this.concertTicketsRepository = concertTicketsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ConcertTickets>> ApiGetConcertTicketData()
        {
        return (await concertTicketsRepository.GetConcertTicket().ToList());
    }

        [HttpPut]
        public async Task<ActionResult<ConcertTickets>> BookConcertTicket(int id , ConcertTickets concertTickets)
        {
            if(id != concertTickets.Id)
            {
                return BadRequest("Not Found");
            }
            else
            {
                    var BookingconcertTicket = await concertTicketsRepository.GetConcertTicket(id);

                    if(concertTickets.StatusId == 1 )
                    {   
                    return StatusCode(400,"Unavaliable");
                    }

            var bookingConcertTicket = await concertTicketsRepository.UpdateConcertTicket(concertTickets);

            return StatusCode(200,$"Ticket Id :  {concertTickets.ConcertId} is booked.");
        }



        }


        public void MockData(){
            var concert = new Concert {

            Id = 1,

            Title = “Body Slam”,

             ShowDate = new DateTime(2020,12,31,19,0,0)

};

 

                Var ticket = new ConcertTicket {

                Id = 1,

                ConcertId = 1,

                ReservedBy = “Pup”,

                ReservedDate = DateTime.Now

};
        }
    }
}