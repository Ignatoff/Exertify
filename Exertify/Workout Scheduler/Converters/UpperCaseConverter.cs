﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Workout_Scheduler.Converters
{
    class UpperCaseConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string s = value as String;
            return s.ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
