namespace FireEventADR
{
    partial class FireEventCls
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
            this.Ok_button = new System.Windows.Forms.Button();
            this.txtEditEntity = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.Button();
            this.txtEnterdEntity = new System.Windows.Forms.TextBox();
            this.listViewEntities = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok_button
            // 
            this.Ok_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ok_button.Location = new System.Drawing.Point(350, 411);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(75, 23);
            this.Ok_button.TabIndex = 0;
            this.Ok_button.Text = "OK";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // txtEditEntity
            // 
            this.txtEditEntity.Location = new System.Drawing.Point(64, 61);
            this.txtEditEntity.Name = "txtEditEntity";
            this.txtEditEntity.Size = new System.Drawing.Size(167, 20);
            this.txtEditEntity.TabIndex = 1;
            this.txtEditEntity.TextChanged += new System.EventHandler(this.txtEditEntity_TextChanged);
            this.txtEditEntity.Enter += new System.EventHandler(this.txtEditEntity_Enter);
            this.txtEditEntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texEditEntity_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(355, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label1";
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.close_button.Location = new System.Drawing.Point(526, 411);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // txtEnterdEntity
            // 
            this.txtEnterdEntity.Enabled = false;
            this.txtEnterdEntity.Location = new System.Drawing.Point(359, 61);
            this.txtEnterdEntity.Name = "txtEnterdEntity";
            this.txtEnterdEntity.Size = new System.Drawing.Size(251, 20);
            this.txtEnterdEntity.TabIndex = 5;
            // 
            // listViewEntities
            // 
            this.listViewEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewEntities.FullRowSelect = true;
            this.listViewEntities.Location = new System.Drawing.Point(64, 109);
            this.listViewEntities.Name = "listViewEntities";
            this.listViewEntities.Size = new System.Drawing.Size(731, 283);
            this.listViewEntities.TabIndex = 6;
            this.listViewEntities.UseCompatibleStateImageBehavior = false;
            this.listViewEntities.View = System.Windows.Forms.View.Details;
            this.listViewEntities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewEntities_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.listViewEntities);
            this.panel1.Controls.Add(this.Ok_button);
            this.panel1.Controls.Add(this.txtEnterdEntity);
            this.panel1.Controls.Add(this.txtEditEntity);
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 459);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // FireEventCls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FireEventCls";
            this.Size = new System.Drawing.Size(997, 498);
            this.Resize += new System.EventHandler(this.SingleResultEntry_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ok_button;
        private System.Windows.Forms.TextBox txtEditEntity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.TextBox txtEnterdEntity;
        private System.Windows.Forms.ListView listViewEntities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
