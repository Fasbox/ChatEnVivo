using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodigoLimpioClient.Net.DataBase
{
    public class ConexionClient
    {
        private MongoCollectionBase<LoggedUser> LoggedUsers;
        public ConexionClient()
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

        public LoggedUser ObtenerloggedUser(string password, string nickname)
        {
            var lista = LoggedUsers.Find(d => d.Password == password && d.Nickname == nickname);
            return lista.ToList()[0];
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
