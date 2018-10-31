using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XF.ExemploDS.App_Code;
using XF.ExemploDS.iOS.Dependence;

[assembly: Dependency(typeof(SO_iOS))]
namespace XF.ExemploDS.iOS.Dependence
{
    public class SO_iOS : ISistemaOperacional
    {
        public string Plataforma()
        {
            return "iPhone iOS";
        }
    }
}