using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        List<ContentPage> pages = new List<ContentPage>() { new Entry_Page(), new Timer_Page(), new BoxView_Page(), new DateTime_Page(), new StepperSlider_Page(), new Frame_Page(), new Image_Page(), new PopUpPage(), new Failide_Page()}; // index= 0,1,2,...
        List<string> tekstid = new List<string> { "Ava teksti leht", "Ava timer leht", "Ava box leht", "Ava date leht", "Ava stepper leht", "Ava frame leht", "Ava image leht", "Ava PopUp leht", "Ava Failide leht"};
        StackLayout st;
        public StartPage()
        {
            st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Aqua
            };

            //Button Entry_btn = new Button
            //{
            //    Text = "Ava Entry leht",
            //    TextColor = Color.Tomato,
            //    BackgroundColor = Color.Violet,
            //    TabIndex= 0
            //};
            //Button Timer_btn = new Button
            //{
            //    Text = "Ava Timer leht",
            //    TextColor = Color.Tomato,
            //    BackgroundColor = Color.Violet,
            //    TabIndex= 1
            //};
            //Button Box_btn = new Button
            //{
            //    Text = "Ava BoxView leht",
            //    TextColor = Color.Tomato,
            //    BackgroundColor = Color.Violet,
            //    TabIndex = 2
            //};

            for(int i = 0; i< pages.Count; i++)
            {
                Button button = new Button
                {
                    Text= tekstid[i],
                    TabIndex= i,
                    BackgroundColor= Color.Fuchsia,
                    TextColor= Color.Black,
                    FontSize=20,
                    FontFamily= "Samantha Demo.ttf#Samantha Demo"
                    
                };
                st.Children.Add(button);
                button.Clicked += Navig_funktsion;
            }
            ScrollView sv = new ScrollView { Content = st };
            Content=sv;
            //Entry_btn.Clicked += Navig_funktsion;
            //Timer_btn.Clicked += Navig_funktsion;
            //Box_btn.Clicked += Navig_funktsion;
        }

        private async void Navig_funktsion(object sender, EventArgs e)
        {
            Button btn = sender as Button; //(Button)sender
            await Navigation.PushAsync(pages[btn.TabIndex]);
        }

    }
}