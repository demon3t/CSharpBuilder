using CSharpBuilder.Core.Interfaces;

namespace CSharpBuilder.Core.Base
{
    /// <summary>
    /// Базовая реализация элемента.
    /// </summary>
    public abstract class BaseElement : IElement
    {
        #region Конструкторы

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public BaseElement()
        {
            Id = Guid.NewGuid();
        }

        #endregion Конструкторы

        #region Свойства

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Контент
        /// </summary>
        public abstract IEnumerable<string> Content { get; }

        #endregion Свойства
    }
}