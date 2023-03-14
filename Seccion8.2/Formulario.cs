namespace seccion8._2;

public class Formulario{
    public string Nombre {get;set;}

    public byte Edad {get;set;}

    public double Estatura {get; set;}

    public decimal costoKiloTortilla {get;set;}
    
    public void ImprimirDatos(){
        Console.WriteLine(" {0}  Tiene {1 } y Mide {2} y las tortillas le cuestan {3}", Nombre ,Edad, Estatura, costoKiloTortilla);
    }
}

