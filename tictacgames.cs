using System;
using System.Collections.Generic;
using System.Text;

namespace tictok
{
    class tictacgames
    {
        //uc1
        
        

        char[] Board = new char[10];
        public void gameBoard()
        {

            for (int i = 1; i < 9; i++)
            {
                Board[i] = ' ';
            }
            //Console.WriteLine("+Board[i]");
        }
    }
}
