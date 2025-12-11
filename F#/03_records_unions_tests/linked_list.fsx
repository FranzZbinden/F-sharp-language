type 'a List =
    | Nil
    | Cons of 'a * 'a List

let head = function
    | Nil -> failwith "empty list"
    | Cons(hd,_) -> hd

let tail = function
    | Nil -> failwith "empty list"
    | Cons(_,tl) -> tl

let rec length = function
    | Nil -> 0
    | Cons(_,tl) -> 1 + length tl

let rec sum = function
    | Nil -> 0
    | Cons(hd,tl) -> hd + sum tl

let rec contains target = function
    | Nil -> false
    | Cons(hd,_) when hd = target -> true
    | Cons(_,tl) -> contains target tl

let rec listToString = function
    | Nil -> ""
    | Cons(hd, Nil) -> sprintf "%A" hd
    | Cons(hd, tl) -> sprintf "%A %s" hd (listToString tl)

// to insert elements
let rec insert elem = function
    | Nil -> Cons(elem, Nil)
    | Cons(hd, tl) -> Cons (hd, insert elem tl)

let rec elements lst =
    seq {
        match lst with
        | Nil -> ()
        | Cons(hd, tl) ->
            yield hd
            yield! elements tl
    }

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
