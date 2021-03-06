﻿using System.Web;
using System.Web.Optimization;

namespace BFStudio
{
    public class BundleConfig
    {
        // バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkId=301862  を参照してください
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.unobtrusive-ajax.js",
                "~/Scripts/jquery.signalR-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/blockui").Include(
                        "~/Scripts/jquery.blockUI*"));

            // 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
            // できたら、http://modernizr.com にあるビルド ツールを使用して、必要なテストのみを選択します。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            //CSSを変更すると、リアルタイム更新をする
            bundles.Add(new ScriptBundle("~/Content/cssrefresh").Include(
                        "~/Scripts/cssrefresh.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                        "~/Scripts/jquery.dataTables.min.js"));

            bundles.Add(new ScriptBundle("~/Content/datatable").Include(
                        "~/Content/jquery.dataTables.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/normalize-{version}",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

#if DEBUG
            bundles.GetBundleFor("~/Content/css").Include("~/Content/debug-color.css");
#endif
        
            bundles.Add(new StyleBundle("~/Content/menu").Include( "~/Content/menu.css" ));
            bundles.Add(new ScriptBundle("~/bundles/menu").Include("~/Scripts/menu.js"));

            //自作カレンダー
            bundles.Add(new StyleBundle("~/Content/calendar").Include(
                        "~/Content/calendar.css"));
        }
    }
}
