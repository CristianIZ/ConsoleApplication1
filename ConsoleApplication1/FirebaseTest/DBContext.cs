using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace FirebaseTest
{
    public class DBContext<T>
    { 
        FirebaseClient _client;
        string _child;
        public DBContext()
        {
            _child = typeof(T).Name;


            var url = "https://proyectoprueba-b9c83.firebaseio.com/";


            _client = new FirebaseClient(url);

        }
        public void Delete(T entity)
        {
            _client.Child(_child).DeleteAsync();
        }

        public IList<T> GetAll()
        {

            var res = _client.Child(_child).OnceAsync<T>();

            return res.Result.ToList().Select(y => y.Object).ToList();
        }

        public T Save(T entity)
        {
            var Id = Guid.NewGuid().ToString();
            var xx = _client.Child(_child).Child(Id.ToString()).PostAsync(entity);

            return xx.Result.Object;
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
