
namespace TextE
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CutStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FontStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 422);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenuItem1,
            this.EditStripMenuItem1,
            this.FontStripMenuItem1,
            this.InfoStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            // 
            // FileStripMenuItem1
            // 
            this.FileStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStripMenuItem1,
            this.SaveStripMenuItem1,
            this.SaveAsStripMenuItem1});
            this.FileStripMenuItem1.Name = "FileStripMenuItem1";
            this.FileStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.FileStripMenuItem1.Text = "Файл";
            // 
            // OpenStripMenuItem1
            // 
            this.OpenStripMenuItem1.Name = "OpenStripMenuItem1";
            this.OpenStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.OpenStripMenuItem1.Text = "Открыть";
            this.OpenStripMenuItem1.Click += new System.EventHandler(this.OpenStripMenuItem1_Click);
            // 
            // SaveStripMenuItem1
            // 
            this.SaveStripMenuItem1.Name = "SaveStripMenuItem1";
            this.SaveStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.SaveStripMenuItem1.Text = "Сохранить";
            this.SaveStripMenuItem1.Click += new System.EventHandler(this.SaveStripMenuItem1_Click);
            // 
            // SaveAsStripMenuItem1
            // 
            this.SaveAsStripMenuItem1.Name = "SaveAsStripMenuItem1";
            this.SaveAsStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.SaveAsStripMenuItem1.Text = "Сохранить как";
            this.SaveAsStripMenuItem1.Click += new System.EventHandler(this.SaveAsStripMenuItem1_Click);
            // 
            // EditStripMenuItem1
            // 
            this.EditStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyStripMenuItem1,
            this.PasteStripMenuItem1,
            this.CutStripMenuItem1});
            this.EditStripMenuItem1.Name = "EditStripMenuItem1";
            this.EditStripMenuItem1.Size = new System.Drawing.Size(74, 24);
            this.EditStripMenuItem1.Text = "Правка";
            // 
            // CopyStripMenuItem1
            // 
            this.CopyStripMenuItem1.Name = "CopyStripMenuItem1";
            this.CopyStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.CopyStripMenuItem1.Text = "Копировать";
            this.CopyStripMenuItem1.Click += new System.EventHandler(this.CopyStripMenuItem1_Click);
            // 
            // PasteStripMenuItem1
            // 
            this.PasteStripMenuItem1.Name = "PasteStripMenuItem1";
            this.PasteStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.PasteStripMenuItem1.Text = "Вставить";
            this.PasteStripMenuItem1.Click += new System.EventHandler(this.PasteStripMenuItem1_Click);
            // 
            // CutStripMenuItem1
            // 
            this.CutStripMenuItem1.Name = "CutStripMenuItem1";
            this.CutStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.CutStripMenuItem1.Text = "Вырезать";
            this.CutStripMenuItem1.Click += new System.EventHandler(this.CutStripMenuItem1_Click);
            // 
            // FontStripMenuItem1
            // 
            this.FontStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem1});
            this.FontStripMenuItem1.Name = "FontStripMenuItem1";
            this.FontStripMenuItem1.Size = new System.Drawing.Size(71, 24);
            this.FontStripMenuItem1.Text = "Шрифт";
            // 
            // FontToolStripMenuItem1
            // 
            this.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1";
            this.FontToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.FontToolStripMenuItem1.Text = "Настроить шрифт";
            this.FontToolStripMenuItem1.Click += new System.EventHandler(this.FontToolStripMenuItem1_Click);
            // 
            // InfoStripMenuItem1
            // 
            this.InfoStripMenuItem1.Name = "InfoStripMenuItem1";
            this.InfoStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.InfoStripMenuItem1.Text = "Инфо";
            this.InfoStripMenuItem1.Click += new System.EventHandler(this.InfoStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem1,
            this.PasteToolStripMenuItem1,
            this.CutToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 76);
            // 
            // CopyToolStripMenuItem1
            // 
            this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
            this.CopyToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.CopyToolStripMenuItem1.Text = "Копировать";
            this.CopyToolStripMenuItem1.Click += new System.EventHandler(this.CopyToolStripMenuItem1_Click);
            // 
            // PasteToolStripMenuItem1
            // 
            this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
            this.PasteToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.PasteToolStripMenuItem1.Text = "Вставить";
            this.PasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // CutToolStripMenuItem1
            // 
            this.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1";
            this.CutToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.CutToolStripMenuItem1.Text = "Вырезать";
            this.CutToolStripMenuItem1.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TextE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EditStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PasteStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CutStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FontStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InfoStripMenuItem1;
    }
}

