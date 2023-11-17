using Dapper;
using Fallout76Apparel.Models;
using System.Data;

namespace Fallout76Apparel
{
    public class OutfitRepo : IOutfitRepo
    {
        private readonly IDbConnection _conn;

        public OutfitRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Outfit> GetAllOutfits()
        {
            return _conn.Query<Outfit>("SELECT * FROM outfits;");
        }
    }
}
