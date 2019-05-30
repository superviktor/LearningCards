﻿using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using LearningCardsDomain.DALBase;
using LearningCardsDomain.Services;
using LearningCardsWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningCardsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeckController : ControllerBase
    {
        private readonly DeckService _deckService;
        private readonly IMapper _mapper;
        public DeckController(DeckRepository deckRepository, IMapper mapper)
        {
            if (deckRepository == null) throw  new ArgumentNullException();
            _deckService = new DeckService(deckRepository);
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<DeckModel> Get()
        {
            var deckModels = _mapper.Map<IEnumerable<DeckModel>>(_deckService.GetDecks());
            return deckModels;
        }
    }
}