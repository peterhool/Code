using System;
using System.Security.Cryptography;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] citys = new string[3];
            citys[0] = "BeiJing";
            citys[1] = "ShangHai";
            citys[2] = "TianJin";
            foreach(string item in citys)
            {
                Console.WriteLine(item);
            }
        }

    }

}
