type 'a Tree =
    | Empty
    | Tree of 'a Tree * 'a * 'a Tree

let max<'a when 'a : comparison> (a: 'a) (b: 'a) : 'a = if a > b then a else b

let rec height (tree: 'a Tree) : int =  
    match tree with 
    | Empty -> 0
    | Tree(lft,root,rgt) -> 1 + max (height lft) (height rgt)


let rec list_from_tree (tree: 'a Tree) : 'a list = 
    match tree with
    | Empty -> []
    | Tree(Empty, root, Empty) -> [root]
    | Tree(lft,root,rgt) -> list_from_tree lft @ (root :: list_from_tree rgt) 


let rec insert<'a when 'a : comparison> (elem: 'a) (tree: 'a Tree) : 'a Tree = 
    match tree with 
    | Empty -> Tree(Empty,elem,Empty)
    | Tree(lft,root,rgt) when elem < root -> Tree(insert elem lft, root, rgt)
    | Tree(lft,root,rgt) when elem > root -> Tree(lft, root, insert elem rgt)  
    | _ as bst -> bst   // unwinds tree as it was

let size (tree: 'a Tree) : int = failwith "TODO" // count nodes

let rec product_tree (tree: int Tree) : int = 
    match tree with 
    | Empty -> 1
    | Tree(lft,root,rgt) -> root * product_tree lft * product_tree rgt

let rec contains<'a when 'a : comparison> (target: 'a) (tree: 'a Tree) : bool =
    match tree with 
    | Empty -> false
    | Tree(_,root,_) when root = target -> true
    | Tree(_,root,rgt) when root < target -> contains target rgt 
    | Tree(lft,root,_) when root > target -> contains target lft
    