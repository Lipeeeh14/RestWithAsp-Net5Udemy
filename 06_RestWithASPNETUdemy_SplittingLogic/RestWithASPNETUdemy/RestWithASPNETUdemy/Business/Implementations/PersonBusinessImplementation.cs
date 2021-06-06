using Microsoft.EntityFrameworkCore.Internal;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness // service
    {

        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        // Método responsável por retornar todas as pessoas do DB
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        // Buscar uma pessoa por ID
        public Person FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Cria uma nova pessoa
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        // atualiza uma pessoa
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        // deleta a pessoa por id
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
