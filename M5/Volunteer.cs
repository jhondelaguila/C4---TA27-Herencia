public class Volunteer : Empleado
{

    public Volunteer(string nombre, double salario) : base(nombre, salario)
    {
        comprobarSueldo();
    }
    public override double CalcularSueldo()
    {
        return 0; // No cobran
    }

    public void comprobarSueldo()
    {
        if (SalarioMensual > 0) throw new SueldoIncorrecto("El voluntario no cobra");
    }

    public double Ayuda()
    {
        return 300;
    }
}