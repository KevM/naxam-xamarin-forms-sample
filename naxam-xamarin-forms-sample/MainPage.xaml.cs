using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naxam.Controls.Mapbox.Forms;
using Xamarin.Forms;

namespace naxam.xamarin.forms.sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            map.DidTapOnMapCommand = new Command<Tuple<Position, Point>>((Tuple<Position, Point> obj) =>
            {
                //var features = map.GetFeaturesAroundPoint.Invoke(obj.Item2, 6, null);
                //var filtered = features.Where((arg) => arg.Attributes != null);
                //foreach (IFeature feat in filtered)
                //{
                //    var str = JsonConvert.SerializeObject(feat);
                //    System.Diagnostics.Debug.WriteLine(str);
                //}

            });
            map.DidFinishLoadingStyleCommand = new Command<MapStyle>((obj) =>
            {
                //map.ResetPositionFunc.Execute(null);
                //foreach (Layer layer in obj.OriginalLayers)
                //{
                //    System.Diagnostics.Debug.WriteLine(layer.Id);
                //}

            });
            map.ZoomLevel = Device.RuntimePlatform == Device.Android ? 4 : 10;
        }
    }
}
