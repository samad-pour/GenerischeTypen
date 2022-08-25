namespace GenerischeTypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListString_Click(object sender, EventArgs e)
        {
            List<string> li = new List<string>();

            lstOutput.Items.Clear();

            li.Add("Spanien");
            li.Add("Belgien");
            li.Add("Schweiz");
            AusListString("Zu Beginn", li);

            if (li.Contains("Belgien"))
                lstOutput.Items.Add("Enth�lt Belgien");

            lstOutput.Items.Add("Schweiz an Position: " +
            li.IndexOf("Schweiz"));
            lstOutput.Items.Add("Estland an Position: " +
            li.IndexOf("Estland"));

            if (li.Count >= 2) li.Insert(2, "Polen");
            AusListString("Nach Einf�gen an Position", li);

            if (li.Count >= 2) li.RemoveAt(1);
            AusListString("Nach L�schen an Position", li);

            bool geloescht;
            do
                geloescht = li.Remove("Spanien");
            while (geloescht);
            AusListString("Nach (mehrfachem) " +
            "L�schen eines Werts", li);
        }

        private void AusListString(string s, List<string> lx)
        {
            string aus = s + ": ";
            foreach (string x in lx)
                aus += x + " ";
            /* for(int i=0; i<lx.Count; i++)
            aus += lx[i] + " "; */
            lstOutput.Items.Add(aus);
        }

        private void btnListLand_Click(object sender, EventArgs e)
        {
            List<Land> li = new List<Land>();

            lstOutput.Items.Clear();

            li.Add(new Land("Spanien", "Madrid"));
            li.Add(new Land("Schweiz", "Bern"));
            AusListLand("Zu Beginn", li);

            if (li.Contains(new Land("Schweiz", "Bern")))
                lstOutput.Items.Add("Enth�lt Schweiz/Bern");

            lstOutput.Items.Add("Schweiz/Bern an Position: " +
            li.IndexOf(new Land("Schweiz", "Bern")));
            lstOutput.Items.Add("Estland/Tallinn an Position: " +
            li.IndexOf(new Land("Estland", "Tallinn")));
           
            if (li.Count >= 1) li.Insert(1,
            new Land("Polen", "Warschau"));
            AusListLand("Nach Einf�gen an Position", li);
           
            if (li.Count >= 1) li.RemoveAt(0);
            AusListLand("Nach L�schen an Position", li);
            
            bool geloescht;
            do
                geloescht = li.Remove(new Land("Schweiz", "Bern"));
            while (geloescht);
            AusListLand("Nach (mehrfachem) L�schen eines Werts", li);
        }

        private void AusListLand(string s, List<Land> lx)
        {
            string aus = s + ": ";
            foreach (Land x in lx)
                aus += x + " ";
            /* for (int i=0; i<lx.Count; i++)
            aus += lx[i] + " "; */
            lstOutput.Items.Add(aus);
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, Land> dc = new Dictionary<string, Land>();

            lstOutput.Items.Clear();

            dc["E"] = new Land("Spanien", "Madrid");
            dc["CH"] = new Land("Schweiz", "Bern");

            lstOutput.Items.Add("Anzahl: " + dc.Count);
            AusDictKeys("Schl�ssel", dc);
            AusDictValues("Werte", dc);
            AusDict("Zu Beginn", dc);

            if (dc.ContainsKey("CH"))
                lstOutput.Items.Add("Enth�lt Schl�ssel CH");
            if (dc.ContainsValue(new Land("Schweiz", "Bern")))
                lstOutput.Items.Add("Enth�lt Wert Schweiz/Bern");
            
            dc["E"] = new Land("Ecuador", "Quito");
            AusDict("Nach Ersetzen �ber Schl�ssel", dc);
            
            dc.Remove("E");
            AusDict("Nach L�schen �ber Schl�ssel", dc);
        }

        private void AusDictKeys(string s, Dictionary<string, Land> dx)
        {
            string aus = s + ": ";
            foreach (string sx in dx.Keys)
                aus += sx + " ";
            lstOutput.Items.Add(aus);
        }
        private void AusDictValues(string s, Dictionary<string, Land> dx)
        {
            string aus = s + ": ";
            foreach (Land x in dx.Values)
                aus += x + " ";
            lstOutput.Items.Add(aus);
        }
        private void AusDict(string s, Dictionary<string, Land> dx)
        {
            string aus = s + ": ";
            foreach (string sx in dx.Keys)
                aus += sx + "#" + dx[sx] + " ";
            lstOutput.Items.Add(aus);
        }
    }
}