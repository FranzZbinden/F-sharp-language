// returns the last elem of a list
let last lst = 
    let rec loop = function
        | [hd] -> hd
        | _::tl -> loop tl 
    loop lst


// Return all elements except the last
let init lst = 
    let rec loop new_lst lst = 
        match lst with 
        | [hd] -> List.rev new_lst
        | hd::tl -> loop (hd :: new_lst) tl 
    loop [] lst


// Return the nth element from the end
// Return the nth element from the end
let rec itemFromEnd n lst = 
    match lst with 
    | [] -> failwith "Element not found"
    | hd::_ when n = 0 -> hd
    | _::tl -> itemFromEnd (n-1) tl


//Square every element in a list
let rec squareList lst = 
    match lst with
    | [hd] -> [hd * hd]
    | hd::tl -> hd * hd :: squareList tl


let isEmpty = function | [] -> true | _ -> false

// non-recursive
// recursive
let rec length lst = 
    match lst with 
    | [] -> 0
    | _::tl -> 1 + length tl


// tail-recursive
let length' lst = 
    let rec loop acc = function 
    | [] -> acc
    | _::tl -> loop (acc + 1) tl
    loop 0 lst


// tail-recursive
let rec contains target = function
    | [] -> false
    | hd::_ when hd = target -> true 
    | _::tl -> contains target tl 


// recursive
let rec reverse = function
    | [] -> []
    | hd::tl -> (reverse tl) @ [hd]


// tail-recursive
let reverse' lst = 
    let rec loop new_lst = function
    | [] -> new_lst
    | hd::tl -> loop (hd::new_lst) tl
    loop [] lst


// recursive
let rec append lst1 lst2 = 
    match lst1 with 
    | [] ->  lst2
    | hd::tl -> hd :: append tl lst2
    
let rec last2 = function
    | [hd] -> hd
    | hd::tl -> last2 tl