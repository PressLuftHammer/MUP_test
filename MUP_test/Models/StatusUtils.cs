using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUP_test.Models
{
    public class StatusUtils
    {
        private static string[] StatusNames = new string[]
        {
            "Открыта","Решена","Возврат","Закрыта"
        };        

        public static string GetStatusName(int status)
        {
            return StatusNames[status];
        }

        private static Dictionary<int, int[]> Steps = new Dictionary<int, int[]>
        {
            {0,new int[]{1} },
            {1,new int[]{2,3}},
            {2,new int[]{1}}
        };


        public static int[] GetAccessStatus(int status)
        {
            return Steps.GetValueOrDefault(status, new int[] { });
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
