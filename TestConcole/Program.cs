using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string mydata = "No Name";

        try {
            Console.Write($"This is myname  {mydata}\n");
            Console.Write($"My other name is {mydata}\n");

            Console.ReadLine(); /// 
            


            ///This is a pause statement waiting for enter.
            ///
            /// 
            /// 
            /// 
            ///

        }

        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }

    }
}
