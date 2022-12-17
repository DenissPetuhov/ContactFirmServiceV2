

namespace ContactFirmService.BLL
{
    public class SubFirm
    {
        public SubFirm(string name, SbFirmType sbFirmType, bool isMain)
        {
            Name = name;
            SbFirmTpy = sbFirmType;
            IsMain = isMain;
        }
        public string Name { get; private set; }
        public string? BossName { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public int CountCont
        {
            get {
                CountCont = conts.Count;
                return CountCont;
                }
            private set => CountCont = value;
        }
        public bool IsMain { get; private set; }
        public string? OfcBossName { get; set; }
        public SbFirmType SbFirmTpy { get; private set; }

        private List<Contact>? conts;

        public void AddCont(Contact contact)
        {
            if (conts == null)
                conts = new List<Contact> { contact };
            conts.Add(contact);
        }
        public SbFirmType IsYourType()
        {
            return SbFirmTpy;
        }
        public List<Contact> ExistContact()
        { 
            return conts;
        }
    }
}
