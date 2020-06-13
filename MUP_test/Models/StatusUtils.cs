using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUP_test.Models
{
    public class StatusUtils
    {
        public static readonly string[] StatusNames = new string[]
        {
            "Открыта","Решена","Возврат","Закрыта"
        };

        public static string GetStatusName(int status)
        {
            return StatusNames[status];
        }

        public static int[] GetAccessStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return new int[] { 1 };
                case 1:
                    return new int[] { 2, 3 };
                case 2:
                    return new int[] { 1 };

                default:
                    return new int[] { } ;
            }
        }

        public static bool CheckNextStatus(int cur_status,int new_status)
        {
            return GetAccessStatus(cur_status).Contains<int>(new_status);
        }


        public static string getJSArray()
        {
            return string.Join(',', StatusNames.Select(a => string.Format("'{0}'", a))
                                              .ToArray());
                       
        }
    }
}
