using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit
{
    class Program
    {
        static void Main(string[] args)
        {
            //(while迴圈練習)算出數字有幾位數
            string flag = "y";
            while (flag == "y")
            {
                Console.WriteLine("請輸入一個數值:");
                int temp = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                while (temp != 0)
                {
                    //Console.WriteLine($"{temp}/10 ==> {temp / 10}");
                    temp = temp / 10;
                    result = result + 1;
                }
                Console.WriteLine($"總共有{result}位數");
                Console.WriteLine("是否要繼續？y/n");
                if (Console.ReadLine() == "n")
                {
                    flag = "n";
                }
            }
        }
    }
}
