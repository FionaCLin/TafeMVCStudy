using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var facade = new Facade();
                //create a new person record
                var person = facade.AddPerson("Michael Smith");
                //To test fetch the new person
                person = facade.FetchPerson(person.Id);
                facade.UpdatePerson(person.Id, "David Smith");
                //Print out the details of the person
                Console.WriteLine("Details: Id {0} Name {1}", person.Id, person.Name);
                //Delete the Person record
                facade.DeletePerson(person.Id);                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
