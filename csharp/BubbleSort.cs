using System;
namespace BubbleSortApplication{

   class MainClass {
      static void Main(string[] args) {
          int[] myArray = new int[] {10, 19, 3, 5, 7, 9, 15, 13, 2, 4, 11, 8, 25, 22, 6, 18, 17, 12, 1, 21};
          BubbleSort.sort(myArray);

          foreach (int elem in myArray) {
            Console.WriteLine(elem);
          }
      }
   }

   class BubbleSort {
        public static void sort(int[] array) {
            for (int i = 0; i <= array.Length; i++) {
                for (int j = 0; j < array.Length - 1; j++) {
                    int k = j + 1;
                    int current = array[j];
                    int next = array[k];
                    if(current > next) {
                        array[j] = next;
                        array[k] = current;
                    }
                }
            }
        }
    }
}