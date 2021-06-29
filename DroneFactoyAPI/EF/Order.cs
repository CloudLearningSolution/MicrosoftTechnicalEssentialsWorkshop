namespace DroneFactoyAPI.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderId { get; set; }

        public int CustId { get; set; }

        public int DroneId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Drone Drone { get; set; }
    }
}
