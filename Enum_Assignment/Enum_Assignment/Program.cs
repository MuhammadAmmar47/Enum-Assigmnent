using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Assignment
{
    class Program
    {
        class EnumProgram{
            enum month {Jan=1,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec};
            static void Main(string[] args)
            {
                Console.Write("Enter The day : ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter The month: ");
                string Month = Console.ReadLine();
                Console.Write("Enter The Year : ");
                int year = Convert.ToInt32(Console.ReadLine());
                month m ;
                int n;
            
                
                    if (Enum.TryParse<month>(Month, out m)) {
                             n = (int)(month)m;
                        Console.WriteLine(n);
                        Console.WriteLine("Date is : {0}-{1}-{2}", n, day, year);
                    }
                    
                Console.ReadLine();
            }


        }
        }
    
}
