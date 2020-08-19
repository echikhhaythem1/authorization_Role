#pragma checksum "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5df4ec084999175131e384063d84349bfd4ffae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Index.cshtml", typeof(AspNetCore.Views_Roles_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5df4ec084999175131e384063d84349bfd4ffae", @"/Views/Roles/Index.cshtml")]
    public class Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleBasedAuthorization.Models.Roles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Roles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 89, true);
            WriteLiteral("\n<!-- Content Header (Page header) -->\n<section class=\"content-header\">\n    <h1>\n        ");
            EndContext();
            BeginContext(231, 17, false);
#line 11 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(248, 809, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Roles Table</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example2"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Title</th>
                                <th>Description</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 34 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1144, 106, true);
            WriteLiteral("                            <tr>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(1251, 37, false);
#line 38 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(1401, 40, false);
#line 41 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 112, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(1554, 46, false);
#line 44 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 114, true);
            WriteLiteral("\n                                </td>\n                                <td>\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1714, "\"", 1741, 2);
            WriteAttributeValue("", 1721, "/Roles/Edit/", 1721, 12, true);
#line 47 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1733, item.Id, 1733, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1742, 50, true);
            WriteLiteral(">Edit</a> |\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1792, "\"", 1821, 2);
            WriteAttributeValue("", 1799, "/Roles/Delete/", 1799, 14, true);
#line 48 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1813, item.Id, 1813, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1822, 84, true);
            WriteLiteral(">Delete</a>\n                                </td>\n                            </tr>\n");
            EndContext();
#line 51 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Roles\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1936, 385, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>

<script>
$(function () {
    $('#example2').DataTable({
        'paging': true,
        'lengthChange': true,
        'searching': true,
      'ordering'    : true,
      'info'        : true,
      'autoWidth'   : false
    })
  })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleBasedAuthorization.Models.Roles>> Html { get; private set; }
    }
}
#pragma warning restore 1591