using System;
namespace QuickSortApplication{

   class MainClass {
      static void Main(string[] args) {
          int[] myArray = new int[] {10, 19, 3, 5, 7, 9, 15, 13, 2, 4, 11, 8, 25, 22, 6, 18, 17, 12, 1, 21};

          MergeSort mergeSort = new MergeSort();
          mergeSort.mergeSort(myArray);

          foreach (int elem in myArray) {
            Console.WriteLine(elem);
          }
      }
   }

public class MergeSort {

    public void mergeSort(int[] inputArray) {
        int size = inputArray.Length;
        if (size == 1)
            return;
        int middle = size / 2;
        int leftSize = middle;
        int rightSize = size - middle;
        int[] left = new int[leftSize];
        int[] right = new int[rightSize];
        for (int i = 0; i < middle; i++) {
            left[i] = inputArray[i];

        }
        for (int i = middle; i < size; i++) {
            right[i - middle] = inputArray[i];
        }
        mergeSort(left);
        mergeSort(right);
        merge(left, right, inputArray);
    }

    public static void merge(int[] left, int[] right, int[] arr) {
        int leftSize = left.Length;
        int rightSize = right.Length;

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < leftSize && j < rightSize) {
            if (left[i] < right[j]) {
                arr[k] = left[i];
                k++;
                i++;
            } else {
                arr[k] = right[j];
                k++;
                j++;
            }
        }
        while (i < leftSize) {
            arr[k] = left[i];
            k++;
            i++;
        }
        while (j < leftSize) {
            arr[k] = right[j];
            k++;
            j++;
        }
    }
}
}
