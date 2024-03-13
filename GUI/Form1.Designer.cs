namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textbox_num = new TextBox();
            textbox_seed = new TextBox();
            textbox_capacity = new TextBox();
            Button_Run = new Button();
            label_num_of_items = new Label();
            label_seed = new Label();
            label_capacity = new Label();
            label_instance = new Label();
            label_result = new Label();
            listbox_instance = new ListBox();
            listbox_result = new ListBox();
            SuspendLayout();
            // 
            // textbox_num
            // 
            textbox_num.BorderStyle = BorderStyle.FixedSingle;
            textbox_num.Location = new Point(47, 60);
            textbox_num.Margin = new Padding(4, 5, 4, 5);
            textbox_num.Name = "textbox_num";
            textbox_num.Size = new Size(141, 31);
            textbox_num.TabIndex = 0;
            // 
            // textbox_seed
            // 
            textbox_seed.BorderStyle = BorderStyle.FixedSingle;
            textbox_seed.Location = new Point(47, 202);
            textbox_seed.Margin = new Padding(4, 5, 4, 5);
            textbox_seed.Name = "textbox_seed";
            textbox_seed.Size = new Size(141, 31);
            textbox_seed.TabIndex = 1;
            // 
            // textbox_capacity
            // 
            textbox_capacity.BorderStyle = BorderStyle.FixedSingle;
            textbox_capacity.Location = new Point(47, 347);
            textbox_capacity.Margin = new Padding(4, 5, 4, 5);
            textbox_capacity.Name = "textbox_capacity";
            textbox_capacity.Size = new Size(141, 31);
            textbox_capacity.TabIndex = 2;
            // 
            // Button_Run
            // 
            Button_Run.BackColor = Color.Salmon;
            Button_Run.Font = new Font("Swis721 BlkEx BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Run.Location = new Point(66, 550);
            Button_Run.Margin = new Padding(4, 5, 4, 5);
            Button_Run.Name = "Button_Run";
            Button_Run.Size = new Size(107, 38);
            Button_Run.TabIndex = 3;
            Button_Run.Text = "Run";
            Button_Run.UseVisualStyleBackColor = false;
            Button_Run.Click += Button_Run_Click;
            // 
            // label_num_of_items
            // 
            label_num_of_items.AutoSize = true;
            label_num_of_items.Location = new Point(47, 30);
            label_num_of_items.Margin = new Padding(4, 0, 4, 0);
            label_num_of_items.Name = "label_num_of_items";
            label_num_of_items.Size = new Size(147, 25);
            label_num_of_items.TabIndex = 6;
            label_num_of_items.Text = "Number of items";
            // 
            // label_seed
            // 
            label_seed.AutoSize = true;
            label_seed.Location = new Point(47, 172);
            label_seed.Margin = new Padding(4, 0, 4, 0);
            label_seed.Name = "label_seed";
            label_seed.Size = new Size(51, 25);
            label_seed.TabIndex = 7;
            label_seed.Text = "Seed";
            // 
            // label_capacity
            // 
            label_capacity.AutoSize = true;
            label_capacity.Location = new Point(47, 317);
            label_capacity.Margin = new Padding(4, 0, 4, 0);
            label_capacity.Name = "label_capacity";
            label_capacity.Size = new Size(79, 25);
            label_capacity.TabIndex = 8;
            label_capacity.Text = "Capacity";
            // 
            // label_instance
            // 
            label_instance.AutoSize = true;
            label_instance.Location = new Point(254, 30);
            label_instance.Margin = new Padding(4, 0, 4, 0);
            label_instance.Name = "label_instance";
            label_instance.Size = new Size(77, 25);
            label_instance.TabIndex = 9;
            label_instance.Text = "Instance";
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new Point(254, 520);
            label_result.Margin = new Padding(4, 0, 4, 0);
            label_result.Name = "label_result";
            label_result.Size = new Size(59, 25);
            label_result.TabIndex = 10;
            label_result.Text = "Result";
            // 
            // listbox_instance
            // 
            listbox_instance.BorderStyle = BorderStyle.FixedSingle;
            listbox_instance.FormattingEnabled = true;
            listbox_instance.ItemHeight = 25;
            listbox_instance.Location = new Point(254, 68);
            listbox_instance.Name = "listbox_instance";
            listbox_instance.Size = new Size(294, 427);
            listbox_instance.TabIndex = 11;
            // 
            // listbox_result
            // 
            listbox_result.BorderStyle = BorderStyle.FixedSingle;
            listbox_result.FormattingEnabled = true;
            listbox_result.ItemHeight = 25;
            listbox_result.Location = new Point(254, 548);
            listbox_result.Name = "listbox_result";
            listbox_result.Size = new Size(294, 152);
            listbox_result.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(621, 750);
            Controls.Add(listbox_result);
            Controls.Add(listbox_instance);
            Controls.Add(label_result);
            Controls.Add(label_instance);
            Controls.Add(label_capacity);
            Controls.Add(label_seed);
            Controls.Add(label_num_of_items);
            Controls.Add(Button_Run);
            Controls.Add(textbox_capacity);
            Controls.Add(textbox_seed);
            Controls.Add(textbox_num);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Knapsack problem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_num;
        private TextBox textbox_seed;
        private TextBox textbox_capacity;
        private Button Button_Run;
        private Label label_num_of_items;
        private Label label_seed;
        private Label label_capacity;
        private Label label_instance;
        private Label label_result;
        private ListBox listbox_instance;
        private ListBox listbox_result;
    }
}
