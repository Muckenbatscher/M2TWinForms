namespace M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection
{
    public abstract class SelectionItem<T>
    {
        public string DisplayName { get; private set; }
        public T Value { get; private set; }

        public SelectionItem(string displayName, T value)
        {
            DisplayName = displayName;
            Value = value;
        }
    }
}
