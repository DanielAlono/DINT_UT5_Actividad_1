using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace UT5_Actividad_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Plato> platos;

        public MainWindow()
        {
            InitializeComponent();
            nombresComboBox();
            platos = Plato.GetSamples(Path.GetFileName(@"../Resources/Imagenes"));
            PlatosListBox.DataContext = platos;
        }

        private void nombresComboBox()
        {
            List<String> paises = new List<string>() { "Americana", "China", "Mexicana" };
            opcionesComboBox.ItemsSource = paises;
        }
    }
}
