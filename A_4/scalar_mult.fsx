// This file determines the scalar multiplication of an integer and a list of integers using different methods:

// Recursive function to scale a list to the given number
let rec scalarMult num lst = 
    match lst with 
    | [] -> []
    | hd::tl -> (hd * num) :: scalarMult num tl 

// Function iter to scale a list to the given number
let scalarMultIter num lst =

    let rec loop num lst newLst=
        match lst with
        | [] -> List.rev newLst
        | hd::tl -> loop num tl ((hd*num) :: newLst)

    loop num lst []


let scalarMultHigher num lst = 
    List.map (fun x -> x * num) lst


printfn "Computing the scalar multiplication of 3 by [2;7;4]:"
printfn "Using regular recursion: %A" (scalarMult 3 [2;7;4])
printfn "Using tail-recursive helper function: %A" (scalarMultIter 3 [2;7;4])
printfn "Using List.map: %A" (scalarMultHigher 3 [2;7;4])
