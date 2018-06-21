using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthuisWebShop.Models.Interfaces
{
    public interface ISkuItemsList
    {
        IEnumerable<Item> GetAllItems();
        Item GetItemBySKU(int SKU);
        Item GetItemByDescription(string Description);

    }
}
