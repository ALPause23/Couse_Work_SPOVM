using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace SystemMonitor
{
    public class Memory : OuputData
    {
        private string nameBIOS;
        private string GPU;
        private string RAM;
        
        public Memory()
        {
            setnameBIOS();
            setGPU();
            setRAM();
        }

        public void setnameBIOS()
        {
            nameBIOS = this.OutputResult(this.GetHardwareInfo("Win32_BIOS", "Manufacturer")) + "  ";
            nameBIOS += "Version: " + this.OutputResult(this.GetHardwareInfo("Win32_BIOS", "Version"));

        }
        public string getnameBIOS()
        {
            return nameBIOS;
        }

        public void setGPU()
        {
            GPU += this.OutputResult(this.GetHardwareInfo("Win32_VideoController", "Name"));
            GPU += "  " + System.Convert.ToUInt32(this.OutputResult(this.GetHardwareInfo("Win32_VideoController", "AdapterRAM"))) / 1073741824 + "ГБ";
        }
        public string getGPU()
        {
            return GPU;
        }

        public void setRAM()
        {
            RAM += System.Convert.ToUInt64(this.OutputResult(this.GetHardwareInfo("Win32_PhysicalMemory", "Capacity"))) / 1073741824 + "ГБ";
        }
        public string getRAM()
        {
            return RAM;
        }

        
    }
}
          
            
