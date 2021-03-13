 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_b1
{
    class Program
    {
        static void Main(string[] args)
        {


            int value = 0;
            int count = 0;
            String resultString = "这个数的所有素数因子为\n";
            Console.Write("请输入一个数");
            value = Convert.ToInt32(Console.ReadLine());
            if (value % 2 == 0)
            {
                resultString = resultString + "2\t";
                count++;
                value /= 2;
            }
            if (value % 3 == 0)
            {
                resultString = resultString + "3\t";
                count++;
                value /= 3;
            }

            for (int i = 5; i <= value; i += 2)
            {
                if (value % i != 0)
                    continue;
                else
                {
                    bool flag = true;
                    if (i % 2 == 0)
                        continue;
                    else
                        for (int j = 3; i < i; j += 2)
                        {
                            if (i % j == 0)
                            {
                                flag = false;
                                break;
                            }
                        }

                    if (flag)
                    {
                        resultString = resultString + Convert.ToString(i);
                        if (++count < 4)
                            resultString = resultString + "\t";
                        else
                        {
                            count = 0;
                            resultString = resultString + "\n";
                        }
                    }//if(flag)

                    value /= i;
                }//else

            }//for(i)



            Console.Write("结果是"+resultString);


        }
    }
}
           

