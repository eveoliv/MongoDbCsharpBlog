using MongoDB.Bson;
using MongoDB.Driver;

namespace projetoBlog.Models
{
    public class AcessoMongoDB
    {

        public const string MONGO_DATABASE = "Blog";
        public const string COLLECTION_USUARIOS = "Usuarios";
        public const string COLLECTION_PUBLICACOES = "Publicacoes";
        public const string CONNECTION = "mongodb://localhost:27017";

        private static readonly IMongoClient client;
        private static readonly IMongoDatabase db;

        static AcessoMongoDB()
        {
            client = new MongoClient(CONNECTION);
            db = client.GetDatabase(MONGO_DATABASE);
        }

        public IMongoClient Cliente
        {
            get { return client; }
        }

        public IMongoCollection<Usuario> Usuarios
        {
            get { return db.GetCollection<Usuario>(COLLECTION_USUARIOS); }
        }

        public IMongoCollection<Publicacao> Publicacoes
        {
            get { return db.GetCollection<Publicacao>(COLLECTION_PUBLICACOES); }
        }
    }
}
