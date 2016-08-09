using System;

namespace PokemonGo.RocketAPI.Logic.Utils
{
    public class BotStats
    {
        private int _totalExperience;
        private int _totalPokemons;
        private readonly DateTime _initialSessionDateTime = DateTime.Now;

        private double _getBottingSessionTime()
        {
            return (DateTime.Now - _initialSessionDateTime).TotalSeconds / 3600;
        }

        public void AddExperience(int exp)
        {
            _totalExperience += exp;
        }

        public void AddPokemon(int count)
        {
            _totalPokemons += count;
        }
		public string catchrate()
		{
			return Math.Round(_totalPokemons / _getBottingSessionTime()).ToString("N0");
		}
		public string xprate()
		{
			return Math.Round(_totalExperience / _getBottingSessionTime()).ToString("N0");
		}
        public override string ToString()
        {
            return "XP/h: " + Math.Round(_totalExperience / _getBottingSessionTime()).ToString("N0") + " | Pokemon/h: " + Math.Round(_totalPokemons / _getBottingSessionTime()).ToString("N0") + "";
        }
    }
}
