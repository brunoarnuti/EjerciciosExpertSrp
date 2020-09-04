using System;
using System.Text;

namespace Library
{
    public class User
    {
        private string name;
        private string id;
        private string phoneNumber;

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
        
        public string Id 
        {
             get
             {
                 return this.id;
             }
             set
             {
                 if(!string.IsNullOrEmpty(value))
                 {
                     this.Id = value;
                 }
             }
        }

        public string PhoneNumber
        { 
             get
             {
                 return this.phoneNumber;
             }
             set
             {
                 if(!string.IsNullOrEmpty(value))
                 {
                     this.phoneNumber = value;
                 }
             }
        }

        public User(string id, string phoneNumber)
        {
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }

    }

}