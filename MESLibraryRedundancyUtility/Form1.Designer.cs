namespace MESLibraryRedundancyUtility
{
    partial class Form1
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
            this.txt_primServiceURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_secServiceURL = new System.Windows.Forms.TextBox();
            this.chkb_primServiceDisabled = new System.Windows.Forms.CheckBox();
            this.chkb_secServiceDisabled = new System.Windows.Forms.CheckBox();
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_getEntNameByID = new System.Windows.Forms.Button();
            this.txt_debug = new System.Windows.Forms.TextBox();
            this.btn_getActiveServiceURL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dllVersion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_primServiceURL
            // 
            this.txt_primServiceURL.Location = new System.Drawing.Point(200, 22);
            this.txt_primServiceURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_primServiceURL.Name = "txt_primServiceURL";
            this.txt_primServiceURL.Size = new System.Drawing.Size(324, 22);
            this.txt_primServiceURL.TabIndex = 0;
            this.txt_primServiceURL.Text = "l";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary Service URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Secondary Service URL:";
            // 
            // txt_secServiceURL
            // 
            this.txt_secServiceURL.Location = new System.Drawing.Point(200, 54);
            this.txt_secServiceURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_secServiceURL.Name = "txt_secServiceURL";
            this.txt_secServiceURL.Size = new System.Drawing.Size(324, 22);
            this.txt_secServiceURL.TabIndex = 3;
            this.txt_secServiceURL.Text = "l";
            // 
            // chkb_primServiceDisabled
            // 
            this.chkb_primServiceDisabled.AutoSize = true;
            this.chkb_primServiceDisabled.Location = new System.Drawing.Point(29, 103);
            this.chkb_primServiceDisabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkb_primServiceDisabled.Name = "chkb_primServiceDisabled";
            this.chkb_primServiceDisabled.Size = new System.Drawing.Size(188, 21);
            this.chkb_primServiceDisabled.TabIndex = 4;
            this.chkb_primServiceDisabled.Text = "Primary Service Disabled";
            this.chkb_primServiceDisabled.UseVisualStyleBackColor = true;
            // 
            // chkb_secServiceDisabled
            // 
            this.chkb_secServiceDisabled.AutoSize = true;
            this.chkb_secServiceDisabled.Location = new System.Drawing.Point(28, 132);
            this.chkb_secServiceDisabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkb_secServiceDisabled.Name = "chkb_secServiceDisabled";
            this.chkb_secServiceDisabled.Size = new System.Drawing.Size(208, 21);
            this.chkb_secServiceDisabled.TabIndex = 5;
            this.chkb_secServiceDisabled.Text = "Secondary Service Disabled";
            this.chkb_secServiceDisabled.UseVisualStyleBackColor = true;
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(267, 103);
            this.btn_init.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(127, 59);
            this.btn_init.TabIndex = 6;
            this.btn_init.Text = "Initialize";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // btn_getEntNameByID
            // 
            this.btn_getEntNameByID.Location = new System.Drawing.Point(401, 103);
            this.btn_getEntNameByID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_getEntNameByID.Name = "btn_getEntNameByID";
            this.btn_getEntNameByID.Size = new System.Drawing.Size(165, 59);
            this.btn_getEntNameByID.TabIndex = 7;
            this.btn_getEntNameByID.Text = "Get Entity Name by ID";
            this.btn_getEntNameByID.UseVisualStyleBackColor = true;
            this.btn_getEntNameByID.Click += new System.EventHandler(this.btn_getEntNameByID_Click);
            // 
            // txt_debug
            // 
            this.txt_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_debug.Location = new System.Drawing.Point(16, 193);
            this.txt_debug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_debug.Multiline = true;
            this.txt_debug.Name = "txt_debug";
            this.txt_debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_debug.Size = new System.Drawing.Size(920, 526);
            this.txt_debug.TabIndex = 8;
            // 
            // btn_getActiveServiceURL
            // 
            this.btn_getActiveServiceURL.Location = new System.Drawing.Point(575, 103);
            this.btn_getActiveServiceURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_getActiveServiceURL.Name = "btn_getActiveServiceURL";
            this.btn_getActiveServiceURL.Size = new System.Drawing.Size(153, 59);
            this.btn_getActiveServiceURL.TabIndex = 9;
            this.btn_getActiveServiceURL.Text = "Get active Service URL";
            this.btn_getActiveServiceURL.UseVisualStyleBackColor = true;
            this.btn_getActiveServiceURL.Click += new System.EventHandler(this.btn_getActiveServiceURL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Service Name:";
            // 
            // txt_ServiceName
            // 
            this.txt_ServiceName.Location = new System.Drawing.Point(648, 22);
            this.txt_ServiceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ServiceName.Name = "txt_ServiceName";
            this.txt_ServiceName.Size = new System.Drawing.Size(285, 22);
            this.txt_ServiceName.TabIndex = 11;
            this.txt_ServiceName.Text = "l";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "DLL Version:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_dllVersion
            // 
            this.txt_dllVersion.Location = new System.Drawing.Point(648, 54);
            this.txt_dllVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dllVersion.Name = "txt_dllVersion";
            this.txt_dllVersion.Size = new System.Drawing.Size(285, 22);
            this.txt_dllVersion.TabIndex = 13;
            this.txt_dllVersion.Text = "l";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "GetConnectionString";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 735);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_dllVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ServiceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_getActiveServiceURL);
            this.Controls.Add(this.txt_debug);
            this.Controls.Add(this.btn_getEntNameByID);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.chkb_secServiceDisabled);
            this.Controls.Add(this.chkb_primServiceDisabled);
            this.Controls.Add(this.txt_secServiceURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_primServiceURL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Nestle MES Library Redundancy Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_primServiceURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_secServiceURL;
        private System.Windows.Forms.CheckBox chkb_primServiceDisabled;
        private System.Windows.Forms.CheckBox chkb_secServiceDisabled;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_getEntNameByID;
        private System.Windows.Forms.TextBox txt_debug;
        private System.Windows.Forms.Button btn_getActiveServiceURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ServiceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dllVersion;
        private System.Windows.Forms.Button button1;
    }
}

