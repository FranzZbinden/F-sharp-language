
// Entry point for the program.
let tens = seq {10..10..1000}
printfn "The sequence of the first 100 tens is %A" tens 
printfn "It is empty? %b" (Seq.isEmpty tens)
    
printfn "\nThe head value is %d" (Seq.head tens)
printfn "The tail of the list is %A" (Seq.tail tens)

printfn "\nDoes the sequence contain 40? %b" (Seq.contains 40 tens)
printfn "Its index? %d" (Seq.findIndex (fun elem -> elem = 40) tens)
printfn "The element at index #3 is %d" (Seq.item 3 tens)

tens
    |> Seq.take 5
    |> Seq.sum
    |> printfn "\nThe sum of its first 5 elements is %d"
   
tens
    |> Seq.take 5
    |> Seq.toList
    |> printfn "The list of the the first 5 elements is %A"

let evenSquares = seq {
    for num in 1..200 do 
        if num%2 = 0 then yield num * num
} 
printfn "\nThe sequence of the first 100 even squares is %A" evenSquares

let evenSquares' = 
    seq {1..200} 
        |> Seq.filter (fun elem -> elem%2 = 0)
        |> Seq.map (fun elem -> elem * elem)
printfn "\tUsing pipe and higher-order functions, the sequence is %A" evenSquares'

let evenSquaresSlice = 
    evenSquares
        |> Seq.skip 1
        |> Seq.take 3

printfn "\nAn slice of three even squares, one per line..."
for elem in evenSquaresSlice do
    printfn "%d" elem

let factorialSeq = Seq.initInfinite (fun num -> List.fold ( * ) 1 [1..num])
let limit = 10

printfn $"\nGenerating the first {limit} factorials..."
Seq.iter (printfn "%d") (factorialSeq |> Seq.skip 1 |> Seq.take limit)