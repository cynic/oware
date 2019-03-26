﻿module Oware

type StartingPosition =
    | South
    | North

type Player={
houses : int*int*int*int*int*int
totalHouses :  int*int*int*int*int*int* int*int*int*int*int*int
captured : int}

type states=
|Draw of string
|Win of string
|Northturn 
|Southturn

type Board={
    state : states
    northplayer : Player
    southplayer : Player
    }
    //getSeeds, which accepts a house number and a board,
    //and returns the number of
    //seeds in the specified house
let getSeeds n board = // failwith "Not implemented"
    match board.state with
    |Northturn | Southturn -> 
        let (a',b',c',d',e',f')= board.southplayer.houses 
        let (a,b,c,d,e,f) = board.northplayer.houses in
            match n with 
            |1-> a
            |2->b
            |3->c
            |4->d
            |5->e
            |6->f  
            |7->a'
            |8->b'
            |9->c'
            |10->d'
            |11->e'
            |12->f'
            |_-> failwith "Not implemented"
    |_-> failwith "Not implemented"

//useHouse, which accepts a house number and a board,
//and makes a move using
//that house.
let useHouse n board = // failwith "Not implemented"
         let (a, b,c,d,e,f ) = board.southplayer.houses 
         let (a',b',c',d',e',f')= board.northplayer.houses 
         let k = board.southplayer in
              match n with 
            //  | 1 ->let v =  {k with houses = (a-4, b+1,c+1,d+1,e+1,f) } in
            //             board
              |1->{ board.southplayer.houses = (a-4, b+1,c+1,d+1,e+1,f)}
                    board
            //|2->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|3->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|4->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|5->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|6->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|7->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|8->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|9->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|10->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|11->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
            //|12->{k with houses = (a-4, b+1,c+1,d+1,e+1,f ) }
              | _ ->  failwith "Not implemented"
                     

//start, which accepts a StartingPosition and returns 
//an initialized game where the person
//in the StartingPosition starts the game
let start position =
    //*matching the position to the player to output a borad type
    let reco={houses=(4,4,4,4,4,4);captured=0;totalHouses=(4,4,4,4,4,4,4,4,4,4,4,4)}
    match position with
    |North -> {state = Northturn ; northplayer = reco;southplayer=reco}
    |South->  {state = Southturn ; northplayer = reco;southplayer = reco}

//score, which accepts a board and gives back a 
//tuple of (southScore , northScore)
let score board = failwith "Not implemented"


//gameState, which accepts a board and gives back 
//a string that tells us about the
//state of the game. Valid strings are
//“South’s turn”, “North’s turn”, “Game ended in a draw”,
//“South won”, and “North won”.
let gameState board = failwith "Not implemented"

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    0 // return an integer exit code
