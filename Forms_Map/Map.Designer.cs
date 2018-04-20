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
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.LblOrigin = new System.Windows.Forms.Label();
            this.CbOrigin = new System.Windows.Forms.ComboBox();
            this.LblDestiny = new System.Windows.Forms.Label();
            this.CbDestiny = new System.Windows.Forms.ComboBox();
            this.BtnGo = new System.Windows.Forms.Button();
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
            this.gMap.Location = new System.Drawing.Point(12, 12);
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
            this.gMap.Size = new System.Drawing.Size(781, 267);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            // 
            // LblOrigin
            // 
            this.LblOrigin.AutoSize = true;
            this.LblOrigin.Location = new System.Drawing.Point(81, 309);
            this.LblOrigin.Name = "LblOrigin";
            this.LblOrigin.Size = new System.Drawing.Size(38, 13);
            this.LblOrigin.TabIndex = 1;
            this.LblOrigin.Text = "Origen";
            // 
            // CbOrigin
            // 
            this.CbOrigin.FormattingEnabled = true;
            this.CbOrigin.Location = new System.Drawing.Point(125, 306);
            this.CbOrigin.Name = "CbOrigin";
            this.CbOrigin.Size = new System.Drawing.Size(121, 21);
            this.CbOrigin.TabIndex = 2;
            // 
            // LblDestiny
            // 
            this.LblDestiny.AutoSize = true;
            this.LblDestiny.Location = new System.Drawing.Point(325, 309);
            this.LblDestiny.Name = "LblDestiny";
            this.LblDestiny.Size = new System.Drawing.Size(43, 13);
            this.LblDestiny.TabIndex = 3;
            this.LblDestiny.Text = "Destino";
            // 
            // CbDestiny
            // 
            this.CbDestiny.FormattingEnabled = true;
            this.CbDestiny.Location = new System.Drawing.Point(374, 306);
            this.CbDestiny.Name = "CbDestiny";
            this.CbDestiny.Size = new System.Drawing.Size(121, 21);
            this.CbDestiny.TabIndex = 4;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(533, 306);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 5;
            this.BtnGo.Text = "Ir";
            this.BtnGo.UseVisualStyleBackColor = true;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 334);
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
    }
}

