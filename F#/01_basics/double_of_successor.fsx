
// Computes the successor of a number.
let successor = ( + ) 1

// Computes the double of a number.
let double = ( * ) 2 // takes any number and * by 2

// Composes two functions.
let compose f g =
   fun x -> f (g x)

// Defines an operator as an alias of the composition function.
let ( .<< ) = compose   // creating my own composer ".<<"

// Entry point for the program.
let number = 5
printfn "The number is %d" number

printfn "\nThe double of the successor of the number is..."
printfn "\tUsing nested function calls: %d" (double (successor number))
printfn "\tUsing the backward composition operator: %d" ((double << successor) number) // ">>" built in function for function composition (backward composition)
printfn "\tUsing the forward composition operator: %d" ((successor >> double) number)   //(forward composition)

// value |> function1 |> function2 |> function3
// or vvvvvv

number
   |> successor
   |> double
   |> printfn "\tUsing the forward pipe operator: %d"   // no need to provide value on the right of "printfn"

printfn "\tUsing my composition operator: %d" ((double .<< successor) number)