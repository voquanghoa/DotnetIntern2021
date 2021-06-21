using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise2
    {
        private readonly DataFactory dataFactory = new();

        public List<Student> FindStudentByBirthdayYear(int year)
        {
            return dataFactory
                .Students
                .Where(s => s.Birthday.Year == year)
                .ToList();
        }
    }
}
