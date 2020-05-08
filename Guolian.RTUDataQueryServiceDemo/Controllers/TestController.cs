using Guolian.RTUDataQueryService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guolian.RTUDataQueryServiceDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController
    {
        private  QueryService queryService;
        public TestController(QueryService queryService) 
        {
            this.queryService = queryService;
        }

        [HttpGet]
        public async Task<object> Get() 
        {
            var test = await queryService.GetManagementInformation();
            return test;
        }
        [HttpGet("{id}")]
        public async Task<object> GetOne(int id) 
        {
            var test = await queryService.GetManagementInformation(id);
            return test;
        }
        [HttpGet("{id}/management")]
        public async Task<object> GetTwo(int id) 
        {
            var test = await queryService.GetEquipmentInformation(id);
            return test;
        }
        [HttpGet("{id}/equipment")]
        public async Task<object> GetThree(int id)
        {
            var test = await queryService.GetEquipmentInformationByID(id);
            return test;
        }
        [HttpGet("{id}/history")]
        public async Task<object> GetThree(int id,string year)
        {
            var test = await queryService.GetHistory(id,year);
            return test;
        }
    }
}
