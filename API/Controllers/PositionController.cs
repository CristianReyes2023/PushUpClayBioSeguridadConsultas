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
    public class PositionController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PositionController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PositionDto>>> Get()
        {
            var results = await _unitOfWork.Positions.GetAllAsync();
            return _mapper.Map<List<PositionDto>>(results);
        }

        [HttpGet("{id}")] // 2611
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PositionDto>> Get(int id)
        {
            var result = await _unitOfWork.Positions.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return _mapper.Map<PositionDto>(result);
        }
        [HttpPost] // 2611
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PositionDto>> Post(PositionDto resultDto)
        {
            var result = _mapper.Map<Position>(resultDto);
            _unitOfWork.Positions.Add(result);
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
        public async Task<ActionResult<PositionDto>> Put(int id, [FromBody] PositionDto resultDto)
        {
            var exists = await _unitOfWork.Positions.GetByIdAsync(id);
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
            return _mapper.Map<PositionDto>(exists);
        }
        [HttpDelete("{id}")] // 2611
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Positions.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            _unitOfWork.Positions.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}