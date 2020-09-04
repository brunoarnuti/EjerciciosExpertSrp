using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        // Tambien cabe destacar que esta clase se parece mas a un modelo de programacion procedural que uno orientado a objetos, no hay ningun objeto interactuando, sino que es simplemente un metodo y sus parametros
        // Refiriendose a los parametros, me parece que este metodo maneja demasiados parametros, parametros que tienen gran relacion entre ellos, es decir, que bien podrian estar agrupados en un unico objeto "persona" u "doctor" por ejemplo
        // Me resulta importante destacar tambien que el apponitment no queda guardado en ningun lugar, simplemente se devuelve en un string
        // Por todo lo dicho anteriormente; esta clase, en particular este metodo, tiene mas de una razon de cambio, puede o bien cambiar porque la informacion necesaria para crear el appointment cambia, o bien porque la forma de mostrar la informacion cambia, eso viola el SRP.
        // Lo sensato seria crear una clase User, Doctor, y Appointment
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
