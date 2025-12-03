namespace Exceptions
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException()
            : this("Mensaje Predeterminado")
        {
        }

        public ParametrosVaciosException(string message) 
            : base(message, null)
        {
        }

        public ParametrosVaciosException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
