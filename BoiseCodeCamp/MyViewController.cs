using System;
using ExternalLibrary.BL;
using MonoTouch.UIKit;
using System.Drawing;


namespace BoiseCodeCamp
{
    public class MyViewController : UIViewController
    {
        UIButton button;
        int numClicks = 0;
        float buttonWidth = 200;
        float buttonHeight = 50;

        public MyViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.Frame = UIScreen.MainScreen.Bounds;
            View.BackgroundColor = UIColor.White;
            View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            button = UIButton.FromType(UIButtonType.RoundedRect);

            button.Frame = new RectangleF(
                View.Frame.Width / 2 - buttonWidth / 2,
                View.Frame.Height / 2 - buttonHeight / 2,
                buttonWidth,
                buttonHeight);

            Task t = new Task();
            t.Name = "My Cool task";
            t.DueDate = DateTime.Now.AddDays(10);
            t.Notes = "This should really be done...";

            button.SetTitle("Click me", UIControlState.Normal);
           // MyExternalClassLibrary.BL.Managers.TaskManager();

            button.TouchUpInside += (object sender, EventArgs e) =>
                                        {
                                            t.ID = numClicks + 1;

                                            int taskId = ExternalLibrary.BL.Managers.TaskManager.SaveTask(t);

                button.SetTitle(String.Format("clicked {0} times and TaskId {1}", numClicks++, taskId), UIControlState.Normal);
            };

            button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin |
                UIViewAutoresizing.FlexibleBottomMargin;

           




            View.AddSubview(button);
        }

    }
}

