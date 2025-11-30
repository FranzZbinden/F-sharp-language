let rec countElem elem lst =
    match lst with 
    | [] -> 0
    | hd::tl when hd = elem -> 1 + countElem elem tl
    | _::tl -> countElem elem tl


let countElemIter elem lst = 
    let rec loop acc lst =
        match lst with 
        | [] -> acc
        | hd::tl when hd = elem -> loop (acc+1) tl
        | _::tl -> loop acc tl
    loop 0 lst