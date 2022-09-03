using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonData StevenJohnson = new PersonData("Steven Johnson","45","986782342", "5555-555-555");
            string appointmentResult = AppointmentService.CreateAppointment(StevenJohnson, DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            PersonData RalfManson = new PersonData("Ralf Manson","32","","5555-555-555");
            
            //string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            //Console.WriteLine(appointmentResult2);
        }
    }
}