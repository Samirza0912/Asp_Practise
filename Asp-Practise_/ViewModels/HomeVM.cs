using Asp_Practise_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderContent SliderContents { get; set; }
        public List<Notice> NoticeLeftSides { get; set; }
        public List<NoticeRight> NoticeRightSides { get; set; }
        public List<Courses> Courses { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Events> Event { get; set; }
    }
}
