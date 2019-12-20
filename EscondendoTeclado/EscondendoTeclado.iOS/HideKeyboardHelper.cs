using System;
using System.Collections.Generic;
using System.Linq;
using EscondendoTeclado.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(HideKeyboardHelper))]
namespace EscondendoTeclado.iOS
{
    public class HideKeyboardHelper : IHideKeyboard
    {
        public void HideKeyboard()
        {
            UIApplication.SharedApplication.KeyWindow.EndEditing(true);
        }
    }
}
