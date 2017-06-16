namespace ProyectoInstru
{
    partial class Sensores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.members = new System.Windows.Forms.Label();
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.iniciar = new System.Windows.Forms.Button();
            this.type_sense = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(39, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(76, 13);
            this.title.TabIndex = 0;
            this.title.Text = "titulo de la app";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // members
            // 
            this.members.AutoSize = true;
            this.members.Location = new System.Drawing.Point(42, 68);
            this.members.Name = "members";
            this.members.Size = new System.Drawing.Size(59, 13);
            this.members.TabIndex = 1;
            this.members.Text = "integrantes";
            this.members.Click += new System.EventHandler(this.members_Click);
            // 
            // comboCOM
            // 
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Location = new System.Drawing.Point(42, 112);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(121, 21);
            this.comboCOM.TabIndex = 2;
            this.comboCOM.SelectedIndexChanged += new System.EventHandler(this.comboCOM_SelectedIndexChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(42, 159);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(689, 359);
            this.zedGraphControl1.TabIndex = 3;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(656, 112);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(75, 23);
            this.iniciar.TabIndex = 4;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // type_sense
            // 
            this.type_sense.FormattingEnabled = true;
            this.type_sense.Location = new System.Drawing.Point(210, 112);
            this.type_sense.Name = "type_sense";
            this.type_sense.Size = new System.Drawing.Size(121, 21);
            this.type_sense.TabIndex = 5;
            // 
            // Sensores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.type_sense);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.comboCOM);
            this.Controls.Add(this.members);
            this.Controls.Add(this.title);
            this.Name = "Sensores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label members;
        private System.Windows.Forms.ComboBox comboCOM;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.ComboBox type_sense;
    }
}

