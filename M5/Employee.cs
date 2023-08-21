using static System.Runtime.InteropServices.JavaScript.JSType;

public class Employee : Empleado
{
    public Employee(string nombre, double salario): base(nombre, salario) { }
    public override double CalcularSueldo()
    {
        return SalarioMensual * 0.85;
    }
}

public class Junior : Employee
{
    private double irpf = 0.02;

    public Junior(string nombre, double salario) : base(nombre, salario)
    {
        comprobarSueldo();
    }
    public override double CalcularSueldo()
    {
        return (SalarioMensual * 0.85)-(CalcularSueldo()*this.irpf); // Reducción del 15%
    }

    public void comprobarSueldo()
    {
        if (SalarioMensual < 900 || SalarioMensual > 1600) throw new SueldoIncorrecto("El sueldo debe ser al menos de 900 y no superior a 1600");
    }
}

public class Mid : Employee
{
    private double irpf = 0.15;

    public Mid(string nombre, double salario) : base(nombre, salario)
    {
        comprobarSueldo();
    }
    public override double CalcularSueldo()
    {
        return (SalarioMensual * 0.90) - (CalcularSueldo() * this.irpf); // Reducción del 10%
    }

    public void comprobarSueldo()
    {
        if (SalarioMensual < 1800 || SalarioMensual > 2500) throw new SueldoIncorrecto("El sueldo debe ser al menos de 1800 y no superior a 2500");
    }
}

public class Senior : Employee
{
    private double irpf = 0.24;

    public Senior(string nombre, double salario) : base(nombre, salario)
    {
        comprobarSueldo();
    }
    public override double CalcularSueldo()
    {
        return (SalarioMensual * 0.95) - (CalcularSueldo() * this.irpf); // Reducción del 5%
    }

    public void comprobarSueldo()
    {
        if (SalarioMensual < 2700 || SalarioMensual > 4000) throw new SueldoIncorrecto("El sueldo debe ser al menos de 2700 y no superior a 4000");
    }
}
