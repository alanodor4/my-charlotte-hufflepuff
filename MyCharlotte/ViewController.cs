using System;

using UIKit;
using Foundation;
using CoreGraphics;

namespace MyCharlotte
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            UIStoryboard storyboard = this.Storyboard;

            NavigationController.SetNavigationBarHidden(true, true);
            UIApplication.SharedApplication.SetStatusBarHidden(true, UIStatusBarAnimation.None);

            var bg = new UIImageView(new CoreGraphics.CGRect(0, 0, View.Bounds.Width, View.Bounds.Height));
            bg.ContentMode = UIViewContentMode.ScaleAspectFit;
            bg.Image = UIImage.FromFile("images/mainbg.png");

            View.Add(bg);

            var mainLabel = new UILabel
            {
                Frame = new CoreGraphics.CGRect(0, 150, View.Bounds.Width, 100),
                Text = "Where Would You Like To Start?",
                TextAlignment = UITextAlignment.Center,
                Lines = 2,
                Font = UIFont.SystemFontOfSize(40.0f),
                TextColor = UIColor.White
            };
            View.AddSubview(mainLabel);

            //Browse Events Button
            var browseEventsButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(90, 320, 200, 60),
                BackgroundColor = UIColor.FromRGB(23, 123, 204)
            };
            browseEventsButton.SetTitle("Browse Events", UIControlState.Normal);
            View.Add(browseEventsButton);

            browseEventsButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventsViewController evcontroller = storyboard.InstantiateViewController("EventsViewController") as EventsViewController;
                this.NavigationController.PushViewController(evcontroller, false);
            };

            //View Map Button
            var viewMapButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(90, 400, 200, 60),
                BackgroundColor = UIColor.FromRGB(23, 123, 204)
            };
            viewMapButton.SetTitle("View Map", UIControlState.Normal);
            View.Add(viewMapButton);

            viewMapButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                MapViewController mvcontroller = storyboard.InstantiateViewController("MapViewController") as MapViewController;
                this.NavigationController.PushViewController(mvcontroller, false);
            };

            //My Calendar Button
            var MyCalendarButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(90, 480, 200, 60),
                BackgroundColor = UIColor.FromRGB(23, 123, 204)
            };
            MyCalendarButton.SetTitle("My Calendar", UIControlState.Normal);
            View.Add(MyCalendarButton);

            MyCalendarButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                CalendarViewController cvcontroller = storyboard.InstantiateViewController("CalendarViewController") as CalendarViewController;
                this.NavigationController.PushViewController(cvcontroller, false);
            };


            //City Info Button
            var CityInfoButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(90, 560, 200, 60),
                BackgroundColor = UIColor.FromRGB(23, 123, 204)
            };
            CityInfoButton.SetTitle("City Info", UIControlState.Normal);
            View.Add(CityInfoButton);

            CityInfoButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                InfoViewController ivcontroller = storyboard.InstantiateViewController("InfoViewController") as InfoViewController;
                this.NavigationController.PushViewController(ivcontroller, false);
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
