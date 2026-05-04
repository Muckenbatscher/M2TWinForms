using MaterialTheming.MaterialDesign;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    class ColorRoleWithOnRoleVisualisationMapping
    {
        public ColorRoleWithOnRoleVisualisation VisualisationControl { get; private set; }
        public ColorRoles Role { get; private set; }
        public ColorRoles OnRole { get; private set; }

        public ColorRoleWithOnRoleVisualisationMapping(ColorRoleWithOnRoleVisualisation visualisationControl,
            ColorRoles role, ColorRoles onRole)
        {
            VisualisationControl = visualisationControl;
            Role = role;
            OnRole = onRole;
        }
    }
}
