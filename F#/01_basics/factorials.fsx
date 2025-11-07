
// Computes the factorial of an integer using an if expression.
let rec factorial num = 
   if num = 0 
      then 1 
      else num * factorial (num - 1)

// Computes the factorial of an integer using a pattern-matching expression.
let rec factorialMatch num =
   match num with
   | 0 -> 1
   | _ -> num * factorialMatch (num - 1)

// Computes the factorial of an integer using a pattern-matching function.
let rec factorialMatch' = function
   | 0 -> 1
   | num -> num * factorialMatch' (num - 1)

// Computes the factorial of an integer using a tail-recursive helper function.
let factorialIter num =
   let rec loop prod = function
      | 0 -> prod
      | num -> loop (prod * num) (num - 1)

   loop 1 num

// Entry point for the program.
let number = 5
printfn "The number is %d" number

printfn "\nIts factorial is..."
printfn "\tUsing an if expression: %d" (factorial number)
printfn "\tUsing a pattern-matching expression: %d" (factorialMatch number)
printfn "\tUsing a pattern-matching function: %d" (factorialMatch' number)
printfn "\tUsing a tail-recursive helper function: %d" (factorialIter number)