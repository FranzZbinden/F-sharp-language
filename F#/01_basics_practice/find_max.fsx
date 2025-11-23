let rec maxList lst =
    match lst with 
    | [hd] -> hd
    | hd::tl when hd > maxList tl -> hd
    | _::tl -> maxList tl   


let maxListIter lst =
    let rec loop curr_max lst =
        match lst with
        | [] -> curr_max
        | hd::tl when hd > curr_max -> loop hd tl
        | _::tl -> loop curr_max tl

    match lst with 
    | [] -> failwith "Empty list"
    | hd::tl -> loop hd tl