using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class City
    {
        public string cityName = "";
        public string cityCode = "";
        public string country = "";
        public uint totalPopulation = 0;
        public uint womenPopulation = 0;
        public uint menPopulation = 0;

        public City(string _cityName, string _cityCode, string _country, uint _totalPopulation, uint _womenPopulation, uint _menPopulation)
        {
            this.cityName = _cityName;
            this.cityCode = _cityCode;
            this.country = _country;
            this.totalPopulation = _totalPopulation;
            this.womenPopulation= _womenPopulation;
            this.menPopulation= _menPopulation;
        }

        public City(string _cityName)
        {
            this.cityName = _cityName;
        }
    }
}
