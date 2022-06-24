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
    public class CinemaController : ControllerBase
    {

        private CinemaService _cinemaService;
        public CinemaController(CinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        [HttpPost]
        public IActionResult AdicionarCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            ReadCinemaDto readDto = _cinemaService.AdicionarCinema(cinemaDto);
            return CreatedAtAction(nameof(RecuperarCinemaPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaCinemas([FromQuery] string nomeDoFilme)
        {
            List<ReadCinemaDto> readDto = _cinemaService.RecuperarCinemas(nomeDoFilme);
            
            return readDto == null ? 
                NotFound() : 
                Ok(readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarCinemaPorId(int id)
        {
            ReadCinemaDto readDto = _cinemaService.RecuperaCinemasPorId(id);
            
            return readDto == null ?
                NotFound() :
                Ok(readDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Result resultado = _cinemaService.AtualizarCinema(id, cinemaDto);
            
            return resultado.IsFailed ?
                NotFound() :
                NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCinema(int id)
        {
            Result resultado = _cinemaService.DeletarCinema(id);

            return resultado.IsFailed ?
                NotFound() :
                NoContent();
        }
    }
}
