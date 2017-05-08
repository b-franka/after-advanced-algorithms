package binarysearch;


import java.util.List;

public class BinarySearch {

    public int search(int number, List<Integer> myList) {
        int lowerIndex = 0;
        int higherIndex = myList.size() - 1;

        while (lowerIndex <= higherIndex) {
            int pivot = (lowerIndex + higherIndex) / 2;
            if (number == myList.get(pivot)) return pivot;
            if (number < myList.get(pivot)) {
                higherIndex = pivot - 1;
            } else {
                lowerIndex = pivot + 1;
            }
        }
        return -1;
    }
}