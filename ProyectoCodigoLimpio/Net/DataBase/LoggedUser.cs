using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace ProyectoCodigoLimpioClient.Net.DataBase
{
    public class LoggedUser
    {
        // La clase cumple con el primer principio SOLID
        // La clase cumple con el segundo principio SOLID
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("nickname")]

        public string Nickname { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("messages")]
        public List<string> Messages { get; set; }

    }
}
