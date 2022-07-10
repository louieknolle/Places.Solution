using System.Collections.Generic;
using System;

namespace PlacesList.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public Place(string cityName)
    {
      CityName = cityName;
    }
  }
}