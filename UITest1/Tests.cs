using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest1
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                //.ApkFile ("../../../Android/bin/Debug/UITestsAndroid.apk")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void NewTest()
        {
            app.Tap(x => x.Text("Num1"));

            app.ClearText(x => x.Class("EntryEditText").Text("Num1"));

            app.EnterText(x => x.Class("EntryEditText"), "10");
            app.Screenshot("Entered Number 1 = 10");
            app.Tap(x => x.Text("Num2"));
            app.ClearText(x => x.Class("EntryEditText").Text("Num2"));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "20");
            app.Screenshot("Entered Number 2 = 20");
            app.Tap(x => x.Text("Add"));
            app.WaitForElement(x => x.Text("30"));
            app.Screenshot("Expected = 30");
        }

    }
}

