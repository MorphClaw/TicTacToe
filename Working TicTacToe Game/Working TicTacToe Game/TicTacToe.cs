using System;
using System.Linq; //for LINQ queries
using System.Collections.Generic; //for Lists and Collections

namespace Working_TicTacToe_Game
{
    class TicTacToe
    {
        private static Random randomNumber = new Random();
        //whered my array go
        //https://stackoverflow.com/questions/35873422/test-for-possible-wins-in-tictactoe-game
        //https://www.google.com/search?q=c%23+command+to+check+if+odd+or+even&rlz=1C1CHBF_enUS987US987&oq=c%23+command+to+check+if+odd+or+even&aqs=chrome..69i57j69i58.14448j0j7&sourceid=chrome&ie=UTF-8
        //https://docs.microsoft.com/en-us/dotnet/api/system.enum.tostring?view=net-6.0
        //https://www.google.com/search?q=enum+name%28%29+method+c%23&rlz=1C1CHBF_enUS987US987&ei=KqlNYu_4FfDRkPIP06SL4AE&ved=0ahUKEwjvtYqU2P_2AhXwKEQIHVPSAhwQ4dUDCA4&uact=5&oq=enum+name%28%29+method+c%23&gs_lcp=Cgdnd3Mtd2l6EAMyCAghEBYQHRAeOgUIABCRAjoECAAQQzoOCC4QgAQQsQMQxwEQ0QM6EQguEIAEELEDEIMBEMcBENEDOgsILhCABBCxAxDUAjoICC4QgAQQsQM6CwgAEIAEELEDEIMBOgsILhCABBCxAxCDAToLCC4QgAQQxwEQrwE6BwgAELEDEEM6CAgAEIAEELEDOgoIABCxAxCDARBDOgUIABCABDoGCAAQFhAeSgQIQRgASgQIRhgAUABYpC1gtS9oAXABeACAAWaIAaQLkgEEMjEuMZgBAKABAcABAQ&sclient=gws-wiz
        //https://www.google.com/search?q=how+to+write+the+string+of+an+enum&rlz=1C1CHBF_enUS987US987&oq=how+to+write+the+string+of+an+enum&aqs=chrome..69i57j33i22i29i30l8.10736j0j7&sourceid=chrome&ie=UTF-8
        //https://www.java67.com/2012/08/how-to-convert-enum-to-string-in-java.html
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-create-a-new-method-for-an-enumeration
        //https://stackoverflow.com/questions/8116330/how-to-determine-if-three-ints-are-all-equal
        //https://stackoverflow.com/questions/5327805/find-index-of-item-in-a-multidimensional-array
        //https://stackoverflow.com/questions/66729955/new-to-c-sharp-and-having-issues-with-case-statements-for-a-simple-menu

        private enum Status { SomeoneWon, Continue, CatScratch } //Game status 

        //private enum PositionsEnum //create a switch for conditions for win? 
        //{
        //    topLeft = 1,
        //    topMid = 2,
        //    topRight = 3,
        //    midLeft = 4,
        //    trueMid = 5,
        //    midRight = 6,
        //    botLeft = 7,
        //    botMid = 8,
        //    botRight = 9
        //}
        //const int Pos1rowindex = 0; 
        //const int Pos1colindex = 0;
        //const int Pos2 = GameBoard[0, 1];
        //const int Pos3 = GameBoard[0, 2];
        //const int Pos4 = GameBoard[1, 0];
        //const int Pos5 = GameBoard[1, 1];
        //const int Pos6 = GameBoard[1, 2];
        //const int Pos7 = GameBoard[2, 0];
        //const int Pos8 = GameBoard[2, 1];
        //const int Pos9 = GameBoard[2, 2];

        static int[,] GameBoard = new int[3, 3];

        static int Pos1 = GameBoard[0, 0];
        static int Pos2 = GameBoard[0, 1];
        static int Pos3 = GameBoard[0, 2];
        static int Pos4 = GameBoard[1, 0];
        static int Pos5 = GameBoard[1, 1];
        static int Pos6 = GameBoard[1, 2];
        static int Pos7 = GameBoard[2, 0];
        static int Pos8 = GameBoard[2, 1];
        static int Pos9 = GameBoard[2, 2];

