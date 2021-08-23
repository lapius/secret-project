using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scripts.Enums;

namespace Scripts.Entities
{
    public class Card
    {
        private CardType cardType;
        private CardRank cardRank;

        public Card(CardType setCardType, CardRank setCardRank){
            cardType = setCardType;
            cardRank = setCardRank;
        }
    }
}

