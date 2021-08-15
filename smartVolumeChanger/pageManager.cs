using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartVolumeChanger
{
    class Page
    {
        public int slider_0 = 0;
        public int slider_1 = 0;
        public int slider_2 = 0;
        public int slider_3 = 0;
        public int slider_4 = 0;
        public int slider_5 = 0;
        public int slider_6 = 0;
        public int slider_7 = 0;
        public int slider_8 = 0;
    }

    class PageManager
    {
        public delegate void delUpdateSlider(List<int> slider);

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
            List<int> material = new List<int>();

            material.Add(page.slider_0);
            material.Add(page.slider_1);
            material.Add(page.slider_2);
            material.Add(page.slider_3);
            material.Add(page.slider_4);
            material.Add(page.slider_5);
            material.Add(page.slider_6);
            material.Add(page.slider_7);

            sliderUpdate(material);
        }
    }
}
