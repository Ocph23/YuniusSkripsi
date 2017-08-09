using System.Web;
using System.Web.Optimization;

namespace SIKeluarahan
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/bower_components/angular/angular.js",
                     "~/bower_components/angular-route/angular-route.js",
                     "~/bower_components/angular-animate/angular-animate.js",
                   "~/bower_components/angular-messages/angular-messages.js",
                    "~/bower_components/angular-material/angular-material.js",
                   "~/bower_components/angular-aria/angular-aria.js"
                     ));


            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/bower_components/angular-material/angular-material.css",
                      "~/Content/site.css"));
                      
        }
    }
}
