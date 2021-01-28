using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace XamarinFormsCollectionViewBug
{
  public class MainPageViewModel : ObservableObject
  {
    private bool isBusy;

    public MainPageViewModel()
    {
      this.RefreshCommand = new Command(Refresh);
    }

    public ObservableRangeCollection<ListItem> ListItems { get; set; } = new ObservableRangeCollection<ListItem>();

    public Command RefreshCommand { get; private set; }

    public bool IsBusy
    {
      get { return this.isBusy; }
      set { SetProperty(ref this.isBusy, value); }
    }

    private void Refresh(object obj)
    {
      var colors = new Color[] { Color.Yellow, Color.Red, Color.Green };
      var items = new List<ListItem>();
      var length = (new Random()).Next(25, 50);

      for (var i = 0; i < length; i++)
      {
        Color color = colors[i % 3];
        items.Add(new ListItem(color, color.ToString()));
      }

      this.ListItems.AddRange(items);

      this.IsBusy = false;
    }
  }
}
