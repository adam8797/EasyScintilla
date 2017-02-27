# EasyScintilla
A (hopefully) easier way yo use Scintilla.NET in Windows Forms


### Installation

The easiest way to install is to use NuGet!

```
> Install-Package EasyScintilla
```

### Usage

The goal was to make Scintilla as easy as possible to drop into a Windows Forms project.

From the forms designer, simply drag the `SimpleEditor` control from the toolbox onto the form.

Then, in the code behind set the `Styler` property.

```C#
this.simpleEditor1 = new CSharpStyler();
```

That's it!

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