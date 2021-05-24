using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Tetris
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaracion de variables
        //Agrega los sonidos .wav
        List<System.Media.SoundPlayer> sounList = new List<System.Media.SoundPlayer>();

        //DispatcherTime
        DispatcherTimer timer;

        //Figuras Random
        Random shapeRandom;
        //Colores de las figuras (Tetrominos)
        private static Color O_TetrominoColor = Colors.GreenYellow;
        private static Color I_TetrominoColor = Colors.Red;
        private static Color T_TetrominoColor = Colors.Gold;
        private static Color S_TetrominoColor = Colors.Violet;
        private static Color Z_TetrominoColor = Colors.DeepSkyBlue;
        private static Color J_TetrominoColor = Colors.Cyan;
        private static Color L_TetrominoColor = Colors.LightSeaGreen;

        //Listas de la posicion actual de los Tetrominos
        //ROW
        List<int> currentTetrominoRow = null;

        //COLUMNA
        List<int> currentTetrominoColumn = null;

        //Variables para el nivel
        private int gamelevel = 1;

        //Variables para el score
        private int gameScore = 0;

        //Variable para la velocidad
        private double gameSpeedCounter = 0;

        //Variable para gameover
        private bool isGameOver = false;

        //Variable para verificar si choco con el limite
        private bool bottomCollided = false;
        private bool leftCollided = false;
        private bool rightCollided = false;


        //Variable para saber si roto
        private bool isRotated = false;
        private int rotation = 0;









        //Reproducir el sonido. Index = 0 va a reproducir collied.wav y Index = 1 Reproducir DeleteLine.wav
        private void playsound(int index)
        {
            sounList[index].Play();
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
