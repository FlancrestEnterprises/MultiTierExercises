using MongoDB.Driver;

namespace ExercisesDAL
{
   public class DbContext
    {
        //mongo class level variables
        MongoClient client;
        MongoServer server;
        MongoDatabase db;
        public DbContext()
        {
            client = new MongoClient();
            server = client.GetServer();
            db = server.GetDatabase("HelpdeskDB");
        }
        public MongoCollection<Employee> Employees
        {

            get
            {

                return db.GetCollection<Employee>("employees");


            }

        }

    }
}
