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
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDoctor()
        {
            var doctors = _doctorService.GetAll();
            return Ok(doctors);
        }
        [HttpGet]
        [Route("GetDoctorbyId")]
        public async Task<IActionResult> GetDoctorbyId(int doctorId)
        {
            try
            {
                var doctor = _doctorService.GetDoctor(doctorId);
                if (doctor != null)
                {
                    return Ok(doctor);
                }
                return StatusCode(StatusCodes.Status404NotFound);
            }
            catch
            {
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Doctor doctor)
        {
            try
            {
                _doctorService.Add(doctor);
                return StatusCode(StatusCodes.Status200OK, "Data Added");
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Can't Add data ");
            }
           
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] DoctorDto doctorDto)
        {
            try
            {
                _doctorService.Update(doctorDto);
                return StatusCode(StatusCodes.Status200OK, "Data Updated");

            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _doctorService.Delete(id);
                return StatusCode(StatusCodes.Status200OK);
            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }
    }
}
