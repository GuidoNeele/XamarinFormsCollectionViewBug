using Xamarin.Forms;

namespace XamarinFormsCollectionViewBug
{
  public class DummyDataTemplateSelector : DataTemplateSelector
  {
    public DataTemplate YellowTemplate { get; set; }

    public DataTemplate GreenTemplate { get; set; }

    public DataTemplate RedTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
      var listItem = (ListItem)item;

      if (listItem.TemplateColor == Color.Green)
        return this.GreenTemplate;
      else if (listItem.TemplateColor == Color.Red)
        return this.RedTemplate;
      else
        return this.YellowTemplate;
    }
  }
}
