using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Sort_Method
{
    class simple_array_sort_method
    {
        static void Main(string[] args)
        {

            int[] numbers = {100,
                                7,
                                92,
                                53,
                                89,
                                8

                            };
            Array.Sort(numbers);

            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }
        }
    }
}
