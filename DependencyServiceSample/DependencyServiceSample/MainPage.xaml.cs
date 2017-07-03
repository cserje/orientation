using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependencyServiceSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var orient = new Button
            {
                Text = "Get Orientation",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            orient.Clicked += (sender, e) => {
                var orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();
                switch (orientation)
                {
                    case DeviceOrientations.Undefined:
                        orient.Text = "Undefined";
                        break;
                    case DeviceOrientations.Landscape:
                        orient.Text = "Landscape";
                        break;
                    case DeviceOrientations.Portrait:
                        orient.Text = "Portrait";
                        break;
                }
            };
            Content = orient;
        }
    }
}
