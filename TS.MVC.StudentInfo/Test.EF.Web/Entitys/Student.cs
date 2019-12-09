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
        [DisplayName("名称")]

        public string Name { get; set; }

        [DisplayName("年龄")]
        public int Age { get; set; }

        [Required]
        [StringLength(16)]
        [DisplayName("电话")]
        public string Mobile { get; set; }

        [Required]
        [StringLength(32)]
        [DisplayName("邮箱")]
        public string Email { get; set; }

        [DisplayName("班级名")]

        public int? ClassId { get; set; }

        [DisplayName("时间")]
        public DateTime AddTime { get; set; }

        //public virtual Class Class { get; set; }
    }
}
