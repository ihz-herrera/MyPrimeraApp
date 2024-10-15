using MyPrimeraApp.Entidades;
using System.Collections.Generic;

public interface IRepository<Nose> where Nose : Entidad
{
    void Guardar(Nose entidad);
    Nose Obtener(int id);
    List<Nose> Obtener();
}