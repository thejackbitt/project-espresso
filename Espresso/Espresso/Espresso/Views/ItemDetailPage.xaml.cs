using Espresso.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Espresso.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}