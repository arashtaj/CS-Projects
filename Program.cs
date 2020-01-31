using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayCamera
{
    class Program
    {
            //www.github.com/ArashTaj
        static void Main(string[] args)
        {
            //Highway Camera SpeedLimit
            //camera 1
            Console.WriteLine("Highway Camera 1:" + "\n");
            //thats speed limit for highway
            Console.WriteLine("SpeedLimit: 120km/h"+"\n");
            // Your speed in highway
            Console.Write("Enter the CarSpeed(km/h):"+" ");

            //Thats a Hour the camera 1 see you
            var carSpeed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thats a Hour the camera 1 see you (its between 1 and 24):" + " ");
            //Thats a minute the camera 1 see you
            var hour = Convert.ToInt32(Console.ReadLine()) ;
            Console.Write("Thats a minute the camera 1 see you (its between 1 and 60):" + " ");
            //Thats a second the camera 1 see you
            var minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thats a second the camera 1 see you (its between 1 and 60):" + " ");
            var second = Convert.ToInt32(Console.ReadLine());
            //If your arrival time is right, your time will be recorded
            if (hour > 0 && hour < 24 && minute > 0 && minute < 60 && second > 0 && second <60)
            {
                Console.WriteLine($"{hour}:{minute}:{second}"+"\n");
            }
            //Otherwise, it will be logged out and not registered
            else
            {
                Console.WriteLine("Please Enter hour and minute and second correctly!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            // if your car speed is under than 70km/h your speed is Below the limit
            if (carSpeed < 70)
            {
                Console.WriteLine($"You'r speed is {carSpeed}km/h and you'r low speed fines is 600,000 Rials" + "\n" + "\n");
            }
            // if your car speed is between 70km/h and 120km/h your speed is good
            if (carSpeed > 70 && carSpeed <= 120)
                Console.WriteLine("Good" + "\n" + "\n");
            // if your speed is between 120km/h and 130km/h your speed is Above limit and you shoulی pay speed fines
            if (carSpeed > 120 && carSpeed <= 130)
            {
                Console.WriteLine($"You'r speed is {carSpeed}km/h and you'r High speed fines is 600,000 Rials" + "\n" + "\n");
            }
            // if your speed between 130km/h and 135km/h its too bad! you should pay high speed fines *2 and your driving license roveoked and you gave 5 negetive point
            if (carSpeed > 130 && carSpeed < 135)
            {
                Console.WriteLine($"You'r speed is {carSpeed}km/h and you'r High speed fines is 1,200,000 Rials");
                Console.WriteLine("And you'r Driving license revoked");
                Console.WriteLine("And you gave 5 negetive point" + "\n" + "\n");
            }
            // if your speed above 135km/h its too bad!!! you should pay high speed fines *4 and your driving license roveoked and you gave 10 negetive point and You should go to court 
            if (carSpeed > 135)
            {
                Console.WriteLine($"You'r speed is {carSpeed}km/h and you'r High speed fines is 2,400,000 Rials");
                Console.WriteLine("And you'r Driving license revoked");
                Console.WriteLine("And you gave 10 negetive point");
                Console.WriteLine("And You should go to court"+"\n"+"\n");
            }
            //New Highway camera
            //Camera 2
            //thats a hour camera 2 see you
            Console.WriteLine("Highway Camera 2:"+"\n");
            Console.Write("Thats a Hour the camera 2 see you (its between 1 and 24):" + " ");
            var hour2 = Convert.ToInt32(Console.ReadLine());
            //thats a minute camera 2 see you
            Console.Write("Thats a minute the camera 2 see you (its between 1 and 60):" + " ");
            var minute2 = Convert.ToInt32(Console.ReadLine());
            //thats a second camera 2 see you
            Console.Write("Thats a second the camera 2 see you (its between 1 and 60):" + " ");
            var second2 = Convert.ToInt32(Console.ReadLine());
            
            int TimeControl = (minute2 - minute);
            //If your arrival time is right, your time will be recorded
            if (hour2 > 0 && hour2 < 24 && minute2 > 0 && minute2 < 60 && second2 > 0 && second2 < 60)
            {
                Console.WriteLine($"{hour2}:{minute2}:{second2}" + "\n");
                
            }
            //The timer checks and if you arrive earlier than 3 minutes it is clear that your speed is higher than the speed limit.
            if (TimeControl < 3)
            {
                Console.WriteLine("your speed above 130km/h Because you have arrived earlier than possible");
                Console.WriteLine("you'r High speed fines is 1,200,000 Rials");
                Console.WriteLine("And you'r Driving license revoked");
                Console.WriteLine("And you gave 5 negetive point");
            }
            //The timer checks and if you arrive earlier than 5 minutes it is clear that your speed is higher than the speed limit.
            if (TimeControl > 3 && TimeControl < 5 )
            {
                Console.WriteLine("your speed above 120km/h Because you have arrived earlier than possible");
                Console.WriteLine("you'r High speed fines is 600,000 Rials");
            }
            //Otherwise, it will be logged out and not registered
            else
            {
                Console.WriteLine("Please Enter hour and minute and second correctly!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.ReadKey();

            //www.github.com/ArashTaj
        }
    }
}
