using System.Text.Json.Serialization;

namespace Entities
{
    public class User
    {
        private string _nickName;
        private string _pw;
        

        [JsonConstructor]
        public User(string nickName, string pw)
        {
            _nickName = nickName;
            _pw = pw;
        }
        public User()
        {
            _nickName = "";
            _pw = "";
        }

        #region Properties
        public string NickName 
        {
            get => _nickName;
            /*set 
            {
                string _value = value.Trim();
                if (!string.IsNullOrEmpty(_value))
                {
                    bool ok = true;
                    foreach (User u in Usuarios.UsersList)
                    {
                        if (u.NickName == _value)
                        {
                            ok = false;
                            break;
                        }
                    }
                        if (ok)
                         _nickName = _value;
                }
            }*/

        }
        public string Pw
        { 
            get => _pw;
            set 
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    _pw = value;

            } 

        }

        #endregion

        public static bool operator ==(User u1, User u2)
        {

            if (ReferenceEquals(u1, u2)) return true;

            if (u1 is null || u2 is null) return false;

            return u1.NickName == u2.NickName;
           
        }
        public static bool operator !=(User u1, User u2)
        {
            return !(u1 == u2);
        }

        public override bool Equals(object? obj)
        {
             return this == ((User)obj);
        }

        public override int GetHashCode()
        {
            return this.NickName.GetHashCode();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private string Mostrar()
        {
            return $"User : {NickName} - Pw : {Pw}";
        }
    }
}
