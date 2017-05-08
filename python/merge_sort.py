def sort(array):
    result = []
    if len(array) < 2:
        return array
    mid = int(len(array)/2)
    left = sort(array[:mid])
    right = sort(array[mid:])
    while (len(left) > 0) or (len(right) > 0):
        if len(left) > 0 and len(right) > 0:
            if left[0] > right[0]:
                result.append(right[0])
                right.pop(0)
            else:
                result.append(left[0])
                left.pop(0)
        elif len(right) > 0:
            for i in right:
                result.append(i)
                right.pop(0)
        else:
            for i in left:
                result.append(i)
                left.pop(0)
    return result


def main():
    array = [10, 19, 3, 5, 7, 9, 15, 13, 2, 4, 11, 8, 25, 22, 6, 18, 17, 12, 1, 21]
    print(sort(array))


main()