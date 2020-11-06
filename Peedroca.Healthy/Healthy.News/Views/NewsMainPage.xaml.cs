using Healthy.BaseComponents.Pages;
using Healthy.News.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Healthy.News.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsMainPage : BaseContentPage
    {
        public NewsMainPage()
            : base(typeof(NewsMainViewModel))
        {
            InitializeComponent();
        }
    }
}