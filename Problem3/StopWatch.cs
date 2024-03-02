using System;
using System.Threading.Tasks;

namespace Problem3
{
   
    public class StopWatch
    {
        private DateTime _startTime;
        private bool _isRunning;

        public void Start()
        {
            //Throw Error if Stopwatch is already running
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public TimeSpan Stop()
        {
            //Throw Error if Stopwatch is not running

            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");
            //Calculate Duration here
            TimeSpan duration = DateTime.Now - _startTime;
            _isRunning = false;
            return duration;
        }
    }
}
