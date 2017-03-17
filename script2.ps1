class Program
{
  static void Main(string[] args)
  {
    using (var writer = new StreamWriter("All.sln", false, Encoding.UTF8))
    {
      writer.WriteLine("Microsoft Visual Studio Solution File, Format Version 12.00");
      writer.WriteLine("# Visual Studio 14");

      var seenElements = new HashSet<string>();
      foreach (var file in (new DirectoryInfo(System.IO.Directory.GetCurrentDirectory())).GetFiles("*.csproj", SearchOption.AllDirectories))
      {
        string fileName = Path.GetFileNameWithoutExtension(file.Name);

        if (seenElements.Add(fileName))
        {
          var guid = ReadGuid(file.FullName);
          writer.WriteLine(string.Format(@"Project(""0"") = ""{0}"", ""{1}"",""{2}""", fileName, file.FullName, guid));
          writer.WriteLine("EndProject");
        }
      }
    }
  }

  static Guid ReadGuid(string fileName)
  {
    using (var file = File.OpenRead(fileName))
    {
      var elements = XElement.Load(XmlReader.Create(file));
      return Guid.Parse(elements.Descendants().First(element => element.Name.LocalName == "ProjectGuid").Value);
    }
  }
}