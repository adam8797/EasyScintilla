using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EasyScintilla.Stylers;

namespace ExampleProject
{
    public class ExampleDisplay
    {
        private readonly string _textFile;

        public string Display { get; }

        public ScintillaStyler Styler { get; }

        public ExampleDisplay(string display, string textFile, ScintillaStyler styler)
        {
            _textFile = textFile;
            Display = display;
            Styler = styler;
        }

        public string ReadFile()
        {
            using (var file = Assembly.GetAssembly(GetType()).GetManifestResourceStream("ExampleProject.ExampleCode." + _textFile))
            using (var reader = new StreamReader(file))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
