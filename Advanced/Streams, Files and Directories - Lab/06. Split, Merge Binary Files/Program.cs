namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.txt";
            string joinedFilePath = @"..\..\..\Files\example-joined.txt";
            string partOnePath = @"..\..\..\Files\part-1.txt";
            string partTwoPath = @"..\..\..\Files\part-2.txt";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (StreamReader originalFile = new StreamReader(sourceFilePath))
            using (StreamWriter firstFile =  new StreamWriter(partOneFilePath))
            using (StreamWriter secondFile = new StreamWriter(partTwoFilePath))
            {
                byte[] buffer = originalFile
                    .ReadToEnd()
                    .Split(", ")
                    .Select(byte.Parse)
                    .ToArray();
                int numToAdd = 0;

                if (buffer.Length % 2 == 1)
                {
                    numToAdd++;
                }

                for (int i = 0; i < buffer.Length / 2 + numToAdd; i++)
                {
                    firstFile.Write(buffer[i] + ", ");
                }

                for (int i = buffer.Length / 2 + numToAdd; i < buffer.Length; i++)
                {
                    secondFile.Write(buffer[i] + ", ");
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (StreamReader firstFile = new StreamReader(partOneFilePath))
            using (StreamReader secondFile = new StreamReader(partTwoFilePath))
            using (StreamWriter mergedFile = new StreamWriter(joinedFilePath))
            {
                string firstPart = firstFile
                    .ReadToEnd();

                string secondPart = secondFile
                    .ReadToEnd();


                mergedFile.WriteLine($"{firstPart}, {secondPart}");
            }
        }
    }
}