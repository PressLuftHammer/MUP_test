#pragma checksum "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f390f085627cb6f72d2b5c43bbf3c200826557"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f390f085627cb6f72d2b5c43bbf3c200826557", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc358ff23b90a71be52d19ec7f0b236687e86673", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 1832, true);
            WriteLiteral(@"<div>
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item"">Список заявок</li>
    </ol>
</div>
<div class=""row align-item-center"">
    <div class=""col-md-2"">
        <div class=""text-center"">
            <h4 >Фильтры:</h4>
        </div>
        <div class=""row"">
            <div class=""col-md-12""><h5>Статусы заявки:</h5></div>
            <div class=""col-md-12"">
                <div class=""row"">
                    <div class=""col-md-2"">
                        <input type=""checkbox"" id=""status_0"" value=""0"" checked />
                    </div>
                    <div class=""col-md-10"">
                        Открыта
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-2"">
                        <input type=""checkbox"" id=""status_1"" value=""1"" checked />
                    </div>
                    <div class=""col-md-10"">
                        Решена
                    </div>
                </d");
            WriteLiteral(@"iv>
                <div class=""row"">
                    <div class=""col-md-2"">
                        <input type=""checkbox"" id=""status_2"" value=""2"" checked />
                    </div>
                    <div class=""col-md-10"">
                        Возврат
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-2"">
                        <input type=""checkbox"" id=""status_3"" value=""3"" checked />
                    </div>
                    <div class=""col-md-10"">
                        Закрыта
                    </div>
                </div>
            </div>  
            

        </div>
        <div  class=""row"">
            <div class=""col-md-12""><h5>Период времени:</h5></div>
            
");
            EndContext();
#line 54 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                  
                    DateTime finish = DateTime.Now;
                    DateTime start = finish.AddDays(-30.0);
                

#line default
#line hidden
            BeginContext(2009, 131, true);
            WriteLiteral("               <div class=\"col-md-2 text-right\">С</div>\r\n               <div class=\"col-md-10\"><input type=\"date\" id=\"start-period\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2140, "\"", 2177, 1);
#line 59 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
WriteAttributeValue("", 2148, start.ToString("yyyy-MM-dd"), 2148, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2178, 143, true);
            WriteLiteral("/></div>\r\n               <div class=\"col-md-2 text-right\">по</div>\r\n               <div class=\"col-md-10\"><input type=\"date\" id=\"finish-period\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2321, "\"", 2359, 1);
#line 61 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
WriteAttributeValue("", 2329, finish.ToString("yyyy-MM-dd"), 2329, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2360, 290, true);
            WriteLiteral(@" /></div>
               
               <div class=""col-md-12 text-center py-5"">
                   <button id=""btn_filter"" class=""btn btn-primary"">Обновить</button>
               </div>
        </div>
        
    </div>

    <div class=""col-md-10"">
        <div>
            ");
            EndContext();
            BeginContext(2651, 96, false);
#line 72 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Открыть заявку", "Create", "Request", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(2747, 693, true);
            WriteLiteral(@"
        </div>
        <div>
            <table class=""table table-striped table-bordered"" id=""request_list"">
                <thead class=""thread-dark"">
                    <tr>
                        <th scope=""col"">№ Заявки</th>
                        <th scope=""col"">Текст заявки</th>
                        <th scope=""col"">Дата открытия</th>
                        <th scope=""col"">Текущее состояние</th>
                    </tr>
                </thead>
                <tbody id=""filter_test""></tbody>
            </table>

        </div>
    </div>

</div>

<script type=""text/javascript"">

        function getStatusName(status) {
            const sts = [");
            EndContext();
            BeginContext(3441, 34, false);
#line 95 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                    Write(Html.Raw(StatusUtils.getJSArray()));

#line default
#line hidden
            EndContext();
            BeginContext(3475, 127, true);
            WriteLiteral(" ];\r\n\r\n                return sts[status];\r\n        }\r\n\r\n        function getActionRequest(id) {\r\n            return `<a href=\"");
            EndContext();
            BeginContext(3603, 30, false);
#line 101 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                        Write(Url.Action("Update","Request"));

#line default
#line hidden
            EndContext();
            BeginContext(3633, 467, true);
            WriteLiteral(@"\\${id}"">${new Intl.NumberFormat('ru-RU', { minimumIntegerDigits: 6 }).format(id)}</a>`;
        }


        const sorting = [[2, 0]];

        $(document).ready(function () {

            //настройка сортировки по статусу
            $.tablesorter.addParser({
                id: ""status"",
                is: function () {
                    return false;
                },
                format: function (str) {
                    const sts = [");
            EndContext();
            BeginContext(4101, 34, false);
#line 116 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                            Write(Html.Raw(StatusUtils.getJSArray()));

#line default
#line hidden
            EndContext();
            BeginContext(4135, 1121, true);
            WriteLiteral(@" ];

                    return sts.indexOf(str);
                },
                type:""numeric""
            });


            $(""#request_list"").tablesorter({
                headers: {
                    0: { sorter: false },
                    1: { sorter: false },
                    3: {sorter:""status""}
                },
                sortList:sorting
            });

            $(""#btn_filter"").click(function () {
                const $filter_body = $(""#filter_test"");
                const $btn = $(this);

                $filter_body.empty();
                $btn.prop(""disabled"", true);

                const filt = [];

                if ($(""#status_0"").prop(""checked""))
                    filt.push(0);

                if ($(""#status_1"").prop(""checked""))
                    filt.push(1);

                if ($(""#status_2"").prop(""checked""))
                    filt.push(2);

                if ($(""#status_3"").prop(""checked""))
                    filt.push");
            WriteLiteral("(3);\r\n\r\n\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
            EndContext();
            BeginContext(5257, 25, false);
#line 157 "C:\Users\RTS_NB\source\repos\MUP_test\MUP_test\Views\Home\Index.cshtml"
                     Write(Url.Action("RequestList"));

#line default
#line hidden
            EndContext();
            BeginContext(5282, 1211, true);
            WriteLiteral(@""",
                    data: {
                        statuses: filt,
                        start: $(""#start-period"").val(),
                        finish: $(""#finish-period"").val()
                    },
                    dataType: ""json"",
                    cache: false,
                    traditional: true,
                    success: function (data) {
                        data.requests.forEach(r => {
                            const dt = new Date(r.reqCreateTime);

                            $filter_body.append(`<tr><td>${getActionRequest(r.reqID)}</td >
                                                    <td>${r.reqText}</td><td>${dt.toLocaleDateString(""ru"")}</td>
                                                    <td>${getStatusName(r.curStatus)}</td></tr>`)
                        });

                        $(""#request_list"").trigger(""update"");

                        $(""#request_list"").trigger(""sorton"", sorting);

                    },
                    comp");
            WriteLiteral("lete: function () {\r\n                        $btn.prop(\"disabled\", false);\r\n                    }\r\n                });\r\n\r\n            })\r\n            .click();\r\n\r\n\r\n        });\r\n</script>");
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
