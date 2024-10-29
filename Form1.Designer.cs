namespace HW._MassivKnopok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        public const int M = 3;
        public const int N = 5; 
        public Button[,] buttons = new Button[M, N];

        private void InitializeComponent()
        {
            this.Load += Form1_Load;
            BackColor = SystemColors.HotTrack;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButtonArray();
        }

        private void CreateButtonArray()
        {
            int buttonWidth = 250;
            int buttonHeight = 100;
            int margin = 15;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(buttonWidth, buttonHeight);
                    buttons[i, j].Location = new Point(j * (buttonWidth + margin), i * (buttonHeight + margin));
                    buttons[i, j].Text = $"{i * N + j + 1}";
                    buttons[i, j].Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
                    buttons[i, j].BackColor = SystemColors.Control;
                    buttons[i,j].ForeColor = SystemColors.HotTrack;

                    buttons[i, j].Click += Button_Click;

                    this.Controls.Add(buttons[i, j]);
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int row = -1;
            int column = -1;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (buttons[i, j] == clickedButton)
                    {
                        row = i;
                        column = j;
                        break;
                    }
                }
            }

            if (row != -1 && column != -1)
            {
                MessageBox.Show($"Строка {row + 1}, Столбик {column + 1}");
                clickedButton.Enabled = false;
            }
        }


        #endregion
    }
}
