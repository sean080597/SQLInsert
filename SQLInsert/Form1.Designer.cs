namespace SQLInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_delete = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nameDel = new System.Windows.Forms.TextBox();
            this.button_deleteInPanel = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(33, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(33, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_name.Location = new System.Drawing.Point(108, 28);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(166, 27);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_age
            // 
            this.textBox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_age.Location = new System.Drawing.Point(108, 71);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(166, 27);
            this.textBox_age.TabIndex = 4;
            // 
            // textBox_class
            // 
            this.textBox_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_class.Location = new System.Drawing.Point(108, 115);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(166, 27);
            this.textBox_class.TabIndex = 5;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_save.Location = new System.Drawing.Point(37, 169);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(80, 36);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_update.Location = new System.Drawing.Point(37, 229);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(80, 36);
            this.button_update.TabIndex = 7;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_delete.Location = new System.Drawing.Point(194, 169);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(80, 36);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_display
            // 
            this.button_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_display.Location = new System.Drawing.Point(194, 229);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(80, 36);
            this.button_display.TabIndex = 9;
            this.button_display.Text = "Display";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 277);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel_delete
            // 
            this.panel_delete.Controls.Add(this.button_exit);
            this.panel_delete.Controls.Add(this.button_deleteInPanel);
            this.panel_delete.Controls.Add(this.textBox_nameDel);
            this.panel_delete.Controls.Add(this.label4);
            this.panel_delete.Location = new System.Drawing.Point(12, 12);
            this.panel_delete.Name = "panel_delete";
            this.panel_delete.Size = new System.Drawing.Size(282, 294);
            this.panel_delete.TabIndex = 11;
            this.panel_delete.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name to delete";
            // 
            // textBox_nameDel
            // 
            this.textBox_nameDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_nameDel.Location = new System.Drawing.Point(21, 70);
            this.textBox_nameDel.Name = "textBox_nameDel";
            this.textBox_nameDel.Size = new System.Drawing.Size(240, 30);
            this.textBox_nameDel.TabIndex = 1;
            // 
            // button_deleteInPanel
            // 
            this.button_deleteInPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_deleteInPanel.Location = new System.Drawing.Point(67, 128);
            this.button_deleteInPanel.Name = "button_deleteInPanel";
            this.button_deleteInPanel.Size = new System.Drawing.Size(134, 42);
            this.button_deleteInPanel.TabIndex = 2;
            this.button_deleteInPanel.Text = "Delete";
            this.button_deleteInPanel.UseVisualStyleBackColor = true;
            this.button_deleteInPanel.Click += new System.EventHandler(this.button_deleteInPanel_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_exit.Location = new System.Drawing.Point(205, 249);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 25);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_search.Location = new System.Drawing.Point(117, 271);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(80, 36);
            this.button_search.TabIndex = 12;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 318);
            this.Controls.Add(this.panel_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_class);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_delete.ResumeLayout(false);
            this.panel_delete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_class;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nameDel;
        private System.Windows.Forms.Button button_deleteInPanel;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_search;
    }
}

