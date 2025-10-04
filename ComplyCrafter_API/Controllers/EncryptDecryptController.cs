using ComplyCrafter_BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplyCrafter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptDecryptController : ControllerBase
    {
        [HttpGet("encrypt")]
        public IActionResult Encrypt(string input)
        {
            if (string.IsNullOrEmpty(input))
                return BadRequest("plainText is required.");

            string encrypted = EncryptDecrypt.EncryptString(input);
            return Ok(encrypted);
        }

        [HttpGet("decrypt")]
        public IActionResult Decrypt(string input)
        {
            if (string.IsNullOrEmpty(input))
                return BadRequest("cipherText is required.");

            string decrypted = EncryptDecrypt.DecryptString(input);
            return Ok(decrypted);
        }
    }
}
