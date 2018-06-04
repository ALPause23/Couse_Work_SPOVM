using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management; // нужно добавить ссылку
using System.Diagnostics;
using System.Threading;

namespace SystemMonitor
{
    class SystemInfo
    {
        private Processor processor;
        private OS os;
        private Memory memory;
        //public string CPU;
        
        public void setProcessor(Processor b1)
        {
            processor = b1;
        }
        public Processor getProcessor()
        {
            return processor;
        }
        public void setOS(OS c1)
        {
            os = c1;
        }
        public OS getOS()
        {
            return os;
        }
        public void setMemory(Memory m1)
        {
            memory = m1;
        }
        public Memory getMemory()
        {
            return memory;
        }
                
    }
}
