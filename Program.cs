using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //This Program runs on only visual studio 2017 which allows the use of nexted Methods()

            Random rand = new Random();
            int[] sort=new int[5];
            for (int i = 0; i < sort.Length - 1; i++)
            {
                 
                sort[i] = rand.Next(100,1000);
            }

            int[] array = new int[5];
            for (int i = 0; i < array.Length - 1; i++)
            {

                array[i] = rand.Next(99);
            }
            int[] list = new int[5];
            for (int i = 0; i < list.Length - 1; i++)
            {

                list[i] = rand.Next(100,1000);
            }
            Program m = new Program();
            m.selectionSort(sort);
          m.insertionSort(array);
            m.bubbleSort(list);
            Console.ReadLine();

        }


        public void selectionSort(int [] array)
        {
            Stopwatch s = new Stopwatch();
            int iteration = 0;
            Console.WriteLine("Using Selection sort\n---------------------");
           Console.Write("Array in Unsorted order : ");
           foreach(var e in array)
            {
                Console.Write(" "+e);
            }
            s.Start();
           for (int i = 0; i < array.Length - 1; ++i)
            {
                int smallest = i;
                for(int j = i + 1; j < array.Length; ++j)
                {
                    if (array[j] < array[i])
                    {
                        smallest = j;

                        swap(i, smallest);
                        Console.Write("\nAfter " + iteration + " iteration");
                        ++iteration;
                        foreach (int e in array)
                            Console.Write(" " + e);
                    }
                }
            }
            s.Stop();
            Console.WriteLine();
            Console.Write("Array in sorted order : ");
            foreach (var e in array)
            {
                Console.Write(" " + e);
            }
            Console.Write("    in " + s.Elapsed + "s");
            s.Reset();
            void swap(int first,int second)
            {
                int temporary=array[first];
                array[first] = array[second];
                array[second] = temporary;

            }
        }
      



        public void insertionSort(int [] array)
        {
            Stopwatch s = new Stopwatch();
           
            int dataToInsert;
            
            Console.WriteLine("\n\nUsing Insertion sort\n---------------------");
            Console.Write("Array in Unsorted order : ");
            foreach (var e in array)
            {
                Console.Write(" " + e);
            }

            s.Start();
            for(int i=1; i < array.Length; ++i)
            {
               dataToInsert = array[i];
                int itemToMove = i;
                while (itemToMove > 0 && array[itemToMove-1] > dataToInsert)
                {
                    array[itemToMove] = array[itemToMove - 1];
                    itemToMove--;
                }

               
                array[itemToMove] = dataToInsert;
            }
            s.Stop();
            Console.Write("\nArray in sorted order : ");
            foreach (var e in array)
            {
                Console.Write(" " + e);
            }
            Console.Write("    in " + s.Elapsed+"s");
            s.Reset();
        }







        public void bubbleSort(int [] array)
        {
            int iteration=0;
            Stopwatch s = new Stopwatch();
            Console.WriteLine("\n\nUsing Bubble Sort sort\n---------------------");
            Console.Write("Array in Unsorted order : ");
            foreach (var e in array)
            {
                Console.Write(" " + e);
            }
            s.Start();
           for(int write = 0; write < array.Length; write++)
            {
                for(int sort=0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                        swap(sort, sort + 1);
                }
                Console.Write("\nAfter " + iteration + " iteration");
                ++iteration;
                foreach (int e in array)
                    Console.Write(" " + e);

            }
            s.Stop();
            
            
            Console.WriteLine();
            Console.Write("Array in sorted order : ");
            foreach (var e in array)
            {
                Console.Write(" " + e);
            }
            Console.Write("    in " + s.Elapsed + "s");
            s.Reset();
            void swap(int first, int second)
            {
                int temporary = array[first];
                array[first] = array[second];
                array[second] = temporary;

            }


        }
    }
}
