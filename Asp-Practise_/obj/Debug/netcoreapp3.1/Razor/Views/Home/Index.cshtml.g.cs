#pragma checksum "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85077bf6fee7d00f8b6f23a64be78c57d5754fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\_ViewImports.cshtml"
using Asp_Practise_.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85077bf6fee7d00f8b6f23a64be78c57d5754fba", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b4373f8aae9ee30c93d37819038552c14a01ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"slider-container\" class=\"slider-area\">\r\n");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
     foreach (var item in Model.Sliders)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"slider-owl owl-theme owl-carousel\">\r\n        <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 304, "\"", 360, 4);
            WriteAttributeValue("", 312, "background-image:", 312, 17, true);
            WriteAttributeValue(" ", 329, "url(img/slider/", 330, 16, true);
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
WriteAttributeValue("", 345, item.ImageUrl, 345, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 359, ")", 359, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""slider-content-area"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-7 col-md-offset-left-5"">
                            <div class=""slide-content-wrapper"">
                                <div class=""slide-content"">
                                    ");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                               Write(Html.Raw(Model.SliderContents.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <p>");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                  Write(Model.SliderContents.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                    <a class=""default-btn"" href=""about.html"">learn more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
");
#nullable restore
#line 32 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
        }     

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>

<section class=""notice-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left"">
                    <h3>notice board</h3>
");
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                     foreach (var item in Model.NoticeLeftSides)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-notice-left mb-25 pb-25\">\r\n                            <h4>");
#nullable restore
#line 44 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                          Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                <div class=\"notice-right\">\r\n");
#nullable restore
#line 52 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                     foreach (var item in Model.NoticeRightSides)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-notice-right mb-25 pb-25\">\r\n                            <h3>");
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 56 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                          Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>

