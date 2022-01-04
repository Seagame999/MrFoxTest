using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTicketsApi.Model
{
    [Table("Concert")]
    public class Concert
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Title { get; set; }

        public System.DateTime ShowDate { get; set; }
        
        public string  Location { get; set; }
    }
}