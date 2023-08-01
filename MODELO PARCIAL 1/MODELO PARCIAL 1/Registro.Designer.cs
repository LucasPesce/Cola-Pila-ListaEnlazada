namespace MODELO_PARCIAL_1
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lbDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lbNOMBRE = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.btnINSERTAR = new System.Windows.Forms.Button();
            this.btnEliminarCOLA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listCOLA = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listPILA = new System.Windows.Forms.ListBox();
            this.btnEliminarPILA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listLISTA = new System.Windows.Forms.ListBox();
            this.btnEliminarLISTA = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.Location = new System.Drawing.Point(24, 21);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(40, 20);
            this.lbDNI.TabIndex = 0;
            this.lbDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(119, 23);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(262, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // lbNOMBRE
            // 
            this.lbNOMBRE.AutoSize = true;
            this.lbNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNOMBRE.Location = new System.Drawing.Point(24, 61);
            this.lbNOMBRE.Name = "lbNOMBRE";
            this.lbNOMBRE.Size = new System.Drawing.Size(71, 20);
            this.lbNOMBRE.TabIndex = 2;
            this.lbNOMBRE.Text = "Nombre";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(119, 61);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(262, 20);
            this.txtNOMBRE.TabIndex = 3;
            // 
            // btnINSERTAR
            // 
            this.btnINSERTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINSERTAR.Location = new System.Drawing.Point(425, 21);
            this.btnINSERTAR.Name = "btnINSERTAR";
            this.btnINSERTAR.Size = new System.Drawing.Size(97, 33);
            this.btnINSERTAR.TabIndex = 4;
            this.btnINSERTAR.Text = "INSERTAR";
            this.btnINSERTAR.UseVisualStyleBackColor = true;
            this.btnINSERTAR.Click += new System.EventHandler(this.btnINSERTAR_Click);
            // 
            // btnEliminarCOLA
            // 
            this.btnEliminarCOLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCOLA.Location = new System.Drawing.Point(12, 454);
            this.btnEliminarCOLA.Name = "btnEliminarCOLA";
            this.btnEliminarCOLA.Size = new System.Drawing.Size(173, 29);
            this.btnEliminarCOLA.TabIndex = 5;
            this.btnEliminarCOLA.Text = "ELIMINAR EN COLA";
            this.btnEliminarCOLA.UseVisualStyleBackColor = true;
            this.btnEliminarCOLA.Click += new System.EventHandler(this.btnEliminarCOLA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "COLA";
            // 
            // listCOLA
            // 
            this.listCOLA.FormattingEnabled = true;
            this.listCOLA.Location = new System.Drawing.Point(12, 183);
            this.listCOLA.Name = "listCOLA";
            this.listCOLA.Size = new System.Drawing.Size(173, 251);
            this.listCOLA.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "PILA";
            // 
            // listPILA
            // 
            this.listPILA.FormattingEnabled = true;
            this.listPILA.Location = new System.Drawing.Point(208, 183);
            this.listPILA.Name = "listPILA";
            this.listPILA.Size = new System.Drawing.Size(173, 251);
            this.listPILA.TabIndex = 9;
            // 
            // btnEliminarPILA
            // 
            this.btnEliminarPILA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPILA.Location = new System.Drawing.Point(208, 454);
            this.btnEliminarPILA.Name = "btnEliminarPILA";
            this.btnEliminarPILA.Size = new System.Drawing.Size(173, 29);
            this.btnEliminarPILA.TabIndex = 8;
            this.btnEliminarPILA.Text = "ELIMINAR EN PILA";
            this.btnEliminarPILA.UseVisualStyleBackColor = true;
            this.btnEliminarPILA.Click += new System.EventHandler(this.btnEliminarPILA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "LISTA";
            // 
            // listLISTA
            // 
            this.listLISTA.FormattingEnabled = true;
            this.listLISTA.Location = new System.Drawing.Point(401, 183);
            this.listLISTA.Name = "listLISTA";
            this.listLISTA.Size = new System.Drawing.Size(173, 251);
            this.listLISTA.TabIndex = 12;
            // 
            // btnEliminarLISTA
            // 
            this.btnEliminarLISTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLISTA.Location = new System.Drawing.Point(401, 454);
            this.btnEliminarLISTA.Name = "btnEliminarLISTA";
            this.btnEliminarLISTA.Size = new System.Drawing.Size(173, 29);
            this.btnEliminarLISTA.TabIndex = 11;
            this.btnEliminarLISTA.Text = "ELIMINAR EN LISTA";
            this.btnEliminarLISTA.UseVisualStyleBackColor = true;
            this.btnEliminarLISTA.Click += new System.EventHandler(this.btnEliminarLISTA_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.Location = new System.Drawing.Point(425, 61);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(97, 33);
            this.btnBUSCAR.TabIndex = 14;
            this.btnBUSCAR.Text = "BUSCAR";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 530);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listLISTA);
            this.Controls.Add(this.btnEliminarLISTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPILA);
            this.Controls.Add(this.btnEliminarPILA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCOLA);
            this.Controls.Add(this.btnEliminarCOLA);
            this.Controls.Add(this.btnINSERTAR);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.lbNOMBRE);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lbDNI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "REGISTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lbNOMBRE;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Button btnINSERTAR;
        private System.Windows.Forms.Button btnEliminarCOLA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCOLA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listPILA;
        private System.Windows.Forms.Button btnEliminarPILA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listLISTA;
        private System.Windows.Forms.Button btnEliminarLISTA;
        private System.Windows.Forms.Button btnBUSCAR;
    }
}

