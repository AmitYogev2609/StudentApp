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
    public partial class SignUp2 : ContentPage
    {
        private Student student;
        public SignUp2()
        {
            InitializeComponent();
            
            List<string> grades = new List<string>();
            grades.Add("א");
            grades.Add("ב");
            grades.Add("ג");
            grades.Add("ד");
            grades.Add("ה");
            grades.Add("ו");
            grades.Add("ז");
            grades.Add("ח"); 
            grades.Add("ט");
            grades.Add("י");
            grades.Add("יא");
            grades.Add("יב");
            grade.ItemsSource = grades;
           
        }

        private void grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is Picker)
            {
                Picker picker = (Picker)sender;
                int selectedIndex = picker.SelectedIndex;
                if(selectedIndex!=-1)
                {
                   ((Student)this.BindingContext).Class= (string)picker.ItemsSource[selectedIndex];
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Xamarin.Forms.Page page1 = new Summary();
            page1.Title = "summarry";
            page1.IconImageSource = "";
            ((TabbedPage)this.Parent).Children.Add(page1);
        }
    }
}