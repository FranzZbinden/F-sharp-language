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


let fiboHigher f num =
    List.fold (f num) 0 [0..num]


// let fiboSeq =
