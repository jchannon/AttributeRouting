﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace AttributeRouting.Helpers
{
    public static class ReflectionExtensions
    {
        public static IEnumerable<MethodInfo> GetActionMethods(this Type type, bool inheritActionsFromBaseController)
        {
            var flags = BindingFlags.Public | BindingFlags.Instance;

            if (!inheritActionsFromBaseController)
                flags |= BindingFlags.DeclaredOnly;

            return type.GetMethods(flags);
        }

        public static IEnumerable<TAttribute> GetCustomAttributes<TAttribute>(this Type type, bool inherit)
        {
            return type.GetCustomAttributes(typeof(TAttribute), inherit).Cast<TAttribute>();
        }

        public static TAttribute GetCustomAttribute<TAttribute>(this Type type, bool inherit)
        {
            return type.GetCustomAttributes(typeof(TAttribute), inherit).Cast<TAttribute>().FirstOrDefault();
        }

        public static IEnumerable<TAttribute> GetCustomAttributes<TAttribute>(this MethodInfo method, bool inherit)
        {
            return method.GetCustomAttributes(typeof(TAttribute), inherit).Cast<TAttribute>();
        }

        /// <summary>
        /// Get controllers in given assembly, depending on target framework (MVC, WebAPI)
        /// </summary>
        /// <param name="assembly"></param>
        /// <returns></returns>
        public static IEnumerable<Type> GetControllerTypes<TController>(this Assembly assembly) {
            return from type in assembly.GetTypes()
                   where !type.IsAbstract && typeof(TController).IsAssignableFrom(type)
                   select type;
        }

        public static string GetControllerName(this Type type) {
            return Regex.Replace(type.Name, "Controller$", "");
        }
    }
}