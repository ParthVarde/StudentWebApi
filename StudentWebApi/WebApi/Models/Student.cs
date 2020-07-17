using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public DateTime StudentDob { get; set; }

        public int StudentMarks { get; set; }
    }
}
