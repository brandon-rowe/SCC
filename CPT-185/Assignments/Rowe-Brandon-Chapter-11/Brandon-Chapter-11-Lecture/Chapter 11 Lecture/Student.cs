using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11_Lecture
{
    abstract class Student
    {
        private string _name;
        private string _id;

        public Student(string name, string id)
        {
            _name = name;
            _id = id;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public abstract double RequiredHours
        {
            get;
        }
    }
}
