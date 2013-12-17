using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using ResourcesBox;

namespace OtherProject
{
    public class ShowWindowTests
    {
        [Test,RequiresSTA]
        public void ShowWindowTest()
        {
            var window = new MainWindow();
            var mre = new ManualResetEvent(false);
            window.Closing += (sender, args) => mre.Set();
            window.Show();
            mre.WaitOne();
        }
    }
}
