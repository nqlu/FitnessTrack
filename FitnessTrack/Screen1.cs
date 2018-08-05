using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace FitnessTrack
{
	[Activity(Label = "Activity1")]
	public class Screen1 : Activity
	{
		private List<string> mItems;
		private ListView mListView;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			SetContentView(Resource.Layout.screen1);
			base.OnCreate(savedInstanceState);
			Button clicknews = FindViewById<Button>(Resource.Id.btnlist);
			mListView = FindViewById<ListView>(Resource.Id.lstView);
			clicknews.Click += (object sender, EventArgs args) =>
			{
				mItems = new List<string>();
				mItems.Add("Meal Plan");
				mItems.Add("Training Plan");
				ArrayAdapter<string> mAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
				mListView.Adapter = mAdapter;

			};
			
		}
	}
}