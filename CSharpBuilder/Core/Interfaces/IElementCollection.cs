namespace CSharpBuilder.Core.Interfaces 
{
    /// <summary>
    /// Коллекция элементов.
    /// </summary>
    public interface IElementCollection<TChild> : IElement where TChild : IElement
    {
        /// <summary>
        /// Коллекция элементов.
        /// </summary>
        public ICollection<TChild> Elements { get; internal set; }

        /// <summary>
        /// Добавить элемент в коллекци.
        /// </summary>
        /// <param name="element"> Добавляемый элемент. </param>
        public void Add(TChild element);
    } 
}