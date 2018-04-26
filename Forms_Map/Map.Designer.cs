namespace Forms_Map
{
    partial class Map
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
            this.components = new System.ComponentModel.Container();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.LblOrigin = new System.Windows.Forms.Label();
            this.CbOrigin = new System.Windows.Forms.ComboBox();
            this.LblDestiny = new System.Windows.Forms.Label();
            this.CbDestiny = new System.Windows.Forms.ComboBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(12, 2);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1280, 600);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            // 
            // LblOrigin
            // 
            this.LblOrigin.AutoSize = true;
            this.LblOrigin.Location = new System.Drawing.Point(46, 636);
            this.LblOrigin.Name = "LblOrigin";
            this.LblOrigin.Size = new System.Drawing.Size(38, 13);
            this.LblOrigin.TabIndex = 1;
            this.LblOrigin.Text = "Origen";
            // 
            // CbOrigin
            // 
            this.CbOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOrigin.FormattingEnabled = true;
            this.CbOrigin.Location = new System.Drawing.Point(90, 633);
            this.CbOrigin.Name = "CbOrigin";
            this.CbOrigin.Size = new System.Drawing.Size(121, 21);
            this.CbOrigin.TabIndex = 2;
            this.CbOrigin.SelectedIndexChanged += new System.EventHandler(this.CbOrigin_SelectedIndexChanged);
            // 
            // LblDestiny
            // 
            this.LblDestiny.AutoSize = true;
            this.LblDestiny.Location = new System.Drawing.Point(218, 636);
            this.LblDestiny.Name = "LblDestiny";
            this.LblDestiny.Size = new System.Drawing.Size(43, 13);
            this.LblDestiny.TabIndex = 3;
            this.LblDestiny.Text = "Destino";
            // 
            // CbDestiny
            // 
            this.CbDestiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDestiny.FormattingEnabled = true;
            this.CbDestiny.Location = new System.Drawing.Point(267, 633);
            this.CbDestiny.Name = "CbDestiny";
            this.CbDestiny.Size = new System.Drawing.Size(121, 21);
            this.CbDestiny.TabIndex = 4;
            this.CbDestiny.SelectedIndexChanged += new System.EventHandler(this.CbDestiny_SelectedIndexChanged);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(749, 626);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 5;
            this.BtnGo.Tag = "";
            this.BtnGo.Text = "Ir";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(654, 626);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Tag = "";
            this.BtnBack.Text = "Atras";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(443, 626);
            this.trackZoom.Maximum = 25;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(205, 45);
            this.trackZoom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zoom";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.CbDestiny);
            this.Controls.Add(this.LblDestiny);
            this.Controls.Add(this.CbOrigin);
            this.Controls.Add(this.LblOrigin);
            this.Controls.Add(this.gMap);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Label LblOrigin;
        private System.Windows.Forms.ComboBox CbOrigin;
        private System.Windows.Forms.Label LblDestiny;
        private System.Windows.Forms.ComboBox CbDestiny;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

