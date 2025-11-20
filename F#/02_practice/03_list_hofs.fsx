let numbers = [1;2;3;4;5]

let sumation = List.fold (fun acc x -> x + acc ) 0 numbers 

printfn "%d" sumation

let fiboHigher num =  

    let folder (prev curr) x = (curr x)     // x is the curr elem in list