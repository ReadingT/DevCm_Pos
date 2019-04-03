namespace cm_pos.ViewModels
{
    public class ProductFormViewmodel
    {
        // Mark: make sure public and get; set;
        public ProductViewModel ProductValidViewModel { get; set; }

        public int[] Size { get; set; }

        public ProductFormViewmodel() { }

        public ProductFormViewmodel(ProductViewModel ProductValidModel)
        {
            this.Size = new int[4];
            this.ProductValidViewModel = ProductValidModel;
        }
    }
}