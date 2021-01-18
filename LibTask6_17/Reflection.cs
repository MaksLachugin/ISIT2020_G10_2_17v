using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using LibTask5_17;

namespace LIbTask6_17
{
    class Reflection
    {

        public static List<ItemMethodInfo> ShowMethods(ItemType item)
        {
            List<ItemMethodInfo> items = new List<ItemMethodInfo>();
            StringBuilder sb = new StringBuilder();
            Type type = item.Value;
            foreach (MethodInfo method in type.GetMethods(BindingFlags.DeclaredOnly
            | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                string modificator = "";
                if (method.IsStatic)
                {
                    modificator += "static ";
                }

                if (method.IsVirtual)
                {
                    modificator += "virtual";
                }

                sb.Append($"{modificator} {method.ReturnType.Name} {method.Name} (");
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    sb.Append($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length)
                    {
                        Console.Write(", ");
                    }
                }
                sb.Append(")" + '\n');
                items.Add(new ItemMethodInfo(method, sb.ToString()));
                sb = new StringBuilder();
            }
            return items;
        }
        public static List<ItemType> ShowClasses(string library)
        {
           Type typeInterface = typeof(IFigure);
           Assembly asm = Assembly.LoadFrom(library);
            List<ItemType> items = new List<ItemType>();
            foreach (Type mytype in asm.GetTypes()
                 .Where(mytype => mytype.GetInterfaces().Contains(typeInterface)))
            {
                if (!mytype.IsAbstract)
                {
                    items.Add(new ItemType(mytype, mytype.FullName));
                }
            }
            return items;
        }

        public static string ShowConstructor(ItemType item)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ConstructorInfo constructor in item.Value.GetConstructors())
            {
                sb.Append(item.Value.Name + " (");
                ParameterInfo[] parameters = constructor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    sb.Append(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length)
                    {
                        sb.Append(", ");
                    }
                }
                sb.Append(")");
            }
            return sb.ToString();
        }

        public static string InvokeMethod(ItemMethodInfo item, String args, Object obj)
        {
            MethodInfo method = item.Value;
            ParameterInfo[] parameters = method.GetParameters();
            String[] strings = args.Split(' ');
            Object[] objects = new Object[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                TypeConverter typeConverter = TypeDescriptor.GetConverter(parameters[i].ParameterType);
                objects[i] = typeConverter.ConvertFromString(strings[i]);
            }
            return method.Invoke(obj, objects).ToString();
        }

        public static Object CreateObject(ItemType item, String args)
        {
            Type classObj = item.Value;
            foreach (ConstructorInfo constructor in classObj.GetConstructors())
            {
                ParameterInfo[] parameters = constructor.GetParameters();
                Object[] argsObj = strToObjs(parameters, args);
                object newClass = constructor.Invoke(argsObj);
                return newClass;
            }
            return null;
        }

        public static Object[] strToObjs(ParameterInfo[] parameters, String args)
        {
            String[] strings = args.Split(' ');
            Object[] objects = new Object[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                TypeConverter typeConverter = TypeDescriptor.GetConverter(parameters[i].ParameterType);
                objects[i] = typeConverter.ConvertFromString(strings[i]);
            }
            return objects;
        }
    }

    

}

