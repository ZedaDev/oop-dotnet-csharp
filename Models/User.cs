namespace Models
{
    public class User
    {
        private string _nickName;
        private string _pw;

        public User(string nickName, string pw)
        {
            _nickName = nickName;
            _pw = pw;
        }

        #region Properties
        public string NickName 
        {
            get => _nickName;
            set 
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
            }

        }
        public string Pass
        { 
            get => _pw;
            set 
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    _pw = value;
            } 

        }

        #endregion

        public static bool operator ==(List<User> listaUsuarios, User u2)
        {
            if(u2 is not null)
            {
                foreach (User value in listaUsuarios)
                {
                    if (value.NickName == u2.NickName)
                        return true;
                }

            }
            return false;

        }
        public static bool operator !=(List<User> listaUsuarios, User u2)
        {
            return !(listaUsuarios == u2);
        }

        public override bool Equals(object? obj)
        {
            if(obj is not null && this.GetType() == obj.GetType())
            {
                if (this.NickName == ((User)obj).NickName)
                    return true;
            }

             return false;
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
            return $"User : {NickName} - Pw : {Pass}";
        }
    }
}
