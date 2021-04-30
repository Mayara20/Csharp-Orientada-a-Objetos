using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace System
{
	static class DateExtensions
	{
		public static string TempoDecorrido(this DateTime thisObj)
		{
			TimeSpan duration = DateTime.Now.Subtract(thisObj);

			if(duration.TotalHours < 24)
			{
				return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Horas";
			}
			else
			{
				return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
			}
		}
	}
}
