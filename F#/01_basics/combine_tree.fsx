
let sum num1 num2 = num1 + num2

let minimum num1 num2 = if num1 < num2 then num1 else num2  // si las letras inferidas de tipo son iglaues, tienen que ser de distinto tipo

let combineThree num1 num2 num3 combineTwo =
    let temp = combineTwo num1 num2
    combineTwo temp num3

let number1, number2, number3 = 4, 2, 6
printfn "The numbers are %d, %d, and %d" number1 number2 number3

printfn "\nTheir sum is %d" (combineThree number1 number2 number3 sum)
printfn "\nTheir minimun is %d" (combineThree number1 number2 number3 minimum)

// Anonimous functions in f#
let maximum = fun n1 n2 -> if n1 > n2 then n1 else n2

printfn "\nTheir maximum is %d" (combineThree number1 number2 number3 maximum)
printfn "\nTheir product is %d" (combineThree number1 number2 number3 (fun n1 n2 -> n1 * n2))

printfn "\nUsing built-in operators/functions..."
printfn "\nTheir sum is %d" (combineThree number1 number2 number3 (+))
printfn "\nTheir product is %d" (combineThree number1 number2 number3 ( * ))
printfn "\nTheir product is %d" (combineThree number1 number2 number3 min)
printfn "\nTheir product is %d" (combineThree number1 number2 number3 max)

