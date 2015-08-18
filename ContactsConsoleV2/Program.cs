using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsConsoleV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are your contacts:");
            var client = new ContactsAppV2();
            var contacts = client.Contacts.Get();
            foreach (var c in contacts)
            {
                Console.WriteLine("{0}: {1} {2}",
                    c.Id, c.Name, c.EmailAddress);

            }
            Console.ReadLine();

        }
    }
}
