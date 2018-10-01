using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Service_App
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            this.OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
            System.IO.File.AppendAllLines(strPath, new[] { "Starting time : " + DateTime.Now.ToString() });

        }

        protected override void OnStop()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
            System.IO.File.AppendAllLines(strPath, new[] { "Stop time : " + DateTime.Now.ToString() });

        }
    }
}
