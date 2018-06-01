using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    public class OS : OuputData
    {
        private string name;
        private string version;
        private string serialNumber;
        private string OSver;
        private string MachineName;
        private string architectOS;
        private List<string> Process = new List<string>();

        public OS()
        {
            setName();
            setOSver();
            setMachineName();
            setSerialNumber();
            setVersion();
            setArchitectOS();
            setProcess();
        }

        public void setName()
        {
            name = this.OutputResult(this.GetHardwareInfo("Win32_OperatingSystem", "Caption"));
        }
        public string getName()
        {
            return name;
        }

        public void setVersion()
        {
            version = this.OutputResult(this.GetHardwareInfo("Win32_OperatingSystem", "Version"));
        }
        public string getVersion()
        {
            return version;
        }

        public void setSerialNumber()
        {
            serialNumber = this.OutputResult(this.GetHardwareInfo("Win32_OperatingSystem", "SerialNumber")); 
        }
        public string getSerialNumber()
        {
            return serialNumber;
        }

        public void setOSver()
        {

            switch (System.Convert.ToInt16(this.OutputResult(this.GetHardwareInfo("Win32_OperatingSystem", "OSType"))))
            {
                case 0:
                    OSver = "Unknow";
                    break;
                case 1:
                    OSver = "Other";
                    break;
                case 3:
                    OSver = "ATUNIX";
                    break;
                case 12:
                    OSver = "OS/2";
                    break;
                case 13:
                    OSver = "JavaVM";
                    break;
                case 14:
                    OSver = "MSDOS";
                    break;
                case 17:
                    OSver = "Win 98";
                    break;
                case 18:
                    OSver = "Win NT";
                    break;
                case 36:
                    OSver = "LINUX";
                    break;
            }
        }
        public string getOSver()
        {
            return OSver;
        }

        public void setMachineName()
        {
            MachineName = this.OutputResult(this.GetHardwareInfo("Win32_OperatingSystem", "CSName"));
        }
        public string getMachineName()
        {
            return MachineName;
        }

        public void setArchitectOS()
        {
            architectOS = this.OutputResult(this.GetHardwareInfo("Win32_OperatingSystem", "OSArchitecture"));
        }
        public string getArchitectOS()
        {
            return architectOS;
        }

        public void setProcess()
        {
            System.Diagnostics.Process[] processes;
            processes = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process instance in processes)
            {
                this.Process.Add(instance.ProcessName);
            }
        }
        public List<string> getProcess()
        {
            return Process;
        }
    
    }
}
