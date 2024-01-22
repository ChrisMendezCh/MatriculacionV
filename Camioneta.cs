using System;

class Camioneta : Vehiculo
{
    public double CapacidadCarga { get; set; }

    public Camioneta(string marca, string modelo, int anio, double capacidadCarga)
        : base(marca, modelo, anio)
    {
        SetCapacidadCarga(capacidadCarga);
    }

    public void SetCapacidadCarga(double capacidadCarga)
    {
        if (capacidadCarga > 0)
        {
            CapacidadCarga = capacidadCarga;
        }
        else
        {
            throw new ArgumentException("La capacidad de carga debe ser un número flotante positivo.");
        }
    }

    public new string GetInformation()
    {
        string vehiculoInfo = base.GetInformation();
        return $"{vehiculoInfo}, Capacidad de carga: {CapacidadCarga}";
    }
}
