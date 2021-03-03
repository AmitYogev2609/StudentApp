using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace StudentApp
{
   public class Student : INotifyPropertyChanged
    {
        private string name;
        private string address;
        private string clas;
        private string classnum;
        private DateTime date;
        private bool cs;
        private bool math;
            public string Name { get { return name; }
            set {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
            public string Address {
            get { return address; }
            set
            {
                address = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Address"));
            }
        }
            public string Class
        {
            get { return clas; }
            set
            {
                clas = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Class"));
            }
        }
            public string ClassNumber {
            get { return classnum; }
            set
            {
                classnum = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ClassNumber"));
            }
        }
            public DateTime BirthDate {
            get { return date; }
            set
            {
                date = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BirthDate"));
            }
        }
            public bool LikeMath {
            get { return math; }
            set
            {
               math = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LikeMath"));
            }
        }
            public bool LikeCS {
            get { return cs; }
            set
            {
                cs = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LikeCS"));
            }
        }
            public Student()
            {
                LikeMath = false;
                LikeCS = false;
                BirthDate = new DateTime(2004, 1, 1);
                Name = null;
                Address = null;
                Class = "select garde";
            

            }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
