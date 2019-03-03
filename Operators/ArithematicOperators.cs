using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class ArithematicOperators
    {
        public int  Operators()
        {
           Console.WriteLine("enter the first no: ");
           string a = Console.ReadLine();
            Console.WriteLine("enter the second no: ");
            
            string   b= Console.ReadLine();

            int add = Int32.Parse(a + b);
            Console.WriteLine("resultant is : " +  add);
           Console.ReadLine();
            //int sub = a - b;
            //int mul = a * b;
            //int div= a % b;
            //string res = add + " " + sub + " " + mul + " " + div; 
            //Console.WriteLine("arithematic operator results are: "+ add + sub + mul + div);
            //Console.ReadLine();
            //return (res); 
            return add;
            
        }
    }
}
