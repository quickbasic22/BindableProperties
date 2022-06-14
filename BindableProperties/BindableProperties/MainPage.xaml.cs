using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindableProperties
{
    public partial class MainPage : ContentPage
    {
        public string MyDescription { get; set; } = "Did you subscribe yet?";

        public MainPage()
        {
            InitializeComponent();
            MyControl.ChildAdded += MyControl_ChildAdded;
            MyControl.DescendantAdded += MyControl_DescendantAdded;
            BindingContext = this;
        }

        private void MyControl_DescendantAdded(object sender, ElementEventArgs e)
        {
            DisplayAlert("Descendant Added", e.Element.ToString(), "cancel");
        }

        private void MyControl_ChildAdded(object sender, ElementEventArgs e)
        {
            DisplayAlert("Child Added", e.Element.ToString(), "cancel");
        }
    }
}
