using Healthy.BaseComponents.Interfaces;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Healthy.News.ViewModels
{
    public class NewsMainViewModel : BaseViewModel, IViewModel
    {
        public NewsMainViewModel()
        {
            Title = "News";
        }
    }
}
