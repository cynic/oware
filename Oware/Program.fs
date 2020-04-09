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

let getSeeds n board = failwith "Not implemented"

let useHouse n board = 
    

let start position = failwith "Not implemented"

let score board = failwith "Not implemented"

let gameState board = failwith "Not implemented"

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    0 // return an integer exit code
