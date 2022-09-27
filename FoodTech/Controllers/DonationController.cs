using AutoMapper;
using FoodTech.Data;
using FoodTech.Models;
using FoodTech.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FoodTech.Controllers
{
    [ApiController]
    public class DonationController : Controller
    {
        private readonly DonationContext _donation;
        private readonly IMapper _mapper;
        public DonationController(DonationContext donation, IMapper mapper)
        {
            _donation = donation;
            _mapper = mapper;
        }

        #region Doações
        [HttpPost("cadastrar-doacao")]
        public IActionResult PostDoacao([FromBody] DonationDto donationDto)
        {
            DonationModel donation = _mapper.Map<DonationModel>(donationDto);
            _donation.DonationModel.Add(donation);
            _donation.SaveChanges();
            return NoContent();
        }
        #endregion

        #region Verificações estoques
        [HttpGet("consultar-doacoes")]
        public IEnumerable<DonationModel> GetAllDoacao()
        {
            return _donation.DonationModel;
        }
        [HttpPut("entregar-doacao")]
        public IActionResult PutDoacao([FromBody] DonationDto donationDto)
        {
            DonationModel donation = _donation.DonationModel.FirstOrDefault(data => data.IdDoacao == donationDto.IdDoacao);
            if (donation == null)
            {
                return NotFound();
            }
            _mapper.Map(donationDto, donation);
            _donation.Update(donation);
            _donation.SaveChanges();
            return NoContent();
        }
        #endregion
    }
}
