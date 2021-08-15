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
    public partial class MainWindow : Window
    {
        /* class */
        PageManager pageManager;

        /* view */
        volumeMixer volumeMixer;

        public MainWindow()
        {
            InitializeComponent();
            init();
        }

        void init()
        {
            pageManager = new PageManager(updateSlider);
            volumeMixer = new volumeMixer();
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
            saveSlider();
            pageManager.currentPage = 0;
            pageManager.updatePage(pageManager.page0);
        }

        private void btn_preset1_Click(object sender, RoutedEventArgs e)
        {
            saveSlider();
            pageManager.currentPage = 1;
            pageManager.updatePage(pageManager.page1);
        }

        private void btn_preset2_Click(object sender, RoutedEventArgs e)
        {
            saveSlider();
            pageManager.currentPage = 2;
            pageManager.updatePage(pageManager.page2);
        }

        private void btn_preset3_Click(object sender, RoutedEventArgs e)
        {
            saveSlider();
            pageManager.currentPage = 3;
            pageManager.updatePage(pageManager.page3);
        }

        private void btn_preset4_Click(object sender, RoutedEventArgs e)
        {
            saveSlider();
            pageManager.currentPage = 4;
            pageManager.updatePage(pageManager.page4);
        }


        private void btn_preset5_Click(object sender, RoutedEventArgs e)
        {
            saveSlider();
            pageManager.currentPage = 5;
            pageManager.updatePage(pageManager.page5);
        }




        private void updateSlider(List<int> slider)
        {
            if (slider.Count == 8)
            {
                slider_0.Value = slider[0];
                slider_1.Value = slider[1];
                slider_2.Value = slider[2];
                slider_3.Value = slider[3];
                slider_4.Value = slider[4];
                slider_5.Value = slider[5];
                slider_6.Value = slider[6];
                slider_7.Value = slider[7];
            }
        }

        private void saveSlider()
        {
            switch(pageManager.currentPage)
            {
                case 0:
                    pageManager.page0.slider_0 = (int)slider_0.Value;
                    pageManager.page0.slider_1 = (int)slider_1.Value;
                    pageManager.page0.slider_2 = (int)slider_2.Value;
                    pageManager.page0.slider_3 = (int)slider_3.Value;
                    pageManager.page0.slider_4 = (int)slider_4.Value;
                    pageManager.page0.slider_5 = (int)slider_5.Value;
                    pageManager.page0.slider_6 = (int)slider_6.Value;
                    pageManager.page0.slider_7 = (int)slider_7.Value;
                    break;

                case 1:
                    pageManager.page1.slider_0 = (int)slider_0.Value;
                    pageManager.page1.slider_1 = (int)slider_1.Value;
                    pageManager.page1.slider_2 = (int)slider_2.Value;
                    pageManager.page1.slider_3 = (int)slider_3.Value;
                    pageManager.page1.slider_4 = (int)slider_4.Value;
                    pageManager.page1.slider_5 = (int)slider_5.Value;
                    pageManager.page1.slider_6 = (int)slider_6.Value;
                    pageManager.page1.slider_7 = (int)slider_7.Value;
                    break;

                case 2:
                    pageManager.page2.slider_0 = (int)slider_0.Value;
                    pageManager.page2.slider_1 = (int)slider_1.Value;
                    pageManager.page2.slider_2 = (int)slider_2.Value;
                    pageManager.page2.slider_3 = (int)slider_3.Value;
                    pageManager.page2.slider_4 = (int)slider_4.Value;
                    pageManager.page2.slider_5 = (int)slider_5.Value;
                    pageManager.page2.slider_6 = (int)slider_6.Value;
                    pageManager.page2.slider_7 = (int)slider_7.Value;
                    break;

                case 3:
                    pageManager.page3.slider_0 = (int)slider_0.Value;
                    pageManager.page3.slider_1 = (int)slider_1.Value;
                    pageManager.page3.slider_2 = (int)slider_2.Value;
                    pageManager.page3.slider_3 = (int)slider_3.Value;
                    pageManager.page3.slider_4 = (int)slider_4.Value;
                    pageManager.page3.slider_5 = (int)slider_5.Value;
                    pageManager.page3.slider_6 = (int)slider_6.Value;
                    pageManager.page3.slider_7 = (int)slider_7.Value;
                    break;
                
                case 4:
                    pageManager.page4.slider_0 = (int)slider_0.Value;
                    pageManager.page4.slider_1 = (int)slider_1.Value;
                    pageManager.page4.slider_2 = (int)slider_2.Value;
                    pageManager.page4.slider_3 = (int)slider_3.Value;
                    pageManager.page4.slider_4 = (int)slider_4.Value;
                    pageManager.page4.slider_5 = (int)slider_5.Value;
                    pageManager.page4.slider_6 = (int)slider_6.Value;
                    pageManager.page4.slider_7 = (int)slider_7.Value;
                    break;
                
                case 5:
                    pageManager.page5.slider_0 = (int)slider_0.Value;
                    pageManager.page5.slider_1 = (int)slider_1.Value;
                    pageManager.page5.slider_2 = (int)slider_2.Value;
                    pageManager.page5.slider_3 = (int)slider_3.Value;
                    pageManager.page5.slider_4 = (int)slider_4.Value;
                    pageManager.page5.slider_5 = (int)slider_5.Value;
                    pageManager.page5.slider_6 = (int)slider_6.Value;
                    pageManager.page5.slider_7 = (int)slider_7.Value;
                    break;
                
                case 6:
                    pageManager.page6.slider_0 = (int)slider_0.Value;
                    pageManager.page6.slider_1 = (int)slider_1.Value;
                    pageManager.page6.slider_2 = (int)slider_2.Value;
                    pageManager.page6.slider_3 = (int)slider_3.Value;
                    pageManager.page6.slider_4 = (int)slider_4.Value;
                    pageManager.page6.slider_5 = (int)slider_5.Value;
                    pageManager.page6.slider_6 = (int)slider_6.Value;
                    pageManager.page6.slider_7 = (int)slider_7.Value;
                    break;
                
                case 7:
                    pageManager.page7.slider_0 = (int)slider_0.Value;
                    pageManager.page7.slider_1 = (int)slider_1.Value;
                    pageManager.page7.slider_2 = (int)slider_2.Value;
                    pageManager.page7.slider_3 = (int)slider_3.Value;
                    pageManager.page7.slider_4 = (int)slider_4.Value;
                    pageManager.page7.slider_5 = (int)slider_5.Value;
                    pageManager.page7.slider_6 = (int)slider_6.Value;
                    pageManager.page7.slider_7 = (int)slider_7.Value;
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
            volumeMixer.Show();
        }

        private void label_program1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void label_program2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void label_program4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void label_program5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void label_program6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void label_program7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

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
    }
}