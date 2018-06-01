using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    public class Processor : OuputData
    {
        private string name;
        private string manufacturer;
        private string numCPU;
        private string Achitect;

        public Processor()
        {
            setName();
            setManufacturer();
            setNumCPU();
            setAchitect();
        }

        public void setName()
        {
            name = this.OutputResult(this.GetHardwareInfo("Win32_Processor", "Name"));
        }
        public string getName()
        {
            return name;
        }

        public void setManufacturer()
        {
            manufacturer = this.OutputResult(this.GetHardwareInfo("Win32_Processor", "Manufacturer"));
        }
        public string getManufacturer()
        {
            return manufacturer;
        }

        public void setNumCPU()
        {
            numCPU = "Количество ядер: " + System.Convert.ToString(this.OutputResult(this.GetHardwareInfo("Win32_Processor", "NumberOfCores")));
            numCPU += ";  " + "Логические ядер: " + System.Convert.ToString(this.OutputResult(this.GetHardwareInfo("Win32_Processor", "NumberOfLogicalProcessors")));
        }
        public string getNumCPU()
        {
            return numCPU;
        }

        public void setAchitect()
        {
            switch(System.Convert.ToInt16(this.OutputResult(this.GetHardwareInfo("Win32_Processor", "Architecture"))))
            {
                case 0:
                    Achitect = "x86";
                    break;
                case 1:
                    Achitect = "MIPS";
                    break;
                case 2:
                    Achitect = "ALPHA";
                    break;
                case 3:
                    Achitect = "PowerPC";
                    break;
                case 5:
                    Achitect = "ARM";
                    break;
                case 6:
                    Achitect = "IA-64";
                    break;
               case 9:
                    Achitect = "x64";
                    break;
               default:
                    Achitect = "Unknow";
                    break;
            }
        }
        public string getAchitect()
        {
            return Achitect;
        }
    }
}
                    
