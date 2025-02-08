<img src="https://github.com/CuvinStefanCristian/DarkUI-Refit/blob/master/Resources/MainFormScreenshot.png" />

## DarkUI-Refit
Fork of the [DarkUI](https://github.com/RobinPerris/DarkUI) library originally created by Robin Perris who sadly passed away.
This fork is primarily for personal changes and needs, but if you find any changes that you like to use, feel free to use / modify this.

### Future plans
- DarkGridView (images and text in row/column grid)
- DarkToast (toats notifications)
- DarkSplshScreen (a splash screen system that can be used to show loading progress)

[Nuget](https://www.nuget.org/packages/DarkUI.Refit)

## DarkUI
Dark themed control and docking library for .NET WinForms.

### About DarkUI
DarkUI is an attempt to create a simple, extensible control library which emulates the look and feel of popular tabbed document interfaces such as Visual Studio, Photoshop, WebStorm, and XCode. Originally just a collection of bug fixes and enhancements built on top of WinForms, it has now evolved in to a fully working docking and control library.

## Refit Changes
Changes reflect my needs, don't expect them to make any sense. Contributions are welcomed though!

### Dark Documents
- Document Tabs can be dragged outside the control bounds and undock the DocumentContent
- Documents that are not docked inside a form area will cause a DarkHostForm to appear and the Docuiment will be docked inside there
- Hovering an undocked document over an open DarkHostForm will dock the dragged document in that form
- Documentws can be docked back inside the parent forms. DarkDockForms with no docked documents close automatically

<img src="https://github.com/CuvinStefanCristian/DarkUI-Refit/blob/master/Resources/DocumentDocking.png" />

### DarkTitleBar
- This component replaced the default WinForms title bar (FormBorderStyle)
- The new title bar has 3 states selectable from the properties window: None (create your own), Standard (title, close, maximize, minimize), ToolWindow (title, close)
- If you choose to create your own TitleBar you can use the Drag event of the DarkForm to move the form using your custom title bar.
- The title is changed using the forms Text property

Important: `FormBorderStyle` needs to be anything but `None`. The TitleBar will break if you set it to `None`

<img src="https://github.com/CuvinStefanCristian/DarkUI-Refit/blob/master/Resources/DarkDefaultTitleBarProperty.png" />

### DarkListView
- The DarkListItem ha sa new Property named Details
- This Property is rendered under the normal Text (it is slightly smalled and in Italic)
- This features can be turned on or off from the Desginer property `ShowDetails`

<img src="https://github.com/CuvinStefanCristian/DarkUI-Refit/blob/master/Resources/DarkListView_Details.png" />

### Toasts
- Toast notifications can be shown on every corener of the screen and in 4 variations (Info, Success, Warning, Error)
- The static class `DarkToastManager` is used to call the Toasts and the `DarkToastOptions` class is used to configure the default toast settings (position, animation speed, show duration)

<img src="https://github.com/CuvinStefanCristian/DarkUI-Refit/blob/master/Resources/Toast.png" />

### Demo
- The demo has been updated to showcase the new features (undocking documents, title bar)

### Attribution

Special thanks to the team over at [Ascension Game Dev](https://www.ascensiongamedev.com/) for expanding the library to include `DarkComboBox`, `DarkGroupBox`, and `DarkNumericUpDown`.

### How to use
The best way to learn how to use DarkUI is to check out the Example project included with the source code. It'll show you how to use the majority of the forms, controls, and docking components.

You can also read the [GitHub project wiki](https://github.com/RobinPerris/DarkUI/wiki). This contains all the information you need to get started as well as more detailed information and guides.
