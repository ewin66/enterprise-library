﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using Microsoft.Practices.EnterpriseLibrary.Common.Properties;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    /// <summary>
    /// Represents a configuration converter that converts a string to <see cref="Type"/> based on a fully qualified name.
    /// </summary>
    public class AssemblyQualifiedTypeNameConverter : 
#if !SILVERLIGHT
        ConfigurationConverterBase
#else
        TypeConverter
#endif
    {
        /// <summary>
        /// Returns the assembly qualified name for the passed in Type.
        /// </summary>
        /// <param name="context">The container representing this System.ComponentModel.TypeDescriptor.</param>
        /// <param name="culture">Culture info for assembly</param>
        /// <param name="value">Value to convert.</param>
        /// <param name="destinationType">Type to convert to.</param>
        /// <returns>Assembly Qualified Name as a string</returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value != null)
            {
                Type typeValue = value as Type;
                if (typeValue == null)
                {
                    throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.ExceptionCanNotConvertType, typeof(Type).Name));
                }

                return (typeValue).AssemblyQualifiedName;
            }

            return null;
        }

        /// <summary>
        /// Returns a type based on the assembly qualified name passed in as data.
        /// </summary>
        /// <param name="context">The container representing this System.ComponentModel.TypeDescriptor.</param>
        /// <param name="culture">Culture info for assembly.</param>
        /// <param name="value">Data to convert.</param>
        /// <returns>Type of the data</returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string assemblyQualifiedName = (string)value;
            if (!string.IsNullOrEmpty(assemblyQualifiedName))
            {
                Type result = Type.GetType(assemblyQualifiedName, false);
                if (result == null)
                {
                    throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.ExceptionInvalidType, assemblyQualifiedName));
                }

                return result;
            }

            return null;
        }
    }
}
