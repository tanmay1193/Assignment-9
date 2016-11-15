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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class ViewModel: ObservableObject
    {
        #region PROPERTIES
        const int SPEEDINTERVAL = 5;
        Car CarModel;
        private string _make = "";
        private int _year = 0;
        private int defaultSpeed = 0;
        public string Make
        {
            get
            {
                if (CarModel != null)
                {
                    return CarModel.Make;
                } else
                {
                    return _make;
                }
            }
            set
            {
                if (CarModel != null)
                {
                    CarModel.Make = value;
                    OnPropertyChanged();
                } else
                {
                    _make = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Year
        {
            get
            {
                if (CarModel != null)
                {
                    return CarModel.Year;
                } else
                {
                    return _year;
                }
            }
            set
            {
                if (CarModel != null)
                {
                    CarModel.Year = value;
                    OnPropertyChanged();
                } else
                {
                    _year = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Speed
        {
            get
            {
                if (CarModel != null)
                {
                    return CarModel.Speed;
                } else
                {
                    return defaultSpeed;
                }
            }
            set
            {
                if (CarModel != null)
                {
                    CarModel.Speed = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        public void CreateCar()
        {
            if (CarModel == null)
            {
               CarModel = new Car(_make, _year);
            }
        } 

        public bool AccelerateCar()
        {
            if (CarModel != null)
            {
                Speed += SPEEDINTERVAL;
                return true;
            }
            return false;
        }
        
        public bool DecelerateCar()
        {
            if (CarModel != null)
            {
                Speed -= SPEEDINTERVAL;
                return true;
            }
                return false;
        }
    }
}
