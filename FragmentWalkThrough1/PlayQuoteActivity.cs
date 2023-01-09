using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FragmentWalkThrough1
{
    [Activity(Label = "PlayQuoteActivity")]
    public class PlayQuoteActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var playId = Intent.GetIntExtra("selected_play_id", 0);

            Bundle bundle = new Bundle();
            bundle.PutInt("selected_play_id", playId);
            var playQuoteFragment = PlayQuoteFragment.NewInstance(bundle);

            SupportFragmentManager.BeginTransaction()
                .Add(Android.Resource.Id.Content, playQuoteFragment)
                .Commit();

            Log.Debug("PlayQuoteActivity", " --> OnCreate"); 
        }

        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug("PlayQuoteActivity", " --> OnStart");

        }
        protected override void OnRestoreInstanceState(Bundle savedInstanceState)
        {
            base.OnRestoreInstanceState(savedInstanceState);
            Log.Debug("PlayQuoteActivity", " --> OnRestoreInstanceState");

        }
        protected override void OnResume()
        {
            base.OnResume();
            Log.Debug("PlayQuoteActivity", " --> OnResume");

        }

        protected override void OnPause()
        {
            base.OnPause();
            Log.Debug("PlayQuoteActivity", " --> OnPause");

        }

        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug("PlayQuoteActivity", " --> OnStop");

        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            Log.Debug("PlayQuoteActivity", " --> OnSaveInstanceState");

        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Log.Debug("PlayQuoteActivity", " --> OnDestroy");

        }




    }
}