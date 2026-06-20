namespace NorthBee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            History = new HashSet<History>();
        }

        [Key]
        public int IdRoom { get; set; }

        public int Number { get; set; }

        public int RoomTypeId { get; set; }

        public int HotelId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> History { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
