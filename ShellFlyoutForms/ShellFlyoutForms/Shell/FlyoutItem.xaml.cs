using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellFlyoutForms.Shell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutItem : Xamarin.Forms.Shell
    {
        public FlyoutItem()
        {
            InitializeComponent();
        }
    }
}
