module Oware

<<<<<<< HEAD
=======
open System
open System.Collections.Immutable

>>>>>>> b96643d6b62cac68efe997d49b6577e8d59fb864
type StartingPosition =
    | South
    | North

<<<<<<< HEAD
type Player={
houses : int*int*int*int*int*int
totalHouses :  int*int*int*int*int*int* int*int*int*int*int*int
captured : int}
=======
 type Player=
      {
       houses: int*int*int*int*int*int
       capturedSeeds: int
     
      }

 
>>>>>>> b96643d6b62cac68efe997d49b6577e8d59fb864

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
<<<<<<< HEAD
    |Northturn | Southturn -> 
        let (a',b',c',d',e',f')= board.southplayer.houses 
        let (a,b,c,d,e,f) = board.northplayer.houses in
=======
    |Northturn | Southturn _ -> 
        let (a',b',c',d',e',f')= board.northplayer.houses 
        let (a,b,c,d,e,f) = board.southplayer.houses in
>>>>>>> b96643d6b62cac68efe997d49b6577e8d59fb864
            match n with 
            |1->a
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

<<<<<<< HEAD

let useHouse n board = // failwith "Not implemented"
         
         let (a, b,c,d,e,f ) = board.southplayer.houses 
         let (a',b',c',d',e',f')= board.northplayer.houses 
         //new board
         let {state=S;northplayer=north1;southplayer=south1}= board
         let rec iterate numberofseeds acc =
            match numberofseeds>=0 with
            |true-> iterate (numberofseeds-1) acc+1       
            |_-> 0
         iterate (getSeeds n board) 0




       
            
        
                     

=======
let nextHouse n =
          match n  with 
          |12 -> 1
          | _ -> n+1

let setSeeds n num board =
     let (a',b',c',d',e',f') = board.northplayer.houses 
     let (a ,b ,c ,d ,e ,f ) = board.southplayer.houses in
         match n with
         |1-> {board with southplayer={board.southplayer with houses=(num,b,c,d,e,f)}}
         |2->{board with southplayer={board.southplayer with houses=(a,num,c,d,e,f)}}
         |3->{board with southplayer={board.southplayer with houses=(a,b,num,d,e,f)}}
         |4->{board with southplayer={board.southplayer with houses=(a,b,c,num,e,f)}}
         |5->{board with southplayer={board.southplayer with houses=(a,b,c,d,num,f)}}
         |6->{board with southplayer={board.southplayer with houses=(a,b,c,d,e,num)}}
         |7->{board with northplayer={board.northplayer with houses=(num,b',c',d',e',f')}}
         |8->{board with northplayer={board.northplayer with houses=(a',num,c',d',e',f')}}
         |9->{board with northplayer={board.northplayer with houses=(a',b',num,d',e',f')}}
         |10->{board with northplayer={board.northplayer with houses=(a',b',c',num,e',f')}}
         |11->{board with northplayer={board.northplayer with houses=(a',b',c',d',num,f')}}
         |12->{board with northplayer={board.northplayer with houses=(a',b',c',d',e',num)}}
         |_-> failwith "Not implemented"

 



let useHouse n board = // failwith "Not implemented"
         let (a',b',c',d',e',f') = board.northplayer.houses 
         let (a ,b ,c ,d ,e ,f ) = board.southplayer.houses in
         let numSeeds = getSeeds n board
         let newboard = setSeeds n 0 board


        
         let rec updateBoard currentHouse nSeeds newboard=
              match nSeeds>0 with 
              | true -> 
                let nxtHouse = nextHouse n
                let numSeeds = getSeeds nxtHouse newboard
                //updateBoard (nextHouse n) (getSeeds (nextHouse n) board) in
                let board = setSeeds nxtHouse (numSeeds+1) newboard
                updateBoard nxtHouse (numSeeds-1) board
              | _ -> newboard

         updateBoard n numSeeds newboard



        

        
         


           
//-----------------------------------------------
>>>>>>> b96643d6b62cac68efe997d49b6577e8d59fb864
//start, which accepts a StartingPosition and returns 
//an initialized game where the person
//in the StartingPosition starts the game
let start position =
<<<<<<< HEAD
    //*matching the position to the player to output a borad type
    let reco={houses=(4,4,4,4,4,4);captured=0;totalHouses=(4,4,4,4,4,4,4,4,4,4,4,4)}
=======
  
    let reco={houses=(4,4,4,4,4,4); capturedSeeds = 0}
>>>>>>> b96643d6b62cac68efe997d49b6577e8d59fb864
    match position with
    |North -> {state = Northturn ; northplayer = reco;southplayer=reco}
    |South->  {state = Southturn  ; northplayer = reco;southplayer = reco}

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
<<<<<<< HEAD

    //  let rec count v acc=
    //        match v>0 with
    //        |true ->count (v+1) (acc+1)
    //        |_ -> acc
   //      count (getSeeds n board) 0
       
=======
  
  
>>>>>>> b96643d6b62cac68efe997d49b6577e8d59fb864
