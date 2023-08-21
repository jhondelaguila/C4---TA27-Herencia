public class Empleado
{
    private string nombre;
    private double salario;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public double SalarioMensual
    {
        get { return salario;}
        set { salario = value;}
    }

    public Empleado(string nombre, double salario)
    {
        this.nombre = nombre;
        this.salario = salario;
    }

    public virtual double CalcularSueldo()
    {
        return SalarioMensual;
    }

    public void EmitirBonus()
    {
        this.SalarioMensual = SalarioMensual * 1.10;
    }
}
