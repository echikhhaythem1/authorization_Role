#pragma checksum "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Doctors\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a1e1980f197abb72bdabb8540e4838e29a9037f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Update), @"mvc.1.0.view", @"/Views/Doctors/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Update.cshtml", typeof(AspNetCore.Views_Doctors_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a1e1980f197abb72bdabb8540e4838e29a9037f", @"/Views/Doctors/Update.cshtml")]
    public class Views_Doctors_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleBasedAuthorization.Models.Doctors>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 771, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Doctors
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Update Doctor</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action=""/Doctors/UpdateDoctor"">
            <div class=""box-body"">
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">FirstName</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""FirstName""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 817, "\"", 841, 1);
#line 21 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 825, Model.FirstName, 825, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(842, 338, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastName</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""LastName"" placeholder=""LastName""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1180, "\"", 1203, 1);
#line 27 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 1188, Model.LastName, 1188, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1204, 329, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Phone</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Phone"" placeholder=""Phone""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1533, "\"", 1553, 1);
#line 33 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 1541, Model.Phone, 1541, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1554, 335, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Address</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Address"" placeholder=""Address""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1889, "\"", 1911, 1);
#line 39 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 1897, Model.Address, 1897, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1912, 344, true);
            WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Specialist</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Specialist"" placeholder=""Specialist""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2256, "\"", 2281, 1);
#line 45 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 2264, Model.Specialist, 2264, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2282, 55, true);
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
            BeginContext(2693, 46, true);
            WriteLiteral("                <input type=\"hidden\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2739, "\"", 2756, 1);
#line 54 "C:\Users\Haythem\Desktop\rapport\AdminPanelV2\AdminPanel\AdminPanel\Views\Doctors\Update.cshtml"
WriteAttributeValue("", 2747, Model.Id, 2747, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2757, 376, true);
            WriteLiteral(@" />
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
                <button type=""submit"" class=""btn btn-default"">Cancel</button>
                <button type=""submit"" class=""btn btn-info pull-right"">Update</button>
            </div>
            <!-- /.box-footer -->
        </form>
    </div>
    <!-- /.box -->
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleBasedAuthorization.Models.Doctors> Html { get; private set; }
    }
}
#pragma warning restore 1591
