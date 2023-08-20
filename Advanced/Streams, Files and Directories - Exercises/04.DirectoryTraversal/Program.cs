namespace DirectoryTraversal
{
    using System;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);

            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionsFiles = new();

            string[] files = Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                FileInfo fileInfo = new(file);

                if (!extensionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extensionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }

                extensionsFiles[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var extensionsFile in extensionsFiles.OrderByDescending(x => x.Value.Count))
            {
                sb.Append(extensionsFile.Key);

                foreach (var extension in extensionsFile.Value.OrderBy(f => f.Length))
                {
                    //--Mecanismo.cs - 0.994kb
                    sb.Append($"--{extension.Name} - {(double)extension.Length / 1024}kb");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}
