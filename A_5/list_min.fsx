// Compute the min element on a list:

let minimum val1 val2 = if val1 < val2 then val1 else val2  // Auxiliar Function

// let listMin lst = function
//     | [] ->
//         failwith "listMin: empty list"
//     | x :: xs ->
//         List.fold minimum x xs

let list_min_tl lst = 
    let rec loop min = function 
        | [] -> min 
        | hd::tl -> loop (minimum min hd) tl

    match lst with | [] -> 0 | hd::tl -> loop hd tl 

// let list_min_rec lst =
//     let rec loop min lst = 
//         match lst with 
//         | [] -> min
//         | hd::tl -> loop 

//     match lst with | [] -> 0 | hd::tl -> loop hd tl

