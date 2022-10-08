﻿using System;
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

namespace GIT_es1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //bottone per il calcolo della media
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            double[] v=new double[10];
            Random rnd = new Random();
            //Ciclo per caricare il vettore di numeri casuali
            for(int i=0; i<v.Length; i++)
                v[i] = rnd.Next(0,100);

            double somma = 0;
            for(int i=0; i<v.Length; i++)
                somma+=v[i];
            lbl1.Content = somma/ v.Length;
        }
    }
}
