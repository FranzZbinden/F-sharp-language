let max num1 num2 = 
    if num1 > num2 then num1 
        else num2

let min num1 num2 = 
    if num1 < num2 then num1
    else num2


let sum num1 num2 = num1 + num2

let combineThree num1 num2 num3 combineTwo =
    combineTwo num1 (combineTwo num2 num3)


// Anonimous functions in F#
let maximous = 
    fun n1 n2 -> 
        if n1 > n2 
            then n1 
            else n2