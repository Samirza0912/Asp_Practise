#pragma checksum "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea739f454913f0bc8486f23106730a6ec2506ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea739f454913f0bc8486f23106730a6ec2506ee", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b4373f8aae9ee30c93d37819038552c14a01ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Blog\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>blog</h2>
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
");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Blog\Index.cshtml"
             foreach (var item in Model.Blogs)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                <div class=\"single-blog mb-60\">\r\n                    <div class=\"blog-img\">\r\n                        <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 927, "\"", 956, 2);
            WriteAttributeValue("", 933, "img/blog/", 933, 9, true);
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Blog\Index.cshtml"
WriteAttributeValue("", 942, item.ImageUrl, 942, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""blog""></a>
                        <div class=""blog-hover"">
                            <i class=""fa fa-link""></i>
                        </div>
                    </div>
                    <div class=""blog-content"">
                        <div class=""blog-top"">
                            <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                        </div>
                        <div class=""blog-bottom"">
                            <h2><a href=""blog-details.html"">");
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Blog\Index.cshtml"
                                                       Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\r\n                            <a href=\"blog-details.html\">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\Asp-Practise_\Asp-Practise_\Views\Blog\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""pagination"">
                    <ul>
                        <li><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                    </ul>
                </div>
            </div>
        </div>
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
                    <form action=""http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"" method=""post"" id=""mc-embedded-subsc");
            WriteLiteral("ribe-form\" name=\"mc-embedded-subscribe-form\" class=\"validate\" target=\"_blank\" novalidate>\r\n                        <div id=\"mc_embed_signup_scroll\" class=\"mc-form\">\r\n                            <input type=\"email\"");
            BeginWriteAttribute("value", " value=\"", 2919, "\"", 2927, 0);
            EndWriteAttribute();
            WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                            <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                            <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
            BeginWriteAttribute("value", " value=\"", 3310, "\"", 3318, 0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
