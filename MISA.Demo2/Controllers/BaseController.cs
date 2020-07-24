using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.BL;
using MISA.BL.Interfaces;
using MISA.DL;
using MISA.Entity;

namespace MISA.Demo2.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity
    {
        IBaseBL<T> _baseBL;
        //private readonly BaseBL<T> _baseBL;
        public BaseController(IBaseBL<T> baseBL)
        {
            //_baseBL = new BaseBL<T>();
            _baseBL = baseBL;
        }

        // GET: api/Positions
        [HttpGet]
        public virtual ActionResult<IEnumerable<T>> GetData()
        {
            var data = _baseBL.GetData();
            return Ok(data);
        }

        ///// <summary>
        ///// Thêm mới dữ liệu
        ///// </summary>
        ///// <param name="entity">đối tượng được thêm mới</param>
        ///// <returns></returns>
        ///// CreatedBy: NVMANH (22/07/2020)
        //[HttpPost]
        //public virtual ActionResult<T> InsertData(T entity)
        //{
        //    _baseBL.Insert(entity);
        //    return Ok(entity);
        //}
    }
}
