
namespace Amongus_tool
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.ApplyMaxPlayers = new System.Windows.Forms.Button();
            this.MaxPlayers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME DETECTED :";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.ProcOpenLabel.Location = new System.Drawing.Point(773, 431);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(23, 13);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "NO";
            // 
            // ApplyMaxPlayers
            // 
            this.ApplyMaxPlayers.Location = new System.Drawing.Point(133, 54);
            this.ApplyMaxPlayers.Name = "ApplyMaxPlayers";
            this.ApplyMaxPlayers.Size = new System.Drawing.Size(81, 23);
            this.ApplyMaxPlayers.TabIndex = 2;
            this.ApplyMaxPlayers.Text = "Apply";
            this.ApplyMaxPlayers.UseVisualStyleBackColor = true;
            this.ApplyMaxPlayers.Click += new System.EventHandler(this.ApplyMaxPlayers_Click);
            // 
            // MaxPlayers
            // 
            this.MaxPlayers.Location = new System.Drawing.Point(25, 55);
            this.MaxPlayers.Name = "MaxPlayers";
            this.MaxPlayers.Size = new System.Drawing.Size(100, 20);
            this.MaxPlayers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxPlayers);
            this.Controls.Add(this.ApplyMaxPlayers);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Button ApplyMaxPlayers;
        private System.Windows.Forms.TextBox MaxPlayers;
    }
}

