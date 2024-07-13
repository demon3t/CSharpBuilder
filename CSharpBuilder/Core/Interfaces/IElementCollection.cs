namespace CSharpBuilder.Core.Interfaces 
{
    /// <summary>
    /// Коллекция элементов.
    /// </summary>
    public interface IElementCollection
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Коллекция элементов.
        /// </summary>
        public IEnumerable<IElement> Elements { get; internal set; }

        /// <summary>
        /// Контент.
        /// </summary>
        public IEnumerable<string> Content { get; }
    } 
}