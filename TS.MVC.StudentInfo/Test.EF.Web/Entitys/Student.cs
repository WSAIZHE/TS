namespace Test.EF.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        [DisplayName("����")]

        public string Name { get; set; }

        [DisplayName("����")]
        public int Age { get; set; }

        [Required]
        [StringLength(16)]
        [DisplayName("�绰")]
        public string Mobile { get; set; }

        [Required]
        [StringLength(32)]
        [DisplayName("����")]
        public string Email { get; set; }

        [DisplayName("�༶��")]

        public int? ClassId { get; set; }

        [DisplayName("ʱ��")]
        public DateTime AddTime { get; set; }

        //public virtual Class Class { get; set; }
    }
}
