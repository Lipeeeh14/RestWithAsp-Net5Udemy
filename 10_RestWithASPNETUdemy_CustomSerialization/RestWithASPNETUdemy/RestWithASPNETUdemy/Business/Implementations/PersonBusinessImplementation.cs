using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness // service
    {

        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        // Método responsável por retornar todas as pessoas do DB
        public List<PersonVO> FindAll()
        {
            // convertendo a entidade para um PersonVO
            return _converter.Parse(_repository.FindAll());
        }

        // Buscar uma pessoa por ID
        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Cria uma nova pessoa
        public PersonVO Create(PersonVO person)
        {
            // Converte para Person, pois só assim será salvo no DB
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            // Converte para PersonVO novamente para retornar o objeto VO
            return _converter.Parse(personEntity);
        }

        // atualiza uma pessoa
        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        // deleta a pessoa por id
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
