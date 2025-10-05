using SQLiteWithNetCore.Data;
using SQLiteWithNetCore.Models;

namespace SQLiteWithNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = 1,
                Name = "Ali",
                Age = 24,
                Gender = "Male",
                City = "Kabul",
            };

            int result = DbCrudOps.AddUser(user);

            if(result == 0)
            {
                Console.WriteLine("No record was Updated");
            }
            else
            {
                Console.WriteLine("Record Created Successfully");
            }
            Console.WriteLine();

        }
    }
}
