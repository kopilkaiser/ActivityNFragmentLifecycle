
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
using Android;
using Java.Lang;
using Android.Test;
using System.Diagnostics.Tracing;
using Java.Util.Logging;

namespace FragmentWalkThrough1
{
    public class TitlesFragment : ListFragment
    {
        int selectedPlayId;

        public static TitlesFragment NewInstance(Bundle bundle)
        {
            Log.Debug("TitlesFragment", " --> NewInstance");

            return new TitlesFragment { Arguments = bundle };

        }

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            Log.Debug("TitlesFragment", " --> OnAttach");

        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ListAdapter = new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleListItem1, DataClass.Titles);
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            if (savedInstanceState != null)
            {
                selectedPlayId = savedInstanceState.GetInt("selected_play_id", 0);
            }

            Log.Debug("TitlesFragment", " --> OnCreate");

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return base.OnCreateView(inflater, container, savedInstanceState);
            Log.Debug("TitlesFragment", " --> OnCreateView");
        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            Log.Debug("TitlesFragment", " --> OnViewCreated");

        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            Log.Debug("TitlesFragment", " --> OnActivityCreated");


        }
        public override void OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Log.Debug("TitlesFragment", " --> OnActivityResult");

        }
        public override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutInt("selected_play_id", selectedPlayId);

            Log.Debug("TitlesFragment", " --> OnSaveInstanceState");

        }

        public override void OnListItemClick(ListView l, View v, int position, long id)
        {
            ShowPlayQuote(position);
        }

        void ShowPlayQuote(int playId)
        {
            Intent intent = new Intent(Activity, typeof(PlayQuoteActivity));
            intent.PutExtra("selected_play_id", playId);
            StartActivity(intent);
        }


        public override void OnViewStateRestored(Bundle savedInstanceState)
        {
            base.OnViewStateRestored(savedInstanceState);
            Log.Debug("TitlesFragment", " --> OnViewStateRestored");

        }
        public override void OnStart()
        {
            base.OnStart();
            Log.Debug("TitlesFragment", " --> OnStart");

        }
        public override void OnResume()
        {
            base.OnResume();
            Log.Debug("TitlesFragment", " --> OnResume");

        }

        public override void OnPause()
        {
            base.OnPause();
            Log.Debug("TitlesFragment", " --> OnPause");

        }

        public override void OnStop()
        {
            base.OnStop();
            Log.Debug("TitlesFragment", " --> OnStop");

        }
       
        public override void OnDestroyView()
        {
            base.OnDestroyView();
            Log.Debug("TitlesFragment", " --> OnDestroyView");

        }
        public override void OnDestroy()
        {
            base.OnDestroy();
            Log.Debug("TitlesFragment", " --> OnDestroy");

        }

        public override void OnDetach()
        {
            base.OnDetach();
            Log.Debug("TitlesFragment", " --> OnDetach");

        }
    }
}