﻿using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;

namespace SFML.Graphics.Design
{
    /// <summary>Provides a unified way of converting BoundingSphere values to other types, as well as for accessing standard values and subproperties.</summary>
    public class BoundingSphereConverter : MathTypeConverter
    {
        /// <summary>Initializes a new instance of the BoundingSphereConverter class.</summary>
        public BoundingSphereConverter()
        {
            var type = typeof(BoundingSphere);
            propertyDescriptions =
                new PropertyDescriptorCollection(new PropertyDescriptor[]
                { new FieldPropertyDescriptor(type.GetField("Center")), new FieldPropertyDescriptor(type.GetField("Radius")) }).
                    Sort(new string[] { "Center", "Radius" });
            supportStringConvert = false;
        }

        /// <summary>Converts the given value object to the specified type, using the specified context and culture information.</summary>
        /// <param name="context">The format context.</param>
        /// <param name="culture">The culture to use in the conversion.</param>
        /// <param name="value">The object to convert.</param>
        /// <param name="destinationType">The destination type.</param>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
                throw new ArgumentNullException("destinationType");
            if ((destinationType == typeof(InstanceDescriptor)) && (value is BoundingSphere))
            {
                var sphere = (BoundingSphere)value;
                var constructor = typeof(BoundingSphere).GetConstructor(new Type[] { typeof(Vector3), typeof(float) });
                if (constructor != null)
                    return new InstanceDescriptor(constructor, new object[] { sphere.Center, sphere.Radius });
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        /// <summary>Creates an instance of the type that this BoundingSphereConverter is associated with, using the specified context, given a set of property values for the object.</summary>
        /// <param name="context">The format context.</param>
        /// <param name="propertyValues">The new property values.</param>
        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            if (propertyValues == null)
                throw new ArgumentNullException("propertyValues", FrameworkMessages.NullNotAllowed);
            return new BoundingSphere((Vector3)propertyValues["Center"], (float)propertyValues["Radius"]);
        }
    }
}