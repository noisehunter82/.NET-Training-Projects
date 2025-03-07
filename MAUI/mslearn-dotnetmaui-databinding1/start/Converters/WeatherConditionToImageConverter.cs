using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherClient.Models;

namespace WeatherClient.Converters
{
    internal class WeatherConditionToImageConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            WeatherType weatherType = (WeatherType)value!;

            return weatherType switch
            {
                WeatherType.Sunny => ImageSource.FromFile("sunny.png"),
                WeatherType.Cloudy => ImageSource.FromFile("cloud.png"),
                _ => ImageSource.FromFile("question.png")
            };
        }
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
