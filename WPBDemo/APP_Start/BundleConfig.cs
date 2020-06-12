using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WPBDemo.APP_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/demo").Include(
              "~/Scripts/angular.js",
              "~/Scripts/angular-resource.js",
              "~/Scripts/angular-animate.js",
              "~/Scripts/angular-sanitize.js",
              "~/Scripts/angular-ui/ui-bootstrap-tpls.js"
            ));

            bundles.Add(new StyleBundle("~/content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/ui-bootstrap-csp.css"
                      ));

        }

        protected void Application_Start(object sender, EventArgs e)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }
}