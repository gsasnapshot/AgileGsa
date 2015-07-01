using System.Web.Optimization;

namespace FaNgMvcBs
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js"
                ));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                "~/Content/css/bootstrap.css",
                "~/Content/css/bootstrap-theme.css",
                "~/Content/css/font-awesome.css"
                ));

            BundleTable.EnableOptimizations = true;
        }
    }
}