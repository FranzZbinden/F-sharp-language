
// Entry point of the program.
let numbers = [30; 10; 50; 40; 20]

printfn "The list of numbers is %A" numbers

printfn "\nThese are the elements, one per line: "
for elem in numbers do 
    printfn "%d" elem

printfn "\nThe head value is %d" (List.head numbers)
printfn "The tail of the list is %A" (List.tail numbers)
printfn "Its length is %d" (List.length numbers)
printfn "Is it empty? %b" (List.isEmpty numbers)

printfn "\nThe sum of its elements is %d" (List.sum numbers)
printfn "Its minimum element is %d" (List.min numbers)
printfn "Its maximum element is %d" (List.max numbers)

printfn "\nDoes it contains 20? %b" (List.contains 20 numbers)
printfn "The index of 20 is %d" (List.findIndex (fun elem -> elem = 20) numbers)
printfn "The element at index #4 is %d" (List.item 4 numbers)

printfn "\nThe reversed list is %A" (List.rev numbers)
printfn "The sorted list is %A" (List.sort numbers)

numbers
    |> List.sort
    |> List.rev
    |> printfn "The reversed sorted list is %A"

let numbers' = 5::[4..-1..1]
printfn "\nThe new list of numbers is %A" numbers'
printfn "The concatenation of the new and original lists is %A" (numbers' @ numbers)

let evenSquares = [
    for num in 1..20 do
        if num%2 = 0 then yield num * num
]
printfn "\nThe first ten even squares are %A" evenSquares

evenSquares
    |> List.skip 3
    |> List.take 4
    |> printfn "Its four middle elements are %A"