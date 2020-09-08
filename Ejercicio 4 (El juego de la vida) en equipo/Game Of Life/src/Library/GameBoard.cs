using System;
using System.Text;

namespace PII_Game_Of_Life
{   /*  Esta clase fue creada con el proposito de modelar a traves de una matriz el tablero del juego
        Fue creada porque habian algunos datos sueltos que quedarian mejor todos juntos en una sola clase (los atributos width y height por ejemplo)
        Cumple con el patron Expert, ya que es el experto de la informacion en todas las tareas que realiza, es el que tiene la mayor parte de los datos que hacen falta para llevar a cabo las funciones que posee
        Cumple con el principio SRP, ya que no tiene mas de una razon de cambio:
    
                -Uno de sus metodos se encarga de actualizar el estado actual del tablero de juego. Lo hace delegandoselo a la clase GameLogic.
                Si se quisiera cambiar la logica del juego se tendria que cambiar la clase GameLogic mada mas.
                -El otro metodo es simplemente para representar el tablero en un string para que otra clase lo use como desee, aqui no se viola el SRP
                ya que si se quisiera cambiar la forma en la que se representa y dejar de hacerlo por consola,
                simplemente se tendria que procesar de manera diferente (en otra clase que no sea ConsolePrinter) el string dado por el metodo GetTextToPrint 
    */
    public class GameBoard
    {
        private int boardWidth;
        private int boardHeight;
        private bool[,] initialGameBoard;
        private bool[,] actualGameBoard;


        public int BoardWidth
        {
            get
            {
                return this.boardWidth;
            }
        }

        public int BoardHeight
        {
            get
            {
                return this.boardHeight;
            }
        }

        public bool[,] ActualGameBoard
        {
            get
            {
                return this.actualGameBoard;
            }
            set
            {
                this.actualGameBoard = value;
            }
        }

        //  Elegi que el estado inicial del tablero sea pasado como parametro de su constructor.
        //  Actualmente esta pensado para que ese parametro sea la salida del metodo ReadTextFile() de la clase TextFileReader.
        //  pero en el momento en que se quiera cambiar la manera en la que se leen los datos(que ya no sea de un txt)
        //  ese parametro puede ser la salida de cualquier otro metodo de cualquier otra clase. 
        public GameBoard(bool[,] initalboard) 
        {
            if(initalboard.GetLength(0) > 0 & initalboard.GetLength(1) > 0)
            {
                this.initialGameBoard = initalboard;
                this.actualGameBoard = initalboard;
                this.boardWidth = initalboard.GetLength(0);
                this.boardHeight = initalboard.GetLength(1);
            }
            
        }
        // Este metodo fue comentado, ya que me di cuenta que era creaba una fuerte dependencia hacia la clase GameLogic
        // cosa que esta clase, siendo simplemente la representacion de un tablero, en la cual se podrian usar distintas logicas, no tiene mucho sentido

        /*public void UpdateBoard() 
        {
            actualGameBoard = GameLogic.NewGeneration(this.boardWidth, this.boardHeight, this.actualGameBoard);
        }
        */


        public string GetTextToPrint()
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<this.boardHeight;y++)
            {
                for (int x = 0; x<this.boardWidth; x++)
                {
                    if(this.actualGameBoard[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            return s.ToString();
        }

    }
}
