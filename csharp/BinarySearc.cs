using System;
namespace BinarySearchApplication{

    class MainClass {
        static void Main(string[] args) {
           Console.WriteLine(BinarySearch.search(new int[] {1,2,3,4,6,7,8}, 4));
        }
    }

    class BinarySearch {

        public static int search(int[] inputArray, int number) {
            int lowerIndex = 0;
            int higherIndex = inputArray.Length - 1;

            while (lowerIndex <= higherIndex) {
                int pivot = (lowerIndex + higherIndex) / 2;

                if (number == inputArray[pivot]) {
                    return pivot;
                }
                if (number < inputArray[pivot]) {
                    higherIndex = pivot - 1;
                } else {
                    lowerIndex = pivot + 1;
                }
            }
            return -1;
        }
    }
}