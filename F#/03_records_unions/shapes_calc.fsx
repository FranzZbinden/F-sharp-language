
// Defines the set of available colors.
type Color = White | Red | Green | Blue | Yellow | Black // Discriminated union

// Returns the string representation for the given color.
let colorToString = function
   | White -> "white"
   | Red -> "red"
   | Green -> "green"
   | Blue -> "blue"
   | Yellow -> "yellow"
   | Black -> "black"

// Defines a 2D point with x- and y-coordinates.
type Point = Point of float * float // constructor (*): and

// Returns the string representation for the given point.
let pointToString = function
   Point (x, y) -> sprintf "(%.1f, %.1f)" x y

// Defines the set of available shapes.
type Shape =
   | Circle of // of: case has value OF
      color: Color * location: Point * radius: float
   | Rectangle of 
      color: Color * location: Point * width: float * height: float

// Defines the value of pi.
let pi = 3.14159

// Returns the area of the given shape.
let area = function
   | Circle (_, _, rad) -> pi * rad ** 2.0
   | Rectangle (_, _, wdt, hgt) -> wdt * hgt

// Returns the perimeter of the given shape.
let perim = function
   | Circle (_, _, rad) -> 2.0 * pi * rad // if arg is circle -> return perim of circle
   | Rectangle (_, _, wdt, hgt) -> 2.0 * (wdt + hgt) // if arg is Rectangle -> return perim of Rectangle

// Returns a string representation for the given shape.
let shapeToString = function
   | Circle (clr, loc , rad) -> 
      sprintf "color: %s, location: %s, radius: %.1f" 
         (colorToString clr) (pointToString loc) rad
   | Rectangle (clr, loc , wdt, hgt) ->
      sprintf "color: %s, location: %s, width: %.1f, height: %.1f" 
         (colorToString clr) (pointToString loc) wdt hgt

// Prints the data of the given shape.
let printData shp =
   printfn "\nThe shape is a %s" (
      match shp with
      | Circle (_) -> "circle"
      | Rectangle (_) -> "rectangle"
   )

   printfn "Its data is %s" (shapeToString shp)
   printfn "Its area is %.1f" (area shp)
   printfn "Its perimeter is %.1f" (perim shp)

// Entry point for the program.
let shapes = [
   Circle (color = Green, location = Point (1.0, 2.0), 
      radius = 5.0)
   Rectangle (color = Yellow, location = Point (8.0, 9.0), 
      width = 5.0, height = 6.0)
   Circle (color = Blue, location = Point (7.0, 3.0), 
      radius = 4.0)
]

printfn "These are the shapes..."
for shape in shapes do 
   printData shape