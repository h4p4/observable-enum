using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace observableEnum.Models
{
    internal class ObservableEnumCollection<TEnum> : ObservableCollection<BindableEnum<TEnum>> 
        where TEnum : Enum, new()
    {
        public void Add(TEnum tEnum)
        {
            Add(new BindableEnum<TEnum>(tEnum));
        }

        public void InsertItem(int index, TEnum item)
        {
            base.InsertItem(index, new BindableEnum<TEnum>(item));
        }

        public void SetItem(int index, TEnum item)
        {
            base.SetItem(index, new BindableEnum<TEnum>(item));
        }
        //public bool Contains(TEnum item)
        //{
        //    if (Items.First(x =>
        //    {
        //        if (x.Enum is Enum xEnum && item is Enum tEnum)
        //            return xEnum.ToString() == tEnum.ToString();
        //        return false;
        //    }) != null)
        //        return true;

        //    return false;
        //}
        //public int IndexOf(TEnum item)
        //{
        //    return Items.IndexOf(Items.First(x =>
        //    {
        //        if (x.Enum is Enum xEnum && item is Enum tEnum)
        //            return xEnum.ToString() == tEnum.ToString();
        //        return false;
        //    }));
        //}
    }
}
