using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class StringHelper
    {

        /// <summary>
        /// Checkea que los strings no sean NULL o esten VACIOS. Se puede pasar por argumento Uno o mas de un STRING.
        /// </summary>
        /// <param name="txts"></param>
        /// <returns>Si un string es NULL or Empty retorna false, si no es NULL o Empty Retorna true</returns>
        public static bool CheckText(params string[] txts)
        {
            foreach (string value in txts)
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    return false;
            }
            return true;
        }
    }
}
