using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace FragmentWalkThrough1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var titlesFragment = TitlesFragment.NewInstance(savedInstanceState);
            
            SupportFragmentManager.BeginTransaction()
                .Add(Android.Resource.Id.Content, titlesFragment)
                .Commit();
            Log.Debug("MainActivity", " --> OnCreate");

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug("MainActivity", " --> OnStart");

        }
        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
            Log.Debug("MainActivity", " --> OnRestoreInstanceState");

        }
        protected override void OnResume()
        {
            base.OnResume();
            Log.Debug("MainActivity", " --> OnResume");

        }

        protected override void OnPause()
        {
            base.OnPause();
            Log.Debug("MainActivity", " --> OnPause");

        }

        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug("MainActivity", " --> OnStop");

        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            Log.Debug("MainActivity", " --> OnSaveInstanceState");

        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Log.Debug("MainActivity", " --> OnDestroy");

        }
    }
}