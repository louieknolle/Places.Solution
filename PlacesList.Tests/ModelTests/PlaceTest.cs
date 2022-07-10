using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesList.Models;
using System.Collections.Generic;
using System;

namespace PlacesList.Test 
{
  [TestClass]
  public class PlaceTests 
  {
    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Place()
    { 
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      string cityName = "Kathmandu";
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      string cityName = "Kathmandu";
      Place newPlace = new Place(cityName);
      string updatedCityName = "Lima";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;
      Assert.AreEqual(updatedCityName, result);
    }
  }
}