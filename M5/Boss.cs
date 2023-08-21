public class Boss : Empleado
{
    private double irpf = 0.32;
    public Boss(string nombre, double salario): base(nombre, salario)
    {
        comprobarSueldo();
    }
    public override double CalcularSueldo()
    {
        return (SalarioMensual * 1.50)-(CalcularSueldo()*this.irpf);
    }

    public void comprobarSueldo()
    {
        if (SalarioMensual < 8000) throw new SueldoIncorrecto("El sueldo debe ser al menos de 8000");
    }
}