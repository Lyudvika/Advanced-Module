using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

public class Program
{
    private const string SplitterInputLine = ", ";
    private const string SplitterFaceSuit = " ";
    public static void Main(string[] args)
    {
        string[] inputLine = Console.ReadLine()
            .Split(SplitterInputLine, StringSplitOptions.RemoveEmptyEntries);

        List<Card> cards = new List<Card>();

        for (int i = 0; i < inputLine.Length; i++)
        {
            try
            {
                string[] cardInfo = inputLine[i].Split(SplitterFaceSuit, StringSplitOptions.RemoveEmptyEntries);
                Card card = new Card(cardInfo[0], char.Parse(cardInfo[1]));
                cards.Add(card);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid card!");
            }
        }

        Console.WriteLine(string.Join(" ", cards));
    }
     
}


public class Card
{
    private const string InvalidCardDefinition = "Invalid card!";

    private string face;
    private char suit;

    public Card(string face, char suit)
    {
        Face = face;
        Suit = suit;
    }
    public string Face 
    {
        get => face;
        private set
        {
            if (value != "1"
                && value != "2"
                && value != "3" 
                && value != "4"
                && value != "5"
                && value != "6"
                && value != "7"
                && value != "8"
                && value != "9"
                && value != "10"
                && value != "J"
                && value != "Q"
                && value != "K"
                && value != "A")
                throw new ArgumentException(InvalidCardDefinition);

            face = value;
        }
    }
    public char Suit
    {
        get => suit;
        private set
        {
            char symbol = ' ';
            switch (value) 
            {
                case 'S':
                    symbol = '\u2660';
                    break;
                case 'H':
                    symbol = '\u2665';
                    break;
                case 'D':
                    symbol = '\u2666';
                    break;
                case 'C':
                    symbol = '\u2663';
                    break;
                default:
                    throw new ArgumentException(InvalidCardDefinition);
            }

            suit = symbol;
        }
    }

    public override string ToString()
        => $"[{Face}{Suit}]";
}