namespace ArrayDemo081124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //one diametional Array declare
            int[] ar1 = new int[5];

            //two D array

            //a) 
            int[][] ar2 = new int[3][]; //no of rows 3 and no of column ***
                                        //jagged Array

            //b)
            int[,] ar3 = new int[3,4];//no of rows 3 & no of columns 4


            //// sequencially Access Array elements
            //Console.WriteLine("size of array1 "+ar1.Length);
            //for (int i = 0; i < ar1.Length; i++)
            //{
            //    Console.WriteLine("Enter no:");
            //    //ar1[i] = int.Parse(Console.ReadLine());
            //    ar1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("All Array elements:");
            //int total = 0;
            //for (int i = 0; i < ar1.Length; i++)
            //{
            //    total=total+ar1[i];
            //    Console.WriteLine(ar1[i]);

            //}
            // Console.WriteLine("total="+total);
            //----------------2D array read & write
            //jagged array read write
            ////--------------------------------------------------------------------
            //Console.WriteLine("ar2.Length="+ar2.Length);
            //for (int i = 0; i < ar2.Length; i++)
            //{
            //    int n;
            //    Console.WriteLine("Enter array size");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    ar2[i] = new int[n];
            //}
            //Console.WriteLine(ar2[0].GetLength(0));
            //Console.WriteLine(ar2[1].GetLength(0));
            //Console.WriteLine(ar2[2].GetLength(0));
            ////Console.WriteLine(ar2.GetLength(1));

            //for (int i = 0; i < ar2.Length; i++)
            //{
            //    Console.WriteLine("new Row Started...");
            //    for (int j = 0; j < ar2[i].GetLength(0); j++)
            //    {
            //        Console.WriteLine("Enter no");
            //        int n = int.Parse(Console.ReadLine());
            //        ar2[i][j] = n;                }
            //}

            //Console.WriteLine("Jagged Array Elements are:\n");
            //for (int i = 0; i < ar2.Length; i++)
            //{
            //    for (int j = 0; j < ar2[i].GetLength(0); j++)
            //    {
            //        Console.Write(" " + ar2[i][j]);
            //    }
            //    Console.WriteLine();
            //}


            // how to read write normal 2D array

            Console.WriteLine("ar3.length="+ar3.Length);
            Console.WriteLine("row length "+ar3.GetLength(0));//rows
            Console.WriteLine("column length " + ar3.GetLength(1));//columns

            for (int i = 0; i < ar3.GetLength(0); i++)
            {
                Console.WriteLine("new row started");
                for (int j = 0; j < ar3.GetLength(1); j++)
                {
                    Console.WriteLine("Enter no");
                    int n = int.Parse(Console.ReadLine());
                    ar3[i,j] = n;
                }
            }

            //display 2D array

            for (int i = 0; i < ar3.GetLength(0); i++)
            {
                for (int j = 0; j < ar3.GetLength(1); j++)
                {
                    Console.Write(" " + ar3[i,j]);
                }
                Console.WriteLine();
            }






        }
    }
}
