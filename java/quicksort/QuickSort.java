package quicksort;


import java.util.List;

public class QuickSort {

    private List<Integer> array;
    private int arrayLength;

    public List<Integer> sort(List<Integer> array) {
        this.array = array;
        arrayLength = array.size() - 1;

        int lowestIndex = 0;
        int highestIndex = arrayLength;

        quickSort(lowestIndex, highestIndex);

        return array;
    }

    private void quickSort(int lowestIndex, int highestIndex) {
        Integer pivot = array.get((lowestIndex + highestIndex) / 2);

        int i = lowestIndex;
        int j = highestIndex;

        while (i <= j) {

            while (array.get(i) < pivot) {
                i++;
            }

            while (array.get(j) > pivot) {
                j--;
            }

            if (i <= j) {
                Integer temp = array.get(i);
                array.set(i, array.get(j));
                array.set(j, temp);
                i++;
                j--;
            }

            if (lowestIndex < j) {
                quickSort(lowestIndex, j);
            }

            if (highestIndex > i) {
                quickSort(i, highestIndex);
            }
        }
    }
}