        static List<int> Positions = new List<int>
        {GameBoard[0,0], GameBoard[0,1], GameBoard[0,2], GameBoard[1,0], GameBoard[1,1], GameBoard[1,2], GameBoard[2,0], GameBoard[2,1], GameBoard[2,2]};

        private enum Player
        {           
            N = 0,
            X = 1,
            O = 2
        }

        //Player noPlayer = Player.N;
        //Player player1 = Player.X;
        //Player player2 = Player.O;

        //private enum WinConditions
        //{
        //    TopRow = (Pos1 == Pos2 == Pos3)
        //}

        //static Player pos1String = (Player)Positions[0];
        //static Player pos2String = (Player)Positions[1];
        //static Player pos3String = (Player)Positions[2];
        //static Player pos4String = (Player)Positions[3];
        //static Player pos5String = (Player)Positions[4];
        //static Player pos6String = (Player)Positions[5];
        //static Player pos7String = (Player)Positions[6];
        //static Player pos8String = (Player)Positions[7];
        //static Player pos9String = (Player)Positions[8];


        private static bool PlayWithBot;

        static void Main(string[] args)
        {
            //var noPlayer = (Player) 0;
            ////writeline noplayer outputs N

            //var pos1String = (Player)Pos1;
            //var pos2String = (Player)Pos2;
            //var pos3String = (Player)Pos3;
            //var pos4String = (Player)Pos4;
            //var pos5String = (Player)Pos5;
            //var pos6String = (Player)Pos6;
            //var pos7String = (Player)Pos7;
            //var pos8String = (Player)Pos8;
            //var pos9String = (Player)Pos9;            

          

            Status gameStatus = Status.Continue;
            string evenOrOdd = "odd";

            
            Console.WriteLine("Play against random bot? Y/N\n");
            var input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                PlayWithBot = true;
            }

            Console.WriteLine("\nThe board is set up with numbers as follows:");
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("-----------");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("-----------");
            Console.WriteLine(" 7 | 8 | 9 \n");

            int whatTurnIsIt = 0;
            

            while (gameStatus == Status.Continue)
            {
                var pos1String = (Player)Positions[0];
                var pos2String = (Player)Positions[1];
                var pos3String = (Player)Positions[2];
                var pos4String = (Player)Positions[3];
                var pos5String = (Player)Positions[4];
                var pos6String = (Player)Positions[5];
                var pos7String = (Player)Positions[6];
                var pos8String = (Player)Positions[7];
                var pos9String = (Player)Positions[8];

                whatTurnIsIt++; //increase count

               
                //tell players what is availible
                Console.WriteLine("Player 1 is X, Player 2 is O. N is an availible empty space.");
                Console.WriteLine($" {pos1String} | {pos2String} | {pos3String} ");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {pos4String} | {pos5String} | {pos6String} ");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {pos7String} | {pos8String} | {pos9String} \n");

                if (whatTurnIsIt == 1 || whatTurnIsIt == 3 || whatTurnIsIt == 5 || whatTurnIsIt == 7 || whatTurnIsIt == 9)
                {
                    evenOrOdd = "odd";
                }
                else
                {
                    evenOrOdd = "even";
                }

