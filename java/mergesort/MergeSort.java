package mergesort;


import java.util.ArrayList;
import java.util.List;

public class MergeSort {

    public void mergeSort(int[] array) {
        int size = array.length;
        if (size == 1)
            return;
        int middle = size / 2;

        int[] left = new int[middle];
        int[] right = new int[size - middle];
        System.arraycopy(array, 0, left, 0, middle);
        System.arraycopy(array, middle, right, 0, size - middle);

        mergeSort(left);
        mergeSort(right);
        merge(left, right, array);
    }

    public static void merge(int[] left, int[] right, int[] arr) {

        int i = 0;
        int j = 0;
        int k = 0;

        while (i < left.length && j < right.length) {
            if (left[i] < right[j]) {
                arr[k] = left[i];
                i++;
                k++;
            } else {
                arr[k] = right[j];
                k++;
                j++;
            }
        }
        while (i < left.length) {
            arr[k] = left[i];
            k++;
            i++;
        }
        while (j < left.length) {
            arr[k] = right[j];
            k++;
            j++;
        }
    }

}
