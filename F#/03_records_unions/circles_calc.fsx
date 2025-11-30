(*
 * File: circles_calc.fsx
 * Author: Franz Zbinden
 * Date: 11/24/2025
 * Purpose: This program computes and displays the area and circumference of
 *          the given circles.
 *)

// Defines a 2D point with x- and y-coordinates.
type Point = float * float

// Defines a circle with location and radius.
type Circle = {
    location: Point
    radius: float
}
// Defines the value of pi.
let pi = 3.14159

// Returns the area of the given circle.
let circleArea c = pi * c.radius ** 2.0

// Returns the circumference of the given circle.
let circleCircum c = 2.0 * pi * c.radius

// Scales a circle by the given factor.
let scaleCircle c factor = 
    { c with radius = c.radius * factor }

// Entry point of the program.
let c = { location = Point (3.0, 4.0); radius = 5.0 }

printfn "The location of the circle is (%.1f, %.1f)" 
    (fst c.location) (snd c.location)
printfn "The radius is %.1f" c.radius
printfn "The area is %.1f and the circumference is %.1f"
    (circleArea c) (circleCircum c)

let c' = scaleCircle c 2.0

printfn "\nAfter scaling by 2.0, the radius is %.1f" c'.radius
printfn "The area is %.1f and the circumference is %.1f"
    (circleArea c') (circleCircum c')