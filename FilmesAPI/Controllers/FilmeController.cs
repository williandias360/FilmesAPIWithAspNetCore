using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeService _filmeService;
        public FilmeController(FilmeService filmeService)
        {
            _filmeService = filmeService;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
        {
            ReadFilmeDto readDto = _filmeService.AdicionarFilme(filmeDto);
            return CreatedAtAction(nameof(RecuperarFilmesPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        [Authorize(Roles = "admin, regular", Policy = "IdadeMinima")]
        public IActionResult RecuperarFilmes([FromQuery] int? classificacaoEtaria = null)
        {
            List<ReadFilmeDto> readDto = _filmeService.RecupearFilme(classificacaoEtaria);

            if (readDto != null)
                return Ok(readDto);

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmesPorId(int id)
        {
            ReadFilmeDto readDto = _filmeService.RecupearFilmesPorId(id);

            if (readDto != null)
                return Ok(readDto);

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            Result resultado = _filmeService.AtualizarFilme(id, filmeDto);
            if (resultado.IsFailed)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarFilme(int id)
        {
            Result resultado = _filmeService.DeletarFilme(id);
            if (resultado == null)
                return NotFound();

            return NoContent();
        }
    }
}
