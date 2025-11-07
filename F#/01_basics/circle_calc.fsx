
// Defines the value of pi.
let pi = 3.14159

// Computes the area of the circle with the given radius.
let circleArea rad = pi * rad ** 2.0

// A more familiar way:
let circleArea' rad = 
    pi * rad ** 2.0

// Computes the circumference of the circle with the given radius.
let circleCircum rad = 2.0 * pi * rad

// Entry point for the program.
let radius = 5.0
printfn "The radius of the circle is %.1f" radius

printfn "Area of circle more familiar %.1f" (circleArea' radius)

printfn "\nIts area is %.1f and its circumference is %.1f"
    (circleArea radius) (circleCircum radius)