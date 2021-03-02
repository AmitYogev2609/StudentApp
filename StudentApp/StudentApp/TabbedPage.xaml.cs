using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage : Xamarin.Forms.TabbedPage
    {
        public TabbedPage()
        {
            InitializeComponent();
            
            
                this.BindingContext = new Student();
            this.SelectedTabColor = Color.White;
            this.UnselectedTabColor = Color.Black;
            
 
            CreateTabs();
        }
        private void CreateTabs()
        {
            On<Windows>().SetHeaderIconsEnabled(true);
            On<Windows>().SetHeaderIconsSize(new Size(48, 48));

            Xamarin.Forms.Page page1 = new SignUp1();
            page1.BindingContext = this.BindingContext;
            page1.Title = "student sign up (1)";
            page1.IconImageSource = "";
            this.Children.Add(page1);
        }
    }
}