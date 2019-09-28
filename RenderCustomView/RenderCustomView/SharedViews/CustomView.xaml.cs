using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RenderCustomView.SharedViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomView
    {
        public static readonly BindableProperty NameProperty = BindableProperty.Create(
            "Name",
            typeof(string),
            typeof(CustomView),
            "",
            BindingMode.TwoWay,
            propertyChanged: OnNamePropertyChanged);

        public CustomView()
        {
            InitializeComponent();
        }

        public string Name
        {
            get => GetValue(NameProperty).ToString();
            set => SetValue(NameProperty, value);
        }

        private static void OnNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var label = (CustomView) bindable;
            label.name.Text = newValue.ToString();
        }
    }
}