using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationPaintballGun
{
    class PaintballGun
    {
        public const int MAGAZINE_SIZE = 16;

        private int paintBalls = 0;
        //private int paintBallsLoaded = 0;

        /* When the game needs to display the number of balls left 
         * and the number of balls loaded in the UI, 
         * it can call GetPaintBalls and GetPaintBallsLoaded methods.*/

        /* This property uses private backing field.
         * Its getter returns the value in the field,
         * and its setter updates the field.
         * public int PaintBallsLoaded
         * {
         *     get { return paintBallsLoaded; }
         *     set { paintBallsLoaded = value; }
         * }*/

        public int PaintBallsLoaded { get; set; }
        public bool IsEmpty() { return PaintBallsLoaded == 0; }

        /*public int GetPaintBalls() { return paintBalls; }

         * The game needs to able to set the number of balls.
         * The SetPaintBalls method protects the balls field 
         * by only allowing the game to set a positive number
         * of balls. Then it calls Reload() to automatically reload the gun.
        public void SetPaintBalls (int numberOfPaintBalls)
        {
            if (numberOfPaintBalls > 0)
                paintBalls = numberOfPaintBalls;
            Reload();
        }*/

        /* This is the declaration. It says that the name of the 
         * property is PaintBalls, and its type is int.*/
        public int PaintBalls
        {
            // The get accessor or getter is identical to the GetPaintBalls method
            // that it replaced.
            get { return paintBalls; }

            /* The set accessor or setter is almost identical to the SetPaintBalls
             * method. The only difference is it uses the value keyword where SetPaintBalls
             * used its parameter. The value keyword will always contain the value
             * being assigned by the set accessor.*/
            set
            {
                if (value > 0)
                    paintBalls = value;
                Reload();
            }
        }

        /* The only way to reload the gun is to call the Reload 
         * method, which loads the gun with a full magazine,
         * or the remaining number of balls if there isn't
         * a full magazine's worth. This keeps the paintBalls and
         * paintBallsLoaded from getting out of sync.*/
        public void Reload()
        {
            Console.WriteLine("Reloading ...");
            if (paintBalls > MAGAZINE_SIZE)
                PaintBallsLoaded = MAGAZINE_SIZE;
            else
                PaintBallsLoaded = paintBalls;
        }

        /* The Shoot method returns true and decrements the balls
         * field if the fun is loaded, or false if it isn't.*/
        public bool Shoot()
        {
            if (PaintBallsLoaded == 0) return false;
            PaintBallsLoaded--;
             paintBalls--;
            return true;
        }
    }
}
