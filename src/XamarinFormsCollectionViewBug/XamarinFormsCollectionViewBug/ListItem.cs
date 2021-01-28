using Xamarin.Forms;

namespace XamarinFormsCollectionViewBug
{
  public class ListItem
  {
    public ListItem(Color color, string title)
    {
      this.TemplateColor = color;
      this.Title = title;
    }

    public Color TemplateColor { get; set; }

    public string Title { get; set; }
  }
}
