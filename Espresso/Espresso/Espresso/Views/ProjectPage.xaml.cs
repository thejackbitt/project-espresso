using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Espresso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectPage : ContentPage
    {
        int count = 0;

        public ProjectPage()
        {
            InitializeComponent();

            LabelCount.Text = "You have clicked the button " + count + " times.";
        }

     

        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            count++;
            LabelCount.Text = "You have clicked the button " + count + " times.";
        }
    }
}