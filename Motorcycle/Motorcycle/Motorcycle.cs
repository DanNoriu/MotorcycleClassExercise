using System;
using System.IO;
using System.Text;
using System.Collections;
namespace Motorcycle
{
    class Motorcycle
    {
        private bool started { get; set; }
        private int rpm { get; set; }
        private int gear { get; set; }
        private string name { get; set; }
        private int speed { get; set; }


        public Motorcycle()
        {
            rpm = 0;
            started = false;
            gear = 0;
            name = "";
        }

        public Motorcycle(bool started, string name)
        {
            this.gear = 0;
            if (started == true)
            {
                this.started = true;
                this.rpm = 1000;

            }
            else
            {

                this.rpm = 0;
            }
        }

        public int getRpm()
        {
            return this.rpm;
        }

        public void setRpm(int rpm)
        {
            if (this.started == true && rpm < 8000 && rpm > 999)
            {

            }
        }

        public bool isStarted()
        {
            return this.started;
        }

        public int start(int gear, int rpm, bool started)
        {
            if (this.started == true)
            {
                this.started = true;
                this.rpm = 1000;
                this.gear = 1;
                return this.rpm;
            }
            else
            {
                this.started = false;
                return this.rpm;
            }
        }

        public void stop()
        {
            this.started = false;
            this.rpm = 0;
            this.gear = 0;

        }
        public void ShiftGearUp()
        {
            if (isStarted() == true)
            {
                this.gear = getGear() + 1; 
            }
            else
            {
                Console.WriteLine("no hablo worko gearo");
            }
        }

        public void shiftgearsDown(int g)
        {
            if (g < getGear() && gear > 0)
            {
                this.gear = 0;
            }
        }

        public int getSpeed()
        {
            this.speed = (getRpm() * getGear()) / 200;
            return this.speed;
        }

        public int getGear()
        {
            return this.gear;
        }

        public override string ToString()
        {
            return Convert.ToString("Km/T " + this.getSpeed() + " " + "Rp/m " + this.getRpm() + " " + "Gear " + this.getGear());
        }

    }
}
