using apiMemory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiMemory.Controllers
{
    public class ValuesController : ApiController
    {

        BdKireneEntities db = new BdKireneEntities();

        public List<Produit> getListProduit()
        {
            return db.Produit.ToList();
        }

        [HttpPost]
        public void AddProduit([FromBody] Produit produit)
        {
            db.Produit.Add(produit);
            db.SaveChanges();
        }



        // GET api/values
        /* public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        } */
    }
}
