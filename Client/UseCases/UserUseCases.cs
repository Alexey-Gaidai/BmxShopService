﻿using Client.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.UseCases
{
    public interface UserUseCases
    {
        public Task<AuthInfo> LogIn(string login, string password);
        public Task<string> SignIn(string Name, string Lastname, string Email, string Phone, string Address, string Password);

    }
}