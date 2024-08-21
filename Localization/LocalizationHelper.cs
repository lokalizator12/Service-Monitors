using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ServiceMonitorEVK.Localization
{
    public class LocalizationHelper
    {
        public static void ApplyLocalization(Form form)
        {
            var localization = LocalizationManager.Instance;
            var controls = GetAllControls(form);

            foreach (var control in controls)
            {
                var property = control.GetType().GetProperty("Text");
                if (property != null && property.PropertyType == typeof(string))
                {
                    var key = control.Name;
                    var localizedText = localization.GetString(key);

                    if (!string.IsNullOrEmpty(localizedText)) property.SetValue(control, localizedText);
                }
            }


            form.Text = localization.GetString(form.Name);
        }

        private static IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            IEnumerable<Control> enumerable = controls as Control[] ?? controls.ToArray();
            return enumerable.SelectMany(ctrl => GetAllControls(ctrl)).Concat(enumerable);
        }
    }
}