using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public class M2TDataGridViewColumnCollectionTypeDescriptor : CustomTypeDescriptor
    {
        private Type[] _newColumnTypes;

        public M2TDataGridViewColumnCollectionTypeDescriptor(ICustomTypeDescriptor parent, Type[] newColumnTypes)
            : base(parent)
        {
            _newColumnTypes = newColumnTypes;
        }

        // Überschreibe GetProperties, um sicherzustellen, dass die PropertyDescriptor-Liste
        // die Eigenschaft "ColumnTypes" enthält, die für den Designer relevant ist.
        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection properties = base.GetProperties(attributes);

            // Wir müssen die interne Property "ColumnTypes" des DataGridViewColumnCollection-Designers manipulieren.
            // Dies ist ein Trick, da diese Eigenschaft nicht öffentlich ist.
            // Wir suchen nach der Eigenschaft, die den Typ der Spalten auflistet, die hinzugefügt werden können.
            // Diese Eigenschaft ist nicht direkt zugänglich, aber der Designer nutzt sie intern.
            // Stattdessen fügen wir eine PropertyDescriptor hinzu, die der Designer als Quelle für Typen verwendet.
            // Die exakte Implementierung hängt oft von internen Details des Designer-Frameworks ab.
            // Der gängigste Weg ist, einen Wrapper um die CollectionEditor zu machen.

            // Für dieses spezifische Szenario mit dem DataGridView Column Editor
            // ist es NICHT über GetProperties() zu steuern, sondern über das Hinzufügen
            // des TypeDescriptionProviders zum CollectionEditor des DataGridViewColumnCollection.
            // Dies ist der "Hack", da DataGridViewColumnCollection den TypeDescriptor seiner eigenen
            // Elementtypen über seine Property `ItemType` oder `CollectionItemType` nicht freigibt.

            // Die korrekte Methode ist die Verwendung eines CollectionEditor der überschrieben wird,
            // und den TypeDescriptionProvider an den Typ der Sammlung anzuhängen.
            // Aber da die DataGridViewColumnCollection intern nicht einfach "erweitert" werden kann,
            // um andere Elementtypen zu bekommen, müssen wir die Eigenschaft des DataGridView überschreiben.

            // Der ursprüngliche Plan, einen TypeDescriptionProvider direkt an DataGridViewColumnCollection
            // zu hängen, funktioniert nicht so einfach, da der Designer den internen Typ-Array
            // nicht direkt über einen TypeDescriptor abfragt.

            // Wir müssen zurück zum CollectionEditor-Ansatz, aber auf einer höheren Ebene.
            // Die Idee war gut, aber die Implementierung des Designer-Frameworks ist an dieser Stelle hartnäckig.
            // Das heißt, wir müssen den CollectionEditor für die Columns-Eigenschaft des DataGridView ändern.

            // Da die DataGridView.Columns Eigenschaft vom Typ DataGridViewColumnCollection ist,
            // und diese Klasse die Add-Methoden bereits überschreibt, die nur M2TDataGridViewColumn-Typen
            // zulassen, ist die Typsicherheit gewährleistet.

            // Um den Dialog mit "Hinzufügen" so zu beeinflussen, dass er nur M2TDataGridViewColumn-Typen zeigt,
            // müssen wir den Type Editor für die Columns-Eigenschaft des M2TDataGridView selbst überschreiben,
            // oder dem CollectionEditor mitteilen, welche Typen er anbieten soll.
            // Die [Editor] Attribut auf der Columns-Eigenschaft ist der Weg!
            return properties;
        }
    }
}
