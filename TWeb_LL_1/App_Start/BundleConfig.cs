using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace TWeb_LL_1
{
    public static class BundleConfig
    {
        // GET: BundleConfig
        public static void RegisterBundles(BundleCollection bundles)
        {
               //Bootstrap style
               bundles.Add(new StyleBundle("~/bundles/boostrap/css").Include(
                    "~/Content/css/bootstrap.min.css",
                    "~/Content/css/materialdesignicons.min.css",
                    "~/Content/css/pe-icon-7-stroke.css",
                    "~/Content/css/style.css"));

               //Bootstrap 
               bundles.Add(new ScriptBundle("~/bundles/boostrap/js").Include(
                    "~/Scripts/js/jquery.min.js",
                    "~/Scripts/js/bootstrap.bundle.min.js",
                    "~/Scripts/js/jquery.easing.min.js",
                    "~/Scripts/js/scrollspy.min.js",
                    "~/Scripts/js/counter.init.js",
                    "~/Scripts/js/app.js"));

               /*//Font Awesome Icons style
               bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                    "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));*/
          }
    }
}