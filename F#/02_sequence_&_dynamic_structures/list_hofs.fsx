
// Entry point of the program.
let numbers = [30; 10; 50; 40; 20]

printfn "The list of numbers is %A" numbers
printfn "Its length is %d" (List.fold (fun acc _ -> acc + 1) 0 numbers)
printfn "The sum of its elements is %d" (List.fold ( + ) 0 numbers)

numbers
    |> List.fold (fun acc elem -> elem::acc) []
    |> printfn "The reversed list is %A"

let naturals = [1..10]
printfn "\nThe first 10 naturals: %A" naturals

let evens = List.filter (fun elem -> elem%2 = 0) naturals
printfn "The first five even naturals: %A" evens

let evenSquares = List.map (fun elem -> elem * elem) evens
printfn "The list of the first five even squares is %A" evenSquares

let evenSquares' =
    [1..10]
        |> List.filter (fun elem -> elem%2 = 0)
        |> List.map (fun elem -> elem * elem)

printfn "\tUsing pipe, the list is %A" evenSquares'

let factorial num = List.fold ( * ) 1 [1..num]
printfn "\nThe factorial of 5 is %d" (factorial 5)

let limit = 10
let factorialList = List.init limit (fun idx -> factorial (idx + 1))

printfn $"\nThe list of the first {limit} factorials..."
List.iter (printfn "%d") factorialList