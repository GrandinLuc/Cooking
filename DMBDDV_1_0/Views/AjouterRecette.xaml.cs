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

namespace DMBDDV_1_0.Views
{
    /// <summary>
    /// Logique d'interaction pour AjouterRecette.xaml
    /// </summary>
    public partial class AjouterRecette : UserControl
    {
        public AjouterRecette()
        {
            InitializeComponent();
        }

        private void Valider_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Recette ajoutée");
        }
    }
}
