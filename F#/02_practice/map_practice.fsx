let mascotas = Map ["Cali", 1; "Aria",2]

printfn "%A" mascotas 

let mascotas2 = Map.add "Doki" 3 mascotas

printfn "%A" mascotas2

let printKeys courseMap = 
    for KeyValue(a,b) in courseMap do 
        printfn "%A : %A" a b

printKeys mascotas2

let look_up_map code map = 
    for KeyValue(a,b) in map do
        if a = code then b 

let content = Map.tryFind "Cali" mascotas
printfn "%A" content