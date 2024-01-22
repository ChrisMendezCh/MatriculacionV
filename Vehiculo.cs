using System;
class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }

    public Vehiculo(string marca, string modelo, int anio)
    {
        SetMarca(marca);
        SetModelo(modelo);
        SetAnio(anio);
    }

    public void SetMarca(string marca)
    {
        if (!string.IsNullOrEmpty(marca))
        {
            Marca = marca;
        }
        else
        {
            throw new ArgumentException("La marca debe ser una cadena no vacía.");
        }
    }

    public void SetModelo(string modelo)
    {
        if (!string.IsNullOrEmpty(modelo))
        {
            Modelo = modelo;
        }
        else
        {
            throw new ArgumentException("El modelo debe ser una cadena no vacía.");
        }
    }

    public void SetAnio(int anio)
    {
        if (anio > 0)
        {
            Anio = anio;
        }
        else
        {
            throw new ArgumentException("El año debe ser un número entero positivo.");
        }
    }

    public string GetInformation()
    {
        return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}";
    }

    public string RunAction()
    {
        return "Realizando una acción genérica del vehículo.";
    }
}
