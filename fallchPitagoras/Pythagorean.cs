using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








namespace fallchPitagoras
{
    class carculation
    {
        static void Main(string[] args)
        {
            double triangleA = 3;
            double triangleB = 4;
            double calculationfactor = 0;
            double triangleC = -1;
            int debug = 0;
            string unknownValue = "none";
            int outPutCount = 1;
            int numberLoadingCount =0;
            int perfactFactorDebug = 0;

            int outPutLimit = 3; // change the value if you want to calculation more

            while (outPutCount <= 3)
            {

                double[] length = new double[10];
                
                if(outPutCount == 1)
                {
                    Console.WriteLine("please enter the length of first triangle");
                    length[1] = Convert.ToInt32(Console.ReadLine()); // length A
                    length[2] = Convert.ToInt32(Console.ReadLine());// length B
                    length[3] = Convert.ToInt32(Console.ReadLine()); // length C

                }

                if(outPutCount == 2)
                {
                    Console.WriteLine("please enter the length of second triangle");
                    length[4] = Convert.ToInt32(Console.ReadLine()); // length A
                    length[5] = Convert.ToInt32(Console.ReadLine()); // length B
                    length[6] = Convert.ToInt32(Console.ReadLine());// length C
                }

                if(outPutCount == 3)
                {
                    Console.WriteLine("please enter the length of third triangle");
                    length[7] = Convert.ToInt32(Console.ReadLine()); // length A
                    length[8] = Convert.ToInt32(Console.ReadLine()); // length B
                    length[9] = Convert.ToInt32(Console.ReadLine()); // length C
                }

                

                numberLoadingCount = (outPutCount -1) * 3;
                triangleA = length[1 + numberLoadingCount];
                triangleB = length[2 + numberLoadingCount];
                triangleC = length[3 + numberLoadingCount];

                if(triangleA != -1 && triangleB != -1 && triangleC != -1)
                {
                    perfactFactorDebug += 1;
                }

                if (triangleA == -1)
                {
                    unknownValue = "A";
                    if (triangleB <= 0 || triangleC <= 0)
                    {
                        debug = +1; // if is not able return debug 1 or more
                    }

                    calculationfactor = triangleC * triangleC - triangleB * triangleB; //squared
                    triangleA = (int)Math.Sqrt(calculationfactor); //squrt the factor of calculation
                    triangleA = Math.Round(triangleA,4); //Round the factor from 4th of decimal



                }
                if (triangleB == -1)
                {
                    unknownValue = "B";
                    if (triangleA <= 0 || triangleC <= 0)
                    {
                        debug = +1; // if is not able return debug 1 or more
                    }

                    calculationfactor = triangleC * triangleC - triangleA * triangleA ; //squared
                    triangleB = (int)Math.Sqrt(calculationfactor); //squrt the factor of calculation
                    triangleB = Math.Round(triangleB,4); //Round the factor from 4th of decimal

                }
                if (triangleC == -1)
                {
                    unknownValue = "C";
                    if (triangleB <= 0 || triangleA <= 0)
                    {
                        debug = +1; // if is not able return debug 1 or more
                    }

                    calculationfactor = triangleB * triangleB + triangleA * triangleA; //squared
                    triangleC = (int)Math.Sqrt(calculationfactor); //squrt the factor of calculation
                    triangleC = Math.Round(triangleC,4); //Round the factor from 4th of decimal

                }

                if (triangleB * triangleB + triangleA * triangleA > triangleC * triangleC)
                {
                    debug =+ 1;
                }

                if (debug >= 1) //if it's not a triangle return Impossible.
                {
                    Console.WriteLine("Trianlge #" + outPutCount);
                    if (unknownValue == "A")
                    {
                        Console.WriteLine("Impossible.");
                        Console.WriteLine();
                    }

                    if (unknownValue == "B")
                    {
                        Console.WriteLine("Impossible.");
                        Console.WriteLine();
                    }

                    if (unknownValue == "C")
                    {
                        Console.WriteLine("Impossible.");
                        Console.WriteLine();
                    }

                    debug = -1;
                }
                else
                {
                    Console.WriteLine("Trianlge #" + outPutCount); //print the result
                    if (perfactFactorDebug >= 1)
                    {
                        Console.WriteLine("This is so perfect triangle that I can not carculat"); // if there is no -1
                        Console.WriteLine();
                        perfactFactorDebug -= 1;
                    }

                    else
                    {
                        if (unknownValue == "A")
                        {
                            Console.WriteLine(unknownValue + " = " + triangleA);
                            Console.WriteLine();
                        }

                        if (unknownValue == "B")
                        {
                            Console.WriteLine(unknownValue + " = " + triangleB);
                            Console.WriteLine();
                        }

                        if (unknownValue == "C")
                        {
                            Console.WriteLine(unknownValue + " = " + triangleC);
                            Console.WriteLine();
                        }

                    }
                }
                

                outPutCount += 1; //if it's outputed count 







            }

            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey(); 





        }
    }
}





    

