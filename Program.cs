using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
				MyDbContext db = new MyDbContext();
				Programme p =	new Programme();
				p.Id = 100;
				p.Title = "CESS";
				p.Duration = 5;
				p.Fees = 10000;
				db.Programmes.Add(p);
				db.SaveChanges();
				Console.WriteLine("Database Created");
				Console.ReadLine();

			}
			catch (Exception e)
			{
                Console.WriteLine(e.Message);

            }
        }
    }
}
