#pragma checksum "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ba38d66aa0ee91433ceae633e9ec52892fddbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\_ViewImports.cshtml"
using HotelBooking;

#line default
#line hidden
#line 2 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\_ViewImports.cshtml"
using HotelBooking.Models;

#line default
#line hidden
#line 3 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\_ViewImports.cshtml"
using HotelBooking.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ba38d66aa0ee91433ceae633e9ec52892fddbb", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca1c4dcf3926c3d0c390790dd687941893ca2f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Room", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Room", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(65, 461, true);
            WriteLiteral(@"    <script>
        shortcut.add(""F1"", function () {
            location.href = './GetHelp#pr'
        });
    </script>
<!-- User profile page-->
<div class=""d-flex h-75 justify-content-center align-items-start mrt-35 mrb-15"">
    <div class=""container w-25"">
        <div class=""row justify-content-start align-items-center"">
            <div class=""col col-12 text-warning font-weight-bold"">
                FAVORITES
            </div>
        </div>
");
            EndContext();
#line 19 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
         if (Model.Favorites.Any()) {
            int i = 1;
            

#line default
#line hidden
#line 21 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
             foreach (var favorite in Model.Favorites) {

#line default
#line hidden
            BeginContext(644, 177, true);
            WriteLiteral("                <div class=\"row justify-content-center align-items-center\">\n                    <div class=\"col col-12\">\n                        <span class=\"font-weight-light\">");
            EndContext();
            BeginContext(822, 1, false);
#line 24 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(823, 65, true);
            WriteLiteral(" .</span>\n                        <span class=\"font-weight-bold\">");
            EndContext();
            BeginContext(889, 18, false);
#line 25 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                  Write(favorite.Room.Name);

#line default
#line hidden
            EndContext();
            BeginContext(907, 58, true);
            WriteLiteral("</span>\n                    </div>\n                </div>\n");
            EndContext();
#line 28 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                i++;
            }

#line default
#line hidden
#line 29 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
             
        } else {

#line default
#line hidden
            BeginContext(1017, 247, true);
            WriteLiteral("            <div class=\"row justify-content-center align-items-center\">\n                <div class=\"col col-12\">\n                    <span class=\"font-weight-light\">You don\'t have any favorites yet</span>\n                </div>\n            </div>\n");
            EndContext();
#line 36 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
        }

#line default
#line hidden
            BeginContext(1274, 192, true);
            WriteLiteral("        <div class=\"row justify-content-start align-items-center\">\n            <div class=\"col col-12 text-warning font-weight-bold\">\n                REVIEWS\n            </div>\n        </div>\n");
            EndContext();
#line 42 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
         if (Model.Reviews.Any()) {
            int i = 1;
            

#line default
#line hidden
#line 44 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
             foreach (var review in Model.Reviews) {

#line default
#line hidden
            BeginContext(1578, 177, true);
            WriteLiteral("                <div class=\"row justify-content-center align-items-center\">\n                    <div class=\"col col-12\">\n                        <span class=\"font-weight-light\">");
            EndContext();
            BeginContext(1756, 1, false);
#line 47 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1757, 63, true);
            WriteLiteral("</span>\n                        <span class=\"font-weight-bold\">");
            EndContext();
            BeginContext(1821, 16, false);
#line 48 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                  Write(review.Room.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1837, 175, true);
            WriteLiteral("</span>\n                    </div>\n                </div>\n                <div class=\"row justify-content-end align-items-start\">\n                    <div class=\"col col-12\">\n");
            EndContext();
#line 53 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                         for (int j = 0; j < review.Rate; j++) {

#line default
#line hidden
            BeginContext(2077, 61, true);
            WriteLiteral("                            <span class=\"fa fa-star\"></span>\n");
            EndContext();
#line 55 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                        }

#line default
#line hidden
            BeginContext(2164, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 56 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                         for (int j = 0; j < 5 - review.Rate; j++) {

#line default
#line hidden
            BeginContext(2233, 63, true);
            WriteLiteral("                            <span class=\"fa fa-star-o\"></span>\n");
            EndContext();
#line 58 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                        }

#line default
#line hidden
            BeginContext(2322, 50, true);
            WriteLiteral("                    </div>\n                </div>\n");
            EndContext();
#line 61 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                i++;
            }

#line default
#line hidden
#line 62 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
             
        } else {

#line default
#line hidden
            BeginContext(2424, 247, true);
            WriteLiteral("            <div class=\"row justify-content-center align-items-center\">\n                <div class=\"col col-12\">\n                    <span class=\"font-weight-light\">You haven\'t made any reviews yet</span>\n                </div>\n            </div>\n");
            EndContext();
#line 69 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
        }

#line default
#line hidden
            BeginContext(2681, 311, true);
            WriteLiteral(@"    </div>
    <div class=""container w-75"">
        <div class=""mrb-3"">
            <div class=""row justify-content-start align-items-center bg-warning"">
                <div class=""col col-auto font-weight-bold color-w"">
                    My Bookings
                </div>
            </div>
        </div>
");
            EndContext();
#line 79 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
         if (Model.Bookings.Any()) {
            

#line default
#line hidden
#line 80 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
             foreach (var booking in Model.Bookings) {

#line default
#line hidden
            BeginContext(3084, 107, true);
            WriteLiteral("                <div class=\"row\">\n                    <div class=\"col col-2 pl-0\">\n                        ");
            EndContext();
            BeginContext(3191, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b17e0b08932e4f729d6bc551aefd6e6f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3201, "~/lib/images/room-photos/", 3201, 25, true);
#line 83 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
AddHtmlAttributeValue("", 3226, booking.Room.Photo, 3226, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3267, 128, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"col col-10\">\n                        <span class=\"font-weight-bold\">");
            EndContext();
            BeginContext(3396, 17, false);
#line 86 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                  Write(booking.Room.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3413, 68, true);
            WriteLiteral("</span> <br />\n                        <span class=\"hotel-location\">");
            EndContext();
            BeginContext(3482, 17, false);
#line 87 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                Write(booking.Room.City);

#line default
#line hidden
            EndContext();
            BeginContext(3499, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(3502, 17, false);
#line 87 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                                    Write(booking.Room.Area);

#line default
#line hidden
            EndContext();
            BeginContext(3519, 117, true);
            WriteLiteral("</span> <br />\n                        <span class=\"font-weight-light hotel-desc-short\" id=\"hotel-short-description\">");
            EndContext();
            BeginContext(3637, 29, false);
#line 88 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                                                                 Write(booking.Room.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(3666, 151, true);
            WriteLiteral("</span>\n                    </div>\n                </div>\n                <div class=\"row justify-content-end align-items-center\">\n                    ");
            EndContext();
            BeginContext(3817, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8b3760293034a729a19f7fc0e3cf3c3", async() => {
                BeginContext(3936, 15, true);
                WriteLiteral("Go to Room Page");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                                                     WriteLiteral(booking.RoomId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3955, 165, true);
            WriteLiteral("\n                </div>\n                <div class=\"row mrb-15 mrt-1\">\n                    <div class=\"col col-2 price-bar pl-0\">\n                        Per Night: ");
            EndContext();
            BeginContext(4121, 18, false);
#line 96 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                              Write(booking.Room.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4139, 122, true);
            WriteLiteral("&euro;\n                    </div>\n                    <div class=\"col col-3 dash\">\n                        Check in Date: ");
            EndContext();
            BeginContext(4262, 19, false);
#line 99 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                  Write(booking.CheckInDate);

#line default
#line hidden
            EndContext();
            BeginContext(4281, 223, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"col col-auto dash\">\n                        |\n                    </div>\n                    <div class=\"col col-3 dash\">\n                        Check Out Date : ");
            EndContext();
            BeginContext(4505, 20, false);
#line 105 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                    Write(booking.CheckOutDate);

#line default
#line hidden
            EndContext();
            BeginContext(4525, 220, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"col col-auto dash\">\n                        |\n                    </div>\n                    <div class=\"col col-3 dash\">\n                        Type of Room: ");
            EndContext();
            BeginContext(4746, 31, false);
#line 111 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
                                 Write(booking.Room.RoomType.RoomType1);

#line default
#line hidden
            EndContext();
            BeginContext(4777, 51, true);
            WriteLiteral("\n                    </div>\n                </div>\n");
            EndContext();
#line 114 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
            }

#line default
#line hidden
#line 114 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
             
        } else {

#line default
#line hidden
            BeginContext(4859, 172, true);
            WriteLiteral("            <div class=\"row\">\n                <div class=\"col col-12 font-weight-light\">\n                    No bookings to show.\n                </div>\n            </div>\n");
            EndContext();
#line 121 "C:\Users\oleksandr.papirnyk\Desktop\HotelBooking-master\Views\Home\Profile.cshtml"
        }

#line default
#line hidden
            BeginContext(5041, 52, true);
            WriteLiteral("    </div>\n</div>\n<!-- End of User Profile Page-->\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591