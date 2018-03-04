using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace DAL
{
    public class RedisRepository
    {
        private IDatabase db;
        public RedisRepository()
        {
            ConfigurationOptions co = new ConfigurationOptions()
            {
                SyncTimeout = 500000,
                ConnectTimeout = 10000,
                AbortOnConnectFail = false,
                EndPoints = { "localhost"}
            };
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(co);
            db = redis.GetDatabase();

        }
        public void Set(string key, string value)
        {
            db.StringSet(key, value);
        }
        public string Get(string key)
        {
            return db.StringGet(key);
        }

        public void Delete(string key)
        {
            db.KeyDelete(key);
        }

    }
}
