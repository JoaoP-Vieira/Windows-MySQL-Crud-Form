namespace WindowsFormsApp1
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
      this.labelType = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.labelId = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.newBtn = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.dataGrid = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // labelType
      // 
      this.labelType.Font = new System.Drawing.Font("Rubik Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelType.Location = new System.Drawing.Point(91, 90);
      this.labelType.Name = "labelType";
      this.labelType.Size = new System.Drawing.Size(250, 30);
      this.labelType.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.Cursor = System.Windows.Forms.Cursors.Default;
      this.label3.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(23, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 29);
      this.label3.TabIndex = 1;
      this.label3.Text = "Type";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // labelName
      // 
      this.labelName.Font = new System.Drawing.Font("Rubik Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelName.Location = new System.Drawing.Point(91, 54);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(250, 30);
      this.labelName.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.Cursor = System.Windows.Forms.Cursors.Default;
      this.label2.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(23, 55);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 29);
      this.label2.TabIndex = 1;
      this.label2.Text = "Name";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // labelId
      // 
      this.labelId.Font = new System.Drawing.Font("Rubik Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelId.Location = new System.Drawing.Point(91, 19);
      this.labelId.Name = "labelId";
      this.labelId.Size = new System.Drawing.Size(250, 30);
      this.labelId.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Cursor = System.Windows.Forms.Cursors.Default;
      this.label1.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(23, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 29);
      this.label1.TabIndex = 1;
      this.label1.Text = "Id";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // newBtn
      // 
      this.newBtn.AutoSize = true;
      this.newBtn.Cursor = System.Windows.Forms.Cursors.Hand;
      this.newBtn.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newBtn.Location = new System.Drawing.Point(91, 136);
      this.newBtn.Name = "newBtn";
      this.newBtn.Size = new System.Drawing.Size(115, 33);
      this.newBtn.TabIndex = 2;
      this.newBtn.Text = "New";
      this.newBtn.UseVisualStyleBackColor = true;
      this.newBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.AutoSize = true;
      this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button2.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(212, 136);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(115, 33);
      this.button2.TabIndex = 2;
      this.button2.Text = "Edit";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.AutoSize = true;
      this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button3.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(333, 136);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(115, 33);
      this.button3.TabIndex = 2;
      this.button3.Text = "Delete";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.AutoSize = true;
      this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button4.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(454, 136);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(115, 33);
      this.button4.TabIndex = 2;
      this.button4.Text = "Search";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.AutoSize = true;
      this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button5.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button5.Location = new System.Drawing.Point(575, 136);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(115, 33);
      this.button5.TabIndex = 2;
      this.button5.Text = "Show";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // dataGrid
      // 
      this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGrid.Location = new System.Drawing.Point(91, 176);
      this.dataGrid.Name = "dataGrid";
      this.dataGrid.Size = new System.Drawing.Size(599, 312);
      this.dataGrid.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(781, 511);
      this.Controls.Add(this.dataGrid);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.newBtn);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.labelId);
      this.Controls.Add(this.labelName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.labelType);
      this.MinimumSize = new System.Drawing.Size(797, 550);
      this.Name = "Form1";
      this.Padding = new System.Windows.Forms.Padding(20);
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox labelType;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox labelName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox labelId;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button newBtn;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.DataGridView dataGrid;
  }
}

