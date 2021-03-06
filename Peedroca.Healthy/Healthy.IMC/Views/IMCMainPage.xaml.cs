﻿using Healthy.BaseComponents.Pages;
using Healthy.IMC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Healthy.IMC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IMCMainPage : BaseContentPage
    {
        public IMCMainPage()
            : base(typeof(IMCMainViewModel))
        {
            InitializeComponent();
        }
    }
}