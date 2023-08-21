[Serializable]
public class SueldoIncorrecto : Exception
{
    public SueldoIncorrecto(string message)
        : base(message) { }
}