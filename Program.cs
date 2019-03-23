using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Emaratech_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            sample1();
            Question();
        }
        public static void sample1()
        {
            try
            {
                List<List<int>> prm = new List<List<int>>();
                prm.Add(new List<int>() { 1 });
                prm.Add(new List<int>() { 8, 9 });
                prm.Add(new List<int>() { 1, 5, 9 });
                prm.Add(new List<int>() { 4, 5, 2, 3 });

                List<int> res = new List<int>();
                bool oddflag = false;
                int sum = 0;
                for (int i = 0; i < prm.Count; i++)
                {
                    if (prm[i].Count == 1)
                    {
                        res.Add(prm[i][0]);
                        if (prm[i][0] % 2 == 0)
                        {
                            oddflag = true;
                        }
                    }
                    else
                    {
                        res.Add(prm[i].Where((n) => ((n % 2 == 0) == oddflag) && (prm[i].IndexOf(n)) <= (prm[i - 1].IndexOf(res[res.Count - 1]) + 1) && (prm[i].IndexOf(n)) >= (prm[i - 1].IndexOf(res[res.Count - 1]))).Max());
                    }
                    oddflag = (!oddflag);
                }
                Console.Write("\n\nPath :");
                for (int i = 0; i < res.Count; i++)
                {
                    sum += res[i];
                    Console.Write("{0} ", res[i]);
                }
                Console.WriteLine("\n\nSum : {0}\n\n ", sum);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception :{0}", ex.Message);
            }
        }
        public static void Question()
        {
            try
            {
                Console.WriteLine("\n\n");
                List<int> res = new List<int>();
                bool oddflag = false;
                int sum = 0;
                List<List<int>> prm = new List<List<int>>();
                prm.Add(new List<int>() { 215 });
                prm.Add(new List<int>() { 192, 124 });
                prm.Add(new List<int>() { 117, 269, 442 });
                prm.Add(new List<int>() { 218, 836, 347, 235 });
                prm.Add(new List<int>() { 320, 805, 522, 417, 345 });
                prm.Add(new List<int>() { 229, 601, 728, 835, 133, 124 });
                prm.Add(new List<int>() { 248, 202, 277, 433, 207, 263, 257 });
                prm.Add(new List<int>() { 359, 464, 504, 528, 516, 716, 871, 182 });
                prm.Add(new List<int>() { 461, 441, 426, 656, 863, 560, 380, 171, 923 });
                prm.Add(new List<int>() { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449 });
                prm.Add(new List<int>() { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444 });
                prm.Add(new List<int>() { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197 });
                prm.Add(new List<int>() { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928 });
                prm.Add(new List<int>() { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121 });
                prm.Add(new List<int>() { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 });

                Console.WriteLine("                            215\n");
                Console.WriteLine("                          192 124\n");
                Console.WriteLine("                        117 269 442\n");
                Console.WriteLine("                      218 836 347 235\n");
                Console.WriteLine("                    320 805 522 417 345\n");
                Console.WriteLine("                  229 601 728 835 133 124\n");
                Console.WriteLine("                248 202 277 433 207 263 257\n");
                Console.WriteLine("              359 464 504 528 516 716 871 182\n");
                Console.WriteLine("            461 441 426 656 863 560 380 171 923\n");
                Console.WriteLine("          381 348 573 533 448 632 387 176 975 449\n");
                Console.WriteLine("        223 711 445 645 245 543 931 532 937 541 444\n");
                Console.WriteLine("      330 131 333 928 376 733 017 778 839 168 197 197\n");
                Console.WriteLine("    131 171 522 137 217 224 291 413 528 520 227 229 928\n");
                Console.WriteLine("  223 626 034 683 839 052 627 310 713 999 629 817 410 121\n");
                Console.WriteLine("924 622 911 233 325 139 721 218 253 223 107 233 230 124 233\n");

                for (int i = 0; i < prm.Count; i++)
                {
                    if (prm[i].Count == 1)
                    {
                        res.Add(prm[i][0]);
                        if (prm[i][0] % 2 == 0)
                        {
                            oddflag = true;
                        }
                    }
                    else
                    {
                        res.Add(prm[i].Where((n) => ((n % 2 == 0) == oddflag) && (prm[i].IndexOf(n)) <= (prm[i - 1].IndexOf(res[res.Count - 1]) + 1) && (prm[i].IndexOf(n)) >= (prm[i - 1].IndexOf(res[res.Count - 1]))).Max());
                    }
                    oddflag = (!oddflag);
                }

                Console.Write("\n\nPath :");
                for (int i = 0; i < res.Count; i++)
                {
                    sum += res[i];
                    Console.Write("{0} ", res[i]);
                }
                Console.WriteLine("\n\nSum : {0}\n\n ", sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception :{0}", ex.Message);
            }
        }
    }
}
