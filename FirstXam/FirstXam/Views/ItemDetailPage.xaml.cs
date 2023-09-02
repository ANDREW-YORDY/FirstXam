using FirstXam.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FirstXam.Views
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