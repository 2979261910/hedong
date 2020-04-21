using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Common
{
    public class DataValidate
    {
        /// <summary>
        /// 验证正整数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsInteger(string str)
        {
            Regex reg=new Regex(@"^[1-9]\d*$");
            return reg.IsMatch(str);
        }
        ///身份证验证、电话或手机号验证、日期验证
    }
}
