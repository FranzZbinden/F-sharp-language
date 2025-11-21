
// Returns the ammount of odd numbers in a list using normal recursion
let rec oddCount = function 
    | [] -> 0
    | hd::tl when hd % 2 <> 0 -> 1 + oddCount tl
    | _::tl -> oddCount tl


// Returns the ammount of odd numbers in a list list using tail recursion   
let oddCountIter lst =
    let rec loop lst acc =
        match lst with 
        | [] -> acc
        | hd::tl when hd % 2 <> 0 -> loop tl (acc+1)
        | _::tl -> loop tl acc
    loop lst 0


let oddCountHigher lst = 
    lst
    |> List.filter (fun x -> x % 2 <> 0) 
    |> List.length

let list_ = [5;10;4;3;2;9;1;6;-7;8]
printfn "Computing the number of odds in %A:" list_
printfn "Using regular recursion: %d" (oddCountHigher list_)
printfn "Using tail-recursive helper function: %d" (oddCountHigher list_)
printfn "Using List.filter and List.length: %d" (oddCountHigher list_)

