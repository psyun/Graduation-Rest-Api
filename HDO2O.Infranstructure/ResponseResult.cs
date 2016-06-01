using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDO2O.Infranstructure
{
    public class ResponseResult
    {
        /// <summary>
        /// 响应的code代码
        /// </summary>
        public ResponseCodeEnum code { get; set; }
        /// <summary>
        /// 响应的描述信息
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 响应携带的data参数
        /// </summary>
        public object data { get; set; }


        /// <summary>
        /// 默认是SUCCESS
        /// </summary>
        /// <param name="code"></param>
        /// <param name="description"></param>
        public ResponseResult(ResponseCodeEnum code = ResponseCodeEnum.SUCCESS, string description = "")
        {
            this.code = code;
            this.description = description;
        }

        public void SetServerError(string exMessage, string preffix = "")
        {
            if (string.IsNullOrEmpty(preffix))
            {
                preffix = "服务器内部错误，请联系管理员解决。详细信息:";
            }

            this.code = ResponseCodeEnum.SERVER_ERROR;
            this.description = string.Format("{0}{1}", preffix, exMessage);
        }
    }
}
