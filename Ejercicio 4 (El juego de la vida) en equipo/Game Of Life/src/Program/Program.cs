using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileReader reader = new TextFileReader("../../assets/board.txt"); //Se crea el lector 
            GameBoard board = new GameBoard(reader.ReadTextFile()); //Se instancia el tablero, siendo su estado inicial el resultado de ReadTextFile que recibe en su constructor
            GameLogic logic = new GameLogic();
            ConsolePrinter.Print(board, logic); //Recibe un tablero y lo representa en loop por consola
        }
    }
}
