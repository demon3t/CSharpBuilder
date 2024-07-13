namespace CSharpBuilder.Core.Interfaces 
{
    /// <summary>
    /// Элемент.
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Контент.
        /// </summary>
        public IEnumerable<string> Content { get; }
    } 
}