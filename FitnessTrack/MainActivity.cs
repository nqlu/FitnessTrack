using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;

namespace FitnessTrack
{
	[Activity(Label = "FitnessTrack", MainLauncher = true)]
	public class MainActivity : Activity
	{
		
		private Button btnlogin;
		private EditText txtusername, txtpassword;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
		
			SetContentView(Resource.Layout.Main);
			btnlogin = FindViewById<Button>(Resource.Id.btnlogin);
			txtusername = FindViewById<EditText>(Resource.Id.txtusername);
			txtpassword = FindViewById<EditText>(Resource.Id.txtpassword);
			btnlogin.Click += Btn_Login;	
		}

		private void Btn_Login(object sender, System.EventArgs e)
		{
			if (txtusername.Text == "testname" && txtpassword.Text == "testpass")
			{
				StartActivity(typeof(Screen1));
			}
			else
			{
				Toast.MakeText(this, " username or password are incorrect", ToastLength.Long).Show();
			}
		}
	}
}

