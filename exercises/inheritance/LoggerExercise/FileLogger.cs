using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    public class FileLogger : StreamLogger
    {
        private readonly StreamWriter _streamWriter;
        public FileLogger(StreamWriter streamWriter) : base(streamWriter)
        {
            _streamWriter = streamWriter;
        }

        public static FileLogger Create(string filename)
        {
            StreamWriter streamWriter = new(File.OpenWrite(filename));
            return new FileLogger(streamWriter);
        }

        public override void Close()
        {
            _streamWriter.Close();
        }
    }
}
