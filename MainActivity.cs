using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace CalcDemo
{
    [Activity(Label = "Calc", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            
            EditText N1 = FindViewById<EditText>(Resource.Id.N1);
            EditText N2 = FindViewById<EditText>(Resource.Id.N2);
            TextView result = FindViewById<TextView>(Resource.Id.result);

            FindViewById<Button>(Resource.Id.add).Click += (a, b) =>
                result.Text = (Convert.ToDouble(N1.Text) + Convert.ToDouble(N2.Text)).ToString();
            
            FindViewById<Button>(Resource.Id.sub).Click += (a, b) =>
                    result.Text = (Convert.ToDouble(N1.Text) - Convert.ToDouble(N2.Text)).ToString();

            FindViewById<Button>(Resource.Id.multiple).Click += (a, b) =>
                result.Text = (Convert.ToDouble(N1.Text) * Convert.ToDouble(N2.Text)).ToString();

            FindViewById<Button>(Resource.Id.divide).Click += (a, b) =>
                result.Text = (Convert.ToDouble(N1.Text) / Convert.ToDouble(N2.Text)).ToString();
           
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}