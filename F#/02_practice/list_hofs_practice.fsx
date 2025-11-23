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