                if (evenOrOdd == "odd")
                {
                    //Player1 turn
                    Console.WriteLine("Player 1, enter a number 1-9.");
                    int input1 = int.Parse(Console.ReadLine()) -1;                   
                    if (Positions[input1] != 0)
                    {
                        int correctInput = 1;
                        while (correctInput == 1)
                        {
                            Console.WriteLine("That space is full. Choose Another.");
                            int input2 = int.Parse(Console.ReadLine()) -1;
                            if (Positions[input2] == 0)
                            {
                                correctInput = 2;
                                input1 = input2;
                                
                            }
                            else { continue; }
                        }

                    }
                    if (Positions[input1] == 0)
                    {
                        Positions[input1] = 1;

                        switch (input1)
                        {
                            case 0:
                                GameBoard[0,0] = 1;
                                break;
                            case 1:
                                GameBoard[0,1] = 1;
                                break;
                            case 2:
                                GameBoard[0,2] = 1;
                                break;
                            case 3:
                                GameBoard[1,0] = 1;
                                break;
                            case 4:
                                GameBoard[1,1] = 1;
                                break;
                            case 5:
                                GameBoard[1,2] = 1;
                                break;
                            case 6:
                                GameBoard[2,0] = 1;
                                break;
                            case 7:
                                GameBoard[2,1] = 1;
                                break;
                            case 8:
                                GameBoard[2,2] = 1;
                                break;
                        }
                        //need to insert the input into the multidimensional array itself
                    }


                }
                else if (evenOrOdd == "even")
                { 
                    //Player2 turn
                    if (whatTurnIsIt != 10)
                    {
                        if (PlayWithBot) //bot
                        {
                            int roll = randomNumber.Next(0, 9); //random num between 0 and 9, 0-8
                            while (Positions[roll] != 0)
                            {
                                roll = randomNumber.Next(0, 9);
                            }
                            Positions[roll] = 2;                            
                            switch (roll)
                            {
                                case 0:
                                    GameBoard[0, 0] = 2;
                                    break;
                                case 1:
                                    GameBoard[0, 1] = 2;
                                    break;
                                case 2:
                                    GameBoard[0, 2] = 2;
                                    break;
                                case 3:
                                    GameBoard[1, 0] = 2;
                                    break;
                                case 4:
                                    GameBoard[1, 1] = 2;
                                    break;
                                case 5:
                                    GameBoard[1, 2] = 2;
                                    break;
                                case 6:
                                    GameBoard[2, 0] = 2;
                                    break;
                                case 7:
                                    GameBoard[2, 1] = 2;
                                    break;
                                case 8:
                                    GameBoard[2, 2] = 2;
                                    break;
                            }

                        }
                        else //player
                        {
                            Console.WriteLine("Player 2, enter a number 1-9.");
                            int input1 = int.Parse(Console.ReadLine()) -1;
                            if (Positions[input1] != 0)
                            {
                                int correctInput = 1;
                                while (correctInput == 1)
                                {
                                    Console.WriteLine("That space is full. Choose Another.");
                                    int input2 = int.Parse(Console.ReadLine()) -1;
                                    if (Positions[input2] == 0)
                                    {
                                        correctInput = 2;
                                        input1 = input2;
                                    }
                                    else { continue; }
                                }

                            }
                            if (Positions[input1] == 0)
                            {
                                Positions[input1] = 2;
                                switch (input1)
                                {
                                    case 0:
                                        GameBoard[0, 0] = 2;
                                        break;
                                    case 1:
                                        GameBoard[0, 1] = 2;
                                        break;
                                    case 2:
                                        GameBoard[0, 2] = 2;
                                        break;
                                    case 3:
                                        GameBoard[1, 0] = 2;
                                        break;
                                    case 4:
                                        GameBoard[1, 1] = 2;
                                        break;
                                    case 5:
                                        GameBoard[1, 2] = 2;
                                        break;
                                    case 6:
                                        GameBoard[2, 0] = 2;
                                        break;
                                    case 7:
                                        GameBoard[2, 1] = 2;
                                        break;
                                    case 8:
                                        GameBoard[2, 2] = 2;
                                        break;
                                }
                            }

                        }
                    }                       
                } //p2 end

                //check win condition after every one
                Pos1 = GameBoard[0, 0]; //update these
                Pos2 = GameBoard[0, 1];
                Pos3 = GameBoard[0, 2];
                Pos4 = GameBoard[1, 0];
                Pos5 = GameBoard[1, 1];
                Pos6 = GameBoard[1, 2];
                Pos7 = GameBoard[2, 0];
                Pos8 = GameBoard[2, 1];
                Pos9 = GameBoard[2, 2]; 

