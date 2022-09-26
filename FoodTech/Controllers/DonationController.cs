using FoodTech.Interface;
using FoodTech.Models;
using FoodTech.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FoodTech.Controllers
{
    [ApiController]
    public class DonationController : Controller
    {
        private readonly IDonationService donationService;
        public DonationController(IDonationService donationService)
        {
            this.donationService = donationService;
        }

        #region Doações
        [HttpPost("cadastrar-doacao")]
        public IActionResult PostDoacao([FromBody] DonationDto donation)
        {
            var result = donationService.PostDoacao(donation);
            return Ok(result);
        }
        #endregion

        #region Verificações estoques
        [HttpGet("consultar-doacoes")]
        public IActionResult GetAllDoacao()
        {
            var result = donationService.GetDoacao();
            return Ok(result);
        }
        [HttpPut("entregar-doacao")]
        public IActionResult PutDoacao([FromBody] DeliverDonationDto donation)
        {
            var result = donationService.PutDoacao(donation);
            return Ok(result);
        }
        #endregion
    }
}
