using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson03
{
    // Car class - blueprint for car objects
    class Car
    {
        //public properties*************************************

        //private properties*************************************
        private string make;
        private string model;
        private string colour;
        private string VIN;//Vehicle Identification Number
        private int speed;

        //Constructor*************************************
        public Car(string make, string model, string colour, string VIN)
        {
            //string myString = "Hello";

            //Initialize properties via the constructor
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.VIN = VIN;

            this.speed = 0;

            this.display();//Display cars property values

        }

        //public methods*************************************
        //cause the car object to drive forward*******************
        public void driveForward()
        {
            Console.WriteLine("The car is driving forward.");
            setSpeed(100);
            Console.WriteLine("Speed: {0}", speed);
        }

        //private methods*************************************
        //cause the car to change speed
        private void setSpeed(int newSpeed)
        {
            speed = newSpeed;
        }

        private void display()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Make:{0}", this.make);
            Console.WriteLine("Model:{0}", this.model);
            Console.WriteLine("Colour:{0}", this.colour);
            Console.WriteLine("VIN:{0}", this.VIN);
            Console.WriteLine("+++++++++++++++++++++++++++++");


        }
    }
}
