package bubblesort;


import java.util.ArrayList;
import java.util.List;

public class BubbleSort {

    private static List<Integer> sort(List<Integer> array) {
        for (int i = array.size(); i >= 0; i--) {
            for (int j = 0; j < array.size() - 1; j++) {
                int k = j +1;
                Integer current = array.get(j);
                Integer next = array.get(k);
                if(current > next) {
                    array.set(j, next);
                    array.set(k, current);
                }
            }
        }
        return array;
    }

    public static void main(String[] args) {
        List<Integer> myArray = new ArrayList<>();
        myArray.add(10);
        myArray.add(19);
        myArray.add(3);
        myArray.add(5);
        myArray.add(7);
        myArray.add(9);
        myArray.add(15);
        myArray.add(13);
        myArray.add(2);
        myArray.add(4);
        myArray.add(11);
        myArray.add(8);
        myArray.add(25);
        myArray.add(22);
        myArray.add(6);
        myArray.add(18);
        myArray.add(17);
        myArray.add(12);
        myArray.add(1);
        myArray.add(21);

        System.out.println(sort(myArray));

    }
}
