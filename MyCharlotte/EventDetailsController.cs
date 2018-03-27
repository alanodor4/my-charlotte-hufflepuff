using Foundation;
using System;
using UIKit;

namespace MyCharlotte
{
    public partial class EventDetailsController : UIViewController
    {
        public EventDetailsController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            UIStoryboard storyboard = this.Storyboard;
            NavigationController.SetNavigationBarHidden(true, true);
            UIApplication.SharedApplication.SetStatusBarHidden(true, UIStatusBarAnimation.None);

            var bg = new UIImageView(new CoreGraphics.CGRect(110, 0, View.Bounds.Width - 110, View.Bounds.Height));
            bg.ContentMode = UIViewContentMode.ScaleAspectFit;
            bg.Image = UIImage.FromFile("images/infobg.png");

            View.Add(bg);

            var topLabel = new UILabel
            {
                Frame = new CoreGraphics.CGRect(110, 30, View.Bounds.Width - 110, 40),
                Text = "Event Details",
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(40.0f),
                TextColor = UIColor.Black
            };
            View.Add(topLabel);

            var bar = new UIView
            {
                Frame = new CoreGraphics.CGRect(0, 0, 110, View.Bounds.Height),
                BackgroundColor = UIColor.FromRGB(32, 153, 255)
            };
            View.Add(bar);

            var logo = new UIImageView(new CoreGraphics.CGRect(0, 0, 110, 110));
            logo.ContentMode = UIViewContentMode.ScaleAspectFit;
            logo.Image = UIImage.FromFile("images/charlotte-crown.png");
            logo.BackgroundColor = UIColor.FromRGB(23, 123, 204);

            View.AddSubview(logo);

            //Browse Maps Button
            var browseEventsButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(10, 120, 90, 90),
                BackgroundColor = UIColor.FromRGB(23, 123, 204)
            };
            browseEventsButton.SetImage(UIImage.FromFile("images/list.png"), UIControlState.Normal);
            View.Add(browseEventsButton);

            browseEventsButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventsViewController evcontroller = storyboard.InstantiateViewController("EventsViewController") as EventsViewController;
                this.NavigationController.PushViewController(evcontroller, false);
            };

            //View Map Button
            var viewMapButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(10, 225, 90, 90)
            };
            viewMapButton.SetImage(UIImage.FromFile("images/map_icon.png"), UIControlState.Normal);
            View.Add(viewMapButton);

            viewMapButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                MapViewController mvcontroller = storyboard.InstantiateViewController("MapViewController") as MapViewController;
                this.NavigationController.PushViewController(mvcontroller, false);
            };

            //View Map Button
            var myCalendarButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(10, 330, 90, 90)
            };
            myCalendarButton.SetImage(UIImage.FromFile("images/calendar.png"), UIControlState.Normal);
            View.Add(myCalendarButton);

            myCalendarButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                CalendarViewController cvcontroller = storyboard.InstantiateViewController("CalendarViewController") as CalendarViewController;
                this.NavigationController.PushViewController(cvcontroller, false);
            };

            //View Map Button
            var cityInfoButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(10, 435, 90, 90)
            };
            cityInfoButton.SetImage(UIImage.FromFile("images/info.png"), UIControlState.Normal);
            View.Add(cityInfoButton);

            cityInfoButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                InfoViewController ivcontroller = storyboard.InstantiateViewController("InfoViewController") as InfoViewController;
                this.NavigationController.PushViewController(ivcontroller, false);
            };

            //Settings Button
            var settingsButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(10, 540, 90, 90)
            };
            settingsButton.SetImage(UIImage.FromFile("images/settings_icon.png"), UIControlState.Normal);
            View.Add(settingsButton);

            settingsButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                SettingsViewController svcontroller = storyboard.InstantiateViewController("SettingsViewController") as SettingsViewController;
                this.NavigationController.PushViewController(svcontroller, false);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}