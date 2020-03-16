using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary1_cs_
{
    public class Container
    {
        private
            int str_nums = 0;
            static int len1 = 10;
            MainString[] text = new MainString[len1];

        public void clear()
        {
            for (int i = 0; i < len1; i++)
            {
                text[i] = null;
            }
            str_nums = 0;
        }

        public void plus(MainString mainstring)
        {
            if (text[len1 - 1] != null)
            {
                len1 = (3 * len1) / 2 + 1;
                MainString[] newtext = new MainString[len1];
                for (int i = 0; i < str_nums; i++)
                {
                    newtext[i] = text[i];
                }
                text = newtext;
            }
            text[str_nums] = mainstring;
            str_nums++;
        }

        public int col_v_text()
        {
            int col2 = 0;
            for (int i = 0; i < str_nums; i++)
            {
                col2 += text[i].col_v_str();
            }
            return col2;
        }

        public int col_z_text()
        {
            int col = 0;
            for (int i = 0; i < str_nums; i++)
            {
                col += text[i].col_z_str();
            }
            return col;
        }

        public float pr_z_text()
        {
            float col = 0, col1 = 0;
            float pr = 0;
            col = col_v_text();
            col1 = col_z_text();
            pr = 100 * col1 / col;
            return pr;
        }

        public void delete_str(MainString mainstring)
        {
            int indx = 0;
            int i = 0;
            while (i < str_nums && !mainstring.same_str(text[i]))
            {
                indx = i;
                i++;
            }
            for (int j = indx; j < str_nums; j++)
            {
                text[j] = text[j + 1];
            }
            text[str_nums] = null;
            str_nums--;
        }

        public MainString largest_str()
        {
            MainString newstring;
            int max_len = 0;
            int index = 0;
            for (int i = 0; i < str_nums; i++)
            {
                if (text[i].strlength() > max_len)
                {
                    max_len = text[i].strlength();
                    newstring = text[i];
                    index = i;
                }
            }
            return text[index];
        }
    }
}
