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
        public ICollection<IElement> Elements { get; internal set; }

        /// <summary>
        /// Добавить элемент в коллекци.
        /// </summary>
        /// <param name="element"> Добавляемый элемент. </param>
        public void Add(IElement element);
    } 
}