using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest2
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
            //app.Tap(x => x.Id("button2"));
            //app.Screenshot("Tapped on view with class: Button");
            app.Tap(x => x.Text("Num1"));
            app.ClearText(x => x.Class("EntryEditText").Text("Num1"));
            app.EnterText(x => x.Class("EntryEditText"), "5");
            app.Tap(x => x.Text("Num2"));
            app.ClearText(x => x.Class("EntryEditText").Text("Num2"));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "6");
            app.Tap(x => x.Text("Rich.UI"));
            //app.Tap(x => x.Text("Simple.UI"));
            //app.Tap(x => x.Text("Rich.UI"));
            app.Tap(x => x.Text("1"));
            app.Tap(x => x.Text("X"));
            app.Tap(x => x.Text("2"));
            app.Tap(x => x.Text("="));
            app.Tap(x => x.Text("5"));
            app.Tap(x => x.Text("X"));
            app.Tap(x => x.Text("6"));
            app.Tap(x => x.Text("="));
        }



       

       
    }
}

