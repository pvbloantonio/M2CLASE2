using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace Compartido.Utiles
{
    public static class EnumAyuda
    {
        public static T GetEnumValue<T>(string str) where T : struct, IConvertible
        {
            Type enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new Exception("T no es tipo Enum.");
            }
            T val;
            return Enum.TryParse<T>(str, true, out val) ? val : default(T);
        }

        public static T GetEnumValue<T>(int intValue) where T : struct, IConvertible
        {
            Type enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new Exception("T no es tipo Enum.");
            }
            T result = (T)Enum.ToObject(enumType, intValue);

            return result;
        }

        public static ValueConverter<T, string> ConvertirIdaVueltaEnum_MariaDB<T>() where T : struct, IConvertible
        {
            Type enumType = typeof(T);
            ValueConverter<T, string> convertirEnum = new ValueConverter<T, string>
                               (valorEntrante => Enum.GetName(enumType, valorEntrante),
                               valorDesdeLaDB => GetEnumValue<T>(valorDesdeLaDB));

            return convertirEnum;
        }
    }
}
