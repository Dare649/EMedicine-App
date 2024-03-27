using EMedicineBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace EMedicineBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("registration")]
        public Response register(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            response = dal.register(users, connection);

            return response;
        }

        [HttpPost]
        [Route("login")]
        public Response login(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            response = dal.login(users, connection);


            return response;
        }

        [HttpGet]
        [Route("viewUsers")]
        public Response viewUser(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            response = dal.viewUser(users, connection);

            return response;
        }

        [HttpPut]
        [Route("updateProfile")]
        public Response updateProfile(Users users)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            DAL dal = new DAL();
            response = dal.updateProfile(users, connection);


            return response;
        }


    }
}
