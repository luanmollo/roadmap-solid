//LSP - Principio de sustitucion de Liskov
//Una clase hija no debe eliminar comportamiento de la clase padre
//Una clase hija puede sustituir al padre


VentaConImpuestos venta = new VentaLocal(100, "Pepe", 0.15m);
venta.CalcularImpuestos();
venta.Generar();

VentaAbstracta venta2 = new VentaExtranjera(200, "Juan");
venta2.Generar();


public abstract class VentaAbstracta //T
{
    protected decimal Monto;
    protected string Cliente;

    public abstract void Generar();
}

public abstract class VentaConImpuestos : VentaAbstracta //S
{
    protected decimal Impuestos;

    public abstract void CalcularImpuestos();
}


public class VentaLocal : VentaConImpuestos //S
{
    public VentaLocal(decimal monto, string cliente, decimal impuestos)
    {
        this.Monto = monto;
        this.Cliente = cliente;
        this.Impuestos = impuestos;
    }

    public override void Generar()
    {
        Console.WriteLine("Venta generada");
    }

    public override void CalcularImpuestos()
    {
        Console.WriteLine("Calculando impuestos");
    }


}

public class VentaExtranjera : VentaAbstracta //S
{
    public VentaExtranjera(decimal monto, string cliente)
    {
        this.Monto = monto;
        this.Cliente = cliente;
    }

    public override void Generar()
    {
        Console.WriteLine("Generando venta extranjera");
    }


}