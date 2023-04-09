using System.ComponentModel.DataAnnotations;

namespace GraphQL.Data.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        
        // Relations
        public IEnumerable<Review> Reviews { get; set; }
    }
}
