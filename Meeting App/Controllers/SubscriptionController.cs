using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Meeting_App.Models;

namespace Meeting_App.Controllers
{
    public class SubscriptionController : ApiController
    {
        private Virtual_StudyEntities db = new Virtual_StudyEntities();
        
        [HttpGet]
        [Route("api/Subscription/SubscriptionAuthnticate")]
        public bool UserExists(int numberofusers, int price)
        {
            //bool userExists = false;
            // string email = Convert.ToString(id);
             bool userExists = db.Subscriptions.Any(x => x.NumberOfUsers >= numberofusers && x.Price==price);

            return userExists;
        }

        [HttpGet]
        [Route("api/Subscription/price")]
        public IEnumerable<Subscription> PriceCount()
        {
            //bool userExists = false;
            // string email = Convert.ToString(id);
            var userExists = db.Subscriptions;

            return userExists;
        }
        // GET: api/Subscription
        public IQueryable<Subscription> GetSubscriptions()
        {
            return db.Subscriptions;
        }

        // GET: api/Subscription/5
        [ResponseType(typeof(Subscription))]
        public IHttpActionResult GetSubscription(int id)
        {
            Subscription subscription = db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return NotFound();
            }

            return Ok(subscription);
        }

        // PUT: api/Subscription/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSubscription(int id, Subscription subscription)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subscription.SubscriptionID)
            {
                return BadRequest();
            }

            db.Entry(subscription).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubscriptionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Subscription
        [ResponseType(typeof(Subscription))]
        public IHttpActionResult PostSubscription(Subscription subscription)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Subscriptions.Add(subscription);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = subscription.SubscriptionID }, subscription);
        }

        // DELETE: api/Subscription/5
        [ResponseType(typeof(Subscription))]
        public IHttpActionResult DeleteSubscription(int id)
        {
            Subscription subscription = db.Subscriptions.Find(id);
            if (subscription == null)
            {
                return NotFound();
            }

            db.Subscriptions.Remove(subscription);
            db.SaveChanges();

            return Ok(subscription);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SubscriptionExists(int id)
        {
            return db.Subscriptions.Count(e => e.SubscriptionID == id) > 0;
        }
    }
}