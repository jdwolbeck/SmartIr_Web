#pragma checksum "C:\Projects\VisualStudios\SensorDataWeb\SensorDataWeb\Views\Home\WeatherView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d596c1eae8cfc54c114c0c66e117f9fbabb26a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeatherView), @"mvc.1.0.view", @"/Views/Home/WeatherView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WeatherView.cshtml", typeof(AspNetCore.Views_Home_WeatherView))]
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
#line 1 "C:\Projects\VisualStudios\SensorDataWeb\SensorDataWeb\Views\_ViewImports.cshtml"
using SensorDataWeb;

#line default
#line hidden
#line 2 "C:\Projects\VisualStudios\SensorDataWeb\SensorDataWeb\Views\_ViewImports.cshtml"
using SensorDataWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d596c1eae8cfc54c114c0c66e117f9fbabb26a2", @"/Views/Home/WeatherView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73e21b3c95bb778acbd3f51d88407b31ee633a08", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeatherView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Projects\VisualStudios\SensorDataWeb\SensorDataWeb\Views\Home\WeatherView.cshtml"
  
    ViewData["Title"] = "WeatherJs";

#line default
#line hidden
            BeginContext(47, 708, true);
            WriteLiteral(@"
<h2>WeatherJs</h2>
<p>City name:</p>
<p id=""name""></p>
<p>Temperature:</p>
<p id=""temp""></p>
<p>Humidity:</p>
<p id=""humidity""></p>
<button>Get Weather</button>

<script>
    $(document).ready(function () {
        $(""button"").click(function () {
            $.get(""http://api.openweathermap.org/data/2.5/forecast?lat=45.5579&lon=-94.1632&APPID=d3240fe7b5dc8ced58f7991381b5d90d&units=imperial"", function (response) {
                console.log(response);
                $(""#name"").text(response.city.name);
                $(""#temp"").text(response.list[0].main.temp);
                $(""#humidity"").text(response.list[0].main.humidity);
            });
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
