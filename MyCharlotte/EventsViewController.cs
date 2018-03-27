using System;
using UIKit;

namespace MyCharlotte
{
    public partial class EventsViewController : UIViewController
    {
        public EventsViewController (IntPtr handle) : base (handle)
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
                Text = "Events",
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

            //Search Bar
            var searchBar = new UISearchBar
            {
                Frame = new CoreGraphics.CGRect(140, 80, View.Bounds.Width - 170, 30),
                BackgroundColor = UIColor.Clear
            };

            View.Add(searchBar);

            //Button
            var firstButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 140, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.White
            };
            firstButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            firstButton.SetTitle("Event 1", UIControlState.Normal);
            firstButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            firstButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventDetailsController edcontroller = storyboard.InstantiateViewController("EventDetailsController") as EventDetailsController;
                this.NavigationController.PushViewController(edcontroller, false);
            };
            View.Add(firstButton);

            //Button
            var secondButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 220, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.White
            };
            secondButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            secondButton.SetTitle("Event 2", UIControlState.Normal);
            secondButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            secondButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventDetailsController edcontroller = storyboard.InstantiateViewController("EventDetailsController") as EventDetailsController;
                this.NavigationController.PushViewController(edcontroller, false);
            };
            View.Add(secondButton);

            //Button
            var thirdButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 300, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.White
            };
            thirdButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            thirdButton.SetTitle("Event 3", UIControlState.Normal);
            thirdButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            thirdButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventDetailsController edcontroller = storyboard.InstantiateViewController("EventDetailsController") as EventDetailsController;
                this.NavigationController.PushViewController(edcontroller, false);
            };
            View.Add(thirdButton);

            //Button
            var fourthButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 380, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.White
            };
            fourthButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            fourthButton.SetTitle("Event 4", UIControlState.Normal);
            fourthButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            fourthButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventDetailsController edcontroller = storyboard.InstantiateViewController("EventDetailsController") as EventDetailsController;
                this.NavigationController.PushViewController(edcontroller, false);
            };
            View.Add(fourthButton);

            //Button
            var fifthButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 460, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.White
            };
            fifthButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            fifthButton.SetTitle("Event 5", UIControlState.Normal);
            fifthButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            fifthButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventDetailsController edcontroller = storyboard.InstantiateViewController("EventDetailsController") as EventDetailsController;
                this.NavigationController.PushViewController(edcontroller, false);
            };
            View.Add(fifthButton);

            //Button
            var sixthButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 540, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.White
            };
            sixthButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            sixthButton.SetTitle("Event 6", UIControlState.Normal);
            sixthButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            sixthButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventDetailsController edcontroller = storyboard.InstantiateViewController("EventDetailsController") as EventDetailsController;
                this.NavigationController.PushViewController(edcontroller, false);
            };
            View.Add(sixthButton);

            //Button
            var seventhButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 620, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.White
            };
            seventhButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            seventhButton.SetTitle("Event 7", UIControlState.Normal);
            seventhButton.SetTitleColor(UIColor.Black, UIControlState.Normal);

            seventhButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                EventDetailsController edcontroller = storyboard.InstantiateViewController("EventDetailsController") as EventDetailsController;
                this.NavigationController.PushViewController(edcontroller, false);
            };
            View.Add(seventhButton);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}