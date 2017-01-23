namespace AmazonianDates.Parsers
{
    public interface IDateParser
    {
        bool IsMatch(string amazonDate);

        Interval Parse(string amazonDate);
    }
}