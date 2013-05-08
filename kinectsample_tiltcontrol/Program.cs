using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Kinect;

namespace kinectsample_tiltcontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            KinectSensor sensor = KinectSensor.KinectSensors[0];
            sensor.Start();

            sensor.ElevationAngle = 0; 

            sensor.Stop();

        }
    }
}
