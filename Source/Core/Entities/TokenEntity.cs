namespace CarCatalogAPI.Source.Core.Entities
{
    public class TokenEntity
    {
        public TokenEntity(string value)
        {
            Value = value;
        }
    
        public string Value { get; }
    }
}
