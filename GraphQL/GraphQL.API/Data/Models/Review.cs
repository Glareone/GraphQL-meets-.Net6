using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQL.Data.Models;

public class Review
{
    [Key]
    public int Id { get; set; }

    public int Rate { get; set; }

    public string Comment { get; set; }
    
    // Relations with Course
    public int CourseId { get; set; }

    [ForeignKey("CourseId")]
    public Course Course { get; set; }
    
}