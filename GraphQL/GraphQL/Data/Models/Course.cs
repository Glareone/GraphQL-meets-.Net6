﻿using System.ComponentModel.DataAnnotations;

namespace GraphQL.Data.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Review { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
