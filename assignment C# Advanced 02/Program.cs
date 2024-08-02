using System;
using System.Collections;

namespace assignment_C__Advanced_02
{
    internal class Program 

    {
        public static void RevArray(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;

            while (start < end)
            {
                // Swap elements at left and right indices
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start++;
                end--;
            }
        }
            static void Main(string[] args)
        {
            #region Part01
            //Structure : How elements are organized and accessed  
            //Time Complexity : Big O Notation: Expresses the upper bound of an algorithm's runtime as input size grows.
            //Business Cases : Problem Domain , Requirements, Constrains, Evaluation  

            #endregion

            #region Part02 Q1
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            RevArray(list); 
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            #endregion

            Console.WriteLine("==================================================");
            #region Q2
            ArrayList list2 = new ArrayList { 10, 11, 12, 13, 14 };

            for (int i = 0; i < list2.Count; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(list2[i]);
                }
                
            }
            #endregion
            Console.WriteLine("==================================================");

            #region Q3
            FixedSizeList<int> list3 = new FixedSizeList<int>(3);
            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            for (int i = 0;i < list3.Count; i++)
            {
                Console.WriteLine(list3.Get(i));
            }


            #endregion




        }
    }
}
