#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Profile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Profile/ConfirmPassword.ProfileEdit.cshtml")]
    public partial class ConfirmPassword_ProfileEdit : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile.ProfileEmailEditViewModel>
    {
        public ConfirmPassword_ProfileEdit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 9 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div>\n    <h3>");

            
            #line 14 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
   Write(Html.Resource("EditProfileLink"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 16 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
     if (Model.ShowProfileChangedMsg)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
                                                                       Write(Html.Resource("ChangesAreSaved"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 19 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 21 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
     if (!String.IsNullOrEmpty(ViewBag.ErrorMessage))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 23 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
                                                                      Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 24 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 26 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
     using (Html.BeginFormSitefinity("EditEmail", "EditProfileForm", FormMethod.Post, new Dictionary<string, object> { { "enctype", "multipart/form-data"},  { "role", "form" }, { "aria-label", Html.Resource("EditProfileLink") } }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\n");

WriteLiteral("            ");

            
            #line 29 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.HiddenFor(u => u.UserId));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 30 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.HiddenFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("                     \n        </div>\n");

            
            #line 32 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 1311), Tuple.Create("\'", 1359)
            
            #line 33 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("PasswordChangeDescription")
            
            #line default
            #line hidden
, 1316), false)
);

WriteLiteral(">");

            
            #line 33 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
                                                       Write(Html.Resource("PasswordEditMessage"));

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 34 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n");

            
            #line 36 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
              
                var passwordDescription = Html.UniqueId("PasswordChangeDescription") + " " + Html.UniqueId("PasswordChangeValidationMessage");
            
            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 39 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.LabelFor(u => u.Password, Html.Resource("Password")));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 40 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
       Write(Html.PasswordFor(u => u.Password, new { @class = "form-control", aria_describedby = passwordDescription}));

            
            #line default
            #line hidden
WriteLiteral("\n\n            <div");

WriteAttribute("id", Tuple.Create(" id=\'", 1816), Tuple.Create("\'", 1870)
            
            #line 42 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 1821), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("PasswordChangeValidationMessage")
            
            #line default
            #line hidden
, 1821), false)
);

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 43 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
           Write(Html.ValidationMessageFor(u => u.Password));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n        </div>\n");

            
            #line 46 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <div>\n            <input");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2131), Tuple.Create("\'", 2172)
            
            #line 48 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
              , Tuple.Create(Tuple.Create("", 2139), Tuple.Create<System.Object, System.Int32>(Html.Resource("EditProfileSave")
            
            #line default
            #line hidden
, 2139), false)
);

WriteLiteral(" />   \n        </div>\n");

            
            #line 50 "..\..MVC\Views\Profile\ConfirmPassword.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
