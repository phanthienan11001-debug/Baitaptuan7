using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL
{
    public class Student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public double Grade { get; set; }
    }
}
