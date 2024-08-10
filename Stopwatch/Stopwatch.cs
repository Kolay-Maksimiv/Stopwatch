namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _isRunning = false;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running");

            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running");

            _endTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
