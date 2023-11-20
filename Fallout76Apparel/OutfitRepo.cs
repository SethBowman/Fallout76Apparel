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

        public Outfit GetSingleOutfit(int id)
        {
            return _conn.QuerySingle<Outfit>("SELECT * FROM outfits WHERE outfitId = @id;", new { id });
        }

        public IEnumerable<Outfit> SearchOutfit(string search)
        {
            return _conn.Query<Outfit>("SELECT * FROM outfits WHERE name LIKE @name;", new { name = $"%{search}%" });
        }
    }
}
