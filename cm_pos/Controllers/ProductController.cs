using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cm_pos.Database;
using cm_pos.Models;
using cm_pos.services;
using cm_pos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace cm_pos.productcontrollers
{
    public class productController : Controller
    {

        ILogger<productController> _logger;
        private readonly ProductService ProductService;
        private readonly UtilService utilService;

        public productController(ILogger<productController> logger, ProductService ProductService, UtilService utilService)
        {
            this.utilService = utilService;
            this.ProductService = ProductService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            // ViewData["fristname"] = "Nattapong";
            // ViewData["age"] = 30;

            // var product = new Product();
            // product.ID = 358;
            // product.NAME = "notebook";

            // ViewData["product"] = product;

            // return View(product);

            // IEnumerable<Product> result = new List<Product>{
            // new Product{
            //   Name = "Notebook",
            //   CodeName = "CM1150",
            //   Price = 12000,
            //   TotalStock = 8,
            // },
            // new Product{
            //   Name = "Notebook2",
            //   CodeName = "CM1151",
            //   Price = 14000,
            //   TotalStock = 10,
            // }
            // };     

            (var result, var totalOutStock, var totalNewProduct, var totalProduct, var totalCategories)
            = await ProductService.GetProducts();

            ViewData["total_product"] = totalProduct;
            ViewData["total_categories"] = totalCategories;
            ViewData["total_new_product"] = totalNewProduct;
            ViewData["total_out_stock"] = totalOutStock;

            return View(result);
        }

        public IActionResult Edit(int id)
        {
            var form = ProductService.EditForm(id);
            if (form != null)
            {
                return View(form);
            }
            return NotFound();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(ProductFormViewmodel _input, int id)
        {
            if (ModelState.IsValid)
            {
                if (ProductService.EditProduct(_input, id))
                    return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
            return View(_input);
        }
        public IActionResult privacy()
        {

            return View();
        }
        //Set Get & Post Function Create
        //Get Create
        public IActionResult Create()
        {

            return View(new ProductFormViewmodel(new ProductViewModel()));
        }

        //Post Create
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Create")]
        public IActionResult InsertDatabase(ProductFormViewmodel _data)
        {
            if (ModelState.IsValid)
            {
                // insert database
                if (ProductService.AddProduct(_data))
                {
                    //todo
                    return RedirectToAction("Index");
                }
                else
                {
                    return BadRequest();
                }
                //var name = _data.ProductValidViewModel.Name;
            }
            return View(_data);
        }

        public async Task<IActionResult> UploadFilesAjax()
        {
            //Upload Image
            List<String> _imagename = await utilService.UploadFilesAjax();
            return Json(_imagename);
        }

        //Set Get & Post Function Detail
        //Get Detail
        public IActionResult Detail(int id)
        {
            var form = ProductService.DetailForm(id);
            if (form != null)
            {
                return View(form);
            }
            return NotFound();
        }
        //Post Detail
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Detail(ProductFormViewmodel _input, int id)
        {
            if (ModelState.IsValid)
            {
                return View(_input);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult delete(int id)
        {
            if (ModelState.IsValid)
            {
                if (ProductService.delete(id))
                {
                    return Json("Success");
                }
                return BadRequest("Delete Failure");
            }
            return NotFound();
        }

    }
}


//case order by
//return View(await context.Products.OrderBy(o => o.Price).ToListAsync());
//return View(await (from p in context.Products orderby p.Price descending select p).ToListAsync());
//return View(context.Products.FromSql("select * from Products order by Price ASC"));

/*
        public async Task<IActionResult> Query()
        {
            //exam 1
            IEnumerable<Product> exam1 = context.Products.FromSql("select * from Products where id = 1");
            List<Product> exam2 = new List<Product>();
            List<Product> exam3 = new List<Product>();
            List<Product> exam4 = new List<Product>();

            var conn = context.Database.GetDbConnection();
            DbDataReader reader;
            string query;

            try
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    //exam 2
                    query = "select * from Products";
                    command.CommandText = query;
                    reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var row = new Product
                            {
                                ID = reader.GetInt32(0),
                                CodeName = reader.GetString(2),
                                Name = reader.GetString(9),
                                Detail = reader.GetString(3),
                                Price = reader.GetDecimal(10),
                                CategoryID = reader.GetInt32(1),
                                Image1 = reader.GetString(4),
                                Image2 = reader.GetString(5),
                                Image3 = reader.GetString(6),
                                Image4 = reader.GetString(7),
                                Image5 = reader.GetString(8),
                                Timestamp = reader.GetDateTime(11)
                            };
                            exam2.Add(row);
                        }
                    }

                    reader.Close();

                    //exam 3
                    int nCatID = 2;
                    exam3 = context.Products.FromSql("myStoredProcedure @p0", nCatID).ToList();

                    //exam 4
                    query = "myStoredProcedure";
                    command.CommandText = query;
                    command.CommandType = CommandType.StoredProcedure;
                    reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                         while (await reader.ReadAsync())
                        {
                            var row = new Product
                            {
                                ID = reader.GetInt32(0),
                                CodeName = reader.GetString(2),
                                Name = reader.GetString(9),
                                Detail = reader.GetString(3),
                                Price = reader.GetDecimal(10),
                                CategoryID = reader.GetInt32(1),
                                Image1 = reader.GetString(4),
                                Image2 = reader.GetString(5),
                                Image3 = reader.GetString(6),
                                Image4 = reader.GetString(7),
                                Image5 = reader.GetString(8),
                                Timestamp = reader.GetDateTime(11)
                            };

                            exam4.Add(row);
                        }
                    }

                    reader.Close();
                }
            }
            catch
            {

            }finally{
                conn.Close();
            }

            return View();
        }

        //exam 5
        using (var command = context.Database.GetDbConnection().CreateCommand())
        {
            command.CommandText = "StoredProcedureName";
            command.CommandType = CommandType.StoredProcedure;

            context.Database.OpenConnection();

            var dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                string _test = dataReader.GetString(dataReader.GetOrdinal("ColumnName"));
            }
        }

        //exam 6
        await Context.Database.ExecuteSqlCommandAsync("myStoredProcedure @p0, @p1", 
        parameters: new[] { "codemobiles", "cmdev" });
 */
