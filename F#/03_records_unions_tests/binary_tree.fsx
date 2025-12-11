type 'a Tree =
    | Empty
    | Tree of 'a Tree * 'a * 'a Tree

let max a b =
    if a > b then a else b

let rec height t =
    failwith "TODO"

let rec list_from_tree t =
    failwith "TODO"

let root t = function
    | Empty -> failwith "Empty tree, no elements"
    | Tree(_,root,_) -> root

let left t = function
    | Empty -> failwith "Empty list"
    | Tree(lft,_,_) -> lft 
    
let right t = function
    | Empty -> failwith "Empty list"
    | Tree(_,_,rgt) -> rgt

let rec insert elem = function
    | Empty -> Tree(Empty,elem,Empty)
    | Tree(lft,root,rgt) when root > elem -> Tree(insert elem lft,root,rgt)  
    | Tree(lft,root,rgt) when root < elem -> Tree(lft,root,insert elem rgt)
    | _ as bst -> bst

let rec size = function
    | Empty -> 0
    | Tree(lft,_,rgt) -> 1 + size lft + size rgt

let rec sum = function
    | Empty -> 0
    | Tree(lft,root,rgt) -> sum lft + root + sum rgt

let rec contains target = function
    | Empty -> false
    | Tree(lft,root,_) when root > target -> contains target lft 
    | Tree(_,root,rgt) when root < target -> contains target rgt
    | Tree(_,root,_) when root = target -> true 
    | _ -> false 

let rec treeToString =
    failwith "TODO"

let rec elements bst =
    seq { failwith "TODO" }

let numbers = 
    Empty 
        |> insert 30 
        |> insert 50 
        |> insert 10 
        |> insert 40 
        |> insert 20

printfn "The tree height is %A" (height numbers)
printfn "The list of the tree is: %A" (list_from_tree numbers)

printfn "The tree is %s" (numbers |> treeToString)
printfn "Its size is %d" (size numbers)

printfn "\nThe root value is %d" (root numbers)
printfn "The left subtree is %s" (left numbers |> treeToString)
printfn "The right subtree is %s" (right numbers |> treeToString)

printfn "\nThe sum of its elements is %d" (sum numbers)
printfn "Does it contain 40? %b" (contains 40 numbers)

printfn "\nThese are the elements of the tree, one per line: "
for elem in (elements numbers) do
    printfn "%d" elem
