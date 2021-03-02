using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
   public class Student
    { 
            public string Name { get; set; }
            public string Address { get; set; }
            public string Class { get; set; }
            public string ClassNumber { get; set; }
            public DateTime BirthDate { get; set; }
            public bool LikeMath { get; set; }
            public bool LikeCS { get; set; }
            public Student()
            {
                LikeMath = false;
                LikeCS = false;
                BirthDate = new DateTime(2004, 1, 1);
                Name = null;
                Address = null;
                Class = "select garde";
            

            }
        
    }
}
