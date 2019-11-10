﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.ServiceModel;
using Lisman.LismanService;

namespace Lisman {
    /// <summary>
    /// Interaction logic for MultiplayerGame.xaml
    /// </summary>

    public partial class MultiplayerGame : Window, IMultiplayerManagerCallback{

        int idgame;

        int[,] gameMap = new int[24, 23];

        Image lismanPlayer = null;

        int[,] gameMap = new int[24,23];
        const int LISMANYELLOW = 3;
        const int LISMANBLUE = 4;
        const int LISMANRED = 5;
        const int LISMANGREEN = 6;
        Image lismanPlayerImage = null;

        int X = 1;
        int Y = 1;

        String parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        Image pill0 = new Image();
        Image pill1 = new Image();
        Image pill2 = new Image();
        Image pill3 = new Image();
        Image pill4 = new Image();
        Image pill5 = new Image();
        Image pill6 = new Image();
        Image pill7 = new Image();
        Image pill8 = new Image();
        Image pill9 = new Image();
        Image pill10 = new Image();
        Image pill11 = new Image();

        DispatcherTimer runLeft = new DispatcherTimer();
        DispatcherTimer runUp = new DispatcherTimer();
        DispatcherTimer runRight = new DispatcherTimer();
        DispatcherTimer runDown = new DispatcherTimer();

        InstanceContext instace = null;
        MultiplayerManagerClient client = null;

        public MultiplayerGame(int idgame)
        {
            InitializeComponent();
            instace = new InstanceContext(this);
            this.idgame = idgame;
            client = new MultiplayerManagerClient(instace);
            client.JoinMultiplayerGame(SingletonAccount.getSingletonAccount().User, idgame);

            runLeft.Tick +=  new EventHandler(RunLeft);
            runLeft.Interval = new TimeSpan(0, 0, 0, 0, 300);
            runUp.Tick += new EventHandler(RunUp);  
            runUp.Interval = new TimeSpan(0, 0, 0, 0,300);
            runRight.Tick += new EventHandler(RunRight);
            runRight.Interval = new TimeSpan(0, 0, 0, 0, 300);         
            runDown.Tick += new EventHandler(RunDown);
            runDown.Interval = new TimeSpan(0, 0, 0, 0, 300);
            
            MatrizGame();
            DrawPills();
            

            

        }

        public void MatrizGame() {
            using (StreamReader sr = new StreamReader(parentDirectory + "/Resources/Map.txt")) {

                for (int i = 0; i <= 23; i++) {
                    for (int j = 0; j <= 22; j++) {
                        int caracter = sr.Read();

                        if (caracter != -1) {

                            if (caracter == 48) {
                                gameMap[i, j] = 0;
                            }

                            if (caracter == 49) {
                                gameMap[i, j] = 1;
                            }

                            if (caracter == 51) {
                                gameMap[i, j] = 3;
                            }

                            if (caracter == 52) {
                                gameMap[i, j] = 4;
                            }

                            if (caracter == 53) {
                                gameMap[i, j] = 5;
                            }

                            if (caracter == 54) {
                                gameMap[i, j] = 6;
                            }
                            if (caracter == 56) {
                                gameMap[i, j] = 8;
                            }
                        }

                    }
                    Console.WriteLine();
                }

            }

        }

        public void DrawPills() {
            BitmapImage bmp1 = new BitmapImage();
            bmp1.BeginInit();
            bmp1.UriSource = new Uri(parentDirectory + "/Resources/img/Pill.png");
            bmp1.EndInit();

            pill0.Source = bmp1;
            pill1.Source = bmp1;
            pill2.Source = bmp1;
            pill3.Source = bmp1;
            pill4.Source = bmp1;
            pill5.Source = bmp1;
            pill6.Source = bmp1;
            pill7.Source = bmp1;
            pill8.Source = bmp1;
            pill9.Source = bmp1;
            pill10.Source = bmp1;
            pill11.Source = bmp1;

            panel_5_2.Children.Add(pill0);
            panel_11_18.Children.Add(pill1);
            panel_11_5.Children.Add(pill2);
            panel_12_12.Children.Add(pill3);
            panel_13_12.Children.Add(pill4);
            panel_21_12.Children.Add(pill5);
            panel_7_7.Children.Add(pill6);
            panel_9_9.Children.Add(pill7);
            panel_15_22.Children.Add(pill8);
            panel_16_1.Children.Add(pill9);
            panel_4_10.Children.Add(pill10);
            panel_2_13.Children.Add(pill11);
        }


        public bool canMove(int onX, int onY) {
            //Console.WriteLine("Mover a: [{0},{1}]= {2}",onX,onY,gameMap[onX,onY]);
            bool can = true;
            if (gameMap[onX, onY] == 0) {
                can = false;
            }

            return can;

        }

