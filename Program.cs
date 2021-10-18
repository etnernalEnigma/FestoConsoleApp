using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestoConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CourseBusinessLayer courseBusinessLayer = new CourseBusinessLayer();
            string arg = args != null && args.Length > 0  ? args[0] : null;
            List<CourseModel> models = courseBusinessLayer.GetAllCourse(arg).ToList();
            models = models.OrderBy(item => item.Title).ToList();
            Console.WriteLine("CourseTitle              CourseName            ");
            foreach (var model in models)
            {
                Console.WriteLine("{0}              {1}", model.Title, model.CourseTypeName);
            }
            Console.ReadKey();
        }
    }
}
