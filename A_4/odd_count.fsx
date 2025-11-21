// int list -> int
let rec oddCount = function 
    | [] -> 0
    | hd::tl when hd % 2 <> 0 -> 1 + oddCount tl
    | _::tl -> oddCount tl


// int list -> int
let oddCountIter lst =
    let rec loop lst acc =
        match lst with 
        | [] -> acc
        | hd::tl when hd % 2 <> 0 -> loop tl (acc+1)
        | _::tl -> oddCount tl
    loop lst 0


// // int list -> int
let oddCountHigher lst = 
    lst
    |> List.filter (fun x -> x % 2 = 0) 
    |> List.fold (fun acc _ -> acc + 1) 0
    