                //CheckWinCondition(); possibleWins { { 1,2,3},{ 4,5,6},{ 7,8,9},{ 1,4,7},{ 2,5,8},{ 3,6,9},{ 1,5,9},{ 3,5,7} };
                if (
                    (Pos1 == 1 || Pos1 == 2) && (Pos1 == Pos2 && Pos2 == Pos3) ||
                    (Pos4 == 1 || Pos4 == 2) && (Pos4 == Pos5 && Pos5 == Pos6) ||
                    (Pos7 == 1 || Pos7 == 2) && (Pos7 == Pos8 && Pos8 == Pos9) ||
                    (Pos1 == 1 || Pos1 == 2) && (Pos1 == Pos4 && Pos4 == Pos7) ||
                    (Pos2 == 1 || Pos2 == 2) && (Pos2 == Pos5 && Pos5 == Pos8) ||
                    (Pos3 == 1 || Pos3 == 2) && (Pos3 == Pos6 && Pos6 == Pos9) ||
                    (Pos1 == 1 || Pos1 == 2) && (Pos1 == Pos5 && Pos5 == Pos9) ||
                    (Pos3 == 1 || Pos3 == 2) && (Pos3 == Pos5 && Pos5 == Pos7) 
                    )
                {
                    gameStatus = Status.SomeoneWon;
                }
                if (whatTurnIsIt == 10)
                {
                    gameStatus = Status.CatScratch;
                }
            }    //while loop end

            if (gameStatus == Status.CatScratch)
            {
                Console.WriteLine("CatScratch! No one won.");
            }
           
            if (gameStatus == Status.SomeoneWon)
            {
                Pos1 = GameBoard[0, 0]; //update this
                Pos2 = GameBoard[0, 1];
                Pos3 = GameBoard[0, 2];
                Pos4 = GameBoard[1, 0];
                Pos5 = GameBoard[1, 1];
                Pos6 = GameBoard[1, 2];
                Pos7 = GameBoard[2, 0];
                Pos8 = GameBoard[2, 1];
                Pos9 = GameBoard[2, 2];
                var pos1String = (Player)Positions[0];
                var pos2String = (Player)Positions[1];
                var pos3String = (Player)Positions[2];
                var pos4String = (Player)Positions[3];
                var pos5String = (Player)Positions[4];
                var pos6String = (Player)Positions[5];
                var pos7String = (Player)Positions[6];
                var pos8String = (Player)Positions[7];
                var pos9String = (Player)Positions[8];
                var winner = pos1String;
                if (                      
                       Pos4 == Pos5 && Pos5 == Pos6 ||                         
                       Pos2 == Pos5 && Pos5 == Pos8 ||
                       Pos3 == Pos6 && Pos6 == Pos9 ||                      
                       Pos3 == Pos5 && Pos5 == Pos7
                       )
                {
                    winner = pos5String;
                }
                else if (
                      Pos1 == Pos2 && Pos2 == Pos3 ||                                    
                      Pos3 == Pos6 && Pos6 == Pos9                      
                      )
                {
                    winner = pos3String;
                }
                else if (                 
                        Pos7 == Pos8 && Pos8 == Pos9                    
                        )                
                    {
                    winner = pos7String;
                    }
                else if (
                        Pos1 == Pos4 && Pos4 == Pos7
                        )            
                {
                    winner = pos4String;
                }

                Console.WriteLine($"Congrats! {winner} won!");
                Console.WriteLine($" {pos1String} | {pos2String} | {pos3String} ");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {pos4String} | {pos5String} | {pos6String} ");
                Console.WriteLine($"-----------");
                Console.WriteLine($" {pos7String} | {pos8String} | {pos9String} \n");
            }

            Console.WriteLine("Thank you for Playing!");        
            
        } //main end
        
    } //class end
}
//public class Indexes
//{
//    int int1;
//    int int2;

    
//}
//public static class CheckWinCondition
//{
//     //switch      









//}