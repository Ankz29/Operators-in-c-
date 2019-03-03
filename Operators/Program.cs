using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ArithematicOperators modelClass = new ArithematicOperators();
          modelClass.Operators();

            voteRights();
        }

        public static int voteRights()
        {
            int age = 18;
            if(age <= 18)
            {
                Console.WriteLine("not eligible to vote...");
            }
            else 
            {
                Console.WriteLine("eligible to vote....");
            }
            return age;
            }
        }
    }

