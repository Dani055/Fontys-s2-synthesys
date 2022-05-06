using BusinessLayer.models;
using Newtonsoft.Json;

namespace DuelSysWeb
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            }));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
        }
        public static User GetLoggedUser(this ISession session)
        {
            return session.GetObject<User>("loggedUser");
        }

    }
}
