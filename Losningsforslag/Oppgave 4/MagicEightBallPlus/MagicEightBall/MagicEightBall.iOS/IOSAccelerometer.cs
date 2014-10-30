using System;
using System.Collections.Generic;
using System.Text;

[assembly: Dependency(typeof(MagicEightBall.iOS.IOSAccelerometer))]
namespace MagicEightBall.iOS
{
    public class IOSAccelerometer : IAccelerometer
    {
        public event EventHandler Shaked;

        public IOSAccelerometer() { }
    }
}
