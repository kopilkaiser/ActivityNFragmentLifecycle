
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FragmentWalkThrough1
{
    public class PlayQuoteFragment : Fragment
    {
        int PlayId => Arguments.GetInt("selected_play_id", 0);
        public static PlayQuoteFragment NewInstance(Bundle bundle)
        {
            Log.Debug("QuoteFragment", " --> NewInstance");

            return new PlayQuoteFragment {Arguments = bundle};
        }
        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            Log.Debug("QuoteFragment", " --> OnAttach");

        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Log.Debug("QuoteFragment", " --> OnCreate");

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            if (container == null)
            {
                return null;
            }

            var textView = new TextView(Activity);
            var padding = Convert.ToInt32(TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Activity.Resources.DisplayMetrics));
            textView.SetPadding(padding, padding, padding, padding);
            textView.TextSize = 24;
            textView.Text = DataClass.Description[PlayId];

            var scroller = new ScrollView(Activity);
            scroller.AddView(textView);
            Log.Debug("QuoteFragment", " --> OnCreateView");

            return scroller;

        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            Log.Debug("QuoteFragment", " --> OnViewCreated");

        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            Log.Debug("QuoteFragment", " --> OnActivityCreated");

        }

        public override void OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Log.Debug("QuoteFragment", " --> OnActivityResult");

        }
        public override void OnViewStateRestored(Bundle savedInstanceState)
        {
            base.OnViewStateRestored(savedInstanceState);
            Log.Debug("QuoteFragment", " --> OnViewStateRestored");

        }
        public override void OnStart()
        {
            base.OnStart();
            Log.Debug("QuoteFragment", " --> OnStart");

        }
        public override void OnResume()
        {
            base.OnResume();
            Log.Debug("QuoteFragment", " --> OnResume");

        }

        public override void OnPause()
        {
            base.OnPause();
            Log.Debug("QuoteFragment", " --> OnPause");

        }

        public override void OnStop()
        {
            base.OnStop();
            Log.Debug("QuoteFragment", " --> OnStop");

        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            Log.Debug("QuoteFragment", " --> OnSaveInstanceState");

        }
        public override void OnDestroyView()
        {
            base.OnDestroyView();
            Log.Debug("QuoteFragment", " --> OnDestroyView");

        }
        public override void OnDestroy()
        {
            base.OnDestroy();
            Log.Debug("QuoteFragment", " --> OnDestroy");

        }

        public override void OnDetach()
        {
            base.OnDetach();
            Log.Debug("QuoteFragment", " --> OnDetach");

        }
    }
}