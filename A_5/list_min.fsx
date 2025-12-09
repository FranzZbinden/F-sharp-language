// Compute the min element on a list using: List fold, tail & normal recursion:

let minimum val1 val2 = if val1 < val2 then val1 else val2  // Auxiliar Function

//Using list fold
let list_min = function
    | [] ->
        failwith "listMin: empty list"
    | hd :: tl ->
        List.fold minimum hd tl

//Using tail recursive 
let list_min_tl lst = 
    let rec loop min = function 
        | [] -> min 
        | hd::tl -> loop (minimum min hd) tl

    match lst with | [] -> 0 | hd::tl -> loop hd tl 

//Using normal recurison
let rec list_min_rec = function 
        | [] -> failwith "Empty list"
        | [hd] -> hd    
        | hd::tl -> minimum hd (list_min_rec tl)
        