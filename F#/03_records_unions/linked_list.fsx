
// Defines a type for a linked list.
type 'a List =
    | Nil
    | Cons of 'a * 'a List

// Returns the first element of a list.
let head = function
    | Nil -> failwith "empty list"
    | Cons (hd, _) -> hd

// Returns the tail portion of a list.
let tail = function
    | Nil -> failwith "empty list"
    | Cons (_, tl) -> tl

// Returns the number of elements in a list.
let rec length = function
    | Nil -> 0
    | Cons (_, tl) -> 1 + length tl

// Returns the sum of the elements in the given list of integers.
let rec sum = function
    | Nil -> 0
    | Cons (hd, tl) -> hd + sum tl

// Returns true if the given list contains the given element.    
let rec contains target = function
    | Nil -> false 
    | Cons (hd, _) when target = hd -> true 
    | Cons (_, tl) -> contains target tl

// Returns a string representation of the given list.
let rec listToString = function
    | Nil -> ""
    | Cons (hd, tl) -> sprintf "%A %s" hd (listToString tl)

// Returns a sequence with the elements in the given list.
let rec elements lst =
    seq {
        match lst with
        | Nil -> yield! Seq.empty
        | Cons (hd, tl) -> 
            yield hd
            yield! elements tl
    }

// Entry point for the program.
let numbers = 
    Cons (30, Cons (10, Cons (50, Cons (40, Cons (20, Nil)))))

printfn "The list is %s" (numbers |> listToString)
printfn "The length of the list is %d" (length numbers)

printfn "\nThe head value is %d" (head numbers)
printfn "The tail of the list is %s" (tail numbers |> listToString)

printfn "\nThe sum of its elements is %d" (sum numbers)
printfn "Does it contain 20? %b" (contains 20 numbers)

printfn "\nThese are the elements of the list, one per line: "
for elem in (elements numbers) do
    printfn "%d" elem