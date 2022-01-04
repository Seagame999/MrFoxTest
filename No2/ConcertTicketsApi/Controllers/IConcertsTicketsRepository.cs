using ConcertTicketsApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConcertTicketsApi.Controllers
{
    internal interface IConcertsTicketsRepository
    {
    Task<IEnumerable<ConcertTickets>> GetConcertTicket();

    Task<ConcertTickets> GetConcertTicket(int Id);
    Task<ConcertTickets> UpdateConcertTicket(ConcertTickets concertTickets);
    }
}