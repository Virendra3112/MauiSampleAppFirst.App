using Android.Content;
using Android.Text;
using Android.Widget;
using MauiSampleAppFirst.Controls;
using MauiSampleAppFirst.Platforms.Android.CustomRenderer;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly: ExportRenderer(typeof(CustomHtmlLabel), typeof(CustomHtmlLabelRenderer))]
namespace MauiSampleAppFirst.Platforms.Android.CustomRenderer
{
    public class CustomHtmlLabelRenderer : LabelHandler// LabelRenderer
    {
        public CustomHtmlLabelRenderer()//(Context context) : base(context)
        {
        }

        //override one
        //protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        //{
        //    base.OnElementChanged(e);

        //    var view = (CustomHtmlLabel)Element;
        //    if (view == null) return;
        //    if (!string.IsNullOrEmpty(Control.Text))
        //    {
        //        if (Control.Text.Contains("<a"))
        //        {
        //            var a = Control.Text.IndexOf("<a");
        //            var b = Control.Text.IndexOf("</a>");
        //            var d = Control.Text.Length;
        //            var c = Control.Text.Length - Control.Text.IndexOf("</a>");
        //            int length = b - a + 4;

        //            string code = Control.Text.Substring(a, length);
        //            Control.SetText(Html.FromHtml(view.Text.ToString().Replace(code, string.Empty)), TextView.BufferType.Spannable);
        //        }
        //        else
        //            Control.SetText(Html.FromHtml(view.Text.ToString()), TextView.BufferType.Spannable);
        //    }

        //}
    }
}
