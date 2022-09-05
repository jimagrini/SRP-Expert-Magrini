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
        public string Age {get; set;}
        public string Name {get; set;}
        public string Id {get; set;}
        public string PhoneNumber {get; set;}
        public PersonData(String name, string age, String id, string phoneNumber)
        {
            StringBuilder stringBuilder = new StringBuilder("Saving personal data...\n");
            Boolean isValid = true;
            
            this.Age=age;
            
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
}