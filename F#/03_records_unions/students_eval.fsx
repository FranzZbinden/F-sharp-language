
// Defines a student with id, name, and list of exams.
type Student = {
   id: string
   name: string
   exams: int list
}

// Represents an evaluation consisting of average and grade.
type Evaluation = {
   average: float
   grade: char
}

// Returns the average of the given list of integers.
let average lst = 
   float (List.sum lst) / float (List.length lst)

// Returns the grade corresponding to the given score.
let grade score =
   if score >= 90.0 then 'A'
   elif score >= 80.0 then 'B'
   elif score >= 70.0 then 'C'
   elif score >= 60.0 then 'D'
   else 'F'

// Returns the evaluation of the given student.
let evaluate std =
   let avg = average std.exams
   let grd = grade avg
   { average = avg; grade = grd }

// Prints the data and evaluation of the given student.
let printData std =
   printfn "\nId: %s" std.id
   printfn "Name: %s" std.name
   printfn "Exams: %A" std.exams

   let eval = evaluate std
   printfn "Average: %.1f" eval.average
   printfn "Grade: %c" eval.grade   

// Entry point for the program.
let students = [
   { id = "1111"; name = "John Doe"; exams = [80; 85; 93] }
   { id = "2222"; name = "Jane Doe"; exams = [90; 85; 87] }
   { id = "3333"; name = "Joe Smith"; exams = [81; 76; 80] }
]

printfn "These are the students..."
List.iter printData students