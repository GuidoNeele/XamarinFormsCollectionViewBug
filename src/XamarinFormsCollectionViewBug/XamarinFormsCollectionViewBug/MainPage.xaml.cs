using Xamarin.Forms;

namespace XamarinFormsCollectionViewBug
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    protected override void OnAppearing()
    {
      this.RefreshView.IsRefreshing = true;
    }
  }
}
