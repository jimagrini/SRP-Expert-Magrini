using System;
using System.Text;

namespace Library
{
        public class AppointmentService
    {
        /*Opino que AppointmentService violaba el principio SRP debido a que tiene más de una razon de cambio
        los datos de la persona deberían de almacenarse en otra clase distinta por ej: PersonData y que la
        unica razón de cambio sea editar datos de la persona. Por otro lado otra clase para fijar la cita médica
        que la única razón de cambio sea editar la cita médica
        */
        public static string CreateAppointment(PersonData person,DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder($"Scheduling appointment ...\n");
            Boolean isValid = true;
            
            StringBuilder appointmentCode  = new StringBuilder($"APPCOD{new Random().Next()}");
            //Aqui estoy creando una variable que genera un codigo identificador para cada cita médica

            //Creo que incluir una variable sobre la especialidad del doctor es innecesario
            //ya que al especificar el nombre del doctor estariamos conociendo ya su especialidad

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append($"Appoinment for {person.Name} succesfully scheduled");
            }

            return stringBuilder.ToString() + $", the code is {appointmentCode}";
        }

    }
}