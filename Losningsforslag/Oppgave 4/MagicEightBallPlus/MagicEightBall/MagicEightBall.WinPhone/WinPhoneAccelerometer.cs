using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBall;
using Xamarin.Forms;
using Microsoft.Devices.Sensors;
using Microsoft.Xna.Framework;

[assembly: Dependency(typeof(MagicEightBall.WinPhone.WinPhoneAccelerometer))]
namespace MagicEightBall.WinPhone
{
    public class WinPhoneAccelerometer : IAccelerometer
    {
        private static readonly float THRESHOLD = 5.0f;
        private Accelerometer accelerometer;
        private Vector3? acceleration;

        public event EventHandler Shaked;

        public WinPhoneAccelerometer()
        {
            accelerometer = new Accelerometer();
            if (this.accelerometer != null)
            {
                this.acceleration = null;
                this.accelerometer.CurrentValueChanged += Accelerometer_CurrentValueChanged;
                this.accelerometer.Start();
            }
        }

        private void Accelerometer_CurrentValueChanged(Object con, SensorReadingEventArgs<AccelerometerReading> e)
        {
            if (Shaked != null)
            {
                Vector3 newAcceleration = e.SensorReading.Acceleration;

                if (this.acceleration != null)
                {
                    if (Math.Abs(this.acceleration.Value.LengthSquared() - newAcceleration.LengthSquared()) > THRESHOLD)
                    {
                        Shaked(this, EventArgs.Empty);
                    }
                }

                this.acceleration = newAcceleration;
            }
        }
    }
}
