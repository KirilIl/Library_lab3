namespace Library.Data.Entities.QuoteAggregate
{
   public class Quote
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string QuoteString { get; set; }
    }
}
