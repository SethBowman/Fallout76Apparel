using Fallout76Apparel.Models;

namespace Fallout76Apparel
{
    public interface IOutfitRepo
    {
        public IEnumerable<Outfit> GetAllOutfits();
        public Outfit GetSingleOutfit(int id);
        public IEnumerable<Outfit> SearchOutfit(string search);
    }
}
