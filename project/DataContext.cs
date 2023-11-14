using project.Entities;

namespace project
{
    public class DataContext
    {
        public List<Court> CourtsList { get; set; }
        public List<Government> GovernmentList { get; set; }
        public List<Hknesset> HknessetList { get; set; }

        public DataContext()
        {
            CourtsList=new List<Court>();
            CourtsList.Add(new Court{ Id = 1, Name = "בית המשפט המחוזי בנצרת", City = "נוף הגליל" });
            CourtsList.Add(new Court { Id = 2, Name = "בית המשפט המחוזי בחיפה", City = "חיפה" });
            CourtsList.Add(new Court { Id = 3, Name = "בית המשפט המחוזי בתל אביב", City = "תל אביב" });
            CourtsList.Add(new Court { Id = 4, Name = "בית המשפט המחוזי בירושלים", City = "ירושלים" });
            CourtsList.Add(new Court { Id = 5, Name = "בית המשפט המחוזי בבאר שבע", City = "באר שבע" });
            CourtsList.Add(new Court { Id = 6, Name = "בית המשפט המחוזי מרכז", City = "לוד" });
            GovernmentList = new List<Government>();
            GovernmentList.Add(new Government { Id = 1, Name = "ביבי נתניהו", PartyId = 1 });
            GovernmentList.Add(new Government { Id = 2, Name = "משה גפני", PartyId = 2 });
            GovernmentList.Add(new Government { Id = 3, Name = "מנסור עבאס", PartyId = 3 });
            GovernmentList.Add(new Government { Id = 4, Name = "יאיר לפיד", PartyId = 4 });
            HknessetList = new List<Hknesset>();
            HknessetList.Add(new Hknesset { Id = 1, PartyName = "הליכוד", Type = 1 });
            HknessetList.Add(new Hknesset { Id = 2, PartyName = "ג", Type = 1 });
            HknessetList.Add(new Hknesset { Id = 3, PartyName = "רעמ", Type = 2 });
            HknessetList.Add(new Hknesset { Id = 4, PartyName = "יש עתיד", Type = 2 });

        }
    }
}
