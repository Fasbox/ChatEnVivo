using MongoDB.Driver;
using ProyectoCodigoLimpioClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodigoLimpioClient.Net.DataBase
{
    public class MongoDBService : IDatabaseService
    {
        // La clase cumple con el primer principio SOLID
        // La clase cumple con el segundo principio SOLID

        private MongoCollectionBase<LoggedUser> LoggedUsers;
        public MongoDBService()
        {
            var pass = "AdminMongoAtlas";
            var databaseName = "ChuBox";
            var collection = "loggedUser";
            var settings = MongoClientSettings.FromConnectionString($"mongodb+srv://Admin:{pass}@clusteradrianperdomo.b32op.mongodb.net/{databaseName}?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase(databaseName);
            LoggedUsers = (MongoCollectionBase<LoggedUser>?)database.GetCollection<LoggedUser>("loggedUser");
        }

        public void insertLoggedUser(LoggedUser nuevo)
        {
            LoggedUsers.InsertOne(nuevo);

        }

        public List<LoggedUser> ObtenerLogggedUsers()
        {
            var filter = Builders<LoggedUser>.Filter.Empty;

            var lista = LoggedUsers.Find(filter);
            return lista.ToList();
        }

        public LoggedUser? ObtenerloggedUser(string password, string nickname)
        {
            var lista = LoggedUsers.Find(d => d.Password == password && d.Nickname == nickname);
            if (lista.Count() == 0)
            {
                return null;
            }
            return lista.ToList()[0];
        }

        public bool LoggedUserExist(string nickname)
        {
            var lista = LoggedUsers.Find(d => d.Nickname == nickname);
            return lista.ToList().Count != 0;
        }
        public void UpdateLoggedUser(LoggedUser userToUpdate)
        {
            this.LoggedUsers.ReplaceOne(d => d.Id == userToUpdate.Id, userToUpdate);
        }

        public void DeleteLoggedUser(LoggedUser loggedUser)
        {
            this.LoggedUsers.DeleteOne(d => d.Id == loggedUser.Id);
        }
    }
}
