using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms
{
    public class M2TDataGridViewColumnTypeDescriptionProvider : TypeDescriptionProvider
    {
        private static Type[] _columnTypes;

        public M2TDataGridViewColumnTypeDescriptionProvider()
            : base(TypeDescriptor.GetProvider(typeof(DataGridViewColumnCollection)))
        {
            // Initialisiere die Liste der erlaubten Spaltentypen.
            // Hier fügen wir unsere benutzerdefinierten Typen hinzu.
            // Du kannst auch TextBoxColumn, ButtonColumn etc. hinzufügen, wenn du sie als Basis möchtest,
            // aber sie müssen dann von M2TDataGridViewColumn erben oder du musst deine Add/Insert-Prüfung anpassen.
            _columnTypes = new Type[]
            {
            typeof(M2TDataGridViewTextBoxColumn),
            typeof(M2TDataGridViewButtonColumn)
            };
        }

        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            ICustomTypeDescriptor baseDescriptor = base.GetTypeDescriptor(objectType, instance);

            // Wir interessieren uns nur für DataGridViewColumnCollection, wenn sie im Kontext des Designers ist.
            if (objectType == typeof(DataGridViewColumnCollection) || objectType.IsSubclassOf(typeof(DataGridViewColumnCollection)))
            {
                return new M2TDataGridViewColumnCollectionTypeDescriptor(baseDescriptor, _columnTypes);
            }
            return baseDescriptor;
        }
    }
}
