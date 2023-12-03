using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static___Sealed___Nullable.Models
{
    internal class Student
    {
        private static int _count;
        private readonly int _id;
        private string _fullname;

        public string Fullname 
        {
            get => _fullname;
            set
            {
                _fullname = value;
            } 
        }
        public int Id 
        {
            get;
        }
        public int Count 
        {
            get;
        }

        public Student(string fullname)
        {
            Fullname = fullname;
            _count++;
            Id = _count++;
        }

        public static bool CheckFullname(string fullname)
        {
            fullname = fullname.Trim();
            if (fullname.Length >= 7 && fullname.Length <= 30 && HasDigit(fullname) == false && SpaceTest(fullname) == true && SecondTest(fullname) == true)
            {
                return true;
            }
            return false;
        }

        public static bool HasDigit(string fullname)
        {
            fullname = fullname.Trim();
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsDigit(fullname[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SpaceTest(string fullname)
        {
            byte count = 0;
            fullname = fullname.Trim();
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsWhiteSpace(fullname[i]) == true && char.IsUpper(fullname[i+1]) == true)
                { 
                    count++;
                }
            }
            if (count == 1)
            {
                return true;
            }
            return false;
        }
        public static bool SecondTest(string fullname)
        {
            byte count = 0;
            fullname = fullname.Trim();
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsUpper(fullname[i]) == true)
                {
                    count++;
                }
            }
            if (count == 2 && char.IsUpper(fullname[0]) == true)
            {
                return true;
            }
            return false;
        }
    }
}
