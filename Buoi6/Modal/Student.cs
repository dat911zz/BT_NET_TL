using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.Modal
{
    public class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public bool Gender { get; set; }
        public string ForeignLanguages { get; set; }
        public string Ethnic { get; set; }
        public Student(string n, string i, bool g, string f, string e)
        {
            this.Name = n;
            this.Id = i;
            this.Gender = g;
            this.ForeignLanguages = f;
            this.Ethnic = e;
        }
    }
}
