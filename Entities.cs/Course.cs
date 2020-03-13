using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseLibrary.API.Entities
{
    public class Course
    {
        [Key]       
        public Guid Id { get; set; }

        [Required]
        [MaxLength(90)]
        public string Title { get; set; }

        [MaxLength(1501)]
        public string Description { get; set; }

        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        public Guid AuthorId { get; set; }
    }
}
