using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace smartVolumeChanger
{
    /// <summary>
    /// volumeMixer.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class volumeMixer : Window
    {
        public bool isShow { get; set; }
        System.Windows.Threading.DispatcherTimer timer;

        public volumeMixer()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += new EventHandler(updateProcess);
            timer.Start();
        }

        public void updateProcess(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                volumeChanger.init();
            });
            
        }
    }
}
