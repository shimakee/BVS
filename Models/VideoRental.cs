using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VideoRental : BaseEntity
    {
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public RentalStatus Status {get; set;}
        public virtual Customer Customer { get; set; }
        public virtual Video Video { get; set; }
    }

    public enum RentalStatus
    {
        Rented,
        Returned
    }
}
