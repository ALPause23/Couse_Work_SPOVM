using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SystemMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SystemInfo sysInfo = new SystemInfo();
            sysInfo.setProcessor(new Processor());
            sysInfo.setOS(new OS());
            sysInfo.setMemory(new Memory());

            label1.Text = "Операционная система: " + sysInfo.getOS().getName();
            label2.Text = "Разрядность: " + sysInfo.getOS().getArchitectOS();
            label3.Text = "Архитектура ОС: " + sysInfo.getOS().getOSver();
            label4.Text = "Версия: " + sysInfo.getOS().getVersion();
            label5.Text = "Имя ВМ: " + sysInfo.getOS().getMachineName();
            label6.Text = "Серийный номер: " + sysInfo.getOS().getSerialNumber();

            label7.Text = "Процессор: " + sysInfo.getProcessor().getName();
            label8.Text = "Архитектура процессора: " + sysInfo.getProcessor().getAchitect();
            label9.Text = "Производитель: " + sysInfo.getProcessor().getManufacturer();
            label10.Text = sysInfo.getProcessor().getNumCPU();

            label11.Text = "BIOS: " + sysInfo.getMemory().getnameBIOS();
            label12.Text = "GPU: " + sysInfo.getMemory().getGPU();
            label13.Text = "ОЗУ: " + sysInfo.getMemory().getRAM();

            Process();

            for (int i = 0; i < sysInfo.getOS().getProcess().Capacity; i++)
            {
                listBox1.Items.Add(sysInfo.getOS().getProcess()[i]);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void Process()
        {
            DriveInfo[] all;
            all = DriveInfo.GetDrives();
            foreach (DriveInfo obj in all)
            {
                if (obj.IsReady && Convert.ToString(obj.DriveType) == "Fixed")
                {
                    label14.Text += obj.Name;
                    label14.Text += "\n";
                    label14.Text += "Тип файловой системы: ";
                    label14.Text += obj.DriveFormat;
                    label14.Text += "\n";
                    label14.Text += "Размер: ";
                    Double CapacityHDD = 0;
                    CapacityHDD = obj.TotalSize / 1073741824;
                    label14.Text += CapacityHDD + " GB\n";
                    label14.Text += "Своодно: ";
                    Double UsedSpace = 0;
                    Double FreeSpace = 0;
                    FreeSpace = obj.AvailableFreeSpace / 1073741824;
                    label14.Text += FreeSpace + " GB\n";
                    label14.Text += "Занято:";
                    UsedSpace = CapacityHDD - FreeSpace;
                    label14.Text += UsedSpace + " GB\n";
                    label14.Text += "\n";
                }
            }

        }
    }
}
