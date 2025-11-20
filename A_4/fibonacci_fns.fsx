let rec fibo num =
    if num = 0 then 0 
    elif num = 1 then 1 
    else fibo (num-1) + fibo (num-2)

let rec fiboMatch num = 
    match num with
    | 0 -> 0
    | 1 -> 1
    | _ -> fiboMatch(num-1) + fiboMatch (num-2)


let fiboIter num =
    let rec loop num = 
        match num with 
        | 0 -> 0
        | 1 -> 1
        | _ -> loop (num-1) + loop (num-2)

    loop num


let fiboHigher num =
    let window (prev, curr) _ = (curr, curr + prev)
    let (prev, curr) = List.fold window (0, 1) [1..num]
    prev

// let fiboSeq =
