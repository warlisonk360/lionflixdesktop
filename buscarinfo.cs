using System;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Lionflix.Info
{
    public class buscarinfo
    {
        public DsLionFlix ds = new DsLionFlix();

        //Info
        public int INFO_ID;
        public string INFO_Nome;
        public string INFO_Genero;
        public string INFO_Idade;
        public int INFO_Ano;
        public string INFO_img_p;
        public int INFO_Total;
        //episodios
        public int Ep_ID;
        public string Ep_Nome;
        public string Ep_Link;
        public string Ep_Temporadas;
        public int Ep_Episodio;
        public string Ep_Nome_Ep;
        //Filmes
        public int MO_ID;
        public string MO_Nome;
        public string MO_Link;
        public string MO_Genero;
        public string MO_Idade;
        public int MO_Ano;
        public int MO_Legenda;
        public string MO_img_p;
        //Upgrade
        public double UPGD_VERSAO;
        public double UPGD_VERSAO_P;

        public class Versoes
        {
            public double versao_link { get; set; }
            public double versao_prgm { get; set; }
        }

        public void baixar()
        {
            WebClient mywebClient = new WebClient();
            string address = "https://drive.google.com/u/0/uc?id=1YYObB0aUdKj0Rs7pBF5j_BuLipeTM5ux&export=download";
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string folder = desktop + "/lionflix/";
            string folderimg = desktop + "/lionflix/img";
            if (!Directory.Exists(folder))
            {
                DirectoryInfo di = Directory.CreateDirectory(folder);
            }
            string fileName = folder + "\\myfile.json";
            mywebClient.DownloadFile(address, fileName);

            if (!Directory.Exists(folderimg))
            {
                DirectoryInfo di_img = Directory.CreateDirectory(folderimg);
                BaixarFilmes();
                BaixarSeries();
            }
        }

        public void BaixarFilmes()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string fileName = desktop + "/lionflix/" + "\\myfile.json";
            string jsonString = File.ReadAllText(fileName);
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            Form fm = new Form();
            ProgressBar pb = new ProgressBar();
            WebClient mywebClient = new WebClient();
            foreach (var item in array)
            {
                dynamic episodios = item.database[0].episodios;
                dynamic info = item.database[1].info;
                dynamic links = item.database[2].links;
                dynamic upgrade = item.database[3].upgrade;

                int cont_filmes = ((ICollection)links).Count;
                int i;
                for (i = 0; i < cont_filmes; i++)
                {
                    MO_ID = links[i].ID;
                    MO_Nome = links[i].NameFilme;
                    MO_Link = links[i].LinkFilme;
                    MO_Genero = links[i].Genero;
                    MO_Idade = links[i].Idade;
                    MO_Ano = links[i].Ano;
                    MO_Legenda = links[i].Legenda;
                    MO_img_p = "https://lionflixAPI.videirastore.com.br/img/filmes/img_p/" + links[i].foto;

                    string address = MO_img_p;
                    string file = desktop + "/lionflix/img/" + "\\" + links[i].foto;
                    if (!File.Exists(@"" + file))
                    {
                        mywebClient.DownloadFile(address, file);

                        fm.Size = new Size(500, 100);
                        fm.StartPosition = FormStartPosition.CenterScreen;
                        fm.Name = "Info";
                        fm.Text = "Lionflix - Carregando Arquivos Aguarde!";
                        fm.BackColor = Color.Aqua;
                        fm.Enabled = true;
                        fm.Visible = true;
                        fm.ShowIcon = false;
                        fm.ControlBox = false;

                        pb.Name = "Progresso";
                        pb.BackColor = Color.White;
                        pb.ForeColor = Color.Green;
                        pb.Minimum = 1;
                        pb.Maximum = cont_filmes;
                        pb.Value = 1;
                        pb.Step = 1;
                        pb.Size = new Size(fm.Width, fm.Height);
                        pb.Visible = true;

                        for (int x = 0; x <= cont_filmes; x++)
                        {
                            // Inserts code to copy a file  
                            pb.PerformStep();
                            // Updates the label to show that a file was read.                         
                        }

                        fm.Controls.Add(pb);
                    }
                }

            }
            fm.Show();
            fm.Close();
        }

        public void BaixarSeries()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string fileName = desktop + "/lionflix/" + "\\myfile.json";
            string jsonString = File.ReadAllText(fileName);
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            Form fm = new Form();
            ProgressBar pb = new ProgressBar();
            WebClient mywebClient = new WebClient();
            foreach (var item in array)
            {
                dynamic episodios = item.database[0].episodios;
                dynamic info = item.database[1].info;
                dynamic links = item.database[2].links;
                dynamic upgrade = item.database[3].upgrade;

                int cont_filmes = ((ICollection)info).Count;
                int i;
                for (i = 0; i < cont_filmes; i++)
                {
                    INFO_ID = info[i].ID;
                    INFO_Nome = info[i].Nome;
                    INFO_Genero = info[i].Genero;
                    INFO_Idade = info[i].Idade;
                    INFO_Ano = info[i].Ano;
                    INFO_img_p = "https://lionflixAPI.videirastore.com.br/img/series/img_p/" + info[i].foto;
                    INFO_Total = info[i].Total_Temporadas;

                    string address = INFO_img_p;
                    string file = desktop + "/lionflix/img/" + "\\" + info[i].foto;
                    if (!File.Exists(@"" + file))
                    {
                        mywebClient.DownloadFile(address, file);

                        fm.Size = new Size(500, 100);
                        fm.StartPosition = FormStartPosition.CenterScreen;
                        fm.Name = "Info";
                        fm.Text = "Lionflix - Carregando Arquivos Aguarde!";
                        fm.BackColor = Color.Aqua;
                        fm.Enabled = true;
                        fm.Visible = true;
                        fm.ShowIcon = false;
                        fm.ControlBox = false;

                        pb.Name = "Progresso";
                        pb.BackColor = Color.White;
                        pb.ForeColor = Color.Green;
                        pb.Minimum = 1;
                        pb.Maximum = cont_filmes;
                        pb.Value = 1;
                        pb.Step = 1;
                        pb.Size = new Size(fm.Width, fm.Height);
                        pb.Visible = true;

                        for (int x = 0; x <= cont_filmes; x++)
                        {
                            // Inserts code to copy a file  
                            pb.PerformStep();
                            // Updates the label to show that a file was read.                         
                        }

                        fm.Controls.Add(pb);
                    }
                }

            }
            fm.Show();
            fm.Close();
        }


        public void CarregarEpisodios()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string fileName = desktop + "/lionflix/" + "\\myfile.json";
            string jsonString = File.ReadAllText(fileName);
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            foreach (var item in array)
            {
                dynamic episodios = item.database[0].episodios;
                dynamic info = item.database[1].info;
                dynamic links = item.database[2].links;
                dynamic upgrade = item.database[3].upgrade;

                int cont_ep = ((ICollection)episodios).Count;

                for (int i = 0; i < cont_ep; i++)
                {
                    Ep_ID = episodios[i].ID;
                    Ep_Nome = episodios[i].Nome;
                    Ep_Link = episodios[i].Link;
                    Ep_Temporadas = episodios[i].Temporadas;
                    Ep_Episodio = episodios[i].Ep;
                    Ep_Nome_Ep = episodios[i].Nome_Ep;

                    ds.episodios.Rows.Add(Ep_ID, Ep_Nome, Ep_Link, Ep_Temporadas, Ep_Episodio, Ep_Nome_Ep);
                }

            }

        }


        public void CarregarFilmes()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string fileName = desktop + "/lionflix/" + "\\myfile.json";
            string jsonString = File.ReadAllText(fileName);
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            foreach (var item in array)
            {
                dynamic episodios = item.database[0].episodios;
                dynamic info = item.database[1].info;
                dynamic links = item.database[2].links;
                dynamic upgrade = item.database[3].upgrade;

                int cont_ep = ((ICollection)links).Count;

                for (int i = 0; i < cont_ep; i++)
                {
                    MO_ID = links[i].ID;
                    MO_Nome = links[i].NameFilme;
                    MO_Link = links[i].LinkFilme;
                    MO_Genero = "Geral, " + links[i].Genero;              
                    MO_Idade = links[i].Idade;
                    MO_Ano = links[i].Ano;
                    MO_Legenda = links[i].Legenda;
                    MO_img_p = desktop + "/lionflix/img/" + "\\" + links[i].foto;

                    ds.links.Rows.Add(MO_ID, MO_Nome, MO_Link, MO_Genero, MO_Idade, MO_Ano, MO_Legenda, MO_img_p);
                }

            }

        }

        public void CarregarInfo()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string fileName = desktop + "/lionflix/" + "\\myfile.json";
            string jsonString = File.ReadAllText(fileName);
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            foreach (var item in array)
            {
                dynamic episodios = item.database[0].episodios;
                dynamic info = item.database[1].info;
                dynamic links = item.database[2].links;
                dynamic upgrade = item.database[3].upgrade;

                int cont_ep = ((ICollection)info).Count;

                for (int i = 0; i < cont_ep; i++)
                {
                    INFO_ID = info[i].ID;
                    INFO_Nome = info[i].Nome;
                    INFO_Idade = info[i].Idade;
                    INFO_Genero = info[i].Genero;
                    INFO_Ano = info[i].Ano;
                    INFO_img_p = desktop + "/lionflix/img/" + "\\" + info[i].foto;
                    INFO_Total = info[i].Total_Temporadas;

                    ds.info.Rows.Add(INFO_ID, INFO_Nome, INFO_Idade, INFO_Genero, INFO_Ano, INFO_img_p, INFO_Total);
                }

            }

        }

        public void CarregarUpgrade()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string folder = desktop + "/lionflix/";
            string fileName = desktop + "/lionflix/" + "\\myfile.json";
            string att = desktop + "/lionflix/" + "\\info.json";
            string jsonString = File.ReadAllText(fileName);
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            foreach (var item in array)
            {
                dynamic episodios = item.database[0].episodios;
                dynamic info = item.database[1].info;
                dynamic links = item.database[2].links;
                dynamic upgrade = item.database[3].upgrade;

                int cont_ep = ((ICollection)upgrade).Count;

                for (int i = 0; i < cont_ep; i++)
                {
                    UPGD_VERSAO = upgrade[i].Ultima_Versao;
                    UPGD_VERSAO_P = upgrade[i].Versao_programa;

                    ds.upgrade.Rows.Add(UPGD_VERSAO, UPGD_VERSAO_P);

                    var ver = new Versoes
                    {
                        versao_link = UPGD_VERSAO,
                        versao_prgm = UPGD_VERSAO_P
                    };

                    string lista = JsonConvert.SerializeObject(ver);

                    if (!File.Exists(@"" + att)){ 
                        File.WriteAllText(@"" + folder + "\\info.json", lista);
                    }
                }
            }
        }

    }
}
