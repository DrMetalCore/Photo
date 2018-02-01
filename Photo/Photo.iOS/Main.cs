
using Plugin.Media;
using UIKit;

namespace Photo.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static async System.Threading.Tasks.Task MainAsync(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");

            await CrossMedia.Current.Initialize();
        }
    }
}
