﻿using System;
using System.Windows;
using System.Globalization;

using System.Diagnostics;

namespace MediaPlayer
{
    public class ApplicationPageValueConverter : BaseValueConverters<ApplicationPageValueConverter>
    {
        /// <summary>
        /// Convert enum to a page view 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((CurrentViewType)value)
            {
                // load media 
                case CurrentViewType.Media:
                    return new MediaView();
                // load medi background 
                case CurrentViewType.MediaBackground:
                    return new MediaBackgroundView();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        /// <summary>
        /// Convert back page to enum
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
