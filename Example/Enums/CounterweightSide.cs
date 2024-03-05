using System.ComponentModel;

namespace observableEnum.Example.Enums
{
    internal enum CounterweightSide
    {
        [Description("Слева")]
        Left,

        [Description("Справа")]
        Right,

        [Description("Сверху")]
        Top,

        [Description("Снизу")]
        Bottom,
    }
}
