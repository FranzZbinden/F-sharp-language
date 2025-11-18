let nums = [1;2;3;4;5]

let sum = List.fold (fun acc elem -> acc + 1) 0 nums

printfn "%d" sum

let factorial = List.fold ( * ) 1 nums

printfn "%d" factorial