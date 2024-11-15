using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public static class Utility
    {
      //  static public string ImagePath = Dictionary.GetParent(Dictionary.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\Products\";
        static public bool IsOpeningForm(string formname)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == formname)
                    return true;
            return false;
        }
    }
}
