using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{	
	public partial class Image_Page : ContentPage
	{
		Switch sw;
		Image img;

		public Image_Page ()
		{
			img = new Image { Source = "test.jpg" };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            tap.NumberOfTapsRequired = 2;
            img.GestureRecognizers.Add(tap);
            sw = new Switch
			{
				IsToggled = true,
				VerticalOptions=LayoutOptions.EndAndExpand,
				HorizontalOptions=LayoutOptions.Center
			};
            sw.Toggled += Sw_Toggled;
			this.Content = new StackLayout { Children = { img, sw } };
		}
        int tapid;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            tapid++;
            var imgsender = (Image)sender;
            if (tapid % 2 == 0)
            {
                img.Source = "test1.jpg";
            }
            else
            {
                img.Source = "test.jpg";
            }
        }

        private void Sw_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                img.IsVisible = true;
            }
            else
            {
                img.IsVisible = false;
            }
        }
    }
}

