
// Prints the map of courses as a table.
let printData courseMap =
    printfn "Title\t  Credits"
    printfn "-----\t  -------"

    Map.iter (fun title credits -> printfn "%s\t%d" title credits) courseMap
    printfn "There are %d courses" (Map.count courseMap)

// Entry point of the program.
let courses = Map [
    "COTI3101", 4; "COTI3102", 4; "COTI3205", 3; "COTI4039", 3
]

printfn "The map of courses to credits is %A" courses
printfn "The number of bindings is %d" (Map.count courses)

printfn "\nThese are the courses..."
printData courses

let newCourse = "COTI4150"
let courses' = Map.add newCourse 3 courses

printfn $"\nAfter adding {newCourse} these are the courses..."
printData courses'

printf $"\nThe course with code {newCourse} was "
if Map.containsKey newCourse courses'
    then printfn $"found and has {courses'[newCourse]} credits" 
    else printfn "not found"

let courses'' =  Map.remove newCourse courses'

printfn $"\nAfter removing {newCourse} these are the courses..."
printData courses''

let words =
    Map.empty
        |> Map.add "Hello" "Hola"
        |> Map.add "Good-bye" "Adios"
        |> Map.add "Today" "Hoy"
        |> Map.add "Yesterday" "Ayer"
        |> Map.add "Tomorrow" "Manana"

printfn "\nThese are the words..."
for KeyValue(english, spanish) in words do
    printfn $"English: {english} => Spanish: {spanish}"
printfn "The number of bindings is %d" (Map.count words)