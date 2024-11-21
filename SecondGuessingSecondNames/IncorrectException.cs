namespace SecondGuessingSecondNames;
class IncorrectException : Exception
{
    public IncorrectException() : base() { } 
    public IncorrectException(string message) : base(message) { }
    public IncorrectException(string message, Exception innerException) : base(message, innerException) { }
}
