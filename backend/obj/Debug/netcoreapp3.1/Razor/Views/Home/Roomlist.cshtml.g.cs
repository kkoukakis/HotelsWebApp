#pragma checksum "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89e4f307603eb04c576cc0c2cef56f16fd4de00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Roomlist), @"mvc.1.0.view", @"/Views/Home/Roomlist.cshtml")]
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
#line 1 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\_ViewImports.cshtml"
using HotelsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\_ViewImports.cshtml"
using HotelsWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89e4f307603eb04c576cc0c2cef56f16fd4de00", @"/Views/Home/Roomlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b66359452fa10b12c1efc8c1530a7eb4d657eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Roomlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelsWebApp.Models.WdaContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("materialboxed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Room", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating halfway-fab waves-effect waves-light background-color-kouk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
  
    ViewData["Title"] = "HotelsWebApp ~ Search results: "+ ViewBag.Search;
    ViewData["Background"] = "login";
    ViewData["Page"] = "Roomlist";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
                              
    if((string)ViewData["LoggedIn"] == "Y"){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
                                                                    
    }

    var search = ViewBag.Search;
    var city = (string)ViewBag.city;
    List<HotelsWebApp.Models.Room> rooms = Model.Room.ToList();
    List<HotelsWebApp.Models.Bookings> bookings = Model.Bookings.ToList();
    var roomtype = (string)ViewBag.roomtype;
    var parking = (string)ViewBag.parking;
    var wifi = (string)ViewBag.wifi;
    var petfriendly = (string)ViewBag.petfriendly;
   
    if(!string.IsNullOrEmpty(city)){
     rooms = rooms.Where(x => x.City == city).ToList();
    }

    if(!string.IsNullOrEmpty(roomtype))
    if(Int32.Parse(roomtype)>0){
    var type = Model.RoomType.Where(x => x.id == Int32.Parse(roomtype)).ToList().First();
     rooms = rooms.Where(x => x.RoomType == type.id).ToList();
    }

     if(!string.IsNullOrEmpty(parking)){
     rooms = rooms.Where(x => x.Parking == Int32.Parse(parking)).ToList();
    }
     if(!string.IsNullOrEmpty(wifi)){
     rooms = rooms.Where(x => x.Wifi == Int32.Parse(wifi)).ToList();
    }
     if(!string.IsNullOrEmpty(petfriendly)){
     rooms = rooms.Where(x => x.PetFriendly == Int32.Parse(petfriendly)).ToList();
    }

    if(!string.IsNullOrEmpty(ViewBag.pricefrom)){
      rooms = rooms.Where(x => x.Price >= Int32.Parse(ViewBag.pricefrom)).ToList();
    }
    if(!string.IsNullOrEmpty(ViewBag.pricetill)){
      rooms = rooms.Where(x => x.Price <= Int32.Parse(ViewBag.pricetill)).ToList();
    }
    if(!string.IsNullOrEmpty(ViewBag.datefrom) && !string.IsNullOrEmpty(ViewBag.datetill)){
      
      //CHECK DATES HERE
    }

    



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n\r\n<!-- MAIN CONTENT -->\r\n\r\n<div class=\"container\">\r\n  <div class=\"row login-kouk\">\r\n");
            WriteLiteral("    ");
#nullable restore
#line 66 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
Write(await Component.InvokeAsync("Searchbox", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </div>\r\n\r\n  <div class=\"row\">\r\n    <div class=\"col s12 background-color-kouk\">\r\n      <h6 class=\"white-text\">Search Results</h6>\r\n    </div>\r\n  </div>\r\n\r\n  <div class=\"row\">\r\n    \r\n    <!-- ROOMS -->\r\n\r\n");
#nullable restore
#line 79 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
      foreach (var room in rooms)  
    {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col s12 m12 l12\">\r\n      <div class=\"card\">\r\n        <div class=\"card-image horizontal\">\r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d89e4f307603eb04c576cc0c2cef56f16fd4de008699", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2575, "~/img/room_images/", 2575, 18, true);
#nullable restore
#line 85 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
AddHtmlAttributeValue("", 2593, room.Photo, 2593, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          <span class=\"card-title\">");
#nullable restore
#line 86 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
                              Write(room.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 87 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
               
            if((string)ViewData["LoggedIn"] == "Y"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89e4f307603eb04c576cc0c2cef56f16fd4de0010848", async() => {
                WriteLiteral("<i class=\"material-icons\">account_balance_wallet</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RoomId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
                                                                               WriteLiteral(room.RoomId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RoomId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RoomId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RoomId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 90 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
            }

          

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"card-content\">\r\n          <p>");
#nullable restore
#line 95 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
        Write(room.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          <p>RoomType=");
#nullable restore
#line 96 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
                 Write(room.RoomType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          <p>Price=");
#nullable restore
#line 97 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
              Write(room.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 98 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
            
            if((string)ViewData["LoggedIn"] != "Y"){
               

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
                                                                                                                                                                  
            }

            

          

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89e4f307603eb04c576cc0c2cef56f16fd4de0015319", async() => {
                WriteLiteral("<i class=\"material-icons left\">house</i>Check this room");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-RoomId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
                                                             WriteLiteral(room.RoomId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RoomId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-RoomId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["RoomId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 111 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Roomlist.cshtml"
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n<!-- ENDS OF MAIN CONTENT -->\r\n<div class=\"row\"></div>\r\n<div class=\"row\"></div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelsWebApp.Models.WdaContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
