using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StopwatchExercise
{
    public class StopwatchControl
    {
        private DateTime _startTime;
        private TimeSpan _duration; 
        //private DateTime _stopTime;
        private DateTime _stopTime; //{ get; set; }

        public StopwatchControl()
        {
            this._startTime = DateTime.Now;
        }

        public DateTime Start(DateTime dateTime)
        {
            this.SetStartTime(dateTime);
            return this._startTime;
        }

        public DateTime Stop(DateTime dateTime)
        {
            this._stopTime = dateTime;
            this.SetDuration();
            return this._stopTime;
        }
        
        public void SetDuration()
        {
            this._duration = this._stopTime.Subtract(this._startTime);
        }

        public TimeSpan GetDuration()
        {
            return this._duration;
        }

        public void SetStartTime(DateTime dateTime)
        {
            this._startTime = dateTime;
        }

        public DateTime GetStartTime()
        {
            return this._startTime;
        }

        public void SetStopTime(DateTime dateTime)
        {
            this._stopTime = dateTime;
        }

        public DateTime GetStopTime()
        {
            return this._stopTime;
        }
    }
}
