using System;
class Automovil : Vehiculo
{
    public int Puertas { get; set; }

    public Automovil(string marca, string modelo, int anio, int puertas)
        : base(marca, modelo, anio)
    {
        SetPuertas(puertas);
    }

    public void SetPuertas(int puertas)
    {
        if (puertas > 0)
        {
            Puertas = puertas;
        }
        else
        {
            throw new ArgumentException("La cantidad de puertas debe ser un número entero positivo.");
        }
    }

    public new string GetInformation()
    {
        string vehiculoInfo = base.GetInformation();
        return $"{vehiculoInfo}, Puertas: {Puertas}";
    }
}
