namespace CSharpBuilder.Core.Interfaces 
{
    /// <summary>
    /// Коллекция элементов.
    /// </summary>
    public interface IElementCollection : IElement
    {
        /// <summary>
        /// Коллекция элементов.
        /// </summary>
        public IEnumerable<IElement> Elements { get; internal set; }
    } 
}