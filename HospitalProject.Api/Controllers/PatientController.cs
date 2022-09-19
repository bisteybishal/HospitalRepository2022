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
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientservice;

        public PatientController(IPatientService patientservice)
        {
            _patientservice = patientservice;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
        try{
                var patients = _patientservice.GetAll();
                return Ok(patients);
           }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error in handling data from database");
            }
        }
        [HttpGet]
        [Route("GetPatient")]
        public async Task <IActionResult> GetPatient(int patientId)
        {
            try
            {
                var patient = _patientservice.GetPatient(patientId);
                if (patient != null)
                {
                    return Ok(patient);
                }
                return StatusCode(StatusCodes.Status404NotFound, "data not found");

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Patient patient)
        {
            try 
            {
                _patientservice.Add(patient);
                return StatusCode(StatusCodes.Status201Created, "Data Posted in Database");
            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PatientDto patientdto)
        {
            try
            {
                _patientservice.Update(patientdto);
                return StatusCode(StatusCodes.Status200OK, "Data Updated");
            }
            catch
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }
        [HttpDelete]
        public async Task <IActionResult> Remove(int Id)
        {
            try
            {

                _patientservice.Remove(Id);
                return Ok("Successfully Deleted");
            }
            catch
            {
                return StatusCode(StatusCodes.Status404NotFound, "Data Found");
            }
        }
    }
}
