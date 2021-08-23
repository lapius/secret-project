using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Entities;

namespace Scripts.Services {
    public interface ICardGenerationService
    {
        List<Card> GenerateCards();
    }
}
