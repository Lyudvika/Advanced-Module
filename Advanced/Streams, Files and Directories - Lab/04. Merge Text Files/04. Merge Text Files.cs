namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            List<string> nums = new List<string>();

            using (StreamReader firstInput =  new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondInput = new StreamReader(secondInputFilePath))
                {
                    string firstLine = firstInput.ReadLine();
                    string secondLine = secondInput.ReadLine();

                    while (firstLine != null || secondLine != null)
                    {
                        if (firstLine != null)
                        {
                            nums.Add(firstLine);
                        }
                        if (secondLine != null)
                        {
                            nums.Add(secondLine);
                        }

                        firstLine = firstInput.ReadLine();
                        secondLine = secondInput.ReadLine();
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath)) 
            {
                writer.WriteLine(string.Join(System.Environment.NewLine, nums));
            }
        }
    }
}