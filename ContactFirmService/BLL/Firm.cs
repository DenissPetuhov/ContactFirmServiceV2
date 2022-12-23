

namespace ContactFirmService.BLL
{
    public class Firm
    {

      
        public Firm(string nameFirm, string[] nameFilds)
        {
            Name = nameFirm;


            subFirms.Add(
                new SubFirm(
                    "Main SubFirm",
                    new SbFirmType()
                    {
                        IsMain = true,
                        Name = "MainType"
                    },
                    true));

            usrFields = new Dictionary<string, string>()
            {
                { nameFilds[0], "" },
                { nameFilds[1], "" },
                { nameFilds[2], "" },
                { nameFilds[3], "" },
                { nameFilds[4], "" }
           };

        }

        public string Name { get; private set; }
        public DateTime DateIn { get; private set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? PostInx { get; set; }
        public string? Street { get; set; }
        public string? Town { get; set; }
        public string? Web { get; set; }
        public int sbFirmsCount
        {
            get
            {
                sbFirmsCount = subFirms.Count;
                return sbFirmsCount;
            }
            private set
            {
                sbFirmsCount = value;
            }
        }

        private Dictionary<string, string> usrFields;
        public List<SubFirm> subFirms = new List<SubFirm>();

        public bool AddCont(Contact contact)
        {
            var subFirm = subFirms.FirstOrDefault(x => x.SbFirmTpy.IsMain == true);
            if (subFirm != null)
            {
                subFirm.AddCont(contact);
                return true;
            }
            return false;
        }
        public bool AddContToSbFirm(string nameSubFirm, Contact contact)
        {
            var subFirm = subFirms.FirstOrDefault(x => x.Name == nameSubFirm);
            if (subFirm != null)
            {
                subFirm.AddCont(contact);
                return true;
            }

            return false;
        }
        public void AddField(string key, string value)
        {
            if (usrFields == null)
            {
                usrFields = new Dictionary<string, string>();
            }

            usrFields.Add(key, value);
        }
        public void AddSbFirm(string name, SbFirmType sbFirmType)
        {
            subFirms.Add(new SubFirm(
               name,
               sbFirmType,
               false
               ));
        }
        public string GetField(string key)
        {

            return usrFields[key];

        }
        public void SetField(string key, string value)
        {

            usrFields[key] = value;

        }
        public bool RenameField(string key, string value)
        {
            if (usrFields == null)
            {
                return false;
            }
            usrFields[key] = value;
            return true;
        }
        public SubFirm isMain()
        {
            return subFirms[0];
        }
        public List<Contact> ExistContact()
        {
            List<Contact> contacts = new List<Contact>();
            foreach (var subFirm in subFirms)
            {
                contacts.AddRange(subFirm.ExistContact());
            }
            return contacts;
        }
    }
}
