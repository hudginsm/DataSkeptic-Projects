using System;
namespace ch1_hello_world
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string hello = "Hellow World!";
            DateTime now = DateTime.Now;
            Console.Write(hello);
            Console.WriteLine(" The Date is " + now.ToLongDateString());       
        }
    }
}
