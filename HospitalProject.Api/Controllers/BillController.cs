using HospitalProject.Domain.Model;
using HospitalProject.Service.Dtos;
using HospitalProject.Service.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBill()
        {
            var bills = _billService.GetAll();
            return Ok(bills);
        }
        [HttpGet]
        [Route("GetBillbyId")]
        public async Task<IActionResult> GetBillbyId(int Id)
        {
            try
            {
                var bill = _billService.GetBill(Id);
                if (bill != null)
                {
                    return Ok(bill);
                }
                return NotFound();
            }
            catch
            {
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Bill bill)

        {
            try
            {
                _billService.Add(bill);
                return StatusCode(StatusCodes.Status200OK, "Data Sucessfully crated");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] BillDto billDto)
        {
            try
            {
                _billService.Update(billDto);
                return StatusCode(StatusCodes.Status200OK, "sucessfully Updated");
            }
            catch
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                _billService.Delete(Id);
                return StatusCode(StatusCodes.Status200OK, "Successfully Deleted");
            }
            catch
            {
                return StatusCode(StatusCodes.Status404NotFound, "Data Can't be found");
            }
        }
    }
}
