using Microsoft.EntityFrameworkCore;

namespace Sql.Samples.DB.Concretes.NorthwindDB.Entities
{
    [Keyless]
    public class MyOrder
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
