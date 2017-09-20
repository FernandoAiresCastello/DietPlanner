using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Android.Views;

namespace DietPlanner
{
    [Activity(Label = "DietPlanner", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private WebView Wv;
        private const string InitialPage = "file:///android_asset/index.htm";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            RequestWindowFeature(WindowFeatures.NoTitle);
            Window.AddFlags(WindowManagerFlags.Fullscreen);
            SetContentView(Resource.Layout.Main);

            Wv = FindViewById<WebView>(Resource.Id.WebView);
            Wv.Settings.JavaScriptEnabled = true;
            Wv.Settings.DomStorageEnabled = true;
            Wv.Settings.DatabaseEnabled = true;
            Wv.Settings.DatabasePath = @"/data/data/" + Wv.Context.PackageName + "/databases/";

            Wv.LoadUrl(InitialPage);
        }

        public override void OnBackPressed()
        {
            Wv.LoadUrl(InitialPage);
        }
    }
}
