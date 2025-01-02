using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLife.Views.Converters
{
    internal class PaneLengthConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is double openPaneLength && parameter is string deduction)
            {
                if (double.TryParse(deduction, out double deductionValue))
                {
                    return openPaneLength - deductionValue;
                }
            }
            return value; // Return original value if conversion fails
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
