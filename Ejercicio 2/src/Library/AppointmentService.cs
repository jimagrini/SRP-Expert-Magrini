using System;
using System.Text;

namespace Library
{
    /*
    Esta nueva clase PersonData tiene como unica responsabilidad guardar la
    información personal del usuario
    */
    public class PersonData
    {
        public string Name {get; set;}
        public string Id {get; set;}
        public string PhoneNumber {get; set;}
        public PersonData(String name, String id, string phoneNumber)
        {
            StringBuilder stringBuilder = new StringBuilder("Saving personal data...\n");
            Boolean isValid = true;
            
            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to save your personal data, field 'name' is required\n");
                isValid = false;
            }
            else
            {
                this.Name=name;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to save your personal data, field 'id' is required\n");
                isValid = false;
            }
            else
            {
                this.Id=id;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to save your personal data, field 'phone number' is required\n");
                isValid = false;
            }
            else
            {
                this.PhoneNumber=phoneNumber;
            }
            if (isValid)
            {
                stringBuilder.Append("Personal data successfully saved");
            }
            Console.WriteLine(stringBuilder.ToString());   
        }
    }
    public class AppointmentService
    {
        /*Opino que AppointmentService violaba el principio SRP debido a que tiene más de una razon de cambio
        los datos de la persona deberían de almacenarse en otra clase distinta por ej: PersonData y que la
        unica razón de cambio sea editar datos de la persona. Por otro lado otra clase para fijar la cita médica
        que la única razón de cambio sea editar la cita médica
        */
        public static string CreateAppointment(PersonData person,DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder($"Scheduling appointment for {person.Name} ...\n");
            Boolean isValid = true;
            
            
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
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}