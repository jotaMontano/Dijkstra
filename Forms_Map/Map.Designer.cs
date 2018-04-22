﻿namespace Forms_Map
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
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.LblOrigin = new System.Windows.Forms.Label();
            this.CbOrigin = new System.Windows.Forms.ComboBox();
            this.LblDestiny = new System.Windows.Forms.Label();
            this.CbDestiny = new System.Windows.Forms.ComboBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
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
            this.gMap.Size = new System.Drawing.Size(1305, 669);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            // 
            // LblOrigin
            // 
            this.LblOrigin.AutoSize = true;
            this.LblOrigin.Location = new System.Drawing.Point(48, 699);
            this.LblOrigin.Name = "LblOrigin";
            this.LblOrigin.Size = new System.Drawing.Size(38, 13);
            this.LblOrigin.TabIndex = 1;
            this.LblOrigin.Text = "Origen";
            // 
            // CbOrigin
            // 
            this.CbOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOrigin.FormattingEnabled = true;
            this.CbOrigin.Location = new System.Drawing.Point(92, 696);
            this.CbOrigin.Name = "CbOrigin";
            this.CbOrigin.Size = new System.Drawing.Size(121, 21);
            this.CbOrigin.TabIndex = 2;
            this.CbOrigin.SelectedIndexChanged += new System.EventHandler(this.CbOrigin_SelectedIndexChanged);
            // 
            // LblDestiny
            // 
            this.LblDestiny.AutoSize = true;
            this.LblDestiny.Location = new System.Drawing.Point(292, 699);
            this.LblDestiny.Name = "LblDestiny";
            this.LblDestiny.Size = new System.Drawing.Size(43, 13);
            this.LblDestiny.TabIndex = 3;
            this.LblDestiny.Text = "Destino";
            // 
            // CbDestiny
            // 
            this.CbDestiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDestiny.FormattingEnabled = true;
            this.CbDestiny.Location = new System.Drawing.Point(341, 696);
            this.CbDestiny.Name = "CbDestiny";
            this.CbDestiny.Size = new System.Drawing.Size(121, 21);
            this.CbDestiny.TabIndex = 4;
            this.CbDestiny.SelectedIndexChanged += new System.EventHandler(this.CbDestiny_SelectedIndexChanged);
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(624, 694);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 5;
            this.BtnGo.Text = "Ir";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(529, 694);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Atras";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
    }
}

