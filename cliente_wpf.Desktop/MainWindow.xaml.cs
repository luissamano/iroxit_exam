using cliente_wpf.Desktop.Domain;
using MaterialDesignThemes.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static cliente_wpf.Desktop.Models.Models;

namespace cliente_wpf.Desktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitProductos();
            InitVentas();
            InitVentasArticulo();
            InitTopProductos();     
            DataContext = new DataObject();

        }

        public async void InitProductos()
        {
            try
            {

                HttpClient client = new HttpClient();
                HttpResponseMessage res = await client.GetAsync("https://localhost:44394/api/productos");
                var json = await res.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<List<Products>>(json).ToList();


                lsViewProductos.ItemsSource = datos;
                lbProductosAlmacen.Text = $"{ datos.Sum(item => item.existencias)}";
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async void InitVentas()
        {
            try
            {

                HttpClient client = new HttpClient();
                HttpResponseMessage res = await client.GetAsync("https://localhost:44394/api/ventas");
                var json = await res.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<List<Ventas>>(json).ToList();
                
                lsViewVentas.ItemsSource = datos;
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async void InitVentasArticulo()
        {
            try
            {

                HttpClient client = new HttpClient();
                HttpResponseMessage res = await client.GetAsync("https://localhost:44394/api/ventas/articulo");
                var json = await res.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<List<VentasArticulo>>(json).ToList();

                lsViewVentasArticulo.ItemsSource = datos;

                lbMonto.Text = $"{string.Format("{0:C}",datos.Sum(item => item.cantidadVendida * item.monto))}";
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public async void InitTopProductos()
        {
            try
            {

                HttpClient client = new HttpClient();
                HttpResponseMessage res = await client.GetAsync("https://localhost:44394/api/productos/top");
                var json = await res.Content.ReadAsStringAsync();
                var datos = JsonConvert.DeserializeObject<List<TopProductos>>(json).ToList();

                lsViewProductosMasVendidos.ItemsSource = datos;

            }
            catch (JsonReaderException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridToolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void OnCopy(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter is string stringValue)
            {
                try
                {
                    Clipboard.SetDataObject(stringValue);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
            }
        }
    }
}
