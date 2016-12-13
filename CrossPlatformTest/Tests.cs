using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlatformTest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void NewTest()
        {
            app.TouchAndHold(x => x.Text("Num1"));
            app.ClearText(x => x.Class("EntryEditText").Text("Num1"));
            app.EnterText(x => x.Class("EntryEditText"), "45");
            app.Tap(x => x.Text("Num2"));
            app.ClearText(x => x.Class("EntryEditText").Text("Num2"));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "65");
            app.Screenshot("Entered numbers");
            app.Tap(x => x.Text("Add"));
            app.ClearText(x => x.Class("EntryEditText").Text("Result"));
            app.EnterText(x => x.Class("EntryEditText").Text("Result"), "Resul");
            app.Screenshot("Expected result ");
            app.WaitForElement(x => x.Text("110"));
        }
    }
}

