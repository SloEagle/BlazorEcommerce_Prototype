﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Loader;

namespace BlazorEcommerce_Prototype.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<Address>>> GetAddress()
        {
            return await _addressService.GetAddress();
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Address>>> AddOrUpdateAddress(Address address)
        {
            return await _addressService.AddOrUpdateAddress(address);
        }
    }
}
