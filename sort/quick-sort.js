// 1. take pivot
// 2. sort leftpart
// 3. sort right part


// swap
// partitional - sorting
quicksort([2, 4, 1, 7, 3, 5, 33], 0, 6);

function quicksort(arr, left, right) {
    if (arr.length <= 1) {
        return arr;
    }

    let pivotIndex = partition(arr, left, right);

    if (left < pivotIndex - 1) {
        quicksort(arr, left, pivotIndex - 1);
    }

    if (pivotIndex < right) {
        quicksort(arr, pivotIndex, right);
    }
    return arr;
}


function partition(arr, left, right) {
    let i = left;
    let j = right;
    let pivot = arr[Math.floor((right + left) / 2)];

    while (i < j) {
        while (arr[i] < pivot) {
            i++;
        }

        while (arr[j] > pivot) {
            j--;
        }

        if (i <= j) {
            swap(arr, i, j);
            i++;
            j--;
        }
    }
    return i;
}

function swap(arr, i, j) {
    let temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}


