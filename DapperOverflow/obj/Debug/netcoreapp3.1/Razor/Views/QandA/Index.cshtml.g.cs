#pragma checksum "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d6ed8e26e5e5ce94763a82125f3a15d083856b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Index), @"mvc.1.0.view", @"/Views/QandA/Index.cshtml")]
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
#line 1 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d6ed8e26e5e5ce94763a82125f3a15d083856b", @"/Views/QandA/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bd00d17f4bd890ab5f401ea4a830e86779818e", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Questions</h1>
<br /><br />

<a href=""/QandA/Add""><b>ADD A QUESTION</b></a>
<br />

<style>
    table, th, td {
        border: 1px solid black;
    }
</style>
<table>
    <tr>
        <th style=""width:200px"">Date</th>
        <th style=""width:600px"">Question</th>
        <th style=""width:100px"">User</th>
        <th style=""width:140px""></th>
    </tr>
");
#nullable restore
#line 21 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
     foreach (Question question in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <th>");
#nullable restore
#line 24 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
       Write(question.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th><a");
            BeginWriteAttribute("href", " href=\"", 511, "\"", 548, 2);
            WriteAttributeValue("", 518, "/QandA/Detail?_id=", 518, 18, true);
#nullable restore
#line 25 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
WriteAttributeValue("", 536, question.id, 536, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
                                                Write(question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n        <th>");
#nullable restore
#line 26 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
       Write(question.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th><a");
            BeginWriteAttribute("href", " href=\"", 627, "\"", 662, 2);
            WriteAttributeValue("", 634, "/QandA/Edit?_id=", 634, 16, true);
#nullable restore
#line 27 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
WriteAttributeValue("", 650, question.id, 650, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>EDIT </b></a> / <a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 722, 2);
            WriteAttributeValue("", 692, "/QandA/Delete?_id=", 692, 18, true);
#nullable restore
#line 27 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
WriteAttributeValue("", 710, question.id, 710, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>DELETE</b></a></th>\r\n    </tr>\r\n");
#nullable restore
#line 29 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
