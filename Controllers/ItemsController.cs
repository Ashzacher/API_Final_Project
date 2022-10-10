using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
using System.Collections.Generic;
using System;

namespace Catalog.Controllers {
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase {
        private readonly InMemItemsRepository repository;

        public ItemsController() {
            repository = new InMemItemsRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems() {
            var items = repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id) {
            var item = repository.GetItem(id);

            if (item is null) {
                return NotFound();
            }

            return item;
        }
    }
}