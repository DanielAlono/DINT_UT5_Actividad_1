using System;
using System.Collections.Generic;
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
            platos = Plato.GetSamples("C:/Users/dealo/OneDrive/Pictures/Imagenes");
            PlatosListBox.DataContext = platos;         
        }
        
        private void nombresComboBox()
        {
            List<String> paises = new List<string>() { "Americana", "China", "Mexicana"};
            opcionesComboBox.ItemsSource = paises;
        }

        private void PlatosListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            formularioStackPanel.DataContext = platos[PlatosListBox.SelectedIndex];
        }
    }
}
