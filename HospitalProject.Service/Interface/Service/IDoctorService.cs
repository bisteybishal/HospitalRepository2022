﻿using HospitalProject.Domain.Model;
using HospitalProject.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Service.Interface.Service
{
    public interface IDoctorService
    {
        IQueryable<DoctorDto> GetAll();
        Doctor GetDoctor(int Id);
        void Add(Doctor entity);
        void Update(DoctorDto doctorDto);
        void Delete(int id);
    }
}
