using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthdate { get; set; }
        public bool likesmusic { get; set; }
        public ICollection<string> skills { get; set; }
    }
}