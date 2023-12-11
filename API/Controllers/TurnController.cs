using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers
{
    public class TurnController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TurnController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TurnDto>>> Get()
        {
            var results = await _unitOfWork.Turns.GetAllAsync();
            return _mapper.Map<List<TurnDto>>(results);
        }

        [HttpGet("{id}")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TurnDto>> Get(int id)
        {
            var result = await _unitOfWork.Turns.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return _mapper.Map<TurnDto>(result);
        }
        [HttpPost] // 2611
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TurnDto>> Post(TurnDto resultDto)
        {
            var result = _mapper.Map<Turn>(resultDto);
            _unitOfWork.Turns.Add(result);
            await _unitOfWork.SaveAsync();
            if (result == null)
            {
                return BadRequest();
            }
            resultDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = resultDto.Id }, resultDto);
        }
        [HttpPut("{id}")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TurnDto>> Put(int id, [FromBody] TurnDto resultDto)
        {
            var exists = await _unitOfWork.Turns.GetByIdAsync(id);
            if (exists == null)
            {
                return NotFound();
            }
            if (resultDto.Id == 0)
            {
                resultDto.Id = id;
            }
            if (resultDto.Id != id)
            {
                return BadRequest();
            }
            // Update the properties of the existing entity with values from resultDto
            _mapper.Map(resultDto, exists);
            // if (resultDto.FechaCreacion == DateOnly.MinValue)
            // {
            //     exists.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            // }
            // The context is already tracking result, so no need to attach it
            await _unitOfWork.SaveAsync();
            // Return the updated entity
            return _mapper.Map<TurnDto>(exists);
        }
        [HttpDelete("{id}")] // 2611
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Turns.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            _unitOfWork.Turns.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}