using System.ServiceProcess;
using System.Timers;

namespace DataParserWindowsService
{
    public partial class Scheduler : ServiceBase
    {
        Timer timer1;
        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer1 = new Timer();
            timer1.Interval = 30000;//Every 30 seconds
            timer1.Elapsed += new ElapsedEventHandler(timer1_Tick);
            timer1.Enabled = true;
            Library.WriteErrorLog("Windows Service Started");

        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            Library.WriteErrorLog("Time ticked and some job has been done sucessfully");
        }

        protected override void OnStop()
        {
            timer1.Enabled = true;
            Library.WriteErrorLog("Windows Service Stopped");
        }
    }
}
