using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneFactoyAPI.EF
{
    public partial class Drone
    {
        public override string ToString()
        {
            return $"{this.DroneNickName ?? "**No Name**"} is a {this.Color} {this.Make} with ID {this.DroneId}.";
        }
    }
}
