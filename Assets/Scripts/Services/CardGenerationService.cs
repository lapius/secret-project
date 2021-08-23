using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Entities;

namespace Scripts.Services {
    public class CardGenerationService : MonoBehaviour, ICardGenerationService
    {
        public List<Card> GenerateCards() {
            

            return new List<Card> { };
        }
    }
}
