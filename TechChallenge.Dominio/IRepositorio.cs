﻿namespace TechChallenge.Dominio;

public interface IRepositorio<T> where T : Entidade
{
    void Criar(T entidade);
    IList<T> BuscarEntidades();
    T? BuscarEntidade(int id);
    void Editar(T entidade);
    void Apagar(int id);
}
