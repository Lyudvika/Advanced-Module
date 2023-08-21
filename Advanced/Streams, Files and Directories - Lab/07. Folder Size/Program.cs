namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;

            DirectoryInfo directory = new DirectoryInfo(folderPath);
            FileInfo[] info = directory.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo infoItem in info)
            {
                sum += infoItem.Length;
            }

            sum = sum / 1024;

            Console.WriteLine(sum);
            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
