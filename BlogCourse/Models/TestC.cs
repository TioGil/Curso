using System;
using System.ComponentModel.DataAnnotations;

namespace BlogCourse.Models
{
    public class TestC
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int Age { get; set; }

        //[Range(typeof(DateTime), "1/2/2004", "3/4/2004",
        //    ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime Created { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Updated { get; set; }

    }
}