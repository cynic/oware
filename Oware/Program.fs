module Oware

type StartingPosition =
    | South
    | North

type player = {
    house : int*int*int*int*int*int
    capturedseeds : int}

type Board={
    northplayer : player
    southplayer : player
    }

let getSeeds n board = 
    match board with
    | northplayer -> function
        | 1 -> 'a| 2 -> 'b | 3 -> 'c | 4 -> 'd | 5 -> 'e | 6 -> 'f | _ -> failwith "Invalid number on board"   
    | southplayer -> function
        | 7 -> 'A | 8 -> 'B | 9 -> 'C | 10 -> 'D | 11 -> 'E | 12 -> 'F | _ -> failwith "Invalid number on board"
    | _ -> failwith "Invalid number on board"


let useHouse n board = failwith "Not implemented"

let start position = 
    match position with
    | North -> North
    | South -> South 
    | _ -> failwith "Invalid starting position"


let score board = failwith "Not implemented"

let gameState board = failwith "Not implemented"

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    0 // return an integer exit code
