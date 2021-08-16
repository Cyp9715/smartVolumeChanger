using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartVolumeChanger
{
    class Page
    {
        public string id_0 = "null";
        public string id_1 = "null";
        public string id_2 = "null";
        public string id_3 = "null";
        public string id_4 = "null";
        public string id_5 = "null";
        public string id_6 = "null";
        public string id_7 = "null";

        public int slider_0 = 0;
        public int slider_1 = 0;
        public int slider_2 = 0;
        public int slider_3 = 0;
        public int slider_4 = 0;
        public int slider_5 = 0;
        public int slider_6 = 0;
        public int slider_7 = 0;
    }

    class PageManager
    {
        public delegate void delUpdateSlider(List<string> label, List<int> slider);

        delUpdateSlider sliderUpdate;

        public int currentPage { get; set; }
        
        public Page page0 = new Page();
        public Page page1 = new Page();
        public Page page2 = new Page();
        public Page page3 = new Page();
        public Page page4 = new Page();
        public Page page5 = new Page();
        public Page page6 = new Page();
        public Page page7 = new Page();

        public PageManager(delUpdateSlider slider)
        {
            currentPage = 0;
            sliderUpdate = slider;
        }

        public void updatePage(Page page)
        {
            List<int> list_slider = new List<int>();
            List<string> list_label = new List<string>();

            list_label.Add(page.id_0);
            list_label.Add(page.id_1);
            list_label.Add(page.id_2);
            list_label.Add(page.id_3);
            list_label.Add(page.id_4);
            list_label.Add(page.id_5);
            list_label.Add(page.id_6);
            list_label.Add(page.id_7);

            list_slider.Add(page.slider_0);
            list_slider.Add(page.slider_1);
            list_slider.Add(page.slider_2);
            list_slider.Add(page.slider_3);
            list_slider.Add(page.slider_4);
            list_slider.Add(page.slider_5);
            list_slider.Add(page.slider_6);
            list_slider.Add(page.slider_7);

            sliderUpdate(list_label, list_slider);
        }
    }
}
