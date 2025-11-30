let foldLength lst = 
    List.fold (fun acc _  -> acc + 1) 0 lst
    

// fold sum of elements
let foldSum lst = 
    List.fold (fun acc curr -> acc + curr) 0 lst


let foldReverse lst = 
    List.fold (fun new_lst curr -> curr :: new_lst ) [] lst

// filter the odd numbers from a list
let filterOdds lst = 
    List.filter (fun curr -> curr % 2 = 0) lst


let mapDouble lst = 
    List.map (fun curr -> curr*2 ) lst


// Return a list of factorials from 1 to n
// (using List.fold or your own factorial function).
let factorialRange n = 
    List.fold (fun acc curr -> acc * curr) 1 [1..n]


let pipeEvenSquares lst = 
    lst
    |> List.filter (fun curr -> curr % 2 = 0)
    |> List.map (fun curr -> curr * curr)


// Description:
// Use List.fold to multiply all elements.
let foldProduct lst = List.fold (fun acc curr -> curr * acc) 1 lst


// Add 1 to every element using List.map.
let mapIncrement lst = List.map(fun curr -> curr + 1) lst


