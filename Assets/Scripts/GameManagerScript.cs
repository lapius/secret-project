using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Services;

namespace Scripts
{
    public class GameManagerScript : MonoBehaviour
    {
        private readonly ICardGenerationService _cardGeneratonService;
        public GameManagerScript(ICardGenerationService  cardGeneratonService){
            _cardGeneratonService = cardGeneratonService;
        }
        // Start is called before the first frame update
        void Start()
        {
            var cards = _cardGeneratonService.GenerateCards();
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}