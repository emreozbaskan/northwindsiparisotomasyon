﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.WinUI.Helper
{
    using Model;
    public static class UIExtension
    {
        public static void SetDataSourceFirstItems<TValue, TData>(this ComboBox combo, IEnumerable<TData> datasource, string displayMember, string valueMember, string firstItemText)
            where TValue : struct
            where TData : class
        {
            List<KeyValue<TValue, TData>> newDatasources = new List<KeyValue<TValue, TData>>();
            newDatasources.Add(new KeyValue<TValue, TData>() { Key = firstItemText, Value = null, Data = null });

            foreach (var item in datasource)
            {
                var key = (string)typeof(TData).GetProperty(displayMember).GetValue(item);
                var value = (TValue)typeof(TData).GetProperty(valueMember).GetValue(item);

                newDatasources.Add(new KeyValue<TValue, TData>() { Key = key, Value = value, Data = item });
            }

            combo.DataSource = newDatasources;
            combo.DisplayMember = "Key";
            combo.ValueMember = "Value";
        }

        public static void SetSelectedValue(this ComboBox combo,object value)
        {
            if (value != null)
                combo.SelectedValue = value;
        }
    }
}

