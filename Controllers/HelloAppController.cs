using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;
namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        private  readonly IRegisterHelloBL _registerHelloBL;
        ResponseModel<string> responseModel;

        public HelloAppController(IRegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
        }

        [HttpGet]
        public string Get()
        {
            return _registerHelloBL.registration("value from controller");
        }

        [HttpPost]
        public ResponseModel<string> Login(LoginDTO loginDTO)
        {


            var response = new ResponseModel<string>();
            bool result = _registerHelloBL.CheckLogin(loginDTO);

            if(result)
            {
                response.Success = true;
                response.Message = "login Successfully";
                response.Data = loginDTO.UserName;
            }
            else
            {
                response.Success = false;
                response.Message = "login failed";
                response.Data = " ";

            }
            
            return response;

        }

        [HttpPost]
        [Route("register")]

        public IActionResult UserRegister(RegisterDTO registerDTO)
        {
           var result =  _registerHelloBL.registrationUser(registerDTO);
            responseModel = new ResponseModel<string>();
            responseModel.Success=true;
            responseModel.Message = "Registration Successfully";
            responseModel.Data = "";
            return Created("User Created ",result);
        }
    }
}
