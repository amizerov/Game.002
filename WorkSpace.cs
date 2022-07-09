using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game._002
{
    class WorkSpace
    {
        public event Action<string>? OnMessage;
        bool _dodo;
        int workDay = 0;

        private void DoWork()
        {
            while (_dodo)
            {
                string msg = $"Day - {workDay++}";
                OnMessage?.Invoke(msg);
                Thread.Sleep(1000);
                
            }
        }
        public void StartWork()
        {
            _dodo = true;
            Task.Run(() => DoWork());
        }
        public void StopWork()
        {
            _dodo = false;
        }
    }
}
