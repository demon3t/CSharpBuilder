using CSharpBuilder.Core.Interfaces;

namespace CSharpBuilder.Core.Base
{
    /// <summary>
    /// Базовая реализация элемента.
    /// </summary>
    public abstract class BaseElementCollection<TChild> : IElementCollection<TChild> where TChild : IElement 
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public BaseElementCollection()
        {
            Id = Guid.NewGuid();
            Elements = new List<TChild>();
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
        public ICollection<TChild> Elements { get; set; }

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

        #region Методы : Public

        /// <summary>
        /// Добавить элемент в коллекцию.
        /// </summary>
        /// <param name="element"> ДОбавляемый элемент. </param>
        public virtual void Add(TChild element)
        {
            if (!Elements.Any(e => element.Id == element.Id))
            {
                Elements.Add(element);
            }
        }

        #endregion Методы : Public
    }
}