using System;
using System.Collections.Generic;
using System.Text;

namespace Healthy.Mobile.Models
{
    /// <summary>
    /// Modelo de item do menu
    /// </summary>
    public class MenuItemModel
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Título
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Código Hexadecimal do icone
        /// </summary>
        public string Icon { get; set; }
    }
}
