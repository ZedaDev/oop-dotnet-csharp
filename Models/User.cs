using System.Text.Json.Serialization;

namespace Entities
{
    public class User
    {
        string _nickName;
        string _pw;
        int _id;
        DateTime _fechaDeRegistro;
        

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
            //_id = -1;
        }

        #region Properties
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public DateTime FechaRegistro
        {
            get => _fechaDeRegistro;
            set => _fechaDeRegistro = value;
        }
        public string NickName 
        {
            get => _nickName;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    _nickName = value;
            }
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
            return NickName.GetHashCode();
        }
        public override string ToString()
        {
            return Mostrar();
        }
        private string Mostrar()
        {
            return $"User : {NickName}\n Registred : {FechaRegistro.ToShortDateString()}";
        }
    }
}
