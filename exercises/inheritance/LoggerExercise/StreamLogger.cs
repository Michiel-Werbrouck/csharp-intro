using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    public class StreamLogger : Logger
    {
        private readonly StreamWriter _streamWriter;
        public StreamLogger (StreamWriter streamWriter)
        {
            _streamWriter = streamWriter;
        }

        public override void Log(string message)
        {
            _streamWriter.WriteLine(message);
        }
    }
}
