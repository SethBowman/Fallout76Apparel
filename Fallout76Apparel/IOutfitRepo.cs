using Fallout76Apparel.Models;

namespace Fallout76Apparel
{
    public interface IOutfitRepo
    {
        public IEnumerable<Outfit> GetAllOutfits();
    }
}
