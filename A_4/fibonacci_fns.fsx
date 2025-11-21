
// Normal recursion
let rec fibo num =
    if num = 0 then 0 
    elif num = 1 then 1 
    else fibo (num-1) + fibo (num-2)

// Recursive using pattern matching
let rec fiboMatch num = 
    match num with
    | 0 -> 0
    | 1 -> 1
    | _ -> fiboMatch(num-1) + fiboMatch (num-2)

// Using tail recursion
let fiboIter num =
    let rec loop a b cnt= 
        match cnt with        
        | 0 -> a
        | _ -> loop (b) (a + b) (cnt - 1)

    loop 0 1 num
    
// defining the window func that  (a, b) -> (b, a+b)
let window (prev, curr) _ = (curr, curr + prev)

let fiboHigher num =
    let (prev, curr) = List.fold window (0, 1) [1..num]
    prev

// fibonacci sequence
let fiboSeq = 
    Seq.initInfinite (fun num -> 
        let (prev, curr) = List.fold window (0, 1) [1..num] 
        prev
        ) 
    
// Setting the limit
let limit = 7

// Taking only the elements to give later to -> fiboSeq 
fiboSeq
    |> Seq.take limit

// Prints vvvvvvvvvv
printfn "Computing the 7-th term of the Fibonacci sequence: "
printfn "Using if expression: %d" (fibo limit)
printfn "Using pattern matching: %d"(fiboMatch limit)
printfn "Using tail-recursive helper function: %d"(fibo limit)
printfn "Using List.fold: %d"(fibo limit)
printfn "%A" fiboSeq
