namespace Core.Utilities.Results
{
    //root void class
    public interface IResult
    {
        bool Success { get; }
        string Massage { get; }
    }
}
