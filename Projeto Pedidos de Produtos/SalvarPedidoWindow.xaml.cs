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
using System.Windows.Shapes;

namespace Projeto_Pedidos_de_Produtos
{
    /// <summary>
    /// Lógica interna para SalvarPedidoWindow.xaml
    /// </summary>
    public partial class SalvarPedidoWindow : Window
    {
        public SalvarPedidoWindow()
        {
            InitializeComponent();

        }
        ItemWindow w = new ItemWindow();
        private void novoitem_Click(object sender, RoutedEventArgs e)
        {
            
            w.ShowDialog();
        }

        private void voltamenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }
    }
}
