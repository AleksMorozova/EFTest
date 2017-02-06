using BL.Implementation;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            //user.FirstName = "BL user name 2";
            //user.LastName = "BL user  last name 2";
            //user.Login = "BL user  login 2";

            UserImplementation imp = new UserImplementation();
            // var user = imp.GetUserByID();
            //Console.WriteLine("User was readed" + user.FirstName);
            imp.SaveUser(new User { FirstName = "Test 112346", LastName = "Peters", Login = "qwe" });
            Console.WriteLine("User was added");
            Console.ReadKey();
        }
    }
}
