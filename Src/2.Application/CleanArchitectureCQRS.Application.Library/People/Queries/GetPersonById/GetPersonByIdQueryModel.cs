﻿using CleanArchitectureCQRS.Domain.Library.Person.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Library.People.Queries.GetPersonById
{
    public class GetPersonByIdQueryModel : IRequest<Person>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}