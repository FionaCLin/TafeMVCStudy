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
                //var person = facade.AddPerson("Frank Black");

                //var person = facade.People.Where(p => p.Name.Equals("Frank Black")).First();
                //var person = facade.FetchPerson("Jack Black");
                ////person = facade.UpdatePerson(person.Id, "Jack Black");
                //if(person != null)
                //{
                //    person = facade.UpdatePerson(person.Id,"Frank Black");
                //}
                var id = Guid.Empty;
                ////delete 
                //var person = facade.FetchPerson("Frank Black");
                //if (person != null)
                //{
                // facade.DeletePerson(person.Id);
                //}
                var person = facade.FetchPerson(id);
                //foreach (var p in facade.People)
                //{
                //    Console.WriteLine("Id: {0} Name: {1}", p.Id, p.Name);
                //}
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
