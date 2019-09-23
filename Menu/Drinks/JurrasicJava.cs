/*  JurrasicJava.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {

        private bool SetRoomForCream = false;
        public bool RoomForCream
        {
            get { return RoomForCream; }
            set { RoomForCream = value; }
        }

        public bool Decaf
        {
            get { return false; }
        }

        public void LeaveRoomForCream()
        {
         
        }

        public void AddIce()
        {

        }

        public JurrasicJava()
        {
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
    }
}
