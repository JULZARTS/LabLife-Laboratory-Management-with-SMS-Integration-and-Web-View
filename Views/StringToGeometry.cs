using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System.Windows;

namespace LabLife.Views
{
    internal class StringToGeometry : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string key)
            {
                // Attempt to find the resource with the given key
                 if (Avalonia.Application.Current.Resources.TryGetValue(key, out var resource) && resource is StreamGeometry geometry)
                    {
                    return geometry;
                }
            }

            // Return null or a default value if the resource is not found
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
