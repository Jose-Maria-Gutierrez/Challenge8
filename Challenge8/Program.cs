using Challenge8;
using Challenge8.Factory;
/*
Banco banco = new Banco("frances", "mar del plata");


Cuenta c2 = new Cuenta("hernan","alvarez",786.55,banco);
Cuenta clon2 = (Cuenta)c2.clone();

Console.WriteLine(c2);
Console.WriteLine(clon2);
Console.WriteLine("cambio");
c2.Banco.Ciudad = "pinamar";
c2.Nombre = "jorge";
Console.WriteLine(c2);
Console.WriteLine(clon2);
*/
/*
Auto auto1 = new Auto("ford");
Banco banco = new Banco("frances", "mar del plata");
CajaAhorro c1 = new CajaAhorro("jose", "gutierrez", 200.25, banco, 10,auto1);
CajaAhorro clon1 = (CajaAhorro)c1.clone();
Console.WriteLine(c1);
Console.WriteLine(clon1);
Console.WriteLine("cambio");
c1.Banco.Ciudad = "pinamar";
c1.Interes = 50;
c1.Auto.Marca = "mercedes";
Console.WriteLine(c1);
Console.WriteLine(clon1);
*/
/*
Console.WriteLine("caja de ahorro\n" + c1);
Console.WriteLine("cuenta\n" + c2);

CajaAhorro clon1 = (CajaAhorro)c1.clone();
Console.WriteLine(clon1);
Cuenta clon2 = (Cuenta)c2.clone();
Console.WriteLine(clon2);

c1.Interes = 30;
Console.WriteLine("dsp del cambio");
Console.WriteLine("caja de ahorro\n" + c1);
Console.WriteLine(clon1);
 */
BaseDatos f1 = ConnectionFactory.connect("sql");
if (f1 != null)
{
    f1.getConnection();
}
f1 = ConnectionFactory.connect("oracle");
if (f1 != null)
{
    f1.getConnection();
}
f1 = ConnectionFactory.connect("pepe");
if (f1 != null)
{
    f1.getConnection();
}
f1 = ConnectionFactory.connect("mysql");
if (f1 != null)
{
    f1.getConnection();
}