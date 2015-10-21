namespace RPSLS___Project
{
  partial class HandView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnRock = new System.Windows.Forms.Button();
      this.btnPaper = new System.Windows.Forms.Button();
      this.btnScissors = new System.Windows.Forms.Button();
      this.btnLizard = new System.Windows.Forms.Button();
      this.btnSpock = new System.Windows.Forms.Button();
      this.lblNaam = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnRock
      // 
      this.btnRock.Location = new System.Drawing.Point(20, 51);
      this.btnRock.Name = "btnRock";
      this.btnRock.Size = new System.Drawing.Size(75, 23);
      this.btnRock.TabIndex = 0;
      this.btnRock.Text = "Rock";
      this.btnRock.UseVisualStyleBackColor = true;
      this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
      // 
      // btnPaper
      // 
      this.btnPaper.Location = new System.Drawing.Point(20, 80);
      this.btnPaper.Name = "btnPaper";
      this.btnPaper.Size = new System.Drawing.Size(75, 23);
      this.btnPaper.TabIndex = 1;
      this.btnPaper.Text = "Paper";
      this.btnPaper.UseVisualStyleBackColor = true;
      this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
      // 
      // btnScissors
      // 
      this.btnScissors.Location = new System.Drawing.Point(20, 109);
      this.btnScissors.Name = "btnScissors";
      this.btnScissors.Size = new System.Drawing.Size(75, 23);
      this.btnScissors.TabIndex = 3;
      this.btnScissors.Text = "Scissors";
      this.btnScissors.UseVisualStyleBackColor = true;
      this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
      // 
      // btnLizard
      // 
      this.btnLizard.Location = new System.Drawing.Point(20, 138);
      this.btnLizard.Name = "btnLizard";
      this.btnLizard.Size = new System.Drawing.Size(75, 23);
      this.btnLizard.TabIndex = 2;
      this.btnLizard.Text = "Lizard";
      this.btnLizard.UseVisualStyleBackColor = true;
      this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
      // 
      // btnSpock
      // 
      this.btnSpock.Location = new System.Drawing.Point(20, 167);
      this.btnSpock.Name = "btnSpock";
      this.btnSpock.Size = new System.Drawing.Size(75, 23);
      this.btnSpock.TabIndex = 4;
      this.btnSpock.Text = "Spock";
      this.btnSpock.UseVisualStyleBackColor = true;
      this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
      // 
      // lblNaam
      // 
      this.lblNaam.AutoSize = true;
      this.lblNaam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNaam.Location = new System.Drawing.Point(32, 19);
      this.lblNaam.Name = "lblNaam";
      this.lblNaam.Size = new System.Drawing.Size(47, 19);
      this.lblNaam.TabIndex = 5;
      this.lblNaam.Text = "Naam";
      // 
      // HandView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblNaam);
      this.Controls.Add(this.btnSpock);
      this.Controls.Add(this.btnScissors);
      this.Controls.Add(this.btnLizard);
      this.Controls.Add(this.btnPaper);
      this.Controls.Add(this.btnRock);
      this.Name = "HandView";
      this.Size = new System.Drawing.Size(119, 203);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRock;
    private System.Windows.Forms.Button btnPaper;
    private System.Windows.Forms.Button btnScissors;
    private System.Windows.Forms.Button btnLizard;
    private System.Windows.Forms.Button btnSpock;
    private System.Windows.Forms.Label lblNaam;
  }
}
