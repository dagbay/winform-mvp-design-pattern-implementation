
namespace CRUDWinFormsMVP.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hubPanel = new System.Windows.Forms.Panel();
            this.btnPets = new System.Windows.Forms.Button();
            this.hubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hubPanel
            // 
            this.hubPanel.Controls.Add(this.btnPets);
            this.hubPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.hubPanel.Location = new System.Drawing.Point(0, 0);
            this.hubPanel.Name = "hubPanel";
            this.hubPanel.Size = new System.Drawing.Size(200, 450);
            this.hubPanel.TabIndex = 0;
            // 
            // btnPets
            // 
            this.btnPets.BackColor = System.Drawing.Color.White;
            this.btnPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.Location = new System.Drawing.Point(0, 54);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(200, 45);
            this.btnPets.TabIndex = 1;
            this.btnPets.Text = "Pets";
            this.btnPets.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hubPanel);
            this.Name = "MainView";
            this.Text = "MainView";
            this.hubPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hubPanel;
        private System.Windows.Forms.Button btnPets;
    }
}