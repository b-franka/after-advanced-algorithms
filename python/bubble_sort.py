def bubbleSort(array):
    for i in array:
        for j, elem in enumerate(array):
            if j+1 < len(array):
                if array[j] > array[j+1]:
                    temp = array[j]
                    array[j] = array[j+1]
                    array[j+1] = temp
        print(array)


def main():
    array = [10, 19, 3, 5, 7, 9, 15, 13, 2, 4, 11, 8, 25, 22, 6, 18, 17, 12, 1, 21]
    bubbleSort(array)


main()
