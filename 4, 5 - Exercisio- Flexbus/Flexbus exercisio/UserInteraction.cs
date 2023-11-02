using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexbus_exercisio
{
    internal class UserInteraction
    {
        public double AskForDouble(string question)
        {
            //variables
            double answer;

            //Question
            Console.WriteLine(question);

            //input answer
            answer = double.Parse(Console.ReadLine());

            //return answer como um double
            return answer;
        }
        public string AskForString(string question)
        {
            //variables
            string answer;

            //question
            Console.WriteLine(question);

            //input answer
            answer = Console.ReadLine();
            //return answer como um double
            return answer;
        }
    }
}
