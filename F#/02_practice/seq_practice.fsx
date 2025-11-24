let even_sequence = seq {
    for num in 1..100 do 
        if num % 2 = 0 then yield num }

printfn "%A" even_sequence

even_sequence
    |> Seq.map (fun num -> num * 2) 
    |> printfn "%A"


let squares = seq {for num in 0..50 do yield num * num}

// print the first 10
// print the last 5
// find how many squares are > 1000

squares
    |> Seq.take 5
    |> printfn "%A"

 
squares
    |> Seq.take 5 
    |> Seq.toList 
    |> printfn "%A"

let tens = seq {10..10..1000}

tens 
    |> Seq.filter (fun num -> num % 30 = 0)
    |> printfn "%A" 

tens
    |> Seq.take 5
    |> Seq.map (fun num -> num * num)
    |> printfn "%A" 


let factorialSeq = Seq.initInfinite (fun num -> List.fold ( * ) 1 [1..num])
// Compute the sum of the first 7 factorials using only |> Seq.take |> Seq.sum.

factorialSeq
    |> Seq.take 7
    |> Seq.fold (fun acc curr -> acc + curr) 0