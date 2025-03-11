using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AbsoluteNumber.Models
{
    internal class AbsoluteNumValue_Vaibhav
    {
        int num;
        public int GetAbsoluteNumber()
        {
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num<0)
            {
                num = -(num);
                return num;
            }
            return num;
        }
    }
}
