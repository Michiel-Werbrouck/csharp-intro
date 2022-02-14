using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    public class LogBroadcaster : Logger
    {
        private readonly IEnumerable<Logger> _loggers;
        public LogBroadcaster(IEnumerable<Logger> loggers)
        {
            _loggers = loggers;
        }
        
        public override void Log(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(message);
            }
        }
    }
}
