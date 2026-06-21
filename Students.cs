using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    public class Students
    {
        public string name { get; set;}
        public string famylya { get; set;}
        public  int age { get; set; }
        public string name_group { get; set; }
        public int course { get; set; }

        public double math_grade { get; set; }
        public double indormation_grade { get; set; }
        public double english_grade { get; set; }
        public double chemistry_grade { get; set; }
        public bool IsDolgHave { get; set; }

        //у нас студенты в json массиве
        public class StudentsData
        {
            public List<Students> Students { get; set; }
        }

    }
}
