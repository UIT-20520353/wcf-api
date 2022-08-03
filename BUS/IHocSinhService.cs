using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using DTO;

namespace BUS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHocSinhService" in both code and config file together.
    [ServiceContract]
    public interface IHocSinhService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetStudents", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<DTO_HocSinh> LayDanhSachHocSinh();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddNewStudent", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool ThemHocSinh(DTO_HocSinh hs);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteStudent", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE")]
        bool XoaHocSinh(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/UpdateStudent", RequestFormat = WebMessageFormat.Json)]
        bool SuaHocSinh(DTO_HocSinh hs);
    }
}
