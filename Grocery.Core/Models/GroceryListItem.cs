namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; } // getters en setters
        public int ProductId { get; set; }     // getters en setters gemaakt
        public int Amount { get; set; }

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId; //initalisatie van de properties
            ProductId = productId;         
            Amount = amount;               
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
