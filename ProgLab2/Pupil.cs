
using System;
using System.Collections.Generic;

namespace ProgLab2
{
    class Pupil:IComparer<Pupil>
    {
        private string surname, name, patronomyc, group;
        private int course;
        private DateTime birthday;

        public string Surname {
            get { return surname; }
            set { surname = value != "" ? value : throw new ArgumentException("\"\" cant be the argument as Surname"); }
        
        }
        public string Name
        {
            get { return name; }
            set { name = value != "" ? value : throw new ArgumentException("\"\" cant be the argument as Name"); }

        }
        public string Patronomyc
        {
            get { return patronomyc; }
            set { patronomyc = value != "" ? value : throw new ArgumentException("\"\" cant be the argument as Patronomyc"); }

        }
        public int Course
        {
            get { return course; }
            set { course = value >0 && value<=5 ? value : throw new ArgumentException(String.Format("{0} cant be the argument as Course", value)); }

        }
        public string Group
        {
            get { return group; }
            set { group = value != "" ? value : throw new ArgumentException("\"\" cant be the argument as Group"); }

        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value != null ? value : throw new ArgumentException("null cant be the argument as Birthday"); }

        }

        public Pupil(string surname, string name, string patronomyc, DateTime birthday, int course, string group) {
            try
            {
                Surname = surname;
                Name = name;
                Patronomyc = patronomyc;
                Birthday = birthday;
                Course = course;
                Group = group;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        public int Compare(Pupil x, Pupil y)
        {
            if (x.Course.CompareTo(y.Course) != 0) return x.Course.CompareTo(y.Course);
            if (x.Group.CompareTo(y.Group) != 0) return x.Group.CompareTo(y.Group);
            if (x.Surname.CompareTo(y.Surname) != 0) return x.Surname.CompareTo(y.Surname);
            if (x.Name.CompareTo(y.Name) != 0) return x.Name.CompareTo(y.Name);
            if (x.Patronomyc.CompareTo(y.Patronomyc) != 0) return x.Patronomyc.CompareTo(y.Patronomyc);
            return x.Birthday.CompareTo(y.Birthday);
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", Surname, Name, Patronomyc, Birthday, Course, Group);
        }
    }
}
