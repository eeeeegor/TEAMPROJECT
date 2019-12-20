namespace Cash_Table
{
    partial class table_menu
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
            this.Book_button = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.Menu_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.Name_input = new System.Windows.Forms.TextBox();
            this.Guests = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Book_button
            // 
            this.Book_button.Location = new System.Drawing.Point(6, 12);
            this.Book_button.Margin = new System.Windows.Forms.Padding(2);
            this.Book_button.Name = "Book_button";
            this.Book_button.Size = new System.Drawing.Size(250, 136);
            this.Book_button.TabIndex = 0;
            this.Book_button.Text = "Book";
            this.Book_button.UseVisualStyleBackColor = true;
            this.Book_button.Click += new System.EventHandler(this.Book_button_Click_1);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(270, 12);
            this.Check.Margin = new System.Windows.Forms.Padding(2);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(250, 136);
            this.Check.TabIndex = 1;
            this.Check.Text = "Check + Close";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // Menu_button
            // 
            this.Menu_button.Location = new System.Drawing.Point(6, 162);
            this.Menu_button.Margin = new System.Windows.Forms.Padding(2);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(250, 136);
            this.Menu_button.TabIndex = 2;
            this.Menu_button.Text = "Menu";
            this.Menu_button.UseVisualStyleBackColor = true;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(270, 162);
            this.Back_button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(250, 136);
            this.Back_button.TabIndex = 3;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(12, 303);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(115, 20);
            this.TimePicker.TabIndex = 7;
            // 
            // Name_input
            // 
            this.Name_input.Location = new System.Drawing.Point(12, 329);
            this.Name_input.Name = "Name_input";
            this.Name_input.Size = new System.Drawing.Size(115, 20);
            this.Name_input.TabIndex = 8;
            // 
            // Guests
            // 
            this.Guests.AutoSize = true;
            this.Guests.Location = new System.Drawing.Point(267, 336);
            this.Guests.Name = "Guests";
            this.Guests.Size = new System.Drawing.Size(35, 13);
            this.Guests.TabIndex = 9;
            this.Guests.Text = "label1";
            // 
            // table_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 516);
            this.Controls.Add(this.Guests);
            this.Controls.Add(this.Name_input);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Menu_button);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Book_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "table_menu";
            this.Load += new System.EventHandler(this.table_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Book_button;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Menu_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.TextBox Name_input;
        private System.Windows.Forms.Label Guests;
    }
}