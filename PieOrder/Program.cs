using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hurley's Bakery");
            int NoOfPies;
            
            double price1, price2, price3, price4;
            price1 = 4.00;
            price2 = 3.50;
            price3 = 3.25;
            price4 = 3.00;
            string LastName;
            Console.WriteLine("Please input your last name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter number of pies:");
            NoOfPies = Convert.ToInt32(Console.ReadLine());
            const double charge = 0.50;
            double initialPrice1 = ((NoOfPies * price1)+ charge);
            double initialPrice2 = ((NoOfPies * price2)+charge);
            double initialPrice3 = ((NoOfPies * price3)+ charge);
            double initialPrice4 = ((NoOfPies * price4)+ charge);

            Console.WriteLine("You are obligated to pay a cover charge of $0.50 ");
            if (NoOfPies == 1)
            {
                Console.WriteLine("Number of mini pies purchased:\n {0}", NoOfPies);
                Console.WriteLine("The cost of your order is : \n${0}\n", initialPrice1);
            }

            else if(NoOfPies <= 4)
            {
                Console.WriteLine("Number of mini pies purchased:\n {0}", NoOfPies);
                Console.WriteLine("The cost of your order is :\n ${0}\n", initialPrice2);
            }
            else if (NoOfPies < 8)
            {
                Console.WriteLine("Number of mini pies purchased:\n {0}", NoOfPies);
                Console.WriteLine("The cost of your order is :\n ${0}\n", initialPrice3);
            }
            else if (NoOfPies >= 8 )
            {
                Console.WriteLine("Number of mini pies purchased:\n {0}", NoOfPies);
                Console.WriteLine("The total cost of your order is : \n${0}\n", initialPrice4);
            }
            else 
            {
                Console.WriteLine("No such order! Please input at least one mini pie needs to be ordered");
            }




            double tax;
            tax = 0.13;

             if ( NoOfPies==1)
            {
                Console.WriteLine("Customer is obligated to pay a tax of 13% ");
                Console.WriteLine("New price={0}", ((initialPrice1 * tax) + initialPrice1));
            }
            else if ( NoOfPies>1 && NoOfPies <= 4)
            {
                Console.WriteLine("Customer is obligated to pay a tax of 13% ");
                Console.WriteLine("New price={0}", ((initialPrice2 * tax) + initialPrice2));
            }

            if (NoOfPies>4 && NoOfPies <= 8)
            {
                Console.WriteLine("Customer is obligated to pay a tax of 13% ");
                Console.WriteLine("New price={0}", ((initialPrice3 * tax) + initialPrice3));
            }
            if (NoOfPies>8 && NoOfPies <12)
            {
                Console.WriteLine("Customer is obligated to pay a tax of 13% ");
                Console.WriteLine("New price={0}", ((initialPrice4 * tax) + initialPrice4));
            }
            if (NoOfPies > 12 || NoOfPies==0)
            {
                Console.WriteLine("Customer is not obligated to pay any tax");
                
            }
        }
    }
}
