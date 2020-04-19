module Oware

type StartingPosition =
    | South
    | North

type Board = {
    houses: int*int*int*int*int*int*int*int*int*int*int*int
    score : int*int
    }

let getSeeds n board = 
    match board with
    | northplayer -> function
        | 1 -> 'a| 2 -> 'b | 3 -> 'c | 4 -> 'd | 5 -> 'e | 6 -> 'f | _ -> failwith "Invalid number on board"   
    | southplayer -> function
        | 7 -> 'A | 8 -> 'B | 9 -> 'C | 10 -> 'D | 11 -> 'E | 12 -> 'F | _ -> failwith "Invalid number on board"
    | _ -> failwith "Invalid number on board"


let useHouse n board = 
    let (h1',h2',h3',h4',h5',h6',h7',h8',h9',h10',h11',h12') = board.houses
    let numseeds = getSeeds n board
    let rec plantseeds seeds updateboard house_num =
        match seeds > 0 with
        | true -> 
            match house_num with
            | 1 -> plantseeds (seeds-1) {board with houses = ((h1+1),h2,h3,h4,h5,h6,h7,h8,h9,h10,h11,h12)} (house_num+1)
            | 2 -> plantseeds (seeds-1) {board with houses = (h1,(h2+1),h3,h4,h5,h6,h7,h8,h9,h10,h11,h12)} (house_num+1)
            | 3 -> plantseeds (seeds-1) {board with houses = (h1,h2,(h3+1),h4,h5,h6,h7,h8,h9,h10,h11,h12)} (house_num + 1)
            | 4 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,(h4+1),h5,h6,h7,h8,h9,h10,h11,h12)} (house_num + 1)
            | 5 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,(h5+1),h6,h7,h8,h9,h10,h11,h12)} (house_num + 1)
            | 6 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,h5,(h6+1),h7,h8,h9,h10,h11,h12)} (house_num + 1)
            | 7 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,h5,h6,(h7+1),h8,h9,h10,h11,h12)} (house_num + 1)
            | 8 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,h5,h6,h7,(h8+1),h9,h10,h11,h12)} (house_num + 1)
            | 9 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,h5,h6,h7,h8,(h9+1),h10,h11,h12)} (house_num + 1)
            |10 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,h5,h6,h7,h8,h9,(h10+1),h11,h12)} (house_num + 1)
            |11 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,h5,h6,h7,h8,h9,h10,(h11+1),h12)} (house_num + 1)
            |12 -> plantseeds (seeds-1) {board with houses = (h1,h2,h3,h4,h5,h6,h7,h8,h9,h10,h11,(h12+1))} 1
        | false -> //check if we can collect seeds 





    
let start position = 
    match position with
    | North -> North
    | South -> South 
    | _ -> failwith "Invalid starting position"


let score board = failwith "Not implemented"

let gameState board = failwith "Not implemented"

[<EntryPoint>]
let main _ =
    let b = { Board.Houses = (4,4,4,4,4,4,4,4,4,4,4,4);
        score = (0,0) }
    useHouse 2 b.Houses 
    printfn "Hello from F#!"
    0 // return an integer exit code
