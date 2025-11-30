let rec sumDigits n =
    match n with 
    | 0 -> 0
    | _ -> n + sumDigits (n-1)


let rec sumListMatch = function 
    | [] -> 0
    | hd::tl -> hd + sumListMatch tl

let rec sumList lst = 
    match lst with 
    | [] -> 0
    | hd::tl -> hd + sumList tl


let sumListIter lst = // tail recursive
    let rec loop acc lst = 
        match lst with 
        | [] -> acc
        | hd::tl -> loop (hd + acc) tl
    
    loop 0 lst

