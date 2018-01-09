﻿using System;
using System.Linq.Expressions;
using System.Reflection;

namespace ANH.Core
{
    /// <summary>
    /// A helper for expressions
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Compiles an expressioni and gets the functions return value
        /// </summary>
        /// <typeparam name="T">The type of return value</typeparam>
        /// <param name="lamba">The expression to compile</param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lamba)
        {
            return lamba.Compile().Invoke();
        }

        /// <summary>
        /// Sets the underlying properties value to the given value
        /// from an expression that contains the property
        /// </summary>
        /// <typeparam name="T">The type of value to set</typeparam>
        /// <param name="lamba">The expression</param>
        /// <returns></returns>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lamba, T value)
        {
            // Convert a lamba () => some.Property, to some.Property
            var expression = (lamba as LambdaExpression).Body as MemberExpression;

            // Get the property information so we can set it
            var propertyInfo = (PropertyInfo)expression.Member;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            // Set the property value
            propertyInfo.SetValue(target, value);
        }
    }
}
