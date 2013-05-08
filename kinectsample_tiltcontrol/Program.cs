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

            sensor.ElevationAngle = 0;  // 一開始先設定成水平0度

            ConsoleKey presskey;
            while ((presskey = Console.ReadKey().Key) != ConsoleKey.Spacebar)
            {
                if (presskey == ConsoleKey.DownArrow)
                {
                    sensor.ElevationAngle = sensor.ElevationAngle - 5;
                }
                else if (presskey == ConsoleKey.UpArrow)
                {
                    sensor.ElevationAngle = sensor.ElevationAngle + 5;
                }
                Console.WriteLine("現在角度 : " + sensor.ElevationAngle);
            }


            sensor.Stop();

        }
    }
}
