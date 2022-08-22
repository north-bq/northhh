namespace TelekomNevaSvyaz.Entity.Entitysss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Requests = new HashSet<Request>();
        }

        public int ServiceId { get; set; }

        [Required]
        [StringLength(128)]
        public string ServiceName { get; set; }

        public int ServiceDurationInMunutes { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string ServiceDescription { get; set; }

        public byte[] ServicePhoto { get; set; }

        public sbyte ServiceIsVisit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}
