using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection
{
    public partial class Selection<I, T> : UserControl where I : SelectionItem<T>
    {
        public string SelectionPrompt { get => LB_SelectionPrompt.Text; set => LB_SelectionPrompt.Text = value; }

        public I SelectedItem { get => (I)CB_Selection.SelectedItem!; }
        public T SelectedValue { get => (T)CB_Selection.SelectedValue!; }
        public IEnumerable<I> Selections { get => (IEnumerable<I>)CB_Selection.DataSource!; set => CB_Selection.DataSource = value.ToList(); }


        public Selection()
        {
            InitializeComponent();

            CB_Selection.DisplayMember = nameof(SelectionItem<T>.DisplayName);
            CB_Selection.ValueMember = nameof(SelectionItem<T>.Value);

            SelectionPrompt = "Select an item:";
            Selections = new List<I>();
        }
    }
}
