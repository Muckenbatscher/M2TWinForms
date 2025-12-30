using MaterialTheming.MaterialDesign;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    class ColorRoleVisualisationMapping
    {
        public ColorRoleVisualisation VisualisationControl { get; private set; }
        public ColorRoles Role { get; private set; }
        public ColorRoles TextRole { get; private set; }

        public ColorRoleVisualisationMapping(ColorRoleVisualisation visualisationControl, ColorRoles role, ColorRoles textRole)
        {
            VisualisationControl = visualisationControl;
            Role = role;
            TextRole = textRole;
        }
    }
}
