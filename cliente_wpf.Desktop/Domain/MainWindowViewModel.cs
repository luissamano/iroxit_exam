using cliente_wpf.Desktop.Views;
using MaterialDesignThemes.Wpf;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace cliente_wpf.Desktop.Domain
{
    class MainWindowViewModel
    {
        public MainWindowViewModel(ISnackbarMessageQueue snackbarMessageQueue)
        {
            if (snackbarMessageQueue == null) throw new ArgumentNullException(nameof(snackbarMessageQueue));

            DemoItems = new[]
            {
                new DemoItem("Dashboard", new Dashboard(), new []
                    {
                        new DocumentationLink(DocumentationLinkType.Wiki, $"{ConfigurationManager.AppSettings["GitHub"]}/wiki", "WIKI"),
                        DocumentationLink.DemoPageLink<Dashboard>()
                    }
                ),               
                new DemoItem("Productos", new Productos(), new []
                    {
                        DocumentationLink.DemoPageLink<Productos>(),
                        DocumentationLink.StyleLink("Productos")
                    }
                )
            };
        }

        public DemoItem[] DemoItems { get; }
    }
}
