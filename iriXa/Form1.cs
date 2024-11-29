using System.Runtime.InteropServices; // ��� ������ � Windows API
using System.Diagnostics; // ��� ������ � ����������
using System.Windows.Forms; // ��� MessageBox
using System.Net;


namespace iriXa
{
    public partial class iriXa : Form
    {
        // ������ ������� ��� ����������� ����
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public iriXa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

        public void CheckForUpdates()
        {
            try
            {
                string versionFilePath = Path.Combine(Application.StartupPath, "version.txt"); // ���� � ����� ������
                string serverVersionUrl = "https://pastebin.com/raw/J1U6ZQn1"; // URL � ������� ������� �� �������

                // ��������� ������ �� ���������� �����
                string localVersion = File.Exists(versionFilePath) ? File.ReadAllText(versionFilePath).Trim() : "0.0.0"; // ���� ���� �� ������, ���������� "0.0.0"

                using (WebClient client = new WebClient())
                {
                    // �������� ������� ������ � �������
                    string serverVersion = client.DownloadString(serverVersionUrl).Trim();

                    // ���������� ������
                    if (serverVersion != localVersion)
                    {
                        DialogResult result = MessageBox.Show("A new version is available. Would you like to download it?",
                                                             "New Version Available", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            // ��������� �������� ��� ���������� ����� ������
                            System.Diagnostics.Process.Start(new ProcessStartInfo("https://github.com/Amo1224gus/iriXa/releases/latest") { UseShellExecute = true });
                            Application.Exit();  // ������� ����������
                        }
                        else
                        {
                            Application.Exit();  // ������� ����������, ���� �� ������ ��������
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for updates: " + ex.Message);
                Application.Exit();  // ������� ����������, ���� ������ ��� ��������
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox.Text);
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ��������, ������� �� ������� RobloxPlayer.exe
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length == 0) // ���� ������� �� ������
            {
                DialogResult result = MessageBox.Show(
                    "Roblox could not be found. Is this an error?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return; // ��������� ����������
                }
            }

            // ���� ������� ������ ��� ������������ ������ "Yes", ��������� ������� ��������
            ForlornApi.Api.Inject();
            if (ForlornApi.Api.IsInjected()) // ���������, ��� ������ ������ �������
            {
                // ��������� ������, ������ ���� ������ ������
                ForlornApi.Api.ExecuteScript("loadstring(game:HttpGet(\"https://pastefy.app/iBIxkdb4/raw\"))()");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ���������� ���������
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // ���������, ������ �� ����� ������ ����
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/MassiveHubs/loadstring/refs/heads/main/DexXenoAndRezware'))()");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript("loadstring(game:HttpGet(\"https://pastebin.com/raw/PDdkDsgy\"))()");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript("local pastebinURL = \"https://pastebin.com/raw/SdGZaVZs\" local loadedScript = loadstring(game:HttpGet(pastebinURL))()\r\n\r\nlocal FREAKY_ID = 87134700438873 -- :tongue::tongue::tongue:\r\n\r\nloadedScript(FREAKY_ID)");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ForlornApi.Api.SetAutoInject(checkBox1.Checked);
            if (ForlornApi.Api.IsInjected()) // ���������, ��� ������ ������ �������
            {
                // ��������� ������, ������ ���� ������ ������
                ForlornApi.Api.ExecuteScript("loadstring(game:HttpGet(\"https://pastefy.app/iBIxkdb4\"))()");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // ������ ������������ �����
            if (this.Opacity == 1.0)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 1.0;
            }
        }
    }
}