<section class=""choose-area pb-85 pt-77"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4"">
                <div class=""choose-content text-left"">
                    <h2>WHY YOU CHOOSE EDUHOME ?</h2>
                    <p>I must explain to you how all this mistaken idea of denouncing pleure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder of humanit happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because. </p>
                    <p class=""choose-option"">I must explain to you how all this mistaken idea of denouncing pleure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder. </p>
                    <a class=""default-bt");
            WriteLiteral(@"n"" href=""course-details.html"">view courses</a>
                </div>
            </div>
        </div>
    </div>
</section>

<div class=""courses-area pt-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>COURSES WE OFFER</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 91 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
             foreach (var item in Model.Courses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-course\">\r\n                        <div class=\"course-img\">\r\n                            <a href=\"course-details.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 4045, "\"", 4076, 2);
            WriteAttributeValue("", 4051, "img/course/", 4051, 11, true);
#nullable restore
#line 97 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
WriteAttributeValue("", 4062, item.ImageUrl, 4062, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""course"">
                                <div class=""course-hover"">
                                    <i class=""fa fa-link""></i>
                                </div>
                            </a>
                        </div>
                        <div class=""course-content"">
                            <h3><a href=""course-details.html"">");
#nullable restore
#line 104 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>");
#nullable restore
#line 105 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                          Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 110 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-4 hidden-sm col-xs-12"">
                <div class=""single-course"">
                    <div class=""course-img"">
                        <a href=""course-details.html"">
                            <img src=""img/course/course3.jpg"" alt=""course"">
                            <div class=""course-hover"">
                                <i class=""fa fa-link""></i>
                            </div>
                        </a>
                    </div>
                    <div class=""course-content"">
                        <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                        <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                        <a class=""default-btn"" href=""course-details.html"">read more</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""event-area one text-center pt-140 p");
            WriteLiteral(@"b-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>UPCOMMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
        <div class=""col-md-6 col-sm-12 col-xs-12"">
");
#nullable restore
#line 144 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
             foreach (var item in Model.Event)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"single-event mb-35\">\r\n                    <div class=\"event-date\">\r\n                        <h3><a href=\"event-details.html\">");
#nullable restore
#line 148 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                    Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                    </div>\r\n                    <div class=\"event-content text-left\">\r\n                        <div class=\"event-content-left\">\r\n                            <h4><a href=\"event-details.html\">");
#nullable restore
#line 152 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <ul>\r\n                                <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 154 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                            Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 155 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                               Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                            </ul>
                        </div>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 163 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""single-event"">
                <div class=""event-date"">
                    <h3><a href=""event-details.html"">14 <span>June</span></a></h3>
                </div>
                <div class=""event-content text-left"">
                    <div class=""event-content-left"">
                        <h4><a href=""event-details.html"">GLOBAL ECONOMIC CONFERENCE</a></h4>
                        <ul>
                            <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                        </ul>
                    </div>
                    <div class=""event-content-right"">
                        <a class=""default-btn"" href=""event-details.html"">join now</a>
                    </div>
                </div>
            </div>
        </div>
       
        <div class=""row"">
");
#nullable restore
#line 184 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
             foreach (var item in Model.Event)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-sm-12 col-xs-12\">\r\n                    <div class=\"single-event mb-35\">\r\n                        <div class=\"event-date\">\r\n                            <h3><a href=\"event-details.html\">");
#nullable restore
#line 190 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                        Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                        </div>\r\n                        <div class=\"event-content text-left\">\r\n                            <div class=\"event-content-left\">\r\n                                <h4><a href=\"event-details.html\">");
#nullable restore
#line 194 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <ul>\r\n                                    <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 196 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                                Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 197 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                                   Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                            <div class=\"event-content-right\">\r\n                                <a class=\"default-btn\" asp-controller=\"Event\" asp-action=\"EventDetail\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 9045, "\"", 9068, 1);
#nullable restore
#line 201 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
WriteAttributeValue("", 9060, item.Id, 9060, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">join now</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 206 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

        </div>
        
    </div>
    </div>
    

<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
                <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                    <div class=""single-testimonial"">
                        <div class=""testimonial-info"">
                            <div class=""testimonial-img"">
                                <img src=""img/testimonial/testimonial.jpg"" alt=""testimonial"">
                            </div>
                            <div class=""testimonial-content"">
                                <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and expound the actual</p>
                                <h4>David Morgan</h4>
                                <h5>Student, CSE</h5>
                     ");
            WriteLiteral(@"       </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>LATEST FROM BLOG</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 249 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
             foreach (var item in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"blog-img\">\r\n                            <a href=\"blog-details.html\"><img");
            BeginWriteAttribute("src", " src=\"", 11074, "\"", 11103, 2);
            WriteAttributeValue("", 11080, "img/blog/", 11080, 9, true);
#nullable restore
#line 254 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
WriteAttributeValue("", 11089, item.ImageUrl, 11089, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""blog""></a>
                            <div class=""blog-hover"">
                                <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                            </div>
                        </div>
                        <div class=""blog-content"">
                            <div class=""blog-top"">
                                <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                            </div>
                            <div class=""blog-bottom"">
                                <h2><a href=""blog-details.html"">");
#nullable restore
#line 264 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
                                                           Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\r\n                                <a href=\"blog-details.html\">read more</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 270 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>

<div class=""subscribe-area pt-60 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2"">
                <div class=""subscribe-content section-title text-center"">
                    <h2>subscribe our newsletter</h2>
                    <p>I must explain to you how all this mistaken idea </p>
                </div>
                <div class=""newsletter-form mc_embed_signup"">
                    <form action=""http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"" method=""post"" id=""mc-embedded-subscribe-form"" name=""mc-embedded-subscribe-form"" class=""validate"" target=""_blank"" novalidate>
                        <div id=""mc_embed_signup_scroll"" class=""mc-form"">
                            <input type=""email""");
            BeginWriteAttribute("value", " value=\"", 12796, "\"", 12804, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
            BeginWriteAttribute("value", " value=\"", 13187, "\"", 13195, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                            <button id=""mc-embedded-subscribe"" class=""default-btn"" type=""submit"" name=""subscribe""><span>subscribe</span></button>
                        </div>
                    </form>
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
