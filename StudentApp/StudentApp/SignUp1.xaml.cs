using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp1 : ContentPage
    {
        Student Student;
        public SignUp1()
        {
            InitializeComponent();
           
         
           
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Page page1 = new SignUp2();
            page1.Title = "student sign up (2)";
            page1.BindingContext = this.BindingContext;
            page1.IconImageSource = "";
            ((TabbedPage)this.Parent).Children.Add(page1);

            
            
        }
    }
}