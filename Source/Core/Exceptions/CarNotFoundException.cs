namespace CarCatalogAPI.Source.Core.Exceptions
{
    public class CarNotFoundException : Exception
    {
        public CarNotFoundException(string message = "Id não encontrado") : base(message)
        {
        }
    }
}
