using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace bogus_API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(MovieId))]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
