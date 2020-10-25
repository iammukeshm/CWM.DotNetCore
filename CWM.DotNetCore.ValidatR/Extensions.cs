using CWM.DotNetCore.ValidatR.Exceptions;
using System;

namespace CWM.DotNetCore.ValidatR
{
    public static class Extensions
    {
        public static void IfNull<T>(this IThrow validatR, T value, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(propertyName);
            }
        }
        public static void IfNullOrWhiteSpace(this IThrow validatR, string value, string propertyName)
        {
            Throw.Exception.IfNull(value, propertyName);
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Paramater {propertyName} cannot be empty.");
            }
        }
        public static void IfEntityNotFound<T>(this IThrow validatR, int entityId, T value, string entityName)
        {
            if (value == null)
            {
                throw new EntityNotFoundException($"{entityName} Entity with Id {entityId} not found.");
            }
        }
        public static void IfNotEqual<T>(this IThrow validatR, int valueOne, int valueTwo, string property)
        {
            if (valueOne != valueTwo)
            {
                throw new ArgumentException($"Supplied {property} Values are not equal.");
            }
        }
    }
}
