using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CourseModel
    {
        public long CourseId { get; set; }

        public string Title { get; set; }

        public string CourseTypeName { get; set; }
    }

    public class CourseType
    {
        public long CourseTypeId { get; set; }

        public string CourseTypeName { get; set; }
    }

    public class Course
    {

        public long CourseId { get; set; }

        public string Title { get; set; }

        public long CourseType_id { get; set; }
    }
}
