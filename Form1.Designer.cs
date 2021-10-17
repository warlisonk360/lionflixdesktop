
namespace Lionflix
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Barra = new System.Windows.Forms.Panel();
            this.restaure = new System.Windows.Forms.Button();
            this.maximize = new System.Windows.Forms.Button();
            this.miniminize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.download = new System.Windows.Forms.Button();
            this.facebook = new System.Windows.Forms.Button();
            this.whatsapp = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AbrirFilmedodia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fechar_pagina = new System.Windows.Forms.Button();
            this.escolher_genero = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.escolha = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.fechar_episodios = new System.Windows.Forms.Button();
            this.Idade = new System.Windows.Forms.Label();
            this.Ano = new System.Windows.Forms.Label();
            this.Genero_serie = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.fechar_sobre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenSobre = new System.Windows.Forms.Button();
            this.OpenLista = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.busca = new System.Windows.Forms.TextBox();
            this.OpenSeries = new System.Windows.Forms.Button();
            this.OpenFilmes = new System.Windows.Forms.Button();
            this.FecharLista = new System.Windows.Forms.Button();
            this.flowLista = new System.Windows.Forms.FlowLayoutPanel();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra
            // 
            this.Barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Barra.BackColor = System.Drawing.Color.Black;
            this.Barra.Controls.Add(this.restaure);
            this.Barra.Controls.Add(this.maximize);
            this.Barra.Controls.Add(this.miniminize);
            this.Barra.Controls.Add(this.close);
            this.Barra.Controls.Add(this.pictureBox1);
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(800, 29);
            this.Barra.TabIndex = 0;
            this.Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra_MouseMove);
            // 
            // restaure
            // 
            this.restaure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restaure.BackgroundImage")));
            this.restaure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restaure.FlatAppearance.BorderSize = 0;
            this.restaure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restaure.Location = new System.Drawing.Point(740, 1);
            this.restaure.Name = "restaure";
            this.restaure.Size = new System.Drawing.Size(26, 26);
            this.restaure.TabIndex = 4;
            this.restaure.UseVisualStyleBackColor = true;
            this.restaure.Click += new System.EventHandler(this.restaure_Click);
            // 
            // maximize
            // 
            this.maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximize.BackgroundImage")));
            this.maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximize.FlatAppearance.BorderSize = 0;
            this.maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize.Location = new System.Drawing.Point(739, 1);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(26, 26);
            this.maximize.TabIndex = 3;
            this.maximize.UseVisualStyleBackColor = true;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // miniminize
            // 
            this.miniminize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniminize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniminize.BackgroundImage")));
            this.miniminize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miniminize.FlatAppearance.BorderSize = 0;
            this.miniminize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniminize.Location = new System.Drawing.Point(705, 3);
            this.miniminize.Name = "miniminize";
            this.miniminize.Size = new System.Drawing.Size(24, 24);
            this.miniminize.TabIndex = 2;
            this.miniminize.UseVisualStyleBackColor = true;
            this.miniminize.Click += new System.EventHandler(this.miniminize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(772, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 368);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 365);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.download);
            this.tabPage1.Controls.Add(this.facebook);
            this.tabPage1.Controls.Add(this.whatsapp);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            // 
            // download
            // 
            this.download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.download.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("download.BackgroundImage")));
            this.download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.download.FlatAppearance.BorderSize = 0;
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.Location = new System.Drawing.Point(35, 302);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(30, 25);
            this.download.TabIndex = 8;
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // facebook
            // 
            this.facebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.facebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facebook.BackgroundImage")));
            this.facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facebook.FlatAppearance.BorderSize = 0;
            this.facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebook.Location = new System.Drawing.Point(675, 294);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(37, 36);
            this.facebook.TabIndex = 7;
            this.facebook.UseVisualStyleBackColor = true;
            this.facebook.Click += new System.EventHandler(this.facebook_Click);
            // 
            // whatsapp
            // 
            this.whatsapp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.whatsapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("whatsapp.BackgroundImage")));
            this.whatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whatsapp.FlatAppearance.BorderSize = 0;
            this.whatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whatsapp.Location = new System.Drawing.Point(720, 295);
            this.whatsapp.Name = "whatsapp";
            this.whatsapp.Size = new System.Drawing.Size(37, 36);
            this.whatsapp.TabIndex = 6;
            this.whatsapp.UseVisualStyleBackColor = true;
            this.whatsapp.Click += new System.EventHandler(this.whatsapp_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.Random);
            this.panel5.Location = new System.Drawing.Point(32, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 100);
            this.panel5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(107, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filmes Sorteados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Random
            // 
            this.Random.BackColor = System.Drawing.Color.White;
            this.Random.FlatAppearance.BorderSize = 0;
            this.Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Random.Location = new System.Drawing.Point(36, 43);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(236, 42);
            this.Random.TabIndex = 0;
            this.Random.Text = "Ver Filme Aleatorio";
            this.Random.UseVisualStyleBackColor = false;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.AbrirFilmedodia);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(428, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 100);
            this.panel3.TabIndex = 3;
            // 
            // AbrirFilmedodia
            // 
            this.AbrirFilmedodia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbrirFilmedodia.BackColor = System.Drawing.Color.White;
            this.AbrirFilmedodia.FlatAppearance.BorderSize = 0;
            this.AbrirFilmedodia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbrirFilmedodia.Location = new System.Drawing.Point(68, 40);
            this.AbrirFilmedodia.Name = "AbrirFilmedodia";
            this.AbrirFilmedodia.Size = new System.Drawing.Size(212, 37);
            this.AbrirFilmedodia.TabIndex = 1;
            this.AbrirFilmedodia.Text = "Filme do dia";
            this.AbrirFilmedodia.UseVisualStyleBackColor = false;
            this.AbrirFilmedodia.Click += new System.EventHandler(this.AbrirFilmedodia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(113, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recomendação do Dia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOVOS FILMES";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(32, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(725, 129);
            this.panel4.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.fechar_pagina);
            this.tabPage2.Controls.Add(this.escolher_genero);
            this.tabPage2.Controls.Add(this.panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(792, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "pagina";
            // 
            // fechar_pagina
            // 
            this.fechar_pagina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar_pagina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar_pagina.BackgroundImage")));
            this.fechar_pagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechar_pagina.FlatAppearance.BorderSize = 0;
            this.fechar_pagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar_pagina.Location = new System.Drawing.Point(763, 1);
            this.fechar_pagina.Name = "fechar_pagina";
            this.fechar_pagina.Size = new System.Drawing.Size(25, 24);
            this.fechar_pagina.TabIndex = 5;
            this.fechar_pagina.UseVisualStyleBackColor = true;
            this.fechar_pagina.Click += new System.EventHandler(this.fechar_pagina_Click);
            // 
            // escolher_genero
            // 
            this.escolher_genero.FormattingEnabled = true;
            this.escolher_genero.Location = new System.Drawing.Point(3, 3);
            this.escolher_genero.Name = "escolher_genero";
            this.escolher_genero.Size = new System.Drawing.Size(243, 21);
            this.escolher_genero.TabIndex = 1;
            this.escolher_genero.TextChanged += new System.EventHandler(this.escolher_genero_TextChanged);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(3, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(793, 316);
            this.panel.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.escolha);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "episodios";
            // 
            // escolha
            // 
            this.escolha.FormattingEnabled = true;
            this.escolha.Location = new System.Drawing.Point(3, 8);
            this.escolha.Name = "escolha";
            this.escolha.Size = new System.Drawing.Size(230, 21);
            this.escolha.TabIndex = 2;
            this.escolha.TextChanged += new System.EventHandler(this.escolha_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(248, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(536, 325);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.fechar_episodios);
            this.panel6.Controls.Add(this.Idade);
            this.panel6.Controls.Add(this.Ano);
            this.panel6.Controls.Add(this.Genero_serie);
            this.panel6.Controls.Add(this.Nome);
            this.panel6.Controls.Add(this.foto);
            this.panel6.Location = new System.Drawing.Point(8, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 275);
            this.panel6.TabIndex = 0;
            // 
            // fechar_episodios
            // 
            this.fechar_episodios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar_episodios.BackColor = System.Drawing.Color.White;
            this.fechar_episodios.FlatAppearance.BorderSize = 0;
            this.fechar_episodios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar_episodios.Location = new System.Drawing.Point(68, 238);
            this.fechar_episodios.Name = "fechar_episodios";
            this.fechar_episodios.Size = new System.Drawing.Size(75, 23);
            this.fechar_episodios.TabIndex = 0;
            this.fechar_episodios.Text = "Fechar";
            this.fechar_episodios.UseVisualStyleBackColor = false;
            this.fechar_episodios.Click += new System.EventHandler(this.fechar_episodios_Click);
            // 
            // Idade
            // 
            this.Idade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(88, 203);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(34, 13);
            this.Idade.TabIndex = 6;
            this.Idade.Text = "Idade";
            this.Idade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ano
            // 
            this.Ano.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ano.AutoSize = true;
            this.Ano.Location = new System.Drawing.Point(88, 183);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(26, 13);
            this.Ano.TabIndex = 5;
            this.Ano.Text = "Ano";
            this.Ano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Genero_serie
            // 
            this.Genero_serie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Genero_serie.AutoSize = true;
            this.Genero_serie.Location = new System.Drawing.Point(88, 163);
            this.Genero_serie.Name = "Genero_serie";
            this.Genero_serie.Size = new System.Drawing.Size(42, 13);
            this.Genero_serie.TabIndex = 4;
            this.Genero_serie.Text = "Genero";
            this.Genero_serie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nome
            // 
            this.Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(88, 142);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 3;
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foto
            // 
            this.foto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foto.Location = new System.Drawing.Point(59, 18);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(100, 102);
            this.foto.TabIndex = 3;
            this.foto.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.panel8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 339);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "sobre nós";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.fechar_sobre);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.linkLabel2);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(23, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(752, 316);
            this.panel8.TabIndex = 0;
            // 
            // fechar_sobre
            // 
            this.fechar_sobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar_sobre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar_sobre.BackgroundImage")));
            this.fechar_sobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fechar_sobre.FlatAppearance.BorderSize = 0;
            this.fechar_sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar_sobre.Location = new System.Drawing.Point(715, 4);
            this.fechar_sobre.Name = "fechar_sobre";
            this.fechar_sobre.Size = new System.Drawing.Size(30, 27);
            this.fechar_sobre.TabIndex = 4;
            this.fechar_sobre.UseVisualStyleBackColor = true;
            this.fechar_sobre.Click += new System.EventHandler(this.fechar_sobre_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ver 2.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Criado Por: Warlison Santos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(302, 122);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(125, 20);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://lionflix.xyz";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "LIONFLIX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage5.Controls.Add(this.flowLista);
            this.tabPage5.Controls.Add(this.FecharLista);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 339);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Listas";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.OpenSobre);
            this.panel2.Controls.Add(this.OpenLista);
            this.panel2.Controls.Add(this.btn_buscar);
            this.panel2.Controls.Add(this.busca);
            this.panel2.Controls.Add(this.OpenSeries);
            this.panel2.Controls.Add(this.OpenFilmes);
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 41);
            this.panel2.TabIndex = 2;
            // 
            // OpenSobre
            // 
            this.OpenSobre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenSobre.FlatAppearance.BorderSize = 0;
            this.OpenSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.OpenSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSobre.Location = new System.Drawing.Point(348, 2);
            this.OpenSobre.Name = "OpenSobre";
            this.OpenSobre.Size = new System.Drawing.Size(110, 38);
            this.OpenSobre.TabIndex = 5;
            this.OpenSobre.Text = "SOBRE";
            this.OpenSobre.UseVisualStyleBackColor = false;
            this.OpenSobre.Click += new System.EventHandler(this.OpenSobre_Click);
            // 
            // OpenLista
            // 
            this.OpenLista.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenLista.FlatAppearance.BorderSize = 0;
            this.OpenLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.OpenLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenLista.Location = new System.Drawing.Point(234, 2);
            this.OpenLista.Name = "OpenLista";
            this.OpenLista.Size = new System.Drawing.Size(110, 38);
            this.OpenLista.TabIndex = 4;
            this.OpenLista.Text = "LISTAS";
            this.OpenLista.UseVisualStyleBackColor = false;
            this.OpenLista.Click += new System.EventHandler(this.OpenLista_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(719, 9);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // busca
            // 
            this.busca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.busca.Location = new System.Drawing.Point(509, 11);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(204, 20);
            this.busca.TabIndex = 2;
            // 
            // OpenSeries
            // 
            this.OpenSeries.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenSeries.FlatAppearance.BorderSize = 0;
            this.OpenSeries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.OpenSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSeries.Location = new System.Drawing.Point(120, 2);
            this.OpenSeries.Name = "OpenSeries";
            this.OpenSeries.Size = new System.Drawing.Size(110, 38);
            this.OpenSeries.TabIndex = 1;
            this.OpenSeries.Text = "SERIES";
            this.OpenSeries.UseVisualStyleBackColor = false;
            this.OpenSeries.Click += new System.EventHandler(this.OpenSeries_Click);
            // 
            // OpenFilmes
            // 
            this.OpenFilmes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenFilmes.FlatAppearance.BorderSize = 0;
            this.OpenFilmes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.OpenFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFilmes.Location = new System.Drawing.Point(4, 2);
            this.OpenFilmes.Name = "OpenFilmes";
            this.OpenFilmes.Size = new System.Drawing.Size(112, 38);
            this.OpenFilmes.TabIndex = 0;
            this.OpenFilmes.Text = "FILMES";
            this.OpenFilmes.UseVisualStyleBackColor = false;
            this.OpenFilmes.Click += new System.EventHandler(this.OpenFilmes_Click);
            // 
            // FecharLista
            // 
            this.FecharLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FecharLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FecharLista.BackgroundImage")));
            this.FecharLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FecharLista.FlatAppearance.BorderSize = 0;
            this.FecharLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FecharLista.Location = new System.Drawing.Point(759, 3);
            this.FecharLista.Name = "FecharLista";
            this.FecharLista.Size = new System.Drawing.Size(30, 27);
            this.FecharLista.TabIndex = 5;
            this.FecharLista.UseVisualStyleBackColor = true;
            this.FecharLista.Click += new System.EventHandler(this.FecharLista_Click);
            // 
            // flowLista
            // 
            this.flowLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLista.BackColor = System.Drawing.Color.Transparent;
            this.flowLista.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLista.Location = new System.Drawing.Point(3, 36);
            this.flowLista.Name = "flowLista";
            this.flowLista.Size = new System.Drawing.Size(786, 300);
            this.flowLista.TabIndex = 6;
            this.flowLista.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button miniminize;
        private System.Windows.Forms.Button maximize;
        private System.Windows.Forms.Button restaure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenSeries;
        private System.Windows.Forms.Button OpenFilmes;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox busca;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox escolher_genero;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox escolha;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.Label Ano;
        private System.Windows.Forms.Label Genero_serie;
        private System.Windows.Forms.Button OpenLista;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button whatsapp;
        private System.Windows.Forms.Button facebook;
        private System.Windows.Forms.Button fechar_sobre;
        private System.Windows.Forms.Button fechar_episodios;
        private System.Windows.Forms.Button fechar_pagina;
        private System.Windows.Forms.Button AbrirFilmedodia;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenSobre;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button FecharLista;
        private System.Windows.Forms.FlowLayoutPanel flowLista;
    }
}

