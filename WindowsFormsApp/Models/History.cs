namespace NorthBee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        [Key]
        public int IdHistory { get; set; }

        public int GuestId { get; set; }

        public int RoomId { get; set; }

        [Column(TypeName = "date")]
        public DateTime CheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime CheckOut { get; set; }

        public string Comment { get; set; }

        public virtual Guest Guest { get; set; }

        public virtual Room Room { get; set; }
    }
}
