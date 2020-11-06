using Healthy.BaseComponents.Interfaces;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Healthy.IMC.ViewModels
{
    public class IMCMainViewModel : BaseViewModel, IViewModel
    {
        public IMCMainViewModel()
        {
            Title = "Índice de Massa Corporal";
        }
    }
}
