using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;

namespace Hello_World
{
	[Activity (Label = "Hello_World", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			Button polBtn = (Button) FindViewById(Resource.Id.roundButton);

//			Button polBtn2 = (Button) FindViewById(Resource.Id.roundButton2);

			ImageView scaleObject = (ImageView)FindViewById (Resource.Id.scaleObj);

			var scale = new ScaleAnimation (1, 130, 1, 130);
			scale.Duration = 5000;
			var fadeIn = new AlphaAnimation (0.1f, 1.0f);
//			var translate = new TranslateAnimation (0.0f, 20.0f, 0.0f, 
//				-(float)WindowManager.DefaultDisplay.Height/5);
			var translate1 = new TranslateAnimation (0.0f, 200.0f, 0.0f, -200.0f);
			translate1.StartOffset = 2000;
//			var translate2 = new TranslateAnimation (0.0f, 0.0f, 0.0f, -200.0f);

			var set = new AnimationSet (shareInterpolator: true);
			var set3 = new AnimationSet (shareInterpolator: true);

			set.AddAnimation (translate1);
			set.Duration = 2000;

			set3.AddAnimation (scale);
			set3.AddAnimation (translate1);
			set3.Duration = 2000;


			polBtn.Click += delegate {

				scaleObject.StartAnimation (set3);
				polBtn.StartAnimation (set);
			};

//			polBtn2.Click += delegate {
//				polBtn2.StartAnimation (set2);
//			};
		}



	}
}


