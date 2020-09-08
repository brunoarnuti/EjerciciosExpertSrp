using System;
using System.Threading;
using System.IO;

namespace PII_Game_Of_Life
{
    /*  
        Esta clase fue creada con la finalidad de separar la representacion del juego de su logica, y del modelado del tablero.
        De esa forma si se quiere representar de manera diferente el juego lo unico que habria que hacer es modificar esta clase para que procese 
        de manera diferente el string retornado por (GetTextToPrint) o simplemente crear una clase nueva que se encargue de ello.

        En cuanto al principio SRP, aqui se cumple, ya que esta clase solo cambiaria si se quisiera cambiar la manera en la que se imprime en pantalla la informacion
        En lo referente al patron Expert, si bien la clase depende fuertemente de la clase GameBoard para llevar a cabo su responsabilidad,
        me parece correcto hacerlo de esta manera por lo anteriormente mencionado.
        Ya que no me parece correcto que la clase GameBoard tenga la responsabilidad de imprimir las cosas por consola(porque en el futuro esto podria cambiar)
        es sensato crear otra clase que tenga la responsabilidad de recibir el texto y imprimirlo por consola.
    */
    public class ConsolePrinter
    {
        public static void Print(GameBoard board, GameLogic logic)
        {
            while (true)
            { 
                Console.WriteLine(board.GetTextToPrint());
                logic.NewGeneration(board);
                Thread.Sleep(300);
            }  
        }
    }
}
