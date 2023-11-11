namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            File music = new Music( "12", "22", 10, 20 );

            StreamProgressInfo streamProgressInfo = new StreamProgressInfo(music);
        }
    }
}
