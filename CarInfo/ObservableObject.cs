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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class ObservableObject : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
