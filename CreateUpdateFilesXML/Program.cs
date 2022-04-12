using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreateUpdateFilesXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            if (args.Any())
            {
                path = args[0];
            }
            var files = Directory.GetFiles(path);

            var publishUrl = "ftp://xxx.xxx.xxx.xxx/Publish/";
            if (args.Count() > 1)
            {
                publishUrl=args[1];
            }
            Console.WriteLine($"the publish url is ：{publishUrl} ,setting by the second parameter！");

            var xml = new XDocument(new XElement("updateFiles"));
            foreach (var fileName in files)
            {
                var file = new FileInfo(fileName);
                if (file.Extension == ".xml") continue;
                if (file.Extension == ".pdb") continue;

                var fileVersionInfo = FileVersionInfo.GetVersionInfo(file.FullName);
                xml.Root.AddFirst(
                    new XElement("file",
                    new XAttribute("path", file.Name),
                    new XAttribute("url", Path.Combine(publishUrl,file.Name)),//todo support sub directory
                    //new XAttribute("url", file.FullName),
                    //new XAttribute("url", file.Name),
                    new XAttribute("lastver", fileVersionInfo.FileVersion ?? "1.0.0"),
                    new XAttribute("size", file.Length),
                    new XAttribute("needRestart", false))
                    );
            }
            xml.Save("AutoupdateService.xml");

            Console.WriteLine("AutoupdateService.xml created");
        }      
    }
}
