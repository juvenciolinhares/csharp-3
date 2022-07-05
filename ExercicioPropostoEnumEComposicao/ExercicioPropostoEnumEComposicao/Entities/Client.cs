﻿using System;

namespace ExercicioPropostoEnumEComposicao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string clientName, string email, DateTime birthDate)
        {
            Name = clientName;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return Name
                + " (" + BirthDate.ToString("dd/MM/yyyy") + ") - "
                + Email;
               
        }
    }
}
