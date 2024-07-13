using CSharpBuilder.Core.Interfaces;

namespace CSharpBuilder.Core.Base
{
    /// <summary>
    /// Базовая реализация элемента.
    /// </summary>
    public abstract class BaseElementCollection : IElementCollection
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public BaseElementCollection()
        {
            Id = Guid.NewGuid();
            Elements = new List<IElement>();
        }

        #endregion Конструкторы

        #region Свойства

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Коллекция элементов.
        /// </summary>
        public IEnumerable<IElement> Elements { get; set; }

        /// <summary>
        /// Контент
        /// </summary>
        public IEnumerable<string> Content { 
            get
            {
                foreach (var element in Elements)
                {
                    foreach(var content in element.Content)
                    {
                        yield return "\t" + content;
                    }

                    yield return string.Empty;
                }

                yield break;
            }
        }

        #endregion Свойства
    }
}