// determines whether a list is empty or not.
let isEmpty lst = 
    if lst = [] then true else false

// using enference
let isEmpty' lst = 
    lst = []

// Returns the first element in a list.
let head lst = 
    match lst with
    | [] -> failwith "empty list"
    | head::tail -> head  // if possible to get first element, return first

// Returns the rest of the elements in a list
let tail lst = 
    match lst with
    | [] -> failwith "Empty list"
    | _::tail -> tail

// Returns the number of elements in a list
let rec length lst = 
    match lst with 
    | [] -> 0
    | hd::tl -> 1 + length tl   // tl is the new list for recursive call

// Returns the number of elements in a list more efficient 
let rec length' lst =
    let rec loop acc lst = 
        match lst with  
        | [] -> acc // When the given list is out of numbers return the acomulator
        | hd::tl -> loop (acc + 1) tl   // 

    loop 0 lst  // call and assign values to internal functions

// Return the sum of the elements of the given list
let rec sum lst = 
    match lst with 
    | [] -> 0
    | hd::tl -> hd + sum tl


// Returns the sum of the elements of the given list more efficient
let sum' lst = 
    let rec loop acc lst = 
        match lst with 
        | [] -> acc
        | hd::tl -> loop(acc + 1) tl

    loop 0 lst