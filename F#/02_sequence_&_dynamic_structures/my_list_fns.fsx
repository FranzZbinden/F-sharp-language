
// Determines whether a list is empty.
let isEmpty lst = 
    (lst = [])

// Returns the first element of a list.
let head = function
    | [] -> failwith "empty list"
    | hd::_ -> hd

// Returns the tail portion of a list.
let tail = function
    | [] -> failwith "empty list"
    | _::tl -> tl

// Returns the number of elements in a list.
let rec length = function
    | [] -> 0
    | _::tl -> 1 + length tl

// Returns the number of elements in a list.
// Note: Uses a tail-recursive helper function.
let length' lst =
    let rec loop acc = function
        | [] -> acc
        | _::tl -> loop (acc + 1) tl
        
    loop 0 lst

// Returns the sum of the elements in a list of integers.
let rec sum = function
    | [] -> 0
    | hd::tl -> hd + sum tl

// Returns the sum of the elements in a list of integers.
// Note: Uses a tail-recursive helper function.
let sum' lst =
    let rec loop acc = function
        | [] -> acc
        | hd::tl -> loop (acc + hd) tl

    loop 0 lst

// Returns true if the list contains the given target element.
// Note: This is a tail-recursive function.
let rec contains target = function
    | [] -> false 
    | hd::_ when target = hd -> true 
    | _::tl -> contains target tl

// Returns the element at the nth index of a 0-based list.
// Note: This is a tail-recursive function.
let rec item idx lst =
    match idx, lst with
    | idx, _ when idx < 0 -> failwith "out-of-range index"
    | _, [] -> failwith "out-of-range index"
    | 0, hd::_ -> hd
    | idx, _::tl -> item (idx - 1) tl

// Reverses the elements of a list.
let rec reverse = function
    | [] -> []
    | hd::tl -> reverse tl @ [hd]

// Reverses the elements of a list.
// Note: Uses a tail-recursive helper function.
let reverse' lst =
    let rec loop acc = function
        | [] -> acc
        | hd::tl -> loop (hd::acc) tl

    loop [] lst

// Appends a second list to the first one.
let rec append lst1 lst2 = 
    match lst1 with
    | [] -> lst2
    | hd1::tl1 -> hd1::append tl1 lst2

// Appends a second list to the first one.
// Note: Uses a tail-recursive helper function.
let append' lst1 lst2 =
    let rec loop acc = function
        | [] -> acc
        | hd1::tl1 -> loop (hd1::acc) tl1
        
    loop lst2 (reverse' lst1)
// Defines the '++' binary operator in terms of the append' function.
let ( ++ ) = append'

// Sorts a list in ascending order using the quicksort algorithm.
let rec quicksort = function
    | [] -> []
    | hd::tl -> 
        let smallers = [for elem in tl do if elem < hd then yield elem]
        let greaters = [for elem in tl do if elem >= hd then yield elem]
        (quicksort smallers) @ [hd] @ (quicksort greaters)


// Entry point for the program.
let numbers = [30; 10; 50; 40; 20]

printfn "The list of numbers is %A" numbers
printfn "Is it empty? %b" (isEmpty numbers)
printfn "Its head is %d" (head numbers)
printfn "Its tail is %A" (tail numbers)

printfn "\nIts length is %d" (length numbers)
printfn "\tUsing tail recursion, its length is %d" (length' numbers)

printfn "\nThe sum of its elements is %d" (sum numbers)
printfn "\tUsing tail recursion, the sum is %d" (sum' numbers)

printfn "\nDoes it contains 20? %b" (contains 20 numbers)
printfn "Element at index #4: %d" (item 4 numbers)

printfn "\nThe reversed list is %A" (reverse numbers)
printfn "\tUsing tail recursion, the reversed list is %A" (reverse' numbers)
printfn "The sorted list is %A" (quicksort numbers)

let odds = [1..2..9]
printfn "\nThe list of the first five odds is %A" odds

printfn "Appended to the list of numbers: %A" (append numbers odds)
printfn "\tUsing the tail-recursive ( ++ ) operator: %A" (numbers ++ odds)