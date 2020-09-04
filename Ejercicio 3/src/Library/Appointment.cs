using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        private String place;
        public DateTime date;

        public User User {get;}
        public Doctor Doctor {get;}

        public String Place
        { 
             get
             {
                 return this.place;
             }
             set
             {
                 if(!String.IsNullOrEmpty(value))
                 {
                     this.place = value;
                 }
             }
        }
    
       
        public Appointment(User user, Doctor doctor, DateTime date, String place)
        {
            if (!string.IsNullOrEmpty(user.Name) & !string.IsNullOrEmpty(user.PhoneNumber) & !string.IsNullOrEmpty(user.Id)) 
            {
                this.User = user;
            }
            if (!string.IsNullOrEmpty(doctor.Name))
            {
                this.Doctor = doctor;
            }
            this.Place = place;
        }

        public String GetTextToPrint()
        {
            return $"Nombre:${this.User.Name}, ID:${this.User.Id}, Numero:${this.User.PhoneNumber}, Doctor: ${this.Doctor.Name}, Fecha:${this.date.ToString()}, Lugar:${this.Place}";
        }

    }

}