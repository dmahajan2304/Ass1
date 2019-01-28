using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int a = 5, b = 15;
            Console.WriteLine("prime numbers between " + a + "  "+ b);
            printPrimeNumbers(a, b);
            

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            Console.WriteLine("press any key to exit");
            Console.ReadKey(true);
        }//end of main class



        public static int isPrime(int j)   //method for checking prime no
        {
            try
            {
                int count = 0;

                for (int i = 1; i <= j; i++)
                {

                    if (j % i == 0)
                    {
                        count++;
                    }

                }//end of for loop

                if (count <= 2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing isPrime()");
                return 0;
            }

        }//end of prime method
    


        //print prime numbers

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                for(int i = x; i<= y; i++)     //loop for checking prime numbers between x to y 
                {
                    int prime=isPrime(i);
                    if (prime == 1)
                    {
                        Console.Write(i + ",");
                    }
                }
                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }


        }//print prime numbers


        //series result

        public static double factorialOfNumber(int number) // method for calculating factorial
        {
            double x = 1;
            for(int i = number; i>=1; i--)
            {
                x = i * x;
                

            }//end of for
            
            return x;
            
        }//end of factorialOfNumber

        public static double getSeriesResult(int n)
        {
            try
            {
                double y = 0;
                double z = 0;
                double x = 0;
                for (int i=1; i <= n; i++)   //loop for +ve or -ve sign for odd and even and then calculate the sum of series
                {
                   
                    if (i % 2 == 0)
                    {
                       x= -1;
                    }
                    else
                    {
                        x = 1;
                    }
                    y = (x * factorialOfNumber(i)) / (i + 1);
                    z = y + z;
                }//end of first for

                

                return Math.Round(z,3);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }//end of series result



        //decimal to binary

        public static long decimalToBinary(long n)
        {
            try
            {
                long r;
                string number = "";
                while(n > 0)   
                {
                    r = n % 2;
                    n = n / 2;

                    number = r.ToString() + number;
                   
                }//end of while

                long binaryNumber;
                binaryNumber = long.Parse(number);
                return binaryNumber;


            }//end of try
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }//end of catch

            return 0;
        }//end decimal to binary



        // binary to decimal
        public static long binaryToDecimal(long n)
        {
            
            try
            {
                long number = n;
                long reminder;
                long j = 0;
                long baseValue = 1;
                while(number > 0)
                {
                    reminder = number % 10;            
                    j = j + reminder * baseValue;
                    number = number / 10;
                    baseValue = baseValue * 2;

                }

                return j;


            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }//end of binary to decimal



        //trianlge method
        public static void printTriangle(int n)
        {
            try {

                int i, j, k;
                for (i = 1; i <= n; i++)  // lopp for star rows number
                {
                    for (j = 1; j <= n - i; j++)     // loop for spaces
                    {
                        Console.Write(" ");
                    }
                    int l = i * 2 - 1;
                    for (k = 1; k <= l; k++)   // loop for stars
                    {
                        Console.Write("*");
                        
                    }

                    Console.WriteLine("");
                }
                
                //Console.ReadKey(true);

                }//end of try

            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");


            }//end of catch

        }//end of print trianlge


        //Compute frequency


        public static void computeFrequency(int[] a)
        {
            try
            {
                Array.Sort(a);
                int number = a[0];
                int c = 1;
                Console.WriteLine("Number     Frequency");  //title 

                for (int i = 1; i< a.Length; i++)  //loop for comapring the array elements to calculate frequency
                {
                    if (a[i] == a[i-1])
                    {
                        c++;
                    }
                    else
                    { 
                        Console.WriteLine(a[i-1] + "        " + c);
                        c = 1;
                    
                    }//end of else

                    
                }
                Console.WriteLine(a[a.Length-1] + "        " + c);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }

        }//end of compute frequency

       
        }//end of class
    }//end of name spacez