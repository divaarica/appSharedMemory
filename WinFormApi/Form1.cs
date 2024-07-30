using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApi.Model;

namespace WinFormApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<Produit> servGetListProduit()
        {
            HttpClient client;
            client = new HttpClient();
            var services = new List<Produit>();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["ServeurApiUrl"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("Rica/values/getListProduit").Result;

            if(response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                services = JsonConvert.DeserializeObject<List<Produit>>(responseData);
            }

            return services;

        }

        public bool AddProduit(Produit emp)
        {
            bool rep = false;
            string Id = emp.IdProduit > 0 ? emp.IdProduit.ToString() : "0";
            var values = new Dictionary<string, string>
                    {
                       { "id", Id },
                       { "Designation", emp.DesignationProduit },
                       { "Quantite", emp.QteMin.ToString() },
                       { "PU", emp.PU.ToString() },
                       { "idCategorie", emp.IdProduit.ToString() },
                    };
            var content = new FormUrlEncodedContent(values);
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["ServeurApiURL"]);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = (Id.Equals("0")) ? client.PostAsync("api/produit", content).Result : client.PutAsync($"api/produit/{int.Parse(Id)}", content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        rep = true;
                    }
                    else
                    {

                    }

                }
            }
            catch (Exception ex)
            {

            }
            return rep;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //Produit produit = new Produit();
            var rep = false;

            var idProduit = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["ServeurApiURL"]);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Laravel Rest Api
                    var response = client.DeleteAsync($"api/produit/{idProduit}").Result;

                    // Wcf Soap Api
                    //var response = client.DeleteAsync($"api/Produits/DeleteProduit/{idProduit}").Result;

                    if (response.IsSuccessStatusCode)
                    {
                        rep = true;
                        var responseData = response.Content.ReadAsStringAsync().Result;
                        Produit produit = JsonConvert.DeserializeObject<Produit>(responseData);

                    }
                    else
                    {

                    }

                }
            }
            catch (Exception ex)
            {

            }
            return rep;


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.idProduit = int.Parse(txtIdProduit.Text);
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDesignation.Text;
            p.PrixAchat = double.Parse(txtPrixAchat.Text);
            p.PrixUnitaire = double.Parse(txtPrixVente.Text);
            p.QuantiteMinimale = int.Parse(txtQteMin.Text);
            p.QuantiteMaximale = int.Parse(txtQteMax.Text);
            p.CodeCategorie = "C001";
            AddProduct(p);
            effacer();


        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectioner_Click(object sender, EventArgs e)
        {

        }
    }
}
