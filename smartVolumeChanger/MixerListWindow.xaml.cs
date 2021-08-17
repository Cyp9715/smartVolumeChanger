using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class MixerListWindow : Window
    {
        private System.Windows.Threading.DispatcherTimer timer;
        public delegate void _delUpdateLabelText(string str);
        private _delUpdateLabelText _updateLabelText;

        public MixerListWindow(_delUpdateLabelText updateTextBox)
        {
            InitializeComponent();
            init();
            _updateLabelText = updateTextBox;
        }

        private void init()
        {
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += new EventHandler(updateProcess);
            timer.Start();
        }

        public async void updateProcess(object sender, EventArgs e)
        {
            SortedDictionary<string, int> mixList = default;
            var task = Task.Run(() =>
            {
                mixList = volumeChanger.update();
            });
            await task;

            listBox_processList_name.Items.Clear();
            listBox_processList_volume.Items.Clear();

            foreach (var i in mixList)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = i.Key;
                listBox_processList_name.Items.Add(i.Key);
                listBox_processList_volume.Items.Add(i.Value);
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            window_mixList.Hide();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton != MouseButtonState.Pressed)
                DragMove();
        }

        private void window_mixList_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void listBox_processList_name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string lbi = (string)((sender as ListBox).SelectedItem);
            if (lbi is not null)
            {
                _updateLabelText(lbi);
                this.Hide();
            }
        }
    }
}
