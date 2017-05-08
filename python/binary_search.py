import math


def search(num, array):
    lowerIndex = 0
    higherIndex = len(array) - 1

    while lowerIndex <= higherIndex:
        med = math.floor((lowerIndex + higherIndex) / 2)
        pivot = array[med]
        if pivot == num:
            return med
        elif num < pivot:
            higherIndex = med-1
        elif num > pivot:
            lowerIndex = med+1

    return -1


def main():
    array = [1, 2, 10, 12, 17, 18, 19, 20, 23, 24, 25, 26, 27, 29, 30, 31, 33, 34, 36, 37]
    print(search(30, array))


main()