using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms
{
    public class M2TDataGridViewColumnCollectionEditorForDesigner : CollectionEditor
    {
        public M2TDataGridViewColumnCollectionEditorForDesigner(Type type) : base(type) { }

        // Überschreibe diese Methode, um nur unsere benutzerdefinierten Spaltentypen anzubieten.
        protected override Type[] CreateNewItemTypes()
        {
            return new Type[]
            {
            typeof(M2TDataGridViewTextBoxColumn),
            typeof(M2TDataGridViewButtonColumn)
            };
        }

        // Stelle sicher, dass nur unsere Typen instanziiert werden können.
        protected override object CreateInstance(Type itemType)
        {
            // Prüfe, ob der Typ von MyDataGridViewColumn erbt
            if (itemType.IsSubclassOf(typeof(M2TDataGridViewColumn)) || itemType == typeof(M2TDataGridViewColumn))
            {
                return base.CreateInstance(itemType);
            }
            throw new InvalidOperationException($"Only instances of M2TDataGridViewColumn or derived types can be created through this editor. Type: {itemType.Name}");
        }
    }
}
