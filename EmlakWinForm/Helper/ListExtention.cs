using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakWinForm.Helper
{
    public static class ListExtention
    {
        /// <summary>
        /// Datagrid sadece base sınıftaki property leri gösteriyordu.
        /// Bundan dolayı itemdaki alanlar için dinamik kolon eklenmesi
        /// amacı ile geliştirildi.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable CreateDataTable(this IList list)
        {
            var dataTable = new DataTable();

            foreach (var item in list)
            {
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(item.GetType());
                for (int i = 0; i < props.Count; i++)
                {
                    PropertyDescriptor prop = props[i];
                    if (!dataTable.Columns.OfType<DataColumn>().Any(col => col.ColumnName == prop.Name))
                    {
                        dataTable.Columns.Add(prop.Name, prop.PropertyType);
                    }
                }

                DataRow row = dataTable.NewRow();
                for (int i = 0; i < props.Count; i++)
                {
                    PropertyDescriptor prop = props[i];
                    row[prop.Name] = prop.GetValue(item);
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
