using System.Web;
using System.Web.Optimization;

namespace Tutorial
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Bundle gentelella theme

            bundles.Add(new StyleBundle("~/Gentelella/css").Include(
                    "~/Themes/gentelella/vendors/bootstrap/dist/css/bootstrap.min.css",
                    "~/Themes/gentelella/vendors/font-awesome/css/font-awesome.min.css",
                    "~/Themes/gentelella/vendors/iCheck/skins/flat/green.css",
                    "~/Themes/gentelella/vendors/select2/dist/css/select2.min.css",
                    "~/Themes/gentelella/vendors/switchery/dist/switchery.min.css",
                    "~/Themes/gentelella/vendors/datatables.net-bs/css/dataTables.bootstrap.min.css",
                    "~/Themes/gentelella/vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css",
                    "~/Themes/gentelella/vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css",
                    "~/Themes/gentelella/vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css",
                    "~/Themes/gentelella/vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css",
                    "~/Themes/gentelella/build/css/custom.css"));


            bundles.Add(new ScriptBundle("~/Gentelella/js").Include(
                    "~/Themes/gentelella/vendors/jquery/dist/jquery.min.js",
                    "~/Themes/gentelella/vendors/bootstrap/dist/js/bootstrap.min.js",
                    "~/Themes/gentelella/vendors/fastclick/lib/fastclick.js",
                    "~/Themes/gentelella/vendors/nprogress/nprogress.js",
                    "~/Themes/gentelella/vendors/bootstrap-wysiwyg/js/bootstrap-wysiwyg.min.js",
                    "~/Themes/gentelella/vendors/jquery.hotkeys/jquery.hotkeys.js",
                    "~/Themes/gentelella/vendors/google-code-prettify/src/prettify.js",
                    "~/Themes/gentelella/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                    "~/Themes/gentelella/vendors/iCheck/icheck.min.js",
                    "~/Themes/gentelella/js/moment/moment.min.js",
                    "~/Themes/gentelella/js/datepicker/daterangepicker.js",
                    "~/Themes/gentelella/vendors/jquery.tagsinput/src/jquery.tagsinput.js",
                    "~/Themes/gentelella/vendors/switchery/dist/switchery.min.js",
                    "~/Themes/gentelella/vendors/select2/dist/js/select2.full.min.js",
                    "~/Themes/gentelella/vendors/parsleyjs/dist/parsley.min.js",
                    "~/Themes/gentelella/vendors/autosize/dist/autosize.min.js",
                    "~/Themes/gentelella/vendors/devbridge-autocomplete/dist/jquery.autocomplete.min.js",                    
                    "~/Themes/gentelella/vendors/nprogress/nprogress.js",
                    "~/Themes/gentelella/vendors/datatables.net/js/jquery.dataTables.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-buttons/js/buttons.flash.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-buttons/js/buttons.html5.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-buttons/js/buttons.print.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",
                    "~/Themes/gentelella/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",
                    "~/Themes/gentelella/vendors/datatables.net-scroller/js/datatables.scroller.min.js",
                    "~/Themes/gentelella/vendors/jszip/dist/jszip.min.js",
                    "~/Themes/gentelella/vendors/pdfmake/build/pdfmake.min.js",
                    "~/Themes/gentelella/vendors/pdfmake/build/vfs_fonts.js",
                    "~/Themes/gentelella/build/js/custom.js"
                    ));

            #endregion
        }
    }
}
