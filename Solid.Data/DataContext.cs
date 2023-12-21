using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace Solid.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Court> CourtsList { get; set; }
        public DbSet<Government> GovernmentList { get; set; }
        public DbSet<Hknesset> HknessetList { get; set; }

        public int c1=0;
        public int c2=0;
        public int c3=0;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Tamar_db");
        }




        //public DataContext()
        //{
        //    CourtsList=new List<Court>();
        //    CourtsList.Add(new Court{Id = c1++, Name = "בית המשפט המחוזי בנצרת", City = "נוף הגליל" });
        //    CourtsList.Add(new Court{Id = c1++, Name = "בית המשפט המחוזי בחיפה", City = "חיפה" });
        //    CourtsList.Add(new Court{Id = c1++, Name = "בית המשפט המחוזי בתל אביב", City = "תל אביב" });
        //    CourtsList.Add(new Court{Id = c1++, Name = "בית המשפט המחוזי בירושלים", City = "ירושלים" });
        //    CourtsList.Add(new Court{Id = c1++, Name = "בית המשפט המחוזי בבאר שבע", City = "באר שבע" });
        //    CourtsList.Add(new Court{Id = c1++, Name = "בית המשפט המחוזי מרכז", City = "לוד" });
        //    GovernmentList = new List<Government>();
        //    GovernmentList.Add(new Government { Id = c2++, Name = "ביבי נתניהו", PartyId = 1 });
        //    GovernmentList.Add(new Government { Id = c2++, Name = "משה גפני", PartyId = 2 });
        //    GovernmentList.Add(new Government { Id = c2++, Name = "מנסור עבאס", PartyId = 3 });
        //    GovernmentList.Add(new Government { Id = c2++, Name = "יאיר לפיד", PartyId = 4 });
        //    HknessetList = new List<Hknesset>();
        //    HknessetList.Add(new Hknesset { Id = c3++, PartyName = "הליכוד", Type = 1 });
        //    HknessetList.Add(new Hknesset { Id = c3++, PartyName = "ג", Type = 1 });
        //    HknessetList.Add(new Hknesset { Id = c3++, PartyName = "רעמ", Type = 2 });
        //    HknessetList.Add(new Hknesset { Id = c3++, PartyName = "יש עתיד", Type = 2 });

        //}
    }
}
