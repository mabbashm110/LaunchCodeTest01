using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LaunchCode_Test
{
    class Program
    {
        /*
         * Complete the function below.
         */
        static int permutate(string string1, string string2)
        {
            string[] string1Array = convertToArray(string1);
            string[] string2Array = convertToArray(string2);
            int result = 0;
            //int j = string2Array.Length - 1;
            if (string1Array.Length == string2Array.Length)
            {
                //Compare each item from stringArray1 to entire stringArray2
                for (int i = 0; i < string1Array.Length; i++)
                {

                    for (int j = 0; j < string2Array.Length; j++)
                    {
                        if (string1Array[i] == string2Array[j])
                        {
                            
                            result = 1;
                        }
                        else
                        {
                            result = 0;
                        }
                        Console.WriteLine("Comparing i=" + string1Array[i] + " to j=" + string2Array[j]);
                    }
                }
            }
            else
            {
                result = 0;
            }
            return result;
        }

        static string[] convertToArray(string defineString)
        {

            string[] convertedArray;
            return convertedArray = defineString.ToCharArray().Select(c => c.ToString()).ToArray();

        }
        static void Main(string[] args)
        {
            float d = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.0}",d);
            Console.ReadKey();
            //if (int.Parse("a") > int.Parse("b"))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            //string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
            //TextWriter tw = new StreamWriter(@fileName, true);
            /*
            int res;
            string string1;
            string1 = Console.ReadLine();

            string string2;
            string2 = Console.ReadLine();

            res = permutate(string1, string2);
            Console.WriteLine(res);
            Console.WriteLine(string1 + " " + string2);
            Console.ReadKey();
            */

            /*tw.WriteLine(res);

            tw.Flush();
            tw.Close();
            */
        }
    }
}
