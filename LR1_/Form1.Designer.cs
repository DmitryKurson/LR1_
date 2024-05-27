namespace LR1_
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            show_items = new Button();
            about = new Button();
            show_vendors = new Button();
            show_parts = new Button();
            show_orders = new Button();
            exit = new Button();
            toolTip1 = new ToolTip(components);
            more_btn = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // show_items
            // 
            show_items.Font = new Font("Segoe UI", 13.8F);
            show_items.Location = new Point(98, 44);
            show_items.Name = "show_items";
            show_items.Size = new Size(100, 75);
            show_items.TabIndex = 0;
            show_items.Text = "Items";
            toolTip1.SetToolTip(show_items, "Це кнопка для переходу в меню Items, де можна переглянути таблицю Items, бази даних Supply");
            show_items.UseVisualStyleBackColor = true;
            show_items.Click += show_items_Click;
            // 
            // about
            // 
            about.Font = new Font("Segoe UI", 13.8F);
            about.Location = new Point(235, 44);
            about.Name = "about";
            about.Size = new Size(100, 75);
            about.TabIndex = 1;
            about.Text = "About";
            toolTip1.SetToolTip(about, "Тут можна дізнатися про автора");
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // show_vendors
            // 
            show_vendors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            show_vendors.Location = new Point(98, 343);
            show_vendors.Name = "show_vendors";
            show_vendors.Size = new Size(100, 75);
            show_vendors.TabIndex = 2;
            show_vendors.Text = "Vendors";
            toolTip1.SetToolTip(show_vendors, "Це кнопка для переходу в меню Vendors, де можна переглянути таблицю Vendors, бази даних Supply");
            show_vendors.UseVisualStyleBackColor = true;
            show_vendors.Click += show_vendors_Click;
            // 
            // show_parts
            // 
            show_parts.Font = new Font("Segoe UI", 13.8F);
            show_parts.Location = new Point(98, 243);
            show_parts.Name = "show_parts";
            show_parts.Size = new Size(100, 75);
            show_parts.TabIndex = 3;
            show_parts.Text = "Parts";
            toolTip1.SetToolTip(show_parts, "Це кнопка для переходу в меню Parts, де можна переглянути таблицю Parts, бази даних Supply");
            show_parts.UseVisualStyleBackColor = true;
            show_parts.Click += show_parts_Click;
            // 
            // show_orders
            // 
            show_orders.Font = new Font("Segoe UI", 13.8F);
            show_orders.Location = new Point(98, 146);
            show_orders.Name = "show_orders";
            show_orders.Size = new Size(100, 75);
            show_orders.TabIndex = 4;
            show_orders.Text = "Orders";
            toolTip1.SetToolTip(show_orders, "Це кнопка для переходу в меню Orders, де можна переглянути таблицю Orders, бази даних Supply");
            show_orders.UseVisualStyleBackColor = true;
            show_orders.Click += show_orders_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI", 13.8F);
            exit.Location = new Point(235, 146);
            exit.Name = "exit";
            exit.Size = new Size(100, 75);
            exit.TabIndex = 5;
            exit.Text = "Exit";
            toolTip1.SetToolTip(exit, "Вийти з програми?");
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // more_btn
            // 
            more_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            more_btn.Location = new Point(235, 243);
            more_btn.Name = "more_btn";
            more_btn.Size = new Size(100, 75);
            more_btn.TabIndex = 6;
            more_btn.Text = "Більше";
            toolTip1.SetToolTip(more_btn, "Дізнатися більше");
            more_btn.UseVisualStyleBackColor = true;
            more_btn.Click += more_btn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new Point(235, 343);
            button2.Name = "button2";
            button2.Size = new Size(100, 75);
            button2.TabIndex = 7;
            button2.Text = "Help";
            toolTip1.SetToolTip(button2, "Приклади використання програми в підказках та зображеннях");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(370, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 374);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(384, 120);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(more_btn);
            Controls.Add(exit);
            Controls.Add(show_orders);
            Controls.Add(show_parts);
            Controls.Add(show_vendors);
            Controls.Add(about);
            Controls.Add(show_items);
            Name = "Form1";
            Text = "Головне меню";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button show_items;
        private Button about;
        private Button show_vendors;
        private Button show_parts;
        private Button show_orders;
        private Button exit;
        private ToolTip toolTip1;
        private Button more_btn;
        private Button button2;
        private Panel panel1;
        private Label label1;
    }
}
