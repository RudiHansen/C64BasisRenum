using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C64BasisRenum.Librarys
{
    public class TimeCodeExecution
    {
        private Stopwatch watch;
        private string message = "";

        public TimeCodeExecution()
        {
            watch = new();
        }

        public void Start(string _message)
        {
            message = _message;
            watch.Start();
        }
        public void Restart(string _newMessage = "")
        {
            LogHelper.WriteToLogfile("TimeCodeExecution",$"{message} in {watch.ElapsedMilliseconds}ms");
            watch.Restart();
            if (_newMessage != "")
            {
                message = _newMessage;
            }
        }

        public void Stop()
        {
            watch.Stop();
            LogHelper.WriteToLogfile("TimeCodeExecution",$"{message} in {watch.ElapsedMilliseconds}ms");
        }
    }
}
