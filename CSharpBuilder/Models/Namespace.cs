using CSharpBuilder.Core.Base;
using System.Text.RegularExpressions;

namespace CSharpBuilder.Models
{
    /// <summary>
    /// Модель пространства имён.
    /// </summary>
    public partial class Namespace : BaseElementCollection
    {
        #region Конструкторы

        public Namespace(string name) : base()
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), EmptyNameError);
            }

            if (!IsValidNamespace().IsMatch(name))
            {
                throw new ArgumentException(NotValidNameError, nameof(name));
            }

            Name = name;
        }

        #endregion Конструкторы

        #region Константы

        /// <summary>
        /// Регулярное выражение для проверки корректности названия пространства имён.
        /// </summary>
        /// <returns> Регулярное выражение. </returns>
        [GeneratedRegex(@"^[a-zA-Z0-9\.]+$")]
        protected static partial Regex IsValidNamespace();
        
        /// <summary>
        /// Ошибка пустого имени пространства имён.
        /// </summary>
        protected static string EmptyNameError = 
            "Название пространства имён не может быть пустым.";

        /// <summary>
        /// Ошибка корректности имени пространства имён.
        /// </summary>
        protected static string NotValidNameError = 
            "Название пространства имён содержит недопустимые символы.";

        #endregion Константы

        #region Свойства

        /// <summary>
        /// Название пространства имён.
        /// </summary>
        protected string Name { get; set; }
        
        /// <summary>
        /// Контент.
        /// </summary>
        public override IEnumerable<string> Content 
        {
            get
            {
                yield return $"namespace {Name}";
                yield return "{"; 

                foreach (var element in Elements)
                {
                    foreach(var content in element.Content)
                    {
                        yield return "\t" + content;
                    }

                    yield return string.Empty;
                }

                yield return "}";
            }
        }

        #endregion Свойства
    }
}