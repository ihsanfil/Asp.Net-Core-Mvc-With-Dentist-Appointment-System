#pragma checksum "C:\Users\MSİ\Desktop\Dentist-System\DentistCalendar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb29b1caaab950f4aea559c50e044f17720ae065"
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
#line 1 "C:\Users\MSİ\Desktop\Dentist-System\DentistCalendar\Views\_ViewImports.cshtml"
using DentistCalendar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb29b1caaab950f4aea559c50e044f17720ae065", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1079278a60b32d066d3d39218dd5d9b8626b072", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/timegrid/main.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/core/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/timegrid/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fullcalendar/bootstrap/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\MSİ\Desktop\Dentist-System\DentistCalendar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link href=\'/lib/fullcalendar/core/main.css\' rel=\'stylesheet\' />\r\n    <link href=\'/lib/fullcalendar/daygrid/main.css\' rel=\'stylesheet\' />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eb29b1caaab950f4aea559c50e044f17720ae0655195", async() => {
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
                WriteLiteral("\r\n    <link href=\"/lib/fullcalendar/bootstrap/main.css\" rel=\"stylesheet\" />\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div id=\"calendar\"></div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb29b1caaab950f4aea559c50e044f17720ae0656782", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\'/lib/fullcalendar/daygrid/main.js\'></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb29b1caaab950f4aea559c50e044f17720ae0657948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb29b1caaab950f4aea559c50e044f17720ae0659047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""/lib/fullcalendar/core/locales/tr.js""></script> <!--TÜRKÇE DİL PAKETİ-->
    <script>
        document.addEventListener('DOMContentLoaded', function () {
            var calendarEl = document.getElementById('calendar');

            var calendar = new FullCalendar.Calendar(calendarEl, {
                plugins: ['dayGrid', 'timeGrid', 'bootstrap'],
                themeSystem: 'bootstrap',
                bootstrapFontAwesome: {
                    dayGridMonth: 'calendar', // dayGridMonth isim değilde takvim iconu olarak görünecek fontawesome class'ı yazdık buraya
                    prev: 'fa-chevron-circle-left',
                    next: 'fa-chevron-circle-right'
                },
                locale: 'tr', //TÜRKÇE DİL DESTEĞİ
                header: {
                    left: 'prev, next, today, getDate', //solda ileri ve geri olsun
                    center: 'title', //başlık ortada olsun
                    right: 'dayGridMonth, timeGridWeek, timeGridDay, time");
                WriteLiteral(@"GridForFourDay' //sağda ay olsun //timeGridForFourDay ile kendimiz kısıtlama oluşturduk 4 gün
                },
               footer: {
                    left: 'prevYear', //solda ileri ve geri olsun
                    // center: 'title', //başlık ortada olsun
                    right: 'nextYear' //sağda ay olsun //timeGridForFourDay ile kendimiz kısıtlama oluşturduk 4 gün
                },   
               /******== SAAT AYARLARI ==********/
                //  slotDuration: '00:15:00', //takvimdeki saat aralıklarını burada belirliyoruz ***
               //   slotLabelInterval: '00:15:00', // kaç dakika aralıklarla satırlarda saat bilgisi yazsın
                //  slotLabelFormat: { // tam saatleride 6:00 6:30 gibi göster dedik default olarak sadece 6 diyodu
               //     hour: '2-digit',
               //     minute: '2-digit'
                   // meridiem: 'short' dil en olduğunda saatleri 06:00am gibi göstermeye yarıyor
               // },
                handleWindowRes");
                WriteLiteral(@"ize: true,
                windowResizeDelay: 1000, //ekran küçüldükten ne kadar sonra takvim ekrana göre boyutlansın default olarak 100
                windowResize: function (view) {
                    alert('Takvim Yeniden Boyutlandırıldı');
                },
                //Height: 450,
                //contentHeight: 650, //takvimin içerik yüksekliği 650px olsun dedik
                //aspectRatio: 5, //satır sütun boyutlandırma her bir karede diyebiliriz
                defaultView: 'dayGridMonth', //takvim default olarak aylık görüntü şekilde gelsin 
                // weekends: false //takvim haftasonu günleri göstermesin dedik
                weekends: true, //haftasonu gizle/göster 
                allDaySlot: false, // takvim en üst bölümündeki tüm gün satırını kaldırdık. 
               // firstDay: 0, // default olarak ilk gün pazar olsun bunun eklemeseydik pazartesi ilk gün hangi gündeysek o günden takvimi başlatmak içinde kullanabiliriz
                titleFormat: {
        ");
                WriteLiteral(@"            year: 'numeric',
                    month: 'long',
                    day: 'numeric'

                },
                titleRangeSeparator: ' / ', //başlıkta ayraç olarak bunu kullan dedik
                columnHeaderFormat: { //takvim üst kolandaki görünüm ayarları ay ve günü göster
                    //month: 'numeric',
                    weekday: 'long'
                    //day: 'numeric'
                },
                views: {
                    timeGridForFourDay: { //sadece 4 günü göstersin dedik bunu özel olarak oluşturduk.
                        type: 'timeGrid',
                      //dayCount: 4, // bulunduğun tarihten itibaren önündeki 4 günü gösterir gizlenmiş gün varsa onları atlar cumartesi pazarı atlar pazartesiyi gösterir ***
                        duration: {days:4}, //4 dediğimizde bulunduğun tarihten itibaren gizlenmiş gün varsa onları göstermez cuma bakan biri cuma ve pazartesiyi görür
                        buttonText: '4 Gün'
                 ");
                WriteLiteral(@"   }
                },
                customButtons: {
                    getDate: {
                        text: 'date',
                        click: function () {
                            var date = new Date();
                            alert(date);
                        }
                    }
                }
                
                //buttonText: {
                //    today: 'Bugün gün',
                //    month: 'Ay ve ay',
                //    week: 'hafta mı hafta',
                //    day : 'gün gün'
                //}
            });

            calendar.render();
        })
    </script>
");
            }
            );
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
