using System.Web.Optimization;

namespace Dream.IM.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/App_Content/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/layer").Include("~/App_Content/Plugins/layer/layer.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/lib").Include("~/App_Content/Scripts/lib.js"));
            bundles.Add(new ScriptBundle("~/bundles/layim").Include("~/App_Content/Scripts/layim.js"));

            bundles.Add(new StyleBundle("~/Content/layim").Include("~/App_Content/Styles/layim.css"));
        }
    }
}