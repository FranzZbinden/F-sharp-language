let rec power basee exp = // using regular if else
    if exp = 0 then 1
    else basee * power basee (exp-1)

let rec powerMatch basee exp =   // Using match
    match exp with
    | 0 -> 1
    | _ -> basee * powerMatch basee (exp-1)

let rec powerMatch' = function
    | (_,0) -> 1
    | (basee,exp) -> basee * powerMatch' (basee, exp-1)

let powerIter basee exp =
    let rec loop acc exp =
        match exp with
        | 0 -> acc
        | _ -> loop (acc * basee) (exp - 1)
    loop 1 exp
