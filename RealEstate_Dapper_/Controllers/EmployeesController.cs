﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;
using RealEstate_Dapper_Api.Repositories.EmployeeRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Çalışan Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Çalışan Başarıyla Güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var values = await _employeeRepository.GetEmployeeAsync(id);
            return Ok(values);
        }
    }
}
