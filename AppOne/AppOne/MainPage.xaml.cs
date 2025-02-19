using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppOne
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnTransformers_Clicked(object sender, EventArgs e)
        {
            //btnTransformers.Text = "Mudou";

            Button bt = (Button)sender;
            bt.Text = "Mudou";

            foto.Source = "android2";
        }
    }
}
