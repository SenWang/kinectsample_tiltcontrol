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
            KinectSensor sensor = (from sensorToCheck in KinectSensor.KinectSensors
                                   where sensorToCheck.Status == KinectStatus.Connected
                                   select sensorToCheck).FirstOrDefault();

            if (sensor == null)
            {
                Console.WriteLine("找不到任何可用的Kinect裝置，結束執行");
                return;
            }

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
