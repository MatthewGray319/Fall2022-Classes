using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall_2022_Classes
{
    internal class Car
    {
        // properties
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Speed { get; set; }
        public bool IsPayedFor { get; set; }

        //access modifiers: public vs. private vs. internal
        // How we access classes, properities, methods, etc. in our application
        
        // constructor
        public  Car()
        {
            Make = "Lexus";
            Model = "Rx 350";
            Color = "White";
            Year = 2018;
            Speed = 0;
            IsPayedFor = false;
        }

        public Car(string make, string model, string color, int year, int speed, bool isPayedFor)
        {
            Make = make;
            Model = model;
            Color = color;
            Year = year;
            Speed = speed;
            IsPayedFor = isPayedFor;


        } 

        // methods
    }
}
