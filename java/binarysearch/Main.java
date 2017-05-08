package binarysearch;


import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {

        List<Integer> myArray = new ArrayList<>();
        myArray.add(1);
        myArray.add(2);
        myArray.add(10);
        myArray.add(12);
        myArray.add(17);
        myArray.add(18);
        myArray.add(19);
        myArray.add(20);
        myArray.add(23);
        myArray.add(24);
        myArray.add(25);
        myArray.add(26);
        myArray.add(27);
        myArray.add(29);
        myArray.add(30);
        myArray.add(31);
        myArray.add(33);
        myArray.add(34);
        myArray.add(36);
        myArray.add(37);

        BinarySearch binarySearch = new BinarySearch();


        binarySearch.search(31, myArray);
    }
}