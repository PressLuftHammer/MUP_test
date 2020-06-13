#pragma checksum "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f903da762889568f17da91e6dba54a2df26a46c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\_ViewImports.cshtml"
using MUP_test;

#line default
#line hidden
#line 1 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
using MUP_test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f903da762889568f17da91e6dba54a2df26a46c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc358ff23b90a71be52d19ec7f0b236687e86673", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 721, true);
            WriteLiteral(@"<div>
    <div>
        <h1>Список заявок</h1>
    </div>
    <div>
        <div>
            <h3>Фильтры</h3>
        </div>
        <div>
            <div><h4>Статусы заявки</h4></div>
            <div>
                <label><input type=""checkbox"" id=""status_0"" value=""0"" checked />Открыта</label>
                <label><input type=""checkbox"" id=""status_1"" value=""1"" checked />Решена</label>
                <label><input type=""checkbox"" id=""status_2"" value=""2"" checked />Возврат</label>
                <label><input type=""checkbox"" id=""status_3"" value=""3"" checked />Закрыта</label>
            </div>
        </div>
        <div>
            <div><h4>Период времени</h4></div>
            <div>
");
            EndContext();
#line 22 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                  
                    DateTime finish = DateTime.Now;
                    DateTime start = finish.AddDays(-30.0);
                

#line default
#line hidden
            BeginContext(898, 61, true);
            WriteLiteral("                <label>С <input type=\"date\" id=\"start-period\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 959, "\"", 996, 1);
#line 26 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
WriteAttributeValue("", 967, start.ToString("yyyy-MM-dd"), 967, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(997, 76, true);
            WriteLiteral(" /></label>\r\n                <label>по <input type=\"date\" id=\"finish-period\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1073, "\"", 1111, 1);
#line 27 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
WriteAttributeValue("", 1081, finish.ToString("yyyy-MM-dd"), 1081, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1112, 154, true);
            WriteLiteral(" /></label>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <button id=\"btn_filter\">Обновить</button>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1267, 54, false);
#line 35 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Открыть заявку", "Create", "Request"));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 529, true);
            WriteLiteral(@"
    </div>
    <div>
        <table>
            <thead>
                <tr>
                    <th>№ Заявки</th>
                    <th>Текст заявка</th>
                    <th>Дата открытия</th>
                    <th>Текущее состояние</th>
                    <th>Движение</th>
                </tr>
            </thead>
            <tbody id=""filter_test""></tbody>
        </table>

    </div>

    <script type=""text/javascript"">

        function getStatusName(status) {
            const sts = [");
            EndContext();
            BeginContext(1851, 34, false);
#line 56 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                    Write(Html.Raw(StatusUtils.getJSArray()));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 129, true);
            WriteLiteral(" ];\r\n\r\n                return sts[status];\r\n        }\r\n\r\n        function getActionRequest(id) {\r\n            return   `<a href=\"");
            EndContext();
            BeginContext(2015, 30, false);
#line 62 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                          Write(Url.Action("Update","Request"));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 826, true);
            WriteLiteral(@"\\${id}"">Движение</a>`;
        }

        $(document).ready(function () {
            $(""#btn_filter"").click(function () {
                    const $filter_body = $(""#filter_test"");
                    const $btn = $(this);

                $filter_body.empty();
                $btn.prop(""disabled"", true);

                    let filt = [];


                    if ($(""#status_0"").prop(""checked""))
                    filt.push(0);

                    if ($(""#status_1"").prop(""checked""))
                    filt.push(1);

                    if ($(""#status_2"").prop(""checked""))
                    filt.push(2);

                    if ($(""#status_3"").prop(""checked""))
                    filt.push(3);


                $.ajax({
                    type:""POST"",
                    url: """);
            EndContext();
            BeginContext(2872, 25, false);
#line 91 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                     Write(Url.Action("RequestList"));

#line default
#line hidden
            EndContext();
            BeginContext(2897, 1236, true);
            WriteLiteral(@""",
                    data: {
                        statuses: filt,
                        start: $(""#start-period"").val(),
                        finish: $(""#finish-period"").val()
                    },
                    dataType:""json"",
                    cache: false,
                    traditional: true,
                    success: function (data) {
                            data.requests.forEach(r => {
                                const dt = new Date(r.reqCreateTime);

                                $filter_body.append(`<tr><td>${new Intl.NumberFormat('ru-RU', { minimumIntegerDigits: 6 }).format(r.reqID)}</td >
                                                    <td>${r.reqText}</td> <td>${dt.toLocaleDateString(""ru"")}</td>
                                                    <td>${getStatusName(r.curStatus)}</td >
                                                    <td>${getActionRequest(r.reqID)}</td></tr >`)
                        });
                    },
          ");
            WriteLiteral("          complete: function () {\r\n                        $btn.prop(\"disabled\", false);\r\n                    }\r\n                })\r\n\r\n\r\n\r\n            })\r\n            .click();\r\n        });\r\n    </script>\r\n</div>");
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
