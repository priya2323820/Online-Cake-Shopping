using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace online_application.Cake
{
	class CakesBo
	{
		public List<Cakes> findCakes(List<Cakes> CakeList, string cakeName)
		{
			 CakeList= CakeList.Where(x => x.cakename == cakeName).ToList();

			return CakeList;
			

        }



        public List<Cakes> findCakesprice(List<Cakes> CakeList, int Price)
		{
			CakeList = CakeList.Where(x => x.price <= Price).ToList();

			return CakeList;


			
		}

			

	}
}	



