#pragma checksum "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57a8a1afcba4c5efbab805c10556ca579bc55a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Room), @"mvc.1.0.view", @"/Views/Home/Room.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57a8a1afcba4c5efbab805c10556ca579bc55a4", @"/Views/Home/Room.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b66359452fa10b12c1efc8c1530a7eb4d657eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Room : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<HotelsWebApp.Models.Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
  
    ViewData["Title"] = "HotelsWebApp ~ Room";
    ViewData["Background"] = "login";
    ViewData["Page"] = "Room";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                              
    if(ViewData["LoggedIn"] == "Y"){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                                    
    }


     var data = ViewBag.Room;

     var room = Model.First();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>

<!-- MAIN CONTENT -->

<div class=""container"">
  <div class=""row show-on-small""></div>
  <div class=""row"">
  <div class=""col s12 m12"">
    <!-- TITLE , STAR RATINGS, PRICE PER NIGHT -->
    <div class=""row background-color-kouk2"">
      <div class=""col s6"">
      <!-- TITLE OF ROOM -->
      <span class=""favorites-title center  left"">");
#nullable restore
#line 30 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                            Write(room.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n      <!-- STAR RATING -->\r\n      <span");
            BeginWriteAttribute("class", " class=\"", 901, "\"", 909, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <span class=""fa fa-star checked""></span>
        <span class=""fa fa-star checked""></span>
        <span class=""fa fa-star checked""></span>
        <span class=""fa fa-star""></span>
        <span class=""fa fa-star""></span>
      </span>
      </div>
      <div class=""col s6"">
        <span class=""favorites-title center  right"">Per Night: ");
#nullable restore
#line 41 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                           Write(room.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("euro<span>\r\n      </div>\r\n    </div>\r\n\r\n\r\n    <!-- IMAGE OF ROOM-->\r\n    <div class=\"row\">\r\n      <div class=\"col s12 center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e57a8a1afcba4c5efbab805c10556ca579bc55a45963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1426, "~/img/room_images/", 1426, 18, true);
#nullable restore
#line 49 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
AddHtmlAttributeValue("", 1444, room.Photo, 1444, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
    </div>   

    <!-- ROOM INSIGHTS START HERE-->
    <div class=""row center background-color-kouk2"">
      <div class=""col m3 s4"">
        <ul>
          <li>
            <!-- GET TYPE OF ROOM -->
            <p class=""favorites-title center background-color-kouk2"">");
#nullable restore
#line 59 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                                Write(room.CountOfGuests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
          </li>
          <li>
            <p class=""favorites-title center background-color-kouk2""><i class=""material-icons prefix inline"">people</i> Guests</p>
          </li>

        </ul>
      </div>
      <!-- GET TYPE OF ROOM -->
      <div class=""col m2 s4"">
        <ul>
          <li>
            <p class=""favorites-title center background-color-kouk2"">");
#nullable restore
#line 71 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                                Write(room.RoomType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
          </li>
          <li>
            <p class=""favorites-title center background-color-kouk2""><i class=""material-icons prefix inline"">meeting_room</i>Type of room</p>
          </li>
        </ul>
      </div>
      <!-- PARKING -->
      <div class=""col m2 s4"">
        <ul>
          <li>
            <p class=""favorites-title center background-color-kouk2"">");
#nullable restore
#line 82 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                                       if(room.Parking==1){ WriteLiteral("Yes"); }else{WriteLiteral("No");}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
          </li>
          <li>
            <p class=""favorites-title center background-color-kouk2""><i class=""material-icons prefix inline"">local_parking</i>Parking</p>
          </li>
        </ul>
      </div>
      <!-- WIFI -->
      <div class=""col m2 s6"">
        <ul>
          <li>
        <p class=""favorites-title center "">");
#nullable restore
#line 93 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                             if(room.Wifi==1){ WriteLiteral("Yes"); }else{WriteLiteral("No");}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </li>
        <li>
          <p class=""favorites-title center ""><i class=""material-icons prefix inline"">wifi</i>Wifi</p>
        </li>
      </div>
      <!-- PETS -->
      <div class=""col m2 s6"">
        <ul>
          <li>
        <p class=""favorites-title center "">");
#nullable restore
#line 103 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                             if(room.PetFriendly==1){ WriteLiteral("Yes"); }else{WriteLiteral("No");}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </li>
        <li>
          <p class=""favorites-title center ""><i class=""material-icons prefix inline"">pets</i>Pets</p>
        </li>
      </div>
    </div>
    <!-- ROOM INSIGHTS ENDS HERE-->

    <!-- ROOM'S PROPERTIES -->
   <div class=""row background-color-kouk2 "">
    <p class=""favorites-title left"">Room Description</p>
    </div>
    <div class=""row background-color-kouk"">
    <p class=""favorites-title left"">");
#nullable restore
#line 117 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                               Write(room.LongDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"favorites-title left black-text\">Location:");
#nullable restore
#line 118 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                   Write(room.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"row center\">\r\n      <a class=\"waves-effect waves-light btn\"><i class=\"material-icons left\">vpn_key</i>Login to book</a>\r\n      \r\n");
            WriteLiteral(@"

    </div>
  

   <!-- MAP ROOM'S PROPERTIES -->
   <div class=""row background-color-kouk2"">
    <div id=""map""></div>
  </div>
   
   <!-- ROOM'S PROPERTIES -->
   <div class=""row background-color-kouk2 "">
    <p class=""favorites-title left"">Reviews</p>
  </div>
  <div class=""row background-color-kouk2 "">
    <ul class=""collection"">
      <li class=""collection-item""><a>Hilton</a>
        <span class=""right"">
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star""></span>
          <span class=""fa fa-star""></span>
        </span>
      </li>
      <li class=""collection-item""><a>Hilton</a>
        <span class=""right"">
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star""></span>
          <span class=""fa fa-star""></sp");
            WriteLiteral(@"an>
        </span>
      </li>
      <li class=""collection-item""><a>Hilton</a>
        <span class=""right"">
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star checked""></span>
          <span class=""fa fa-star""></span>
          <span class=""fa fa-star""></span>
        </span>
      </li>
    </ul>
  </div>
     <!-- ROOM'S PROPERTIES -->
     <div class=""row background-color-kouk2 "">
      <p class=""favorites-title  left"">Add Review</p>
    </div>
    <div class=""row"">
      <input>
    </div>

</div>
</div>
<div class=""row""></div>
<div class=""row""></div>




</main>



<!-- ENDS OF MAIN CONTENT -->
 <script src=""https://unpkg.com/leaflet@1.6.0/dist/leaflet.js""
   integrity=""sha512-gZwIG9x3wUXg2hdXF6+rVkLF/0Vi9U8D2Ntg4Ga5I5BZpVkVxlJWbSQtXPSiUTtC0TjtGOmxa1AJPuV0CPthew==""");
            BeginWriteAttribute("crossorigin", "\r\n   crossorigin=\"", 6212, "\"", 6230, 0);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n    \r\n   \r\n   <script>\r\n \r\n  \r\n//  MAPS LEAFLET.JS\r\n\r\n   var map = L.map(\'map\',{\r\n   center: [");
#nullable restore
#line 201 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
       Write(room.LatLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 201 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                          Write(room.LngLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("],\r\n   zoom: 14\r\n   });\r\n\r\n\r\n   L.marker([");
#nullable restore
#line 206 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
        Write(room.LatLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 206 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                           Write(room.LngLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("]).bindTooltip(\"");
#nullable restore
#line 206 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                            Write(room.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", 
   {
       permanent: true, 
       direction: 'bottom'
       
   }).addTo(map);
 
       
   L.tileLayer('http://{s}.tile.osm.org/{z}/{x}/{y}.png', {
   attribution: '&copy; <a href=""http://osm.org/copyright"">OpenStreetMap</a> contributors'
   }).addTo(map);


 </script>



<!-- MAP CONTENT -->


  

   
  
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<HotelsWebApp.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
