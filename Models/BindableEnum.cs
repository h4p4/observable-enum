using observableEnum.Helpers;
using System;

namespace observableEnum.Models
{
    internal class BindableEnum<TEnum> where TEnum : Enum, new()
    {
        public TEnum Enum { get; set; }

        public BindableEnum(TEnum tEnum)
        {
            Enum = tEnum;
        }

        public override string ToString()
        {
            return EnumHelper.GetDescription(Enum);
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (!(obj is BindableEnum<TEnum> bindableEnum))
                return false;

            if (bindableEnum.Enum?.GetType() != typeof(TEnum))
                return false;

            if (bindableEnum.Enum.GetHashCode() != Enum.GetHashCode())
                return false;

            return true;
        }
        public override int GetHashCode()
        {
            return Enum.GetHashCode();
        }
    }
}
