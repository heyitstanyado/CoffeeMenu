using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoffeeShopDemo.Controllers
{
    public class DrinkItemController : ApiController
    {
        //Get all information about drink (ex. price, and category)
        public IHttpActionResult Get(int id)
        {

            return Ok();
        }

        //Add new Drink Item to Menu
        public IHttpActionResult Post()
        {

            return Ok();
        }

        //Update Name of Drink (ex. mispelled name)
        public IHttpActionResult Put()
        {
            return Ok();
        }

        //Remove seasonal drink
        public IHttpActionResult Delete()
        {

            return Ok();
        }


        //Demo part: access the endpoints via postman
        // + add a way to show an simple website using the api?

        // MS/vs wizard/scaffold
        // controllers already there
        // if time, then extension 

        // if time, js client
        // use git. 
    }
}
