using Gecko;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using Screen = System.Windows.Forms.Screen;

namespace Lionflix
{
    public partial class Player : Form
    {
        private GeckoWebBrowser geckoWebBrowser1;
        public static string url;
        public static string nome_filme_player;
        bool IsMaximized = false;
        bool TheaterClicked = false;
        Rectangle previousPosition = Rectangle.Empty;
        string UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0";

        public Player()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            GeckoPreferences.User["full-screen-api.enabled"] = true;
            GeckoPreferences.Default["full-screen-api.enabled"] = true;
            GeckoPreferences.User["general.useragent.override"] = UserAgent;
            GeckoPreferences.Default["general.useragent.override"] = UserAgent;
            GeckoPreferences.User["browser.zoom.full"] = true;
            this.Text = nome_filme_player;
            Criar();
        }

        private void Criar()
        {      
            this.geckoWebBrowser1 = new GeckoWebBrowser();
            this.SuspendLayout();
            this.geckoWebBrowser1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.geckoWebBrowser1.ConsoleMessageEventReceivesConsoleLogCalls = true;
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new Point(-1, -2);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new Size(806, 453);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.Dock = DockStyle.Fill;
            this.geckoWebBrowser1.DomDoubleClick += new System.EventHandler<Gecko.DomMouseEventArgs>(this.geckoWebBrowser1_DomDoubleClick);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add((Control)this.geckoWebBrowser1);
            this.Name = nameof(Player);
            this.ShowIcon = false;
            this.Text = "LionFlix";
            this.ResumeLayout(false);
        }

        private void Player_Load(object sender, EventArgs e)
        {
            previousPosition = Bounds;
            geckoWebBrowser1.Navigate(url);
            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "Aviso!";
            popupNotifier.ContentText = "Aperte o Play e Depois ESC para entra e sair da tela cheia!";
            popupNotifier.IsRightToLeft = false;
            popupNotifier.Popup();
        }



        private void SetWindowState(FormWindowState state, bool setSize)
        {
            if (state == FormWindowState.Maximized)
            {
                IsMaximized = true;
                if (setSize) previousPosition = Bounds;
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                Location = Point.Empty;
                Size = Screen.FromHandle(Handle).Bounds.Size;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                Bounds = previousPosition;
                IsMaximized = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Escape)
            {
                SetWindowState(IsMaximized ? FormWindowState.Normal : FormWindowState.Maximized, true);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void geckoWebBrowser1_DomDoubleClick(object sender, DomMouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Player_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                SetWindowState(WindowState, false);

            }
            else if (!IsMaximized)
            {
                previousPosition = Bounds;
            }
        }

        private void Player_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}