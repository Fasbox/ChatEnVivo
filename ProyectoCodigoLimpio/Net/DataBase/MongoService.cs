﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodigoLimpioClient.Net.DataBase
{
    public interface DataBaseService
    {
        public void insertLoggedUser(LoggedUser nuevo);
        public List<LoggedUser> ObtenerLogggedUsers();
        public LoggedUser? ObtenerloggedUser(string password, string nickname);
        public bool LoggedUserExist(string nickname);
        public void UpdateLoggedUser(LoggedUser userToUpdate);
        public void DeleteLoggedUser(LoggedUser loggedUser);
    }
}
