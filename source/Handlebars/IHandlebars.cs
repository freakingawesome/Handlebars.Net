using System;
using System.IO;
using HandlebarsDotNet.Compiler;
using System.Text;

namespace HandlebarsDotNet
{
    public interface IHandlebars
    {
        Action<TextWriter, object> Compile(TextReader template);

        Func<object, string> Compile(string template);

        HandlebarsConfiguration Configuration { get; }

        void RegisterTemplate(string templateName, Action<TextWriter, object> template);

        void RegisterHelper(string helperName, HandlebarsHelper helperFunction);

        void RegisterHelper(string helperName, HandlebarsBlockHelper helperFunction);
    }
}

