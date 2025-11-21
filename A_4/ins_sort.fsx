
// An insert function that inserts an element elem in a sorted list lst, keeping it sorted. 
let rec insert elem lst =
    match lst with 
    | [] -> elem::lst
    | hd::tl when elem < hd -> elem :: lst
    | hd::tl -> hd :: insert elem tl


// A function that receives an unsorted list lst and repeatedly applies insert to sort the list.
let rec insertionSort lst =
    match lst with 
    | [] -> []
    | hd::tl -> insert hd (insertionSort tl)