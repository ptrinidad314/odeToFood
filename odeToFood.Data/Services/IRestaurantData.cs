using System;
using System.Collections.Generic;

namespace odeToFood.Data.Services
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public interface IRestaurantData
	{
		IEnumerable<odeToFood.Data.Models.Restaurant> GetAll();
	}
}
