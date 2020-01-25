using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public School()
        {
            Students = new List<Student>();
        }
    }
}
