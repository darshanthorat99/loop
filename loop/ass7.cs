using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class ass7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number");
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2=Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for(int i=1;i<=n2;i++)
            {
               sum=sum + n1;
            }
            Console.WriteLine($"mulitipication is {sum}");
        }
    }
}
