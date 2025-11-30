
// Defines a type point that contains a touple of 2 floats
type Point = float * float  // the "*" is used for touple type

type Circle = {         // "Circle": record type
    location: Point     // "location": field
    radius: float       // "radius": field
}

let pi = 3.14159

let circleArea c = c.radius * c.radius * pi

let scaleCircle c factor = {c with radius = c.radius * factor}  // in c, copy and update the (radius) with -> X

let c = {location = Point (3.0, 4.0); radius = 4.0}



