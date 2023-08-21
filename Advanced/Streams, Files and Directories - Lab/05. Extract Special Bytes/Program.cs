using System.Text;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader binaryReader = new StreamReader(binaryFilePath), 
                bytesToExtract = new StreamReader(bytesFilePath))
            {
                byte[] binaryFileBytes = File.ReadAllBytes(binaryFilePath);
                List<string> bytesList = new List<String>();

                while (!binaryReader.EndOfStream)
                {
                    bytesList.Add(binaryReader.ReadLine());
                }

                foreach (var item in binaryFileBytes)
                {
                    if (bytesList.Contains(item.ToString()))
                    {
                        sb.AppendLine(item.ToString());
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(outputPath))
            {
                file.WriteLine(sb.ToString().Trim());
            }           
        }
    }
}