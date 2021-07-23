using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneDAL.Models
{
    //TODO 4. <place holder for case study workshop 2 lab tasks>
    public partial class Order
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        public int CustId { get; set; }

        [Required]
        public int DroneId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        [ForeignKey("CustId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("DroneId")]
        public virtual Inventory Drone { get; set; }
    }
}
