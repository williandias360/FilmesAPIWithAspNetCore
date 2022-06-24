using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private GerenteService _gerenteService;

        public GerenteController(GerenteService gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpPost]
        public IActionResult AdicionarGerente(CreateGerenteDto gerenteDto)
        {
            ReadGerenteDto readDto = _gerenteService.AdicionarGerente(gerenteDto);
            return CreatedAtAction(nameof(RecuperarGerentePorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarGerentePorId(int id) 
        {
            ReadGerenteDto readDto = _gerenteService.RecuperarGerentePorId(id);
            return readDto == null ?
                NotFound() :
                Ok(readDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarGerente(int id)
        {
            Result resultado = _gerenteService.DeletarGerente(id);
            return resultado.IsFailed ?
                NotFound() :
                NoContent();
        }
    }
}
