using Lionflix.Info;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Lionflix
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 161;
        public const int HT_CAPTION = 2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        buscarinfo bi = new buscarinfo();
        DsLionFlix dados = new DsLionFlix();

        //Filmes
        public string genero;
        //Outros
        public static string nomeserie;
        public static string genero_serie;
        public static int ano_serie;
        public static string idade_serie;
        public static string imagem;
        public string temp;
        public string[] tarry;
        public static int total_temp;
        public static string nome_do_dia;
        public static string link_do_dia;

        public string[] genero_list =
        {
            "GERAL",
            "AÇÃO",
            "ANIMAÇÃO",
            "AVENTURA",
            "BIOGRAFIA",
            "COMÉDIA",
            "CRIME",
            "DRAMA",
            "FAMILIA",
            "FANTASIA",
            "FAROESTE",
            "FICÇÃO",
            "GOSPEL",
            "GUERRA",
            "MISTERIO",
            "ROMANCE",
            "TERROR",
            "THRILLER"
        };

        public class Guardado
        {
            public string Nome { get; set; }
            public string Link { get; set; }
        }

        public class Versoes
        {
            public double versao_link { get; set; }
            public double versao_prgm { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            bi.baixar();
            bi.CarregarEpisodios();
            bi.CarregarFilmes();
            bi.CarregarInfo();
            bi.CarregarUpgrade();
            preencher();
            dados = bi.ds;
            this.restaure.Visible = false;
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            download.Visible = false;
            CarregarUltimosFilmes();
            PegarTempo();
            PegarFilmedoDia();
            Verificar_atualização();
        }

        public void PegarTempo()
        {

            DateTime hoje = DateTime.Today;
            var Date = hoje.Date.ToString("dd-MM-yyyy");
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string file = JsonConvert.SerializeObject(Date);
            string folder = desktop + "/lionflix/";

            string fileName = folder + "\\tempo.json";

            if (!File.Exists(@"" + fileName))
            {
                FilmeDoDia();
                var guardar = new Guardado
                {
                    Nome = nome_do_dia,
                    Link = link_do_dia
                };

                string lista = JsonConvert.SerializeObject(guardar);
                File.WriteAllText(@"" + folder + "\\tempo.json", file);
                File.WriteAllText(@"" + folder + "\\filmehoje.json", lista);
            }
            else
            {
                string jsonString = File.ReadAllText(fileName);
                dynamic array = JsonConvert.DeserializeObject(jsonString);
                DateTime antes = Convert.ToDateTime(array).Date;

                if (antes < hoje)
                {
                    FilmeDoDia();
                    var guardar = new Guardado
                    {
                        Nome = nome_do_dia,
                        Link = link_do_dia
                    };

                    string lista = JsonConvert.SerializeObject(guardar);
                    File.WriteAllText(@"" + folder + "\\tempo.json", file);
                    File.WriteAllText(@"" + folder + "\\filmehoje.json", lista);
                }
            }
        }

        private void close_Click(object sender, EventArgs e) => this.Close();

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.restaure.Visible = true;
            this.maximize.Visible = false;
            panel4.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            CarregarUltimosFilmes();
        }

        private void restaure_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.restaure.Visible = false;
            this.maximize.Visible = true;
            panel4.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            CarregarUltimosFilmes();
        }

        private void miniminize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void Barra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Form1.ReleaseCapture();
            Form1.SendMessage(this.Handle, 161, 2, 0);
        }

        public void CarregarFilmes()
        {
            if (tabControl1.TabPages.Contains(tabPage2) == false)
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.SelectedTab = tabPage2;
            }
            escolher_genero.Visible = true;

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(panel.Width, panel.Height);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = true;
            flow.WrapContents = true;
            flow.HorizontalScroll.Visible = false;
            panel.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] rows;

           
                if (escolher_genero.Text == "GERAL")
                {
                    rows = table.Select("Genero LIKE '%Geral%'", "NameFilme ASC");
                }
                else
                {
                    if (escolher_genero.Text == "AÇÃO") { genero = "Action"; }
                    else
                    {
                        if (escolher_genero.Text == "COMÉDIA") { genero = "Comedia"; }
                        else
                        {
                            if (escolher_genero.Text == "FICÇÃO") { genero = "Ficcao"; }
                            else
                            {
                                if (escolher_genero.Text == "ANIMAÇÃO") { genero = "Animacao"; } else { genero = escolher_genero.Text; }
                            }
                        }
                    }

                    rows = table.Select("Genero LIKE '%" + genero + "%'", "NameFilme ASC");
                }       

            foreach (DataRow row in rows)
            {
                Button leg = new Button();
                leg.Name = "Legenda";
                leg.Text = "L";
                leg.Font = new Font(FontFamily.GenericSansSerif, 8);
                leg.Location = new Point(0, 80);
                leg.Size = new Size(20,20);
                leg.ForeColor = Color.White;
                leg.BackColor = Color.Black;
                leg.FlatAppearance.BorderSize = 0;
                leg.FlatStyle = FlatStyle.Flat;
                leg.Visible = true;
                leg.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom)| AnchorStyles.Left)));
                leg.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)leg, "Filme Com Legenda Para Deficiente Auditivos!"));
                leg.MouseLeave += (EventHandler)((_param1, _param2) => { });

                PictureBox btn = new PictureBox();
                btn.Name = Convert.ToString(row["NameFilme"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToInt32(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@"" + Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["LinkFilme"]);
                    new Player().Show();
                });
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.BringToFront();


                if(Convert.ToInt32(row["Legenda"]) == 1)
                {
                    btn.Controls.Add(leg);
                }
                
                flow.Controls.Add((Control)btn);
            }
        }

        public void CarregarSeries()
        {
            if (tabControl1.TabPages.Contains(tabPage2) == false)
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.SelectedTab = tabPage2;
            }
            escolher_genero.Visible = false;           

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(panel.Width, panel.Height);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = true;
            flow.WrapContents = true;
            flow.HorizontalScroll.Visible = false;
            panel.Controls.Add(flow);

            DataTable table = dados.info;
            DataRow[] rows = table.Select();

            foreach (DataRow row in rows)
            {
                PictureBox btn = new PictureBox();
                btn.Name = "" + Convert.ToString(row["Nome"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToString(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@""+ Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["Nome"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    nomeserie = Convert.ToString(row["Nome"]);
                    total_temp = Convert.ToInt32(row["Total_Temporadas"]);
                    genero_serie = Convert.ToString(row["Genero"]);
                    ano_serie = Convert.ToInt32(row["Ano"]);
                    idade_serie = Convert.ToString(row["Idade"]);
                    imagem = Convert.ToString(row["foto"]);
                    Genero_serie.Text = nomeserie;
                    temp = "1 Temporada";
                    escolha.Text = temp;
                    preencher_series();
                    CarregarEpisodios();
                    if (tabControl1.TabPages.Contains(tabPage3) == false) 
                    { 
                        tabControl1.TabPages.Add(tabPage3);
                        tabControl1.SelectedIndex = 2;
                    }
 
                });
                btn.BringToFront();

                flow.Controls.Add((Control)btn);
            }
        }

        public void CarregarEpisodios()
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(panel.Width, panel.Height);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.TopDown;
            flow.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = true;
            flow.WrapContents = false;
            flow.HorizontalScroll.Visible = false;
            panel7.Controls.Add(flow);

            DataTable table = dados.episodios;
            DataRow[] rows = table.Select("nome ='" + nomeserie + "' AND Temporadas='" + escolha.Text + "'");

            foreach (DataRow row in rows)
            {

                foto.LoadAsync(@"" + imagem);
                foto.Location = new Point(panel6.Width/2 - foto.Width/2, foto.Location.Y);
                Nome.Text = Convert.ToString(row["Nome"]);
                Nome.Location = new Point(panel6.Width / 2 - Nome.Width / 2, Nome.Location.Y);
                Nome.MaximumSize = new Size(panel6.Width, 0);
                Nome.AutoSize = true;
                Genero_serie.Text = genero_serie;
                Genero_serie.Location = new Point(panel6.Width / 2 - Genero_serie.Width / 2, Genero_serie.Location.Y);
                Ano.Text = "" + ano_serie;
                Ano.Location = new Point(panel6.Width / 2 - Ano.Width / 2, Ano.Location.Y);
                Idade.Text = idade_serie;
                Idade.Location = new Point(panel6.Width / 2 - Idade.Width / 2, Idade.Location.Y);
                fechar_episodios.Location = new Point(panel6.Width / 2 - fechar_episodios.Width / 2, fechar_episodios.Location.Y);

                Button btn_ep = new Button();
                btn_ep.Name = "" + row["Nome_Ep"];
                btn_ep.Text = "" + Convert.ToInt32(row["Ep"]) + " - " + row["Nome_Ep"];
                btn_ep.Location = new Point(0, 0);
                btn_ep.Size = new Size(panel7.Width, 20);
                btn_ep.Visible = true;
                btn_ep.BackColor = Color.White;
                btn_ep.FlatStyle = FlatStyle.Flat;
                btn_ep.FlatAppearance.BorderSize = 0;
                btn_ep.Tag = Convert.ToInt32(row["ID"]);
                btn_ep.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["Link"]);
                    new Player().Show();
                });
                btn_ep.BringToFront();

                flow.Controls.Add((Control)btn_ep);
            }

        }

        public void RandomFilmes()
        {
            DataTable table = dados.links;
            Random rnd = new Random();
            int ident;
            ident = rnd.Next(1, table.Rows.Count);
            DataRow currentRow = table.Rows[ident];

            Player.url = Convert.ToString(currentRow["LinkFilme"]);
            Player.nome_filme_player = Convert.ToString(currentRow["NameFilme"]);
            new Player().Show();
        }

        public void Verificar_atualização()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string folder = desktop + "/lionflix/";
            string fileName = folder + "\\info.json";
            string jsonString = File.ReadAllText(fileName);
            dynamic array = JsonConvert.DeserializeObject(jsonString);

            DataTable table = dados.upgrade;
            DataRow[] rows;

            rows = table.Select();

            foreach (DataRow row in rows)
            {
                double versao_ultima = Convert.ToDouble(row["Ultima_Versao"]);
                double versao_programa = Convert.ToDouble(row["Versao_programa"]);
                double versao_atual_link = Convert.ToDouble(array.versao_link);
                double versao_atual_programa = Convert.ToDouble(array.versao_prgm);

                label5.Text = "ver "+ versao_atual_programa+".0";

                var ver = new Versoes
                {
                    versao_link = versao_atual_link,
                    versao_prgm = versao_atual_programa
                };

                string listanova = JsonConvert.SerializeObject(ver);

                if (versao_atual_link < versao_ultima)
                {
                    var popupNotifier = new PopupNotifier();
                    popupNotifier.TitleText = "Aviso";
                    popupNotifier.ContentText = "Você tem novas atualizações!";
                    popupNotifier.IsRightToLeft = false;
                    popupNotifier.Popup();
                    //download.Visible = true;
             
                    bi.BaixarFilmes();
                    bi.BaixarSeries();
                    File.WriteAllText(@"" + folder + "\\info.json", Convert.ToString(listanova));
                }

                if (versao_atual_programa < versao_programa)
                {
                    var popupNotifier = new PopupNotifier();
                    popupNotifier.TitleText = "Aviso";
                    popupNotifier.ContentText = "Lionflix tem uma nova versão disponivel!";
                    popupNotifier.IsRightToLeft = false;
                    popupNotifier.Popup();
                    download.Visible = true;

                    File.WriteAllText(@"" + folder + "\\info.json", Convert.ToString(listanova));
                }
            }
        }

        public void FilmeDoDia()
        {
            DataTable table = dados.links;
            DataRow[] rows;

            Random rnd = new Random();
            int ident;
            ident = rnd.Next(1, table.Rows.Count);

            rows = table.Select("ID LIKE '%" + ident + "%'");

            foreach (DataRow row in rows)
            {              
                nome_do_dia = Convert.ToString(row["NameFilme"]);
                link_do_dia = Convert.ToString(row["LinkFilme"]);             
            }
        }

        public void PegarFilmedoDia()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string folder = desktop + "/lionflix/";

            string fileName = folder + "\\filmehoje.json";

            if (File.Exists(@"" + fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                dynamic array = JsonConvert.DeserializeObject(jsonString);

                Guardado m = JsonConvert.DeserializeObject<Guardado>(jsonString);
                nome_do_dia = m.Nome;
                link_do_dia = m.Link;
                AbrirFilmedodia.Text = nome_do_dia;
            }
        }

        public void CarregarUltimosFilmes()
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(panel4.Width, panel4.Height);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = true;
            flow.WrapContents = false;
            flow.VerticalScroll.Visible = false;
            panel4.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] rows;
            rows = table.Rows.Cast<DataRow>().Skip(table.Rows.Count - 10).Reverse().ToArray();

            foreach (DataRow row in rows)
            {
                    PictureBox btn = new PictureBox();
                    btn.Name = "" + row["NameFilme"];
                    btn.Location = new Point(panel4.Width / 2 - panel4.Width / 2, btn.Location.Y);
                    btn.Size = new Size(74, panel4.Height-25);
                    btn.Visible = true;
                    btn.Tag = Convert.ToInt32(row["ID"]);
                    btn.WaitOnLoad = false;
                    btn.LoadAsync(@"" + row["foto"]);
                    btn.SizeMode = PictureBoxSizeMode.StretchImage;
                    btn.Click += (EventHandler)((_param1, _param2) =>
                    {
                        Player.url = Convert.ToString(row["LinkFilme"]);
                        new Player().Show();
                    });
                    btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                    btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                    btn.BringToFront();

                    flow.Controls.Add((Control)btn);
            }
        }

        private void OpenFilmes_Click(object sender, EventArgs e)
        {
            panel.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            CarregarFilmes();
        }

        private void OpenSeries_Click(object sender, EventArgs e)
        {
            panel.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            CarregarSeries();
        }

        public void preencher()
        {
            escolher_genero.DataSource = genero_list;
        }

        public void preencher_series()
        {
            ArrayList arr = new ArrayList();
            for (int x = 1; x < total_temp + 1; x++)
            {
                temp = "" + x + " Temporada";
                arr.Add(temp);
            }
            escolha.DataSource = arr;
        }

        private void OpenSobre_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage4) == false)
            {
                tabControl1.TabPages.Add(tabPage4);
                tabControl1.SelectedTab = tabPage4;
            }
            else
            {
                tabControl1.SelectedTab = tabPage4;
            }

            label3.Location = new Point(panel8.Width / 2 - label3.Width / 2, label3.Location.Y);
            linkLabel2.Location = new Point(panel8.Width / 2 - linkLabel2.Width / 2, linkLabel2.Location.Y);
            label4.Location = new Point(panel8.Width / 2 - label4.Width / 2, label4.Location.Y);
            label5.Location = new Point(panel8.Width / 2 - label5.Width / 2, label5.Location.Y);
        }

        public void Busca()
        {
            if (tabControl1.TabPages.Contains(tabPage2) == false)
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.SelectedTab = tabPage2;
            }
            escolher_genero.Visible = true;

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(panel.Width, panel.Height);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = true;
            flow.WrapContents = true;
            flow.HorizontalScroll.Visible = false;
            panel.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] rows;

            if (busca.Text != null)
            {
                rows = table.Select("NameFilme LIKE '%" + busca.Text + "%'", "NameFilme ASC");


            foreach (DataRow row in rows)
            {
                Button leg = new Button();
                leg.Name = "Legenda";
                leg.Text = "L";
                leg.Font = new Font(FontFamily.GenericSansSerif, 8);
                leg.Location = new Point(0, 80);
                leg.Size = new Size(20, 20);
                leg.ForeColor = Color.White;
                leg.BackColor = Color.Black;
                leg.FlatAppearance.BorderSize = 0;
                leg.FlatStyle = FlatStyle.Flat;
                leg.Visible = true;
                leg.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom) | AnchorStyles.Left)));
                leg.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)leg, "Filme Com Legenda Para Deficiente Auditivos!"));
                leg.MouseLeave += (EventHandler)((_param1, _param2) => { });

                PictureBox btn = new PictureBox();
                btn.Name = Convert.ToString(row["NameFilme"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToInt32(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@"" + Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["LinkFilme"]);
                    new Player().Show();
                });
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.BringToFront();


                if (Convert.ToInt32(row["Legenda"]) == 1)
                {
                    btn.Controls.Add(leg);
                }

                flow.Controls.Add((Control)btn);

                }
            }
        }

        private void escolher_genero_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage2) == false)
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
            }

            panel.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            CarregarFilmes();
        }

        private void escolha_TextChanged(object sender, EventArgs e)
        {
            panel7.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            CarregarEpisodios();
        }

        private void whatsapp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://chat.whatsapp.com/F7Q9gU2yL7x4bWZ50osVyw/");
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/lionflixfilmes/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lionflix.xyz");
        }

        private void fechar_sobre_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage4);
        }

        private void fechar_episodios_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage3);
        }

        private void fechar_pagina_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage2) == false)
            {
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
            }

            panel.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            Busca();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            RandomFilmes();
        }
        private void AbrirFilmedodia_Click(object sender, EventArgs e)
        {
            Player.url = Convert.ToString(link_do_dia);
            new Player().Show();
        }

        private void OpenLista_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage5) == false)
            {
                tabControl1.TabPages.Add(tabPage5);
                tabControl1.SelectedTab = tabPage5;
            }
            else
            {
                tabControl1.SelectedTab = tabPage5;
            }

            flowLista.Controls.OfType<Label>().ToList().ForEach((b) => b.Parent = null);
            flowLista.Controls.OfType<FlowLayoutPanel>().ToList().ForEach((b) => b.Parent = null);
            CriarLista1();
            CriarLista2();
            CriarLista3();
            CriarLista4();
            CriarLista5();
        }

        public void CriarLista1()
        {
            flowLista.AutoScroll = true;
            flowLista.WrapContents = true;
            flowLista.HorizontalScroll.Visible = false;

            Label lb = new Label();
            lb.Text = "SAGA CRESPUSCULO";
            lb.Size = new Size(120, 12);
            lb.ForeColor = Color.White;
            lb.Location = new Point(flowLista.Width / 2 - lb.Width / 2, lb.Location.Y);
            flowLista.Controls.Add(lb);

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(flowLista.Width, 129);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)(((AnchorStyles.Left) | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoSize = true;
            flow.AutoScroll = true;
            flow.WrapContents = false;
            flow.VerticalScroll.Visible = false;
            flowLista.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] Rows = table.Select("NameFilme LIKE '%Crepusculo%'", "NameFilme ASC");

            foreach (DataRow row in Rows)
            {

                PictureBox btn = new PictureBox();
                btn.Name = Convert.ToString(row["NameFilme"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToInt32(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@"" + Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["LinkFilme"]);
                    new Player().Show();
                });
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.BringToFront();


                flow.Controls.Add(btn);
            }
        }

        public void CriarLista2()
        {
            flowLista.AutoScroll = true;
            flowLista.WrapContents = false;
            flowLista.HorizontalScroll.Visible = false;

            Label lb = new Label();
            lb.Text = "JOGOS MORTAIS";
            lb.Size = new Size(120, 12);
            lb.ForeColor = Color.White;
            lb.Location = new Point(0, 0);
            flowLista.Controls.Add(lb);

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0,0);
            flow.Size = new Size(flowLista.Width, 129);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)(((AnchorStyles.Left) | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = false;
            flow.AutoSize = true;
            flow.WrapContents = false;
            flow.VerticalScroll.Visible = false;
            flowLista.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] Rows = table.Select("NameFilme LIKE '%Jogos Mortais%'", "NameFilme ASC");

            foreach (DataRow row in Rows)
            {

                PictureBox btn = new PictureBox();
                btn.Name = Convert.ToString(row["NameFilme"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToInt32(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@"" + Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["LinkFilme"]);
                    new Player().Show();
                });
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.BringToFront();


                flow.Controls.Add(btn);
            }
        }

        public void CriarLista3()
        {
            flowLista.AutoScroll = true;
            flowLista.WrapContents = false;
            flowLista.HorizontalScroll.Visible = false;

            Label lb = new Label();
            lb.Text = "JOGOS VORAZES";
            lb.Size = new Size(120, 12);
            lb.ForeColor = Color.White;
            lb.Location = new Point(0, 0);
            flowLista.Controls.Add(lb);

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(flowLista.Width, 129);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)(((AnchorStyles.Left) | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = false;
            flow.AutoSize = true;
            flow.WrapContents = false;
            flow.VerticalScroll.Visible = false;
            flowLista.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] Rows = table.Select("NameFilme LIKE '%Jogos Vorazes%'", "NameFilme ASC");

            foreach (DataRow row in Rows)
            {

                PictureBox btn = new PictureBox();
                btn.Name = Convert.ToString(row["NameFilme"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToInt32(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@"" + Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["LinkFilme"]);
                    new Player().Show();
                });
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.BringToFront();


                flow.Controls.Add(btn);
            }
        }

        public void CriarLista4()
        {
            flowLista.AutoScroll = true;
            flowLista.WrapContents = false;
            flowLista.HorizontalScroll.Visible = false;

            Label lb = new Label();
            lb.Text = "PIRATAS DO CARIBE";
            lb.Size = new Size(120, 12);
            lb.ForeColor = Color.White;
            lb.Location = new Point(0, 0);
            flowLista.Controls.Add(lb);

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(flowLista.Width, 129);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)(((AnchorStyles.Left) | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = false;
            flow.AutoSize = true;
            flow.WrapContents = false;
            flow.VerticalScroll.Visible = false;
            flowLista.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] Rows = table.Select("NameFilme LIKE '%Piratas Do Caribe%'", "NameFilme ASC");

            foreach (DataRow row in Rows)
            {
                PictureBox btn = new PictureBox();
                btn.Name = Convert.ToString(row["NameFilme"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToInt32(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@"" + Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["LinkFilme"]);
                    new Player().Show();
                });
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.BringToFront();


                flow.Controls.Add(btn);
            }
        }

        public void CriarLista5()
        {
            flowLista.AutoScroll = true;
            flowLista.WrapContents = false;
            flowLista.HorizontalScroll.Visible = false;

            Label lb = new Label();
            lb.Text = "KUNG FU PANDA";
            lb.Size = new Size(120, 12);
            lb.ForeColor = Color.White;
            lb.Location = new Point(0, 0);
            flowLista.Controls.Add(lb);

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(0, 0);
            flow.Size = new Size(flowLista.Width, 129);
            flow.Visible = true;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Anchor = ((AnchorStyles)(((AnchorStyles.Left) | AnchorStyles.Right)));
            flow.BringToFront();
            flow.AutoScroll = false;
            flow.AutoSize = true;
            flow.WrapContents = false;
            flow.VerticalScroll.Visible = false;
            flowLista.Controls.Add(flow);

            DataTable table = dados.links;
            DataRow[] Rows = table.Select("NameFilme LIKE '%Kung Fu Panda%'", "NameFilme ASC");

            foreach (DataRow row in Rows)
            {

                PictureBox btn = new PictureBox();
                btn.Name = Convert.ToString(row["NameFilme"]);
                btn.Location = new Point(0, 0);
                btn.Size = new Size(74, 100);
                btn.Visible = true;
                btn.Tag = Convert.ToInt32(row["ID"]);
                btn.WaitOnLoad = false;
                btn.LoadAsync(@"" + Convert.ToString(row["foto"]));
                btn.SizeMode = PictureBoxSizeMode.StretchImage;
                btn.Click += (EventHandler)((_param1, _param2) =>
                {
                    Player.url = Convert.ToString(row["LinkFilme"]);
                    new Player().Show();
                });
                btn.MouseEnter += (EventHandler)((_param1, _param2) => new ToolTip().SetToolTip((Control)btn, Convert.ToString(row["NameFilme"])));
                btn.MouseLeave += (EventHandler)((_param1, _param2) => { });
                btn.BringToFront();


                flow.Controls.Add(btn);
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            string address = "https://drive.google.com/u/0/uc?id=1noMGQNNVzDv-XJWeeCyITcnoV0_OQPct&export=download";
            Process.Start(address);
        }

        private void FecharLista_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage5);
        }
    }
}
