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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.VideoGallery
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/VideoGallery/List.VideoGallery.cshtml")]
    public partial class List_VideoGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_VideoGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\n    <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 300), Tuple.Create("\"", 389)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 308), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 308), false)
, Tuple.Create(Tuple.Create(" ", 323), Tuple.Create("sf-Gallery-thumbs", 324), true)
, Tuple.Create(Tuple.Create(" ", 341), Tuple.Create("sf-Gallery-thumbs--video", 342), true)
, Tuple.Create(Tuple.Create(" ", 366), Tuple.Create("list-unstyled", 367), true)
, Tuple.Create(Tuple.Create(" ", 380), Tuple.Create("clearfix", 381), true)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 390), Tuple.Create("\"", 433)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                               , Tuple.Create(Tuple.Create("", 403), Tuple.Create<System.Object, System.Int32>(Html.Resource("VideoGallery")
            
            #line default
            #line hidden
, 403), false)
);

WriteLiteral(">\n\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
         for (int i = 0; i < Model.Items.Count(); i++)
        {
            var item = Model.Items.ElementAt(i);
            var itemIndex = (Model.CurrentPage - 1) * ViewBag.ItemsPerPage + i + 1;
            var detailPageUrl = ViewBag.OpenInSamePage ? HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex) :
                HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);
            var videoTitleId = Html.UniqueId("VideoTitle") + "-" + i.ToString();


            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"sf-Gallery-thumb d-inline-block\"");

WriteLiteral(">\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1093), Tuple.Create("\"", 1114)
            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1100), Tuple.Create<System.Object, System.Int32>(detailPageUrl
            
            #line default
            #line hidden
, 1100), false)
);

WriteAttribute("title", Tuple.Create("\n                   title=\"", 1115), Tuple.Create("\"", 1256)
, Tuple.Create(Tuple.Create("", 1142), Tuple.Create("Go", 1142), true)
, Tuple.Create(Tuple.Create(" ", 1144), Tuple.Create("to", 1145), true)
, Tuple.Create(Tuple.Create(" ", 1147), Tuple.Create("video", 1148), true)
            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 1153), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(item.Fields.Description) ? item.Fields.Title : item.Fields.Description
            
            #line default
            #line hidden
, 1154), false)
, Tuple.Create(Tuple.Create(" ", 1248), Tuple.Create("details", 1249), true)
);

WriteLiteral(">\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1283), Tuple.Create("\"", 1336)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1289), Tuple.Create<System.Object, System.Int32>(((VideoThumbnailViewModel)item).ThumbnailUrl
            
            #line default
            #line hidden
, 1289), false)
);

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 1337), Tuple.Create("\"", 1368)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                , Tuple.Create(Tuple.Create("", 1355), Tuple.Create<System.Object, System.Int32>(videoTitleId
            
            #line default
            #line hidden
, 1355), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1369), Tuple.Create("\'", 1457)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                                    , Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.Title, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1375), false)
);

WriteLiteral(" />\n                </a>\n                <h3");

WriteAttribute("id", Tuple.Create(" id=\"", 1502), Tuple.Create("\"", 1520)
            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1507), Tuple.Create<System.Object, System.Int32>(videoTitleId
            
            #line default
            #line hidden
, 1507), false)
);

WriteLiteral(">");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                                  Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\n            </li>\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\n    </ul>\n</div>\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
         if (Model.ShowPager)
        {
            
            
            #line default
            #line hidden
            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
       Write(Html.Action("Index", "ContentPager", new
               {
                   currentPage = Model.CurrentPage,
                   totalPagesCount = Model.TotalPagesCount.Value,
                   redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
               }));

            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\VideoGallery\List.VideoGallery.cshtml"
                 
        }

            
            #line default
            #line hidden
WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
