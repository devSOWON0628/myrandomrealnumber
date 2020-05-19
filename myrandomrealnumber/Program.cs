using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correct = random.Next(0, 500);
            int res;
            
            while (true)
            {
                Console.Write("숫자를 입력해주세요 :");
                res = int.Parse(Console.ReadLine());
                if (res > correct)
                {
                    Console.WriteLine(res + "보다 작은 숫자입니다.");
                    Console.WriteLine("");
                }
                else if (res < correct)
                {
                    Console.WriteLine(res + "보다 큰 숫자입니다");
                    Console.WriteLine("");

                }

                else if (res == correct)
                {
                    Console.WriteLine("정답입니다");
                    Console.WriteLine("");

                    break;
                }
            }
            
        }
    }
}
