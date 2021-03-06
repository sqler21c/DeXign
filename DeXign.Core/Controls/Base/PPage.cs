using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

using DeXign.Extension;

using WPFExtension;

namespace DeXign.Core.Controls
{
    [XForms("Xamarin.Forms", "Page")]
    public class PPage : PVisual
    {
        public static readonly DependencyProperty TitleProperty =
            DependencyHelper.Register();

        public static readonly DependencyProperty PaddingProperty =
            DependencyHelper.Register();

        [DesignElement(Category = Constants.Property.Layout, DisplayName = "제목")]
        [XForms("Title")]
        [WPF("WindowTitle")]
        public string Title
        {
            get { return this.GetValue<string>(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        [DesignElement(Category = Constants.Property.Blank, DisplayName = "안쪽 여백")]
        [XForms("Padding")]
        [WPF("Padding")]
        public Thickness Padding
        {
            get { return this.GetValue<Thickness>(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }
    }
}
