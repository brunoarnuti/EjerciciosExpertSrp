using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string name;
        public string Name 
        {
             get
             {
                 return this.name;
             }
             set
             {
                 if(!string.IsNullOrEmpty(value))
                 {
                     this.name = value;
                 }
             }
        }

        public Doctor(string name)
        {
            this.Name = name;
        }

    }

}