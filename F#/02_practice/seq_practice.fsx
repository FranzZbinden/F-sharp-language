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

// first multiples of 3 
let mul_three = seq {for x in 0..10 do if x % 3 = 0 then yield x}

let mix_seq = seq { 
    for x in 0..5 do yield x
    for y in 100..105 do yield y
}

let squares_seq = seq {for x in 1..20 do yield x*x }


let even_seq = seq { for x in 1..20 do if x%2=0 then yield x }

let odd_seq = seq {for x in 0..20 do if x % 2 <> 0 then yield x}

let fibo_seq = seq {
    let mutable x = 0
    let mutable y = 1
    for _ in 0..30 do 
        let next = x + y
        x <- y
        y <- next
        yield next
}
// A sequence that counts from 50 down to 0 by steps of 5.
let countDown = seq {
    for x in 50..-5..0 do yield x
}


let nums = seq {
    for x in 0..20 do yield x
}

nums 
    |> Seq.filter (fun x -> x % 2 = 0)
    |> Seq.map (fun x -> x * x)
    |> Seq.fold (fun acc curr -> acc + curr) 0 
    |> printfn "The sum of the even squares numbers is %A"

