using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace htmlApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var urlSource = new UrlWebViewSource();

            string baseUrl = DependencyService.Get<IBaseUrl>().GetUrl();
            string filePathUrl = Path.Combine(baseUrl, "TestWebPage.html");
            urlSource.Url = filePathUrl;
            webviewjava.Source = urlSource;
        }
    }
}
