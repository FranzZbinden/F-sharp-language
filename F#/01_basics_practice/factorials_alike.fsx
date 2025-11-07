// Calculate the factorial of the given integer
let rec factorial num = 
    if num = 0 then 1
    else num * factorial(num-1) 

// Computes the factorial of an integer using a pattern-matching expression.
let rec factorial_p_m num = 
    match num with 
    | 0 -> 1
    | _ -> num * factorial_p_m(num-1)

// Computes the factorial of an integer using a pattern-matching function.
let rec factorial' = function
    | 0 -> 1
    | num -> num * factorial' (num-1)

// Computes the factorial of an integer using a tail-recursive helper function.
let factorial'' num = 
    let rec loop prod num = 
        match num with 
        | 0 -> prod 
        | num -> loop (prod*num) (num-1)

    loop  1 num 

// Computes the power of the given integer ()tail recursive)
let power' num =
    let prod = 1
    let rec loop num prod = 
        match num with
        | 0 -> prod // returns the power 
        | _ -> loop (num-1) (prod*num)
    
    loop num prod

// Sumation of the given number 6 + 5 + 4 + .. + 1 ( normal )
let sumation num =
    let rec loop cnt sum num=
        match cnt with
        | 0 -> sum
        | _ -> loop (cnt-1) (num+sum) num
    
    loop num 0 num 

let sumation' num = 
    let rec loop cnt result  =
        match cnt with
        | 0 -> result
        |_ -> loop (cnt-1) (cnt + result)
    
    loop num 0