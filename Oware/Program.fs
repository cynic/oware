module Oware

type StartingPosition =
    | South
    | North
 type Player=
      {
       houses: int*int*int*int*int*int
       capturedSeeds: int 
      }

 type board =
      {
           state : string
           northPlayer : Player
           southPlayer : Player
           
      }
                

    //getSeeds, which accepts a house number and a board,
    //and returns the number of
    //seeds in the specified house
let getSeeds n board = failwith "Not implemented"


//useHouse, which accepts a house number and a board,
//and makes a move using
//that house.
let useHouse n board = failwith "Not implemented"
      
            
//-------------------------------------------------
//start, which accepts a StartingPosition and returns 
//an initialized game where the person
//in the StartingPosition starts the game
let start position =
      
                match position = North  with
                | true -> { state= "north" ; northPlayer = {(7,8,9,10,11,12) }
                | _ -> North

                //  //let var n = 
                  //            match n <= 6 with
                  //            |true -> position = South 
                  //            | _ -> position = North
                  //var  
                
                   
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
