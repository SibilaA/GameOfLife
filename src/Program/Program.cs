using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadBoard juegoNuevo = new ReadBoard();
            PrintBoard dibujoJuego = new PrintBoard();
            Logic logicaDeNuevoJuego = new Logic();

            string url = @"../../assets/board.txt";

            juegoNuevo.BuildBoard(url);

            bool[,] copiaJuego = juegoNuevo.GetBoard;

            while (true)
            {
                dibujoJuego.Print(copiaJuego);
                copiaJuego = logicaDeNuevoJuego.GameLogic(copiaJuego);
            }


        }
    }
}
