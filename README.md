# EasyScintilla
A (hopefully) easier way to use [ScintillaNET](https://github.com/jacobslusser/ScintillaNET) in Windows Forms


## Installation

The easiest way to install is to use [NuGet](https://www.nuget.org/packages/EasyScintilla/)!

```
> Install-Package EasyScintilla
```

## Usage

The goal was to make Scintilla as easy as possible to drop into a Windows Forms project.

From the forms designer, simply drag the `SimpleEditor` control from the toolbox onto the form.

Then, in the code behind set the `Styler` property.

```C#
this.simpleEditor1.Styler = new CSharpStyler();
```

That's it!

## Common Issues

Some users have been having issues where the `SimpleEditor` control does not get added to the Designer Toolbox.

To fix that, follow these steps:

1. If you've not done so already, install EasyScintilla
2. Open up the Windows Forms Designer
3. Right click on the empty space in the Toolbox, and click "Choose Items"
4. Once it has finished loading, click Browse.
5. Navigate to your project directory, and look for the folder called "packages". This is where Visual Studio saves your NuGet packages after you install them.
6. Navigate to `[solution_root]\packages\jacobslusser.ScintillaNET.3.6.3\lib\net40` and choose the file `ScintillaNET.dll` and click OK.
7. Navigate to `[solution_root]\packages\EasyScintilla.1.0.3\lib\net40` and choose `EasyScintilla.dll` and click OK.
8. Click OK.
9. You should now see both the `Scintilla` and `SimpleEditor` controls appear in the Toolbox. `Scintilla` is the base editor from Scintilla.NET and `SimpleEditor` is from this project.


## Stylers

I've built a few stylers into EasyScintilla, but I will happily take pull requests for new stylers.

You can create your own stylers be deriving from the abstract class `ScintillaStyler`

Examples can be found in the `Stylers` Directory.

### Built in stylers

| Language                            | Styler Class       |
|-------------------------------------|--------------------|
| C#                                  | `CSharpStyler`     |
| HTML                                | `HtmlStyler`       |
| PowerShell                          | `PowerShellStyler` |
| Python                              | `PythonStyler`     |
| Ruby                                | `RubyStyler`       |
| SQL                                 | `SqlStyler`        |
| Teradata Parallel Transporter (TPT) | `TptStyler`        |
| Windows Batch                       | `BatchStyler`      |
| XML                                 | `XmlStyler`        |
