(*
 * File: binary_tree.fsx
 * Author: Franz Zbinden García 841-22-0855
 * Course: COTI 4039-VH1
 * Date: 11/26/2025
 * Purpose: This program demonstrates how to define and use a binary search
 *          tree.
 *)

// Defines a type for a binary tree.
type 'a Tree =  // defines generic tree
    | Empty
    | Tree of 'a Tree * 'a * 'a Tree    // left * middle * right

// Auxiliar for height
let max a b = if a > b then a else b

// A function that returns the number of levels in the given binary search tree
let rec height = function
    | Empty -> 0
    | Tree (lft,_,rgt) -> 1 + (max (height lft) (height rgt))  // using previously defined auxiliar funcion ^^^^^

// A function that returns the list that corresponds to the given binary search tree
let rec list_from_tree = function
        | Empty -> []
        | Tree (Empty,root,Empty) -> [root]
        | Tree (lft,root,rgt) -> list_from_tree lft @ root :: list_from_tree rgt

// Returns the root element of a tree.
let root = function
    | Empty -> failwith "empty tree"
    | Tree ( _, root, _) -> root

// Returns the left subtree of a tree.
let left = function
    | Empty -> failwith "empty tree"
    | Tree (lft, _, _) -> lft

// Returns the right subtree of a tree.
let right = function
    | Empty -> failwith "empty tree"
    | Tree (_, _, rgt) -> rgt

// Returns the tree that results by inserting an element in the given tree.
let rec insert elem = function
    | Empty -> Tree (Empty, elem, Empty)    // if empty node -> create a node with the element and unwind
    | Tree (lft, root, rgt) when elem < root -> // match tree with condition 
        Tree ((insert elem lft), root, rgt) // inside tree type -> rec call to continue search
    | Tree (lft, root, rgt) when elem > root -> 
        Tree (lft, root, (insert elem rgt))
    | _ as bst -> bst // if elem already exist -> return without any change

// Returns the number of elements in the given tree.
let rec size = function
    | Empty -> 0
    | Tree (lft, _, rgt) -> 1 + size lft + size rgt

// Returns the sum of the elements in the given tree of integers.
let rec sum = function
    | Empty -> 0
    | Tree (lft, root, rgt) -> root + sum lft + sum rgt

// Returns true if the given tree contains the given element.    
let rec contains target = function
    | Empty -> false
    | Tree (lft, root, _)
        when target < root -> contains target lft
    | Tree (_, root, rgt)
        when target > root -> contains target rgt
    | _ -> true

// Returns a string representation of the given tree using inorder traversal.
let rec treeToString = function
    | Empty -> ""
    | Tree (lft, root, rgt) -> 
        sprintf "%s %A %s" (treeToString lft) root (treeToString rgt)

// Returns a sequence of the given tree using inorder traversal.
let rec elements bst =
    seq {
        match bst with
        | Empty -> yield! Seq.empty
        | Tree (lft, root, rgt) -> 
            yield! elements lft
            yield root
            yield! elements rgt
    }

// Entry point for the program.
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