using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cm_pos.Database;
using cm_pos.Models;
using cm_pos.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace cm_pos.services
{
    public class ProductService
    {
        private readonly DatabaseContext Context;
        private readonly String[] SIZE_PRODUCT = { "S", "M", "L", "XL" };
        private readonly ILogger<ProductService> logger;
        public ProductService(DatabaseContext context, ILogger<ProductService> logger)
        {
            this.logger = logger;
            this.Context = context;
        }

        public async Task<(IEnumerable<Product>, int, int, int, int)> GetProducts()
        {
            try
            {
                var result = await Context.Products.Include(p => p.Categories).Include(ps => ps.ProductsSizeList).ToListAsync();

                var currentThaiYear = Convert.ToInt32(DateTime.Now.ToString("yyyy")) + 543;
                var currentTimeStamp = $"{DateTime.Now.ToString("dd-MM")}-{currentThaiYear}";

                var totalOutStock = 0;
                var totalNewProduct = 0;
                var totalProduct = result.Count();
                var totalCategories = Context.Category.Count();

                for (int i = 0; i < totalProduct; i++)
                {
                    Product item = result[i];
                    var tempTotalStock = 0;

                    foreach (var temp in item.ProductsSizeList)
                    {
                        tempTotalStock = tempTotalStock + temp.Count;
                    }

                    result[i].TotalStock = tempTotalStock;

                    if (tempTotalStock == 0)
                    {
                        totalOutStock++;
                    }

                    if (item.Timestamp == currentTimeStamp)
                    {
                        totalNewProduct++;
                        item.NewProduct = true;
                    }
                }

                return (result, totalOutStock, totalNewProduct, totalProduct, totalCategories);
            }
            catch (System.Exception ex)
            {
                //Logging
                logger.LogError($"GetProducts Error: ${ex.Message}");
            }

            logger.LogDebug("Hello World");
            return (null, 0, 0, 0, 0);
        }

        public SelectList CreateListCategories()
        {
            return new SelectList(Context.Category, "CategoryID", "Name");
        }

        public Boolean AddProduct(ProductFormViewmodel _input)
        {
            try
            {

                // insert table product
                ProductViewModel productValidViewModel = _input.ProductValidViewModel;

                Product product = new Product
                {
                    CodeName = productValidViewModel.CodeName,
                    Name = productValidViewModel.Name,
                    Detail = productValidViewModel.Detail,
                    Price = productValidViewModel.Price,
                    CategoryID = productValidViewModel.CategoryID,
                    Image = productValidViewModel.Image,
                    Timestamp = productValidViewModel.Timestamp
                };

                Context.Products.Add(product);

                // insert table product size
                List<ProductSize> productSize = new List<ProductSize>();

                for (int i = 0; i < SIZE_PRODUCT.Count(); i++)
                {
                    var item = new ProductSize
                    {
                        ProductID = product.ProductID,
                        Size = SIZE_PRODUCT[i],
                        Count = _input.Size[i]
                    };

                    productSize.Add(item);
                }

                Context.ProductSize.AddRange(productSize);

                Context.SaveChanges();

                return true;
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Insert Error: {ex.Message}");
            }

            return false;
        }

        public Product GetProduct(int id)
        {
            return Context.Products.Include(m => m.Categories).Include(p => p.ProductsSizeList).SingleOrDefault(ps => ps.ProductID == id);
        }
        public ProductFormViewmodel EditForm(int id)
        {
            try
            {
                var product = GetProduct(id);

                if (product != null)
                {
                    // Product Data
                    ProductViewModel _data = new ProductViewModel();
                    _data.ID = product.ProductID;
                    _data.CodeName = product.CodeName;
                    _data.Name = product.Name;
                    _data.Detail = product.Detail;
                    _data.Price = product.Price;
                    _data.CategoryID = product.CategoryID;
                    _data.Image = product.Image;
                    _data.Timestamp = product.Timestamp;
                    _data.Categories = new Category();
                    _data.Categories.Name = product.Categories.Name;

                    // Product Size Data
                    int[] size = new int[4];
                    int i = 0;
                    foreach (var item in product.ProductsSizeList)
                    {
                        size[i] = item.Count;
                        i++;
                    }

                    // Create ViewModel
                    var productFormViewModel = new ProductFormViewmodel(_data);
                    productFormViewModel.Size = size;

                    return productFormViewModel;
                }
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Edit Error: {ex.Message}");
            }
            return null;
        }

        public bool EditProduct(ProductFormViewmodel _input, int id)
        {
            try
            {
                Product OldProduct = GetProduct(id);

                if (OldProduct == null)
                {
                    return false;
                }

                ProductViewModel NewProduct = _input.ProductValidViewModel;
                OldProduct.CodeName = NewProduct.CodeName;
                OldProduct.Name = NewProduct.Name;
                OldProduct.Detail = NewProduct.Detail;
                OldProduct.Price = NewProduct.Price;
                OldProduct.CategoryID = NewProduct.CategoryID;
                OldProduct.Image = NewProduct.Image;
                OldProduct.Timestamp = NewProduct.Timestamp;

                Context.Products.Update(OldProduct);

                // Product Size Data
                int[] size = new int[4];  // Update Product

                // Update Product Size
                List<ProductSize> productSize = new List<ProductSize>();

                for (int i = 0; i < SIZE_PRODUCT.Count(); i++)
                {
                    ProductSize temp = Context.ProductSize.SingleOrDefault(m => m.Size == SIZE_PRODUCT[i] && m.ProductID == OldProduct.ProductID);
                    temp.Count = _input.Size[i];

                    productSize.Add(temp);
                }

                Context.ProductSize.UpdateRange(productSize);
                Context.SaveChanges();

                return true;

            }
            catch (System.Exception ex)
            {
                logger.LogError($"Update Error: {ex.Message}");
            }
            return false;
        }

        public bool DetailProduct(ProductFormViewmodel _input, int id)
        {
            try
            {
                Product OldProduct = GetProduct(id);

                if (OldProduct == null)
                {
                    return false;
                }

                ProductViewModel NewProduct = _input.ProductValidViewModel;
                OldProduct.CodeName = NewProduct.CodeName;
                OldProduct.Name = NewProduct.Name;
                OldProduct.Detail = NewProduct.Detail;
                OldProduct.Price = NewProduct.Price;
                OldProduct.CategoryID = NewProduct.CategoryID;
                OldProduct.Image = NewProduct.Image;
                OldProduct.Timestamp = NewProduct.Timestamp;

                Context.Products.Update(OldProduct);

                // Product Size Data
                int[] size = new int[4];  // Update Product

                // Update Product Size
                List<ProductSize> productSize = new List<ProductSize>();

                for (int i = 0; i < SIZE_PRODUCT.Count(); i++)
                {
                    ProductSize temp = Context.ProductSize.SingleOrDefault(m => m.Size == SIZE_PRODUCT[i] && m.ProductID == OldProduct.ProductID);
                    temp.Count = _input.Size[i];

                    productSize.Add(temp);
                }

                Context.ProductSize.UpdateRange(productSize);
                Context.SaveChanges();

                return true;

            }
            catch (System.Exception ex)
            {
                logger.LogError($"Update Error: {ex.Message}");
            }
            return false;
        }

        public ProductFormViewmodel DetailForm(int id)
        {
            try
            {
                var product = GetProduct(id);

                if (product != null)
                {
                    // Product Data
                    ProductViewModel _data = new ProductViewModel();
                    _data.ID = product.ProductID;
                    _data.CodeName = product.CodeName;
                    _data.Name = product.Name;
                    _data.Detail = product.Detail;
                    _data.Price = product.Price;
                    _data.CategoryID = product.CategoryID;
                    _data.Image = product.Image;
                    _data.Timestamp = product.Timestamp;
                    _data.Categories = new Category();
                    _data.Categories.Name = product.Categories.Name;

                    // Product Size Data
                    int[] size = new int[4];
                    int i = 0;
                    foreach (var item in product.ProductsSizeList)
                    {
                        size[i] = item.Count;
                        i++;
                    }

                    // Create ViewModel
                    var productFormViewModel = new ProductFormViewmodel(_data);
                    productFormViewModel.Size = size;

                    return productFormViewModel;
                }
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Edit Error: {ex.Message}");
            }
            return null;
        }

        public bool delete(int id)
        {
            try
            {
                Product product = Context.Products.SingleOrDefault(p => p.ProductID == id);
                if (product != null)
                {
                    Context.Products.Remove(product);

                    var productSize = Context.ProductSize.Where(p => p.ProductID == id);
                    if (productSize != null)
                    {
                        Context.ProductSize.RemoveRange(productSize);

                        Context.SaveChanges();

                        return true;
                    }
                }
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Delete Error: {ex.Message}");
            }
            return false;
        }

        public IEnumerable<Category> GetCategories()
        {
            return Context.Category.ToList();
        }

    }
}