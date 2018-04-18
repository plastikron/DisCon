using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DisCon1
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbDataAdapter adapter = null;
        OleDbDataAdapter adapterArtikel = null;
        OleDbDataAdapter adapterGruppe = null;
        DataSet ds = null;
        List<DisplayArtikel> lsArt = new List<DisplayArtikel>();
        public Form1()
        {
            InitializeComponent();
            ds = new DataSet();
            con = new OleDbConnection(Properties.Settings.Default.DBCon);
            adapterArtikel = new OleDbDataAdapter("Select * from tArtikel;", con);
            adapterGruppe = new OleDbDataAdapter("Select * from tArtGruppe;", con);
            adapterGruppe.FillSchema(ds, SchemaType.Source, "ArtGruppe");
            adapterGruppe.Fill(ds, "ArtGruppe");
        }

        private void buttonDataAdapter_Click(object sender, EventArgs e)
        {
            //con = new OleDbConnection(Properties.Settings.Default.DBCon);
            adapter = new OleDbDataAdapter("select * from tKunde", con);
            adapter.Fill(ds, "Kunde");
        }
        private void buttonDsread_Click_1(object sender, EventArgs e)
        {
            DataTableReader reader = ds.Tables["Kunde"].CreateDataReader();
            listBoxAusgabe.Items.Clear();
            while (reader.Read())
            {
                listBoxAusgabe.Items.Add(reader.GetString(2));

            }
            reader.Close();
            dataGridViewAusgabe.DataSource = ds;
            dataGridViewAusgabe.DataMember = "Kunde";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewAusgabe.DataSource = null;
        }

        private void buttonArtikeladapter_Click_1(object sender, EventArgs e)
        {
            //con = new OleDbConnection(Properties.Settings.Default.DBCon);
            adapter = new OleDbDataAdapter("select * from tArtikel", con);
            //adapter.Fill(ds, "Artikel");
        }
        private void buttonArtikellesen_Click(object sender, EventArgs e)
        {
            adapterArtikel.FillSchema(ds, SchemaType.Source, "Artikel");
            ds.Tables["Artikel"].Columns[0].AutoIncrement = true; 
            adapterArtikel.Fill(ds, "Artikel");
            dataGridViewAusgabe.DataSource = ds;
            dataGridViewAusgabe.DataMember = "Artikel";
            DataTableReader reader = ds.Tables["Artikel"].CreateDataReader();
            while (reader.Read())
            {
                DisplayArtikel ds = new DisplayArtikel();
                ds.ArtikelOid = reader.GetInt32(0);
                ds.ArtNr = reader.GetString(1);
                ds.Bezeichnung = reader.GetString(3);
                ds.Meldebestand = reader.GetInt16(5);
                ds.ArtGruppe = GetArtGruppe(reader.GetInt32(2));
                ds.Bestand = reader.GetByte(4);
                lsArt.Add(ds);
            }
            dataGridViewAusgabe.DataSource = lsArt;
        }

        private string GetArtGruppe(int id)
        {
            String bez = "xxx";
            DataRow row = ds.Tables["ArtGruppe"].Rows.Find(id);
            bez = (String)row[1];
            return bez;
        }

        private void buttonwrite_Click(object sender, EventArgs e)
        {
            ds.WriteXml("Bestellung.xml", XmlWriteMode.DiffGram);
            ds.WriteXmlSchema("Bestellung.xsd");
        }

        private void buttonread_Click(object sender, EventArgs e)
        {
            ds.ReadXmlSchema("Bestellung.xsd");
            ds.ReadXml("Bestellung.xml", XmlReadMode.DiffGram);
            dataGridViewAusgabe.DataSource = ds;
            dataGridViewAusgabe.DataMember = "Artikel";
            DataTableReader reader = ds.Tables["Kunde"].CreateDataReader();
            listBoxAusgabe.Items.Clear();
            while (reader.Read())
            {
                listBoxAusgabe.Items.Add(reader.GetString(2));

            }
            reader.Close();
        }

        private void buttonDBsync_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapterArtikel);
            adapterArtikel.DeleteCommand = builder.GetDeleteCommand();
            adapterArtikel.InsertCommand = builder.GetInsertCommand();
            adapterArtikel.UpdateCommand = builder.GetUpdateCommand();
            adapterArtikel.Update(ds.Tables["Artikel"]);
        }
    }
}
