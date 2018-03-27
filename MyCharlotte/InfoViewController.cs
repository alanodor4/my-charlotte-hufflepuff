using System;
using UIKit;
using Foundation;

namespace MyCharlotte
{
    public partial class InfoViewController : UIViewController
    {
        public InfoViewController (IntPtr handle) : base (handle)
        {
            // Note: this .ctor should not contain any initialization logic.
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
                Text = "City Info",
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
                Frame = new CoreGraphics.CGRect(10, 120, 90, 90)
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
                Frame = new CoreGraphics.CGRect(10, 435, 90, 90),
                BackgroundColor = UIColor.FromRGB(23, 123, 204)
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

            //Weather Button
            var weatherButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 100, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.FromRGB(246,219,112)
            };
            weatherButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            weatherButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            weatherButton.SetTitle("Weather", UIControlState.Normal);
            View.Add(weatherButton);

            weatherButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                NSUrl itunesLink;
                itunesLink = new NSUrl("https://itunes.apple.com/us/app/accuweather-weather-tracker/id300048137?mt=8");
                UIApplication.SharedApplication.OpenUrl(itunesLink, new NSDictionary() { }, null);
            };
            View.Add(weatherButton);

            //Air/Water Button
            var airWaterButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 180, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.FromRGB(246, 219, 112)
            };
            airWaterButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            airWaterButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            airWaterButton.SetTitle("Air/Water", UIControlState.Normal);
            View.Add(airWaterButton);

            airWaterButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                NSUrl itunesLink;
                itunesLink = new NSUrl("https://itunes.apple.com/us/app/accuweather-weather-tracker/id300048137?mt=8");
                UIApplication.SharedApplication.OpenUrl(itunesLink, new NSDictionary() { }, null);
            };
            View.Add(airWaterButton);

            //Traffic Button
            var trafficButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 260, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.FromRGB(246, 219, 112)
            };
            trafficButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            trafficButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            trafficButton.SetTitle("Traffic", UIControlState.Normal);
            View.Add(trafficButton);

            trafficButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                NSUrl itunesLink;
                itunesLink = new NSUrl("https://itunes.apple.com/us/app/accuweather-weather-tracker/id300048137?mt=8");
                UIApplication.SharedApplication.OpenUrl(itunesLink, new NSDictionary() { }, null);
            };
            View.Add(trafficButton);

            //Flights Button
            var flightsButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 340, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.FromRGB(246, 219, 112)
            };
            flightsButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            flightsButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            flightsButton.SetTitle("Flights", UIControlState.Normal);
            View.Add(flightsButton);

            flightsButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                NSUrl itunesLink;
                itunesLink = new NSUrl("https://itunes.apple.com/us/app/accuweather-weather-tracker/id300048137?mt=8");
                UIApplication.SharedApplication.OpenUrl(itunesLink, new NSDictionary() { }, null);
            };
            View.Add(flightsButton);

            //Bus Routes Button
            var busRoutesButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 420, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.FromRGB(246, 219, 112)
            };
            busRoutesButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            busRoutesButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            busRoutesButton.SetTitle("Bus Routes", UIControlState.Normal);
            View.Add(busRoutesButton);

            busRoutesButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                NSUrl itunesLink;
                itunesLink = new NSUrl("https://itunes.apple.com/us/app/accuweather-weather-tracker/id300048137?mt=8");
                UIApplication.SharedApplication.OpenUrl(itunesLink, new NSDictionary() { }, null);
            };
            View.Add(busRoutesButton);

            //Contact Us Button
            var contactUsButton = new UIButton
            {
                Frame = new CoreGraphics.CGRect(120, 500, View.Bounds.Width - 130, 60),
                BackgroundColor = UIColor.FromRGB(246, 219, 112)
            };
            contactUsButton.TitleLabel.Font = UIFont.SystemFontOfSize(24.0f);
            contactUsButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            contactUsButton.SetTitle("Contact Us", UIControlState.Normal);
            View.Add(contactUsButton);

            contactUsButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                NSUrl itunesLink;
                itunesLink = new NSUrl("https://itunes.apple.com/us/app/accuweather-weather-tracker/id300048137?mt=8");
                UIApplication.SharedApplication.OpenUrl(itunesLink, new NSDictionary() { }, null);
            };
            View.Add(contactUsButton);
        }
    }
}