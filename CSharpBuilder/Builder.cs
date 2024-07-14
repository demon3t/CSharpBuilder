using CSharpBuilder.Core.Base;
using System.Text;

namespace CSharpBuilder
{
    /// <summary>
    /// Строитель кода.
    /// </summary>
    public class Builder : BaseElementCollection
    {
        #region Конструкторы

        /// <summary>
        /// Коструктор без параметров. 
        /// </summary>
        public Builder()
        {
            FilePath = string.Empty;
            Usings = new List<string>();
            _hasNamespase = false;
        }

        /// <summary>
        /// Коструктор c параметрами.
        /// </summary>
        /// <param name="namespace"> Пространство имён. </param>
        public Builder(string @namespace) : this()
        {
            _hasNamespase = true;
        }

        #endregion Конструкторы

        #region Свойства

        /// <summary>
        /// Путь записи. 
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Директивы.
        /// </summary>
        public IList<string> Usings { get; protected set;}


        /// <summary>
        /// Есть пространство имён.
        /// </summary>
        private bool _hasNamespase = false;

        #endregion Свойства

        #region Методы : Public

        /// <summary>
        /// Установить директивы.
        /// </summary>
        /// <param name="usings"> Коллекция директив. </param>
        public void SetUsing(IEnumerable<string> usings)
        {
            Usings.Clear();

            foreach (var @using in usings)
            {
                Usings.Add(@using.Replace(";", ""));
            }
        }

        /// <summary>
        /// Добавить директивы.
        /// </summary>
        /// <param name="usings"> Коллекция директив. </param>
        public void AddUsing(IEnumerable<string> usings)
        {
            foreach (var @using in usings)
            {
                var _using = @using.Replace(";", "");

                if (!Usings.Contains(_using))
                {
                    Usings.Add(_using);
                }
            }
        }

        /// <summary>
        /// Записать в файл.
        /// </summary>
        /// <param name="filePath"> Полный путь к файлу. </param>
        public void WriteToFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            var sb = new StringBuilder();

            foreach (var line in Content)
            {
                sb.AppendLine(line);
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        #endregion Методы : Public
    }
}