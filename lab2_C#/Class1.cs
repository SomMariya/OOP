using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary1_cs_
{
    public class MainString
    {
        private char[] str;

        public MainString(char[] str)
        {
            int len = 0;
            int i = 0;
            while (str[i] != '\n')
            {
                len++;
                i++;
            }
            this.str = new char[len + 1];
            for (int j = 0; j < len + 1; j++)
            {
                this.str[j] = str[j];
            }
        }

        public int strlength()
        {
            int len = 0;
            if (str == null)
            {
                return len;
            }
            while (str[len] != '\n')
            {
                len++;
            }
            return len;
        }

        public bool check()
        {
            return strlength() == 0;
        }

        public int col_v_str()
        {
            int i = 0;
            int col = 0;
            if (str == null)
            {
                return col;
            }
            while (str[i] != '\n')
            {
                if (str[i] != ' ')
                    col++;
                i++;
            }
            return col;
        }

        public int col_z_str()
        {
            int i = 0;
            int col = 0;
            if (str == null)
            {
                return col;
            }
            while (str[i] != '\n')
            {
                if (str[i] >= '0' && str[i] <= '9')
                    col++;
                i++;
            }
            return col;
        }

        public int pr_v_str()
        {
            int col = 0;
            int pr = 0;
            int i = col_v_str();
            col = col_z_str();
            if (col > 0)
            {
                pr = (100 * col) / i;
            }
            return pr;
        }

        public bool same_str(MainString mainstr)
        {
            int eq = 0;
            if (this.str == mainstr.str)
                return true;
            if (strlength() == mainstr.strlength())
            {
                for (int i = 0; i < strlength(); i++)
                {
                    if (str[i] == mainstr.str[i])
                        eq++;
                }
                if (eq == strlength())
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }







    }
}
