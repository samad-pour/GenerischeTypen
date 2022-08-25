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
                lstOutput.Items.Add("Enthält Belgien");

            lstOutput.Items.Add("Schweiz an Position: " +
            li.IndexOf("Schweiz"));
            lstOutput.Items.Add("Estland an Position: " +
            li.IndexOf("Estland"));

            if (li.Count >= 2) li.Insert(2, "Polen");
            AusListString("Nach Einfügen an Position", li);

            if (li.Count >= 2) li.RemoveAt(1);
            AusListString("Nach Löschen an Position", li);

            bool geloescht;
            do
                geloescht = li.Remove("Spanien");
            while (geloescht);
            AusListString("Nach (mehrfachem) " +
            "Löschen eines Werts", li);
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
                lstOutput.Items.Add("Enthält Schweiz/Bern");

            lstOutput.Items.Add("Schweiz/Bern an Position: " +
            li.IndexOf(new Land("Schweiz", "Bern")));
            lstOutput.Items.Add("Estland/Tallinn an Position: " +
            li.IndexOf(new Land("Estland", "Tallinn")));
           
            if (li.Count >= 1) li.Insert(1,
            new Land("Polen", "Warschau"));
            AusListLand("Nach Einfügen an Position", li);
           
            if (li.Count >= 1) li.RemoveAt(0);
            AusListLand("Nach Löschen an Position", li);
            
            bool geloescht;
            do
                geloescht = li.Remove(new Land("Schweiz", "Bern"));
            while (geloescht);
            AusListLand("Nach (mehrfachem) Löschen eines Werts", li);
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
            AusDictKeys("Schlüssel", dc);
            AusDictValues("Werte", dc);
            AusDict("Zu Beginn", dc);

            if (dc.ContainsKey("CH"))
                lstOutput.Items.Add("Enthält Schlüssel CH");
            if (dc.ContainsValue(new Land("Schweiz", "Bern")))
                lstOutput.Items.Add("Enthält Wert Schweiz/Bern");
            
            dc["E"] = new Land("Ecuador", "Quito");
            AusDict("Nach Ersetzen über Schlüssel", dc);
            
            dc.Remove("E");
            AusDict("Nach Löschen über Schlüssel", dc);
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