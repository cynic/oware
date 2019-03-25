module Oware

open System

type StartingPosition =
    | South
    | North
<<<<<<< HEAD
 type Player=
      {
       houses: int*int*int*int*int*int
       capturedSeeds: int
      }

 type Board =
      {

           houseNumber : int 
           playersTurns : string // it's either south or north's turn
           southLargeHouseHas : int
           northLargeHousehas : int
           initialSeeds : int*int*int*int*int*int*int*int*int*int*int*int
      }
=======

type Player={
houses : int*int*int*int*int*int
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
>>>>>>> 43cfe5821ff84fd161c6de51a643a2773b5a68fd
                

    //getSeeds, which accepts a house number and a board,
    //and returns the number of
    //seeds in the specified house
<<<<<<< HEAD
let getSeeds n board = failwith "Not implemented"
                       

=======
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
>>>>>>> 43cfe5821ff84fd161c6de51a643a2773b5a68fd

//useHouse, which accepts a house number and a board,
//and makes a move using
//that house.
let useHouse n board = failwith "Not implemented"
                      
            
//-------------------------------------------------
//start, which accepts a StartingPosition and returns 
//an initialized game where the person
//in the StartingPosition starts the game
let start position =
<<<<<<< HEAD

      match position with
      | North -> 
               {houseNumber= Convert.ToInt32( System.Console.ReadLine()); playersTurns = "Nouth's turn"; southLargeHouseHas = 0;northLargeHousehas = 0; initialSeeds = (4,4,4,4,4,4,4,4,4,4,4,4) }   
                
      | South -> 
                 let south = {houseNumber=Convert.ToInt32( System.Console.ReadLine()); playersTurns = "South's turn"; southLargeHouseHas = 0;northLargeHousehas = 0; initialSeeds = (4,4,4,4,4,4,4,4,4,4,4,4) }
                 getSeeds (south.houseNumber)  (south.initialSeeds)

//getSeeds Board.houseNumber Board.initialSeeds  

               
                //| true -> { state= "north" ; northPlayer ={(7,8,9,10,11,12);0};southPlayer = _}
                //| true -> { state= "north" ; northPlayer = {(4,4,4,4,4,4)};southPlayer={(4,4,4,4,4,4)}
                //| _ ->  { state= "south" ;_; southPlayer ={(1,2,3,4,5,6); 0 }}
=======
      let reco={houses=(4,4,4,4,4,4);captured=0}
    match position with
    |North -> {state = Northturn ; northplayer = reco;southplayer=reco}
    |South->  {state = Southturn ; northplayer = reco;southplayer = reco}
>>>>>>> 43cfe5821ff84fd161c6de51a643a2773b5a68fd

              
                
                   
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
