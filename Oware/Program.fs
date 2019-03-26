module Oware

open System

type StartingPosition =
    | South
    | North

 type Player=
      {
       houses: int*int*int*int*int*int
       capturedSeeds: int
      }

 

type states=
|Draw of string
|Win of string
|Northturn 
|Southturn

type Board = {
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
        let (a',b',c',d',e',f')= board.northplayer.houses 
        let (a,b,c,d,e,f) = board.southplayer.houses in
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
         let (a, b , c, d, e, f ) = board.southplayer.houses  //(4,4,4,4,4,4) thats a b c d e f   right (4,4,4,4,0,5,    5,5,5,4,4,4
         let (a',b',c',d',e', f')= board.northplayer.houses 
         //{state = Northturn ; northplayer = reco;southplayer=reco}
         //{houses=(4,4,4,4,4,4);capturedSeeds=0} this must be southplayer type
        // let k = board.southplayer in
         match n with 
         | 1 ->let v =  {board with southplayer = {houses = (a-4, b+1,c+1,d+1,e+1,f) ; capturedSeeds = 0;};northplayer = {houses = (a',b',c',d',e',f') ; capturedSeeds = 0}} in
                          v
         | 5 -> let v =  { board with southplayer = {houses = (a,b,c,d,e-4,f+1) ; capturedSeeds = 0} ;northplayer = {houses = (a'+1,b'+1,c'+1,d',e',f') ; capturedSeeds = 0}} in
                          v                  
          
         | _ ->  failwith "Not implemented"

            
//-------------------------------------------------
//start, which accepts a StartingPosition and returns 
//an initialized game where the person
//in the StartingPosition starts the game
let start position =
  
    let reco={houses=(4,4,4,4,4,4);capturedSeeds=0}
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
  
  (*let useHouse n board = // failwith "Not implemented"
         let (a, b , c, d, e, f )= board.southplayer.houses  //(4,4,4,4,4,4) thats a b c d e f   right
         let (a',b',c',d',e', f')= board.northplayer.houses 
         //{state = Northturn ; northplayer = reco;southplayer=reco}
         //{houses=(4,4,4,4,4,4);capturedSeeds=0} this must be southplayer type
         let k = board.southplayer in
         match n with 
         | 1 -> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
                                                     CorrectRecordPlayer
         //| 2 -> let CorrectRecordPlayer  = {k with  houses = (a, b-4,c+1,d+1,e+1,f+1)} in
         //                                            CorrectRecordPlayer
         //| 3 -> let CorrectRecordPlayer  = {k with  houses = (a, b, c-4,d+1,e+1,f+1)} in
         //                                            CorrectRecordPlayer
         //| 4 ->let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 5 ->let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 6 -> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 7 -> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 8 -> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 9 -> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 10 -> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 11-> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer
         //| 12 -> let CorrectRecordPlayer  = {k with  houses = (a-4, b+1,c+1,d+1,e+1,f)} in
         //                                            CorrectRecordPlayer


         
         //let v =  {board with northplayer = {houses = (a-4, b+1,c+1,d+1,e+1,f) ; capturedSeeds = 0;}} in
         //                 v
                            
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
*)