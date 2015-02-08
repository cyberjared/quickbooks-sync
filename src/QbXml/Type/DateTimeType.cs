﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace QBSync.QbXml.Type
{
    public class DateTimeType : IStringConvertible
    {
        private DateTime value;

        public DateTimeType(string value)
        {
            this.value = DateTime.Parse(value);
        }

        public DateTimeType(DateTime value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value.ToString("s", CultureInfo.InvariantCulture); // TODO QBSync confirm timezone
        }

        public static implicit operator DateTimeType(DateTime value)
        {
            if (value == null)
            {
                return null;
            }

            return new DateTimeType(value);
        }
    }
}