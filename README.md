# M2TWinForms

## What is M2TWinforms?
M2TWinforms is a UI library that aims to enhance the dated looks of standard Windows Forms.  
M2T stands for: Minimal Material Themeable  
**Minimal**  
The provided controls provida a minimalist flat appearance that goes well with more modern look and feel.  
**Material**  
The colorroles that are utilized to style the controls stem from Google's Material 3 design guidelines. Some controls also replace their standard Windows Forms appearance witha a Material 3 one.  
**Themeable**  
Theming will be applied to all controls. Making the entire application look and feel more cohesive.  

## Why use M2TWinforms?
M2TWinforms is built on top of standard Windows Forms Controls. This is manifested in the fact that each of the provided controls directly inherits from the corresponding native Windows Forms control. As a result M2TWinforms can be used as a direct drop in replacement for existing applications using native Windows Forms controls.

## How it works
Because the controls directly inherit from their native windows forms counterpart it can be as simple as replacing occurences of windows forms controls with their M2TWinforms counterpart.
Note: There are plans to write a source generator that can take care of migrating a whole project to M2TWinforms controls from native WIndows Forms controls.

### Applying a theme
The currently loaded theme is managed centrally in the `CurrentLoadedThemeManager`. All controls will apply their theming based on the loaded theme.
To load a theme it is as simple as calling the LoadTheme method. This should be done before any controls are initialized. The Program.cs startup is the perfect place for this.

### Creating a theme
M2TWinforms implements the color calculations found in Google's Material 3 specification. 
With these calculations it is possible to create a theme from a single color. Themes can be created to either suit a dark or light theme. They can also be created for varying contrast levels (normal, high, higher). Additionally to creating a theme from a single color it is also possible to specify each of the colors by hand. This can provide additional freedom when desired.

>[!NOTE]
>There are plans to switch the themecreation to use the builder pattern as it can be more expressive than traditional method argument approach that is currently being used. See [#31](https://github.com/Muckenbatscher/M2TWinForms/issues/31)

### Assigning colors
Unlike in native windows forms, the colors are not directly assigned to control elements. Instead the M2TWinforms controls expose properties to set color roles. These color roles will be translated to an actual color based on the theme that is currently loaded.

>[!NOTE]
>Because the controls inherit from their native windows forms controls they will still have to expose the properties for setting the colors directly. They are however marked as [Obsolete] to indicate that the color roles properties should be used instead to ensure proper theming.

The color roles work almost like "paint by number". Assigning a color role property can affect the color of one or more elements within the control. It can also ensure that colors of specific elements work nicely together. A prime example would be a proper foreground text color that provides enough contrast against the background color that is placed on top of.

All controls provide different color roles based on their needs for defined colors and their complexity. They might also allow only the color roles for selection that are valid for a specific property.

### Supported controls

| Windows Forms | M2TWinforms  |
| ------------- | ------------ |
| Form          | M2TForm      |  
| Panel         | M2TPanel     |  
| Label         | M2TLabel     |  
| Button        | M2TButton    |  
| RadioButton   | M2TRadioButton |
| CheckBox      | M2TCheckBox  |  
| DataGridView  | M2TDataGridView |  
