namespace CSharpBuilder;

/// <summary>
/// Строитель кода.
/// </summary>
public class Builder
{
    #region Конструкторы

    /// <summary>
    /// Коструктор без параметров. 
    /// </summary>
    public Builder()
    {
        FilePath = string.Empty;
    }

    /// <summary>
    /// Коструктор c параметрами.
    /// </summary>
    /// <param name="filePath"> Путь записи. </param>
    public Builder(string filePath)
    {
        FilePath = filePath;
    }

    #endregion Конструкторы

    #region Свойства

    /// <summary>
    /// Путь записи. 
    /// </summary>
    public string FilePath { get; set; }

    #endregion Свойства

    #region Методы : Public

    

    #endregion Методы : Public
}
