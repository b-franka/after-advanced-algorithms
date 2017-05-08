using System;
namespace QuickSortApplication{

   class MainClass {
      static void Main(string[] args) {
          int[] myArray = new int[] {10, 19, 3, 5, 7, 9, 15, 13, 2, 4, 11, 8, 25, 22, 6, 18, 17, 12, 1, 21};

          QuickSort quickSort = new QuickSort();
          quickSort.sort(myArray);

          foreach (int elem in myArray) {
            Console.WriteLine(elem);
          }
      }
   }

public class QuickSort {

    public void sort(int[] array) {

        int lowestIndex = 0;
        int highestIndex = array.Length - 1;

        quickSort(array, lowestIndex, highestIndex);
    }

    private void quickSort(int[] array, int lowestIndex, int highestIndex) {
        int pivot = array[(lowestIndex + highestIndex) / 2];

        int i = lowestIndex;
        int j = highestIndex;

        while (i <= j) {

            while (array[i] < pivot) {
                i++;
            }

            while (array[j] > pivot) {
                j--;
            }

            if (i <= j) {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }

            if (lowestIndex < j) {
                quickSort(array, lowestIndex, j);
            }

            if (highestIndex > i) {
                quickSort(array, i, highestIndex);
            }

        }
    }
}
}