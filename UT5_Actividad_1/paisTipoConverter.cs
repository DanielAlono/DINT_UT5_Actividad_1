using System;
using System.Globalization;
using System.Windows.Data;

namespace UT5_Actividad_1
{
    class paisTipoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string pathImage = "";
            switch (value)
            {
                case "Americana":
                    pathImage = "united_states.png";
                    break;
                case "China":
                    pathImage = "china.png";
                    break;
                case "Mexicana":
                    pathImage = "mexico.png";
                    break;
            }
            return pathImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
