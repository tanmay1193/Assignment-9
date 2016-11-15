/*Assignment 9_Group 1
 * Group Members :  1. Oleksandr Rudavka
 *                  2. Jonathan Nagata
 *                  3. Niral Gandhi
 *                  4. Tanmay Teckchandani
 *                  5. Priya Tharuman
 *                  6. Krishna Kanhaiya
 *                  7. Lucas Currah
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class Car
    {
        public string Make
        {
            get; set;
        }
        public int Year
        {
            get; set;
        }
        public int Speed
        {
            get; set;
        }
        public Car(string make, int year) {
            // Constructor that requires make and year
            Make = make;
            Year = year;
            Speed = 0;
        }
        public void Accelerate(int interval)
        {
            // Function to increment car speed
            Speed += interval;
        }

        public void Decelerate(int interval)
        {
            // Function to decrease car speed
            Speed -= interval;
        }
    }
}
