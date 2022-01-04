using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTicketsApi.Model
{
    [Table("ConcertTickets")]
    public class ConcertTickets
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public int ConcertId { get; set; }

        public Int16 StatusId { get; set; }

        public string ReserverdBy { get; set; }

    }
}