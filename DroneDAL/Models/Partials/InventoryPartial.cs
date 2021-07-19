using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DroneDAL.Models
{
    public partial class Inventory
    {
        public override string ToString()
        {
            //TODO 5. <place holder for case study workshop lab tasks>
            return $"{this.PetName ?? "**No Name**"} is a {this.Color} {this.Make} with ID {this.DroneId}.";
        }
        [NotMapped]
        public string MakeColor => $"{Make} + ({Color})";
    }
}
