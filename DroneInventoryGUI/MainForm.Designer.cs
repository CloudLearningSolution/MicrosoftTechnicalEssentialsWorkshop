
namespace DroneInventoryGUI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.droneGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.droneGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // droneGridView
            // 
            this.droneGridView.AllowDrop = true;
            this.droneGridView.AllowUserToOrderColumns = true;
            this.droneGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.droneGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.droneGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.droneGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.droneGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.droneGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.droneGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.droneGridView.GridColor = System.Drawing.SystemColors.ControlText;
            this.droneGridView.Location = new System.Drawing.Point(114, 226);
            this.droneGridView.Name = "droneGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.droneGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.droneGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.droneGridView.RowTemplate.Height = 24;
            this.droneGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.droneGridView.Size = new System.Drawing.Size(558, 212);
            this.droneGridView.TabIndex = 0;
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateInventory.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInventory.Location = new System.Drawing.Point(643, 112);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(145, 39);
            this.btnUpdateInventory.TabIndex = 1;
            this.btnUpdateInventory.Text = "Update";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click_1);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::DroneInventoryGUI.Properties.Resources.drone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.droneGridView);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drone Inventory Graphical Interface";
            ((System.ComponentModel.ISupportInitialize)(this.droneGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView droneGridView;
        private System.Windows.Forms.Button btnUpdateInventory;
    }
}

