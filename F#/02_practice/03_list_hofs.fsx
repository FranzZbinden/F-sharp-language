let numbers = [1;2;3;4;5]

let add x y = x + y


let sumation = List.fold (fun acc x -> x + acc ) 0 numbers 

printfn "%d" sumation

// let fiboHigher num =  
//     let numbers = [0..num]
//     let folder (prev, curr) _ = (curr, curr + prev)     // x is the curr elem in list

//     let num = List.fold (folder) (0, 1) [1..num] 

//     let rec loop prev 


