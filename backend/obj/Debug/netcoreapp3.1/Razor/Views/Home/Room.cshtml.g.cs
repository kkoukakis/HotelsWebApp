#pragma checksum "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3d900fd1fbf17d0fa5ca681e636e38c04ff2da9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3d900fd1fbf17d0fa5ca681e636e38c04ff2da9", @"/Views/Home/Room.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b66359452fa10b12c1efc8c1530a7eb4d657eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Room : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/room_images/room-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
  
    ViewData["Title"] = "HotelsWebApp ~ Room";
    ViewData["Background"] = "login";
    ViewData["Page"] = "Room";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                              
    if(ViewData["LoggedIn"] == "Y"){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kkouk\Desktop\NetAcademy\HotelsWebApp\backend\Views\Home\Room.cshtml"
                                                                    
    }


     var data = ViewBag.Room;

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
      <span class=""favorites-title center  left"">Hilton~ </span>
      <!-- STAR RATING -->
      <span");
            BeginWriteAttribute("class", " class=\"", 796, "\"", 804, 0);
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
        <span class=""favorites-title center  right"">Per Night: 350euro<span>
      </div>
    </div>


    <!-- IMAGE OF ROOM-->
    <div class=""row"">
      <div class=""col s12 center"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d3d900fd1fbf17d0fa5ca681e636e38c04ff2da95678", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            <p class=""favorites-title center background-color-kouk2"">2</p>
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
            <p class=""favorites-title center background-color-kouk2"">1</p>
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
            <p class=""favorites-ti");
            WriteLiteral(@"tle center background-color-kouk2"">Yes</p>
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
        <p class=""favorites-title center "">Yes</p>
        </li>
        <li>
          <p class=""favorites-title center ""><i class=""material-icons prefix inline"">wifi</i>Wifi</p>
        </li>
      </div>
      <!-- PETS -->
      <div class=""col m2 s6"">
        <ul>
          <li>
        <p class=""favorites-title center "">Yes</p>
        </li>
        <li>
          <p class=""favorites-title center ""><i class=""material-icons prefix inline"">pets</i>Pets</p>
        </li>
      </div>
    </div>
    <!-- ROOM INSIGHTS ENDS HERE-->

    <!-- ROOM'S PROPERTIES -->
   <div class=""row background-color-kouk2 "">
    <p class=""favorites-title left"">Room De");
            WriteLiteral(@"scription</p>
    </div>
    <div class=""row background-color-kouk"">
    <p class=""favorites-title left"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Hic, modi nostrum blanditiis soluta dicta quo non saepe suscipit repellendus maiores nam animi quos excepturi! Enim labore ab aut culpa omnis!</p>
    </div>
    <div class=""row center"">
      <a class=""waves-effect waves-light btn""><i class=""material-icons left"">vpn_key</i>Login to book</a>

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
          <span class=""fa fa");
            WriteLiteral(@"-star checked""></span>
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
          <span class=""fa fa-star""></span>
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

</div");
            WriteLiteral(@">
</div>
<div class=""row""></div>
<div class=""row""></div>




</main>



<!-- ENDS OF MAIN CONTENT -->
 <script src=""https://unpkg.com/leaflet@1.6.0/dist/leaflet.js""
   integrity=""sha512-gZwIG9x3wUXg2hdXF6+rVkLF/0Vi9U8D2Ntg4Ga5I5BZpVkVxlJWbSQtXPSiUTtC0TjtGOmxa1AJPuV0CPthew==""");
            BeginWriteAttribute("crossorigin", "\r\n   crossorigin=\"", 5749, "\"", 5767, 0);
            EndWriteAttribute();
            WriteLiteral(@"></script>
    
   
   <script>
 
  
//  MAPS LEAFLET.JS

   var map = L.map('map',{
   center: [37.976703, 23.750417],
   zoom: 14
   });


   L.marker([37.976703, 23.750417]).bindTooltip(""Hilton"", 
   {
       permanent: true, 
       direction: 'bottom',
       
       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
