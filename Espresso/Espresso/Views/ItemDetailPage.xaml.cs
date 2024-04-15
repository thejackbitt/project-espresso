using System.ComponentModel;
using Xamarin.Forms;
using Espresso.ViewModels;

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