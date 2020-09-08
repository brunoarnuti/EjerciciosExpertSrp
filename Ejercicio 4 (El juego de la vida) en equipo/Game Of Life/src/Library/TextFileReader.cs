using System;
using System.IO;

namespace PII_Game_Of_Life
{
    /*  
        Esta clase tiene la responsabilidad de leer y procesar el tablero desde un archivo de texto.
        No colabora con ninguna otra clase.
        Devuelve el tablero en forma de matriz, matriz que luego sera utilizada por la clase GameBoard para crear un objeto tablero.
        Cumple con el principio SRP, ya que solo cambiaria si cambiaria la forma en la que se lee y se procesa un archivo de texto.
        Esta clase tambien cumple con el patron Expert, ya que es la experta en toda la informacion que hace falta para realizar su funcion (url en este caso)
    */
    public class TextFileReader
    {
        private String url;
        
        public string URL
        {
            get
            {
                return this.url;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    this.url = value;
                }
            }
        }
        public TextFileReader(string url)
        {
            this.URL = url;
        }

        public bool[,] ReadTextFile()
        {
            string content = File.ReadAllText(this.url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            return board;
        }
        
    }
}