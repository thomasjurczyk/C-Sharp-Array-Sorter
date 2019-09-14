using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while(true)
            {
                Console.Write("Show all prime numbers less than:");
                String input = Console.ReadLine();
                Console.WriteLine("\n");
                int intInput;
                bool isprime;
                if (!Int32.TryParse(input, out intInput))
                {
                    Console.WriteLine("Please enter an Integer\n");
                }
                else
                {
                    for (int i=2; i <= intInput; i++)
                    {
                        isprime = true;
                        for(int j=2;j<i;j++)
                        {
                            if(i%j==0)
                            {
                                isprime = false;
                                break;
                            }
                        }
                        if(isprime==true)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine("\n");
                }
            }*/
            while (true)
            {
                int intLength;
                Console.Write("How many elements:");
                String length = Console.ReadLine();
                if (!Int32.TryParse(length, out intLength))
                {
                    Console.WriteLine("Please enter an Integer\n");
                }
                else
                {
                    double[] arrayToSort=null;
                    arrayToSort = new double[intLength];
                    Console.WriteLine("Enter array to sort below:");
                    String arrayInput = Console.ReadLine();
                    string[] parsedArray = arrayInput.Split(' ');
                    for(int i=0;i<intLength;i++)
                    {
                        double tempholder;
                        if(Double.TryParse(parsedArray[i],out tempholder))
                        {
                            arrayToSort[i] = tempholder;
                        }
                    }
                    bubblesort(intLength, ref arrayToSort);
                    for(int j=0;j<intLength;j++)
                    {
                        Console.Write(arrayToSort[j]+" ");
                    }
                    Console.Write("\n");
                }
            }
        }
        public static void bubblesort(int arrayLength, ref double[] arrayToSort)
        {
            bool flag = true;
            double tempholder;
            for(int i=0;i<arrayLength&&flag;i++)
            {
                flag = false;
                for(int j=0;j<arrayLength-1;j++)
                {
                    if(arrayToSort[j+1]<arrayToSort[j])
                    {
                        tempholder = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = tempholder;
                        flag = true;
                    }
                }
            }
        }
    }
}
