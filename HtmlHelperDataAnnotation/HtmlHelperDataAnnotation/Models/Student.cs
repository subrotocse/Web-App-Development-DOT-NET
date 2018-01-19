using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HtmlHelperDataAnnotation.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required (ErrorMessage="Please Provide your Name")]
        [StringLength(20)]
        [Column(TypeName="varchar")]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string  Email { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string  Department { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string Gender { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }
    }
}