        public void StopLisman() {
            runLeft.Stop();
            runUp.Stop();
            runRight.Stop();
            runDown.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            StopLisman();
            runRight.Start();
        }

        private void RunLeft(object sender, EventArgs e) {
            if (X == 0 && Y == 11) {
                X = 23;
                Y = 11;
                //Grid.SetColumn(lismanPlayerImage, X);
                //Grid.SetRow(lismanPlayerImage, Y);
                MoveLismanInMap(0, 0, X, Y);
                return;
            }
            if (canMove(X - 1, Y)) {
                if (X > 0) {
                    X -= 1;

                    //Grid.SetColumn(lismanPlayerImage, X);
                    //Grid.SetRow(lismanPlayerImage, Y );
                    MoveLismanInMap(0, 0, X, Y);
                }
            } else {
                StopLisman();
            }


        }

        private void RunUp(object sender, EventArgs e) {

            if (canMove(X, Y - 1)) {
                Y -= 1;
                //Grid.SetColumn(lismanPlayerImage, X);
                //Grid.SetRow(lismanPlayerImage, Y);
                MoveLismanInMap(0, 0, X, Y);
            } else {
                StopLisman();
            }


        }

        private void RunRight(object sender, EventArgs e) {
            if (X == 23 && Y == 11) {
                X = 0;
                Y = 11;
                //Grid.SetColumn(lismanPlayerImage, X);
                //Grid.SetRow(lismanPlayerImage, Y);
                MoveLismanInMap(0, 0, X, Y);
                return;
            }
            if (canMove(X + 1, Y)) {
                X += 1;
                //Grid.SetColumn(lismanPlayerImage, X);
                //Grid.SetRow(lismanPlayerImage, Y);
                MoveLismanInMap(0, 0, X, Y);
            } else {
                StopLisman();
            }


        }

        private void RunDown(object sender, EventArgs e) {
            if (canMove(X, Y + 1)) {
                Y += 1;
                //Grid.SetColumn(lismanPlayerImage, X);
                //Grid.SetRow(lismanPlayerImage, Y);
                MoveLismanInMap(0,0,X,Y);
            } else {
                StopLisman();
            }
        }


        public void MoveLismanInMap(int initialPositionX, int initialPositionY, int finalPositionX, int finalPositionY)
        {
            client.MoveLisman(this.idgame, SingletonAccount.getSingletonAccount().User, initialPositionX, initialPositionY, finalPositionX, finalPositionY);

        }

        private void Matriz_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Left) {
                runUp.Stop();
                runRight.Stop();
                runDown.Stop();
                runLeft.Start();
            }
            if (e.Key == Key.Up) {
                runLeft.Stop();
                //runUp.Stop();
                runRight.Stop();
                runDown.Stop();
                runUp.Start();
            }
            if (e.Key == Key.Right) {
                runLeft.Stop();
                runUp.Stop();
                // runRight.Stop();
                runDown.Stop();
                runRight.Start();
            }
            if (e.Key == Key.Down) {
                runLeft.Stop();
                runUp.Stop();
                runRight.Stop();
                //runDown.Stop();
                runDown.Start();
            }
        }

        public void PrintPlayer(string user, int life, int score)
        {
            throw new NotImplementedException();
        }

        public void NotifyColorPlayer(int colorPlayer)
        {
            switch (colorPlayer)
            {
                case LISMANYELLOW:
                    lismanPlayerImage = LismanYellowImage;
                    X = 1;
                    Y = 1;
                    break;
                case LISMANRED:
                    lismanPlayerImage = LismanRedImage;
                    X = 22;
                    Y = 1;
                    break;
                case LISMANBLUE:
                    lismanPlayerImage = LismanTurquoiseImage;
                    X = 1;
                    Y = 21;
                    break;
                case LISMANGREEN:
                    lismanPlayerImage = LismanGreenImage;
                    X = 22;
                    Y = 21;
                    break;
            }
        }

        public void NotifyLismanMoved(int colorPlayer, int positionX, int positionY)
        {
            Image lismanImageMoved = null;
            switch (colorPlayer)
            {
                case LISMANYELLOW:
                    lismanImageMoved = LismanYellowImage;
                    break;
                case LISMANRED:
                    lismanImageMoved = LismanRedImage;
                    break;
                case LISMANBLUE:
                    lismanImageMoved = LismanTurquoiseImage;
                    break;
                case LISMANGREEN:
                    lismanImageMoved = LismanGreenImage;
                    break;
            }
            Grid.SetColumn(lismanImageMoved, positionX);
            Grid.SetRow(lismanImageMoved, positionY);
        }
    }
}
