﻿using System;
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
            adapterArtikel = new OleDbDataAdapter("Select * from tArtikel;", con);
            adapterArtikel.Fill(ds, "Artikel");
            //DataTableReader reader = ds.Tables["Artikel"].CreateDataReader();
            //dataGridViewAusgabe.DataSource = ds;
            //dataGridViewAusgabe.DataMember = "Artikel";
            adapterGruppe = new OleDbDataAdapter("Select * from tArtGruppe;",con);
            adapterGruppe.Fill(ds, "ArtGruppe");
            DataTableReader reader = ds.Tables["Artikel"].CreateDataReader();
            while(reader.Read())
            {
                DisplayArtikel da = new DisplayArtikel();
                da.ArtNr = reader.GetString(1);
                da.Bezeichnung = reader.GetString(4);
                da.ArtGruppe = GetArtGruppe(reader.GetInt32(3));
                lsArt.Add(da);
            }
            dataGridViewAusgabe.DataSource = lsArt;
        }

        private string GetArtGruppe(int id)
        {
            String bez = "";
            DataTableReader r = ds.Tables["Artikelgruppe"].CreateDataReader();
            while(r.Read())
            {
                if(r.GetInt32(0) == id)
                {
                    bez = r.GetString(1);
                    break;
                }
            } 

            return bez;
        }

        private void buttonwrite_Click(object sender, EventArgs e)
        {
            ds.WriteXml("Bestellung.xml");
            ds.WriteXmlSchema("Bestellung.xsd");
        }

        private void buttonread_Click(object sender, EventArgs e)
        {
            ds.ReadXmlSchema("Bestellung.xsd");
            ds.ReadXml("Bestellung.xml");
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
    }
}
