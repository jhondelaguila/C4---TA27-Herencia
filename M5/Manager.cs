public class Manager : Empleado
{
    private double irpf = 0.26;
    public Manager(string nombre, double salario) : base(nombre, salario)
    {
        comprobarSueldo();
    }
    public override double CalcularSueldo()
    {
        return (SalarioMensual * 1.10)-(CalcularSueldo()*this.irpf);
    }

    public void comprobarSueldo()
    {
        if (SalarioMensual < 3000 || SalarioMensual > 5000) throw new SueldoIncorrecto("El sueldo debe ser al menos de 3000 y no superior a 5000");
    }
}
