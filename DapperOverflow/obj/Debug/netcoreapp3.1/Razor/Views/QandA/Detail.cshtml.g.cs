#pragma checksum "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3952c1a4e479fe0c833d1fe7cb3242d4cc6f6b79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Detail), @"mvc.1.0.view", @"/Views/QandA/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3952c1a4e479fe0c833d1fe7cb3242d4cc6f6b79", @"/Views/QandA/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bd00d17f4bd890ab5f401ea4a830e86779818e", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h6><i>");
#nullable restore
#line 4 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
  Write(Model.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></h6>\r\n<h6>Author: ");
#nullable restore
#line 5 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
       Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<br /><br />\r\n<p>");
#nullable restore
#line 7 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
Write(Model.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br /><br /><br />\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 173, "\"", 224, 3);
            WriteAttributeValue("", 183, "location.href=\'/QandA/Edit?_id=", 183, 31, true);
#nullable restore
#line 9 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 214, Model.id, 214, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 223, "\'", 223, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 225, "\"", 245, 1);
#nullable restore
#line 9 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 233, Model.Title, 233, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">EDIT</button>\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 269, "\"", 322, 3);
            WriteAttributeValue("", 279, "location.href=\'/QandA/Delete?_id=", 279, 33, true);
#nullable restore
#line 10 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 312, Model.id, 312, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 321, "\'", 321, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 323, "\"", 343, 1);
#nullable restore
#line 10 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 331, Model.Title, 331, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">DELETE</button>\r\n<br /><br />\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 383, "\"", 436, 3);
            WriteAttributeValue("", 393, "location.href=\'/QandA/Answer?_id=", 393, 33, true);
#nullable restore
#line 12 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 426, Model.id, 426, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 435, "\'", 435, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 437, "\"", 457, 1);
#nullable restore
#line 12 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 445, Model.Title, 445, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add an Answer</button>\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 490, "\"", 542, 3);
            WriteAttributeValue("", 500, "location.href=\'/QandA/Close?_id=", 500, 32, true);
#nullable restore
#line 13 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 532, Model.id, 532, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 541, "\'", 541, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 543, "\"", 563, 1);
#nullable restore
#line 13 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 551, Model.Title, 551, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mark as Resolved</button>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
