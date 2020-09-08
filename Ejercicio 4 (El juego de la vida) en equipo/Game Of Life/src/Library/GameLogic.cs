using System;
using System.Text;

namespace PII_Game_Of_Life
{

    /*  Esta clase fue creada con el proposito de dejar en una clase unicamente la logica del juego
        Cumple con el principio de SRP. La clase solo tiene una unica razon de cambio, esta es, la de cambiar si la logica del juego cambia.

        En referencia al patron Expert, si bien muchas de las tareas que realiza las hace con los datos que son propios de un objeto GameBoard
        la decision de crear esta clase y de no poner todo este codigo en un metodo de la clase GameBoard(la que seria experta en los datos) fue la de ser fiel al principio SRP
        ya que no me parecia correcto modificar la calse del tablero si unicamente se realizaba un cambio en la logica del juego.

        Aunque tenga inconvenientes con el patron Expert mencionados anteriormente, promueve la reutilizacion de codigo, haciendo que el tablero no este atado a una sola logica

    */
    public class GameLogic
    {
        public void NewGeneration(GameBoard board)
        {   
            bool[,] cloneboard = new bool[board.BoardWidth, board.BoardHeight];
            for (int x = 0; x < board.BoardWidth; x++)
            {
                for (int y = 0; y < board.BoardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<board.BoardWidth && j>=0 && j < board.BoardHeight && board.ActualGameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(board.ActualGameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (board.ActualGameBoard[x,y] && aliveNeighbors < 2) 
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false; 
                    }
                    else if (board.ActualGameBoard[x,y] && aliveNeighbors > 3) 
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false; 
                    }
                    else if (!board.ActualGameBoard[x,y] && aliveNeighbors == 3) 
                    {
                        //Celula nace por reproducción 
                        cloneboard[x,y] = true; 
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = board.ActualGameBoard[x,y];
                    }
                }
            }
            board.ActualGameBoard = cloneboard;
            cloneboard = new bool[board.BoardWidth, board.BoardHeight];
        }
    }
}
