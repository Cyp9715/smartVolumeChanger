using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace smartVolumeChanger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        /* class */
        PageManager _pageManager;

        /* view */
        MixerListWindow _volumeMixer;

        /* TextBox */
        Label _selectedLabel;


        public MainWindow()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            _pageManager = new PageManager(updatePreset);
            _volumeMixer = new MixerListWindow(changeTextBox);
        }

        private void slider_0_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_0.Value = (int)slider_0.Value;
            textBox_0.Text = slider_0.Value.ToString();
        }

        private void slider_1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_1.Value = (int)slider_1.Value;
            textBox_1.Text = slider_1.Value.ToString();
        }

        private void slider_2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_2.Value = (int)slider_2.Value;
            textBox_2.Text = slider_2.Value.ToString();
        }

        private void slider_3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_3.Value = (int)slider_3.Value;
            textBox_3.Text = slider_3.Value.ToString();
        }

        private void slider_4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            slider_4.Value = (int)slider_4.Value;
            textBox_4.Text = slider_4.Value.ToString();
        }

        private void slider_5_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_5.Value = (int)slider_5.Value;
            textBox_5.Text = slider_5.Value.ToString();
        }

        private void slider_6_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_6.Value = (int)slider_6.Value;
            textBox_6.Text = slider_6.Value.ToString();
        }

        private void slider_7_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider_7.Value = (int)slider_7.Value;
            textBox_7.Text = slider_7.Value.ToString();
        }


        private void btn_preset0_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 0;
            _pageManager.updatePage(_pageManager.page0);
        }

        private void btn_preset1_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 1;
            _pageManager.updatePage(_pageManager.page1);
        }

        private void btn_preset2_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 2;
            _pageManager.updatePage(_pageManager.page2);
        }

        private void btn_preset3_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 3;
            _pageManager.updatePage(_pageManager.page3);
        }

        private void btn_preset4_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 4;
            _pageManager.updatePage(_pageManager.page4);
        }


        private void btn_preset5_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 5;
            _pageManager.updatePage(_pageManager.page5);
        }

        private void btn_preset6_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 6;
            _pageManager.updatePage(_pageManager.page6);
        }

        private void btn_preset7_Click(object sender, RoutedEventArgs e)
        {
            savePreset();
            _pageManager.currentPage = 7;
            _pageManager.updatePage(_pageManager.page7);
        }


        private void updatePreset(List<string> label, List<int> slider)
        {
            label_program0.Content = label[0];
            label_program1.Content = label[1];
            label_program2.Content = label[2];
            label_program3.Content = label[3];
            label_program4.Content = label[4];
            label_program5.Content = label[5];
            label_program6.Content = label[6];
            label_program7.Content = label[7];

            slider_0.Value = slider[0];
            slider_1.Value = slider[1];
            slider_2.Value = slider[2];
            slider_3.Value = slider[3];
            slider_4.Value = slider[4];
            slider_5.Value = slider[5];
            slider_6.Value = slider[6];
            slider_7.Value = slider[7];
        }

        private void savePreset()
        {
            switch(_pageManager.currentPage)
            {
                case 0:
                    _pageManager.page0.id_0 = (string)label_program0.Content;
                    _pageManager.page0.id_1 = (string)label_program1.Content;
                    _pageManager.page0.id_2 = (string)label_program2.Content;
                    _pageManager.page0.id_3 = (string)label_program3.Content;
                    _pageManager.page0.id_4 = (string)label_program4.Content;
                    _pageManager.page0.id_5 = (string)label_program5.Content;
                    _pageManager.page0.id_6 = (string)label_program6.Content;
                    _pageManager.page0.id_7 = (string)label_program7.Content;

                    _pageManager.page0.slider_0 = (int)slider_0.Value;
                    _pageManager.page0.slider_1 = (int)slider_1.Value;
                    _pageManager.page0.slider_2 = (int)slider_2.Value;
                    _pageManager.page0.slider_3 = (int)slider_3.Value;
                    _pageManager.page0.slider_4 = (int)slider_4.Value;
                    _pageManager.page0.slider_5 = (int)slider_5.Value;
                    _pageManager.page0.slider_6 = (int)slider_6.Value;
                    _pageManager.page0.slider_7 = (int)slider_7.Value;
                    break;

                case 1:
                    _pageManager.page1.id_0 = (string)label_program0.Content;
                    _pageManager.page1.id_1 = (string)label_program1.Content;
                    _pageManager.page1.id_2 = (string)label_program2.Content;
                    _pageManager.page1.id_3 = (string)label_program3.Content;
                    _pageManager.page1.id_4 = (string)label_program4.Content;
                    _pageManager.page1.id_5 = (string)label_program5.Content;
                    _pageManager.page1.id_6 = (string)label_program6.Content;
                    _pageManager.page1.id_7 = (string)label_program7.Content;

                    _pageManager.page1.slider_0 = (int)slider_0.Value;
                    _pageManager.page1.slider_1 = (int)slider_1.Value;
                    _pageManager.page1.slider_2 = (int)slider_2.Value;
                    _pageManager.page1.slider_3 = (int)slider_3.Value;
                    _pageManager.page1.slider_4 = (int)slider_4.Value;
                    _pageManager.page1.slider_5 = (int)slider_5.Value;
                    _pageManager.page1.slider_6 = (int)slider_6.Value;
                    _pageManager.page1.slider_7 = (int)slider_7.Value;
                    break;

                case 2:
                    _pageManager.page2.id_0 = (string)label_program0.Content;
                    _pageManager.page2.id_1 = (string)label_program1.Content;
                    _pageManager.page2.id_2 = (string)label_program2.Content;
                    _pageManager.page2.id_3 = (string)label_program3.Content;
                    _pageManager.page2.id_4 = (string)label_program4.Content;
                    _pageManager.page2.id_5 = (string)label_program5.Content;
                    _pageManager.page2.id_6 = (string)label_program6.Content;
                    _pageManager.page2.id_7 = (string)label_program7.Content;

                    _pageManager.page2.slider_0 = (int)slider_0.Value;
                    _pageManager.page2.slider_1 = (int)slider_1.Value;
                    _pageManager.page2.slider_2 = (int)slider_2.Value;
                    _pageManager.page2.slider_3 = (int)slider_3.Value;
                    _pageManager.page2.slider_4 = (int)slider_4.Value;
                    _pageManager.page2.slider_5 = (int)slider_5.Value;
                    _pageManager.page2.slider_6 = (int)slider_6.Value;
                    _pageManager.page2.slider_7 = (int)slider_7.Value;
                    break;

                case 3:
                    _pageManager.page3.id_0 = (string)label_program0.Content;
                    _pageManager.page3.id_1 = (string)label_program1.Content;
                    _pageManager.page3.id_2 = (string)label_program2.Content;
                    _pageManager.page3.id_3 = (string)label_program3.Content;
                    _pageManager.page3.id_4 = (string)label_program4.Content;
                    _pageManager.page3.id_5 = (string)label_program5.Content;
                    _pageManager.page3.id_6 = (string)label_program6.Content;
                    _pageManager.page3.id_7 = (string)label_program7.Content;

                    _pageManager.page3.slider_0 = (int)slider_0.Value;
                    _pageManager.page3.slider_1 = (int)slider_1.Value;
                    _pageManager.page3.slider_2 = (int)slider_2.Value;
                    _pageManager.page3.slider_3 = (int)slider_3.Value;
                    _pageManager.page3.slider_4 = (int)slider_4.Value;
                    _pageManager.page3.slider_5 = (int)slider_5.Value;
                    _pageManager.page3.slider_6 = (int)slider_6.Value;
                    _pageManager.page3.slider_7 = (int)slider_7.Value;
                    break;
                
                case 4:
                    _pageManager.page4.id_0 = (string)label_program0.Content;
                    _pageManager.page4.id_1 = (string)label_program1.Content;
                    _pageManager.page4.id_2 = (string)label_program2.Content;
                    _pageManager.page4.id_3 = (string)label_program3.Content;
                    _pageManager.page4.id_4 = (string)label_program4.Content;
                    _pageManager.page4.id_5 = (string)label_program5.Content;
                    _pageManager.page4.id_6 = (string)label_program6.Content;
                    _pageManager.page4.id_7 = (string)label_program7.Content;

                    _pageManager.page4.slider_0 = (int)slider_0.Value;
                    _pageManager.page4.slider_1 = (int)slider_1.Value;
                    _pageManager.page4.slider_2 = (int)slider_2.Value;
                    _pageManager.page4.slider_3 = (int)slider_3.Value;
                    _pageManager.page4.slider_4 = (int)slider_4.Value;
                    _pageManager.page4.slider_5 = (int)slider_5.Value;
                    _pageManager.page4.slider_6 = (int)slider_6.Value;
                    _pageManager.page4.slider_7 = (int)slider_7.Value;
                    break;
                
                case 5:
                    _pageManager.page5.id_0 = (string)label_program0.Content;
                    _pageManager.page5.id_1 = (string)label_program1.Content;
                    _pageManager.page5.id_2 = (string)label_program2.Content;
                    _pageManager.page5.id_3 = (string)label_program3.Content;
                    _pageManager.page5.id_4 = (string)label_program4.Content;
                    _pageManager.page5.id_5 = (string)label_program5.Content;
                    _pageManager.page5.id_6 = (string)label_program6.Content;
                    _pageManager.page5.id_7 = (string)label_program7.Content;

                    _pageManager.page5.slider_0 = (int)slider_0.Value;
                    _pageManager.page5.slider_1 = (int)slider_1.Value;
                    _pageManager.page5.slider_2 = (int)slider_2.Value;
                    _pageManager.page5.slider_3 = (int)slider_3.Value;
                    _pageManager.page5.slider_4 = (int)slider_4.Value;
                    _pageManager.page5.slider_5 = (int)slider_5.Value;
                    _pageManager.page5.slider_6 = (int)slider_6.Value;
                    _pageManager.page5.slider_7 = (int)slider_7.Value;
                    break;
                
                case 6:
                    _pageManager.page6.id_0 = (string)label_program0.Content;
                    _pageManager.page6.id_1 = (string)label_program1.Content;
                    _pageManager.page6.id_2 = (string)label_program2.Content;
                    _pageManager.page6.id_3 = (string)label_program3.Content;
                    _pageManager.page6.id_4 = (string)label_program4.Content;
                    _pageManager.page6.id_5 = (string)label_program5.Content;
                    _pageManager.page6.id_6 = (string)label_program6.Content;
                    _pageManager.page6.id_7 = (string)label_program7.Content;

                    _pageManager.page6.slider_0 = (int)slider_0.Value;
                    _pageManager.page6.slider_1 = (int)slider_1.Value;
                    _pageManager.page6.slider_2 = (int)slider_2.Value;
                    _pageManager.page6.slider_3 = (int)slider_3.Value;
                    _pageManager.page6.slider_4 = (int)slider_4.Value;
                    _pageManager.page6.slider_5 = (int)slider_5.Value;
                    _pageManager.page6.slider_6 = (int)slider_6.Value;
                    _pageManager.page6.slider_7 = (int)slider_7.Value;
                    break;
                
                case 7:
                    _pageManager.page7.id_0 = (string)label_program0.Content;
                    _pageManager.page7.id_1 = (string)label_program1.Content;
                    _pageManager.page7.id_2 = (string)label_program2.Content;
                    _pageManager.page7.id_3 = (string)label_program3.Content;
                    _pageManager.page7.id_4 = (string)label_program4.Content;
                    _pageManager.page7.id_5 = (string)label_program5.Content;
                    _pageManager.page7.id_6 = (string)label_program6.Content;
                    _pageManager.page7.id_7 = (string)label_program7.Content;

                    _pageManager.page7.slider_0 = (int)slider_0.Value;
                    _pageManager.page7.slider_1 = (int)slider_1.Value;
                    _pageManager.page7.slider_2 = (int)slider_2.Value;
                    _pageManager.page7.slider_3 = (int)slider_3.Value;
                    _pageManager.page7.slider_4 = (int)slider_4.Value;
                    _pageManager.page7.slider_5 = (int)slider_5.Value;
                    _pageManager.page7.slider_6 = (int)slider_6.Value;
                    _pageManager.page7.slider_7 = (int)slider_7.Value;
                    break;

                default:
                    break;
            }
        }

        private void textBox_0_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
            if (Int32.Parse(textBox_0.Text) > 100)
                textBox_0.Text = "100";
        }

        private void label_program0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program0;
        }

        private void label_program1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program1;
        }

        private void label_program2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program2;
        }

        private void label_program3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program3;
        }

        private void label_program4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program4;
        }

        private void label_program5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program5;
        }
        private void label_program6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program6;
        }

        private void label_program7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _volumeMixer.Show();
            _selectedLabel = label_program7;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton != MouseButtonState.Pressed) 
                DragMove();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeTextBox(string str)
        {
            _selectedLabel.Content = str;
        }

 
    }
}