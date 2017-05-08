def sort(array):
    less = []
    equal = []
    greater = []

    if len(array) > 1:
        pivot = array[0]
        for i in array:
            if i < pivot:
                less.append(i)
            if i > pivot:
                greater.append(i)
            if i == pivot:
                equal.append(i)
        return sort(less) + equal + sort(greater)
    else:
        return array


def main():
    array = [10, 19, 3, 5, 7, 9, 15, 13, 2, 4, 11, 8, 25, 22, 6, 18, 17, 12, 1, 21]
    print(sort(array))


main()