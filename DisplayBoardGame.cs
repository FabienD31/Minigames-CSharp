using System;


namespace Project2
{
    public class DisplayBoardGame
    {
        public string player1 { get; set; }
        public string player2 { get; set; }




        public void DisplayBoardGames()
        {
            char[] boardGame = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

                


            Console.WriteLine("       -------------------------       ");
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       |   {0}   |   {1}   |   {2}   |       ", boardGame[0], boardGame[1], boardGame[2]);
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       -------------------------       ");
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       |   {0}   |   {1}   |   {2}   |       ", boardGame[3], boardGame[4], boardGame[5]);
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       -------------------------       ");
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       |   {0}   |   {1}   |   {2}   |       ", boardGame[6], boardGame[7], boardGame[8]);
            Console.WriteLine("       |       |       |       |       ");
            Console.WriteLine("       -------------------------       ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

                

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
        
       
       

      
        public void DisplayPlayerName()
        {
            Player player1 = new Player();

            Console.WriteLine(player1.PlayerName + " ton symbole est X");
            

            Player player2 = new Player();
            Console.WriteLine(player2.PlayerName + " ton symbole est O");
        }

        public void DisplayMenuTicTacToe()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
            Console.WriteLine("*                                    *");
            Console.WriteLine("*     BIENVENUE SUR LE MORPION !!    *");
            Console.WriteLine("*                                    *");
            Console.WriteLine("**************************************");
            Console.WriteLine("**************************************");
        }
    }
}
