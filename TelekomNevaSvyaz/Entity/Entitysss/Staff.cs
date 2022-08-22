namespace TelekomNevaSvyaz.Entity.Entitysss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ISPr21-47_KadrovDP_test.Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            EquipmentHistories = new HashSet<EquipmentHistory>();
            Requests = new HashSet<Request>();
        }

        public int StaffId { get; set; }

        [Required]
        [StringLength(32)]
        public string StaffFirstname { get; set; }

        [Required]
        [StringLength(32)]
        public string StaffLastname { get; set; }

        [StringLength(32)]
        public string StaffPatronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime StaffDateOfBirth { get; set; }

        [Column(TypeName = "date")]
        public DateTime StaffStartWorkDate { get; set; }

        [Column(TypeName = "ubigint")]
        public decimal StaffPhone { get; set; }

        [StringLength(32)]
        public string StaffPhoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentHistory> EquipmentHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}
