using Asp_Practise_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_.ViewModels
{
    public class CourseVM
    {
        public List<Courses> Courses { get; set; }
        public List<Slider> Sliders { get; set; }
        public SliderContent SliderContents { get; set; }
    }
}
