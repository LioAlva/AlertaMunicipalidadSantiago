using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.Services
{
    public class DataService : IDisposable
    {


        //public Response Login(string email, string password)
        //{
        //    try
        //    {
        //        using (var da = new DataAccess())
        //        {
        //            var user = da.First<User>(true);
        //            if (user == null)
        //            {
        //                return new Response
        //                {
        //                    IsSuccess = false,
        //                    Message = "No hay conección a internet y no hay un usuario previo"
        //                };
        //            }
        //            if (user.UserName.ToUpper() == email.ToUpper() && user.Password == password)
        //            {
        //                return new Response
        //                {
        //                    IsSuccess = true,
        //                    Message = "Log Ok",
        //                    Result = user
        //                };
        //            }
        //            return new Response
        //            {
        //                IsSuccess = false,
        //                Message = "Usuario y contraseñaincorrectas"
        //            };
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Response
        //        {
        //            IsSuccess = false,
        //            Message = ex.Message
        //        };
        //    }

        //}
        public void Dispose()
        {
            //connection.Dispose();
        }
    }
}
