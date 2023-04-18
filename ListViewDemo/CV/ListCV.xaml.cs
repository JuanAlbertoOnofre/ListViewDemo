using ListViewDemo.Model;

namespace ListViewDemo.CV;

public partial class ListCV : ContentView
{
    public ListCV()
    {
        InitializeComponent();
    }
    public List<User> ItemsSubTipoAlerta
    {
        get { return (List<User>)GetValue(SubTipoAlertaProperty); }
        set { SetValue(SubTipoAlertaProperty, value); }
    }

    public static readonly BindableProperty SubTipoAlertaProperty = BindableProperty.Create(nameof(ItemsSubTipoAlerta), typeof(List<User>), typeof(ListCV),
        propertyChanged: (bindable, oldvalue, newvalue) =>
        {
            var label = (ListCV)bindable;
            label.ItemsSubTipoAlerta = (List<User>)newvalue;

            var listTemp = label.ItemsSubTipoAlerta.Select(x => x.Name); 
            IEnumerable<string> subtiposAlertas = listTemp as IEnumerable<string>;
            BindableLayout.SetItemsSource(label.SubTipoLabel, subtiposAlertas);

            var dataTemplate = new DataTemplate(() =>
            {
                Label myLabel = new Label()
                {
                    TextColor = Color.FromArgb("#FFFFFF"),
                    Margin = 0,
                    Padding = 0,
                    IsVisible = true,
                };
                myLabel.SetBinding(Label.TextProperty, ".");
                return myLabel;
            });
            BindableLayout.SetItemTemplate(label.SubTipoLabel, dataTemplate);
        });

}