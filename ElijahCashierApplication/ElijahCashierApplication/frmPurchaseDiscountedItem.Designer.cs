namespace ElijahCashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            payment_txtbox = new TextBox();
            submit_btn = new Button();
            compute_btn = new Button();
            quantity_txtbox = new TextBox();
            discount_txtbox = new TextBox();
            price_txtbox = new TextBox();
            item_txtbox = new TextBox();
            payment_label = new Label();
            quantity_label = new Label();
            discount_label = new Label();
            price_label = new Label();
            total_label = new Label();
            item_label = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            totalAmount_lbl = new Label();
            label1 = new Label();
            change_lbl = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // payment_txtbox
            // 
            payment_txtbox.Location = new Point(290, 357);
            payment_txtbox.Name = "payment_txtbox";
            payment_txtbox.Size = new Size(136, 23);
            payment_txtbox.TabIndex = 25;
            // 
            // submit_btn
            // 
            submit_btn.Location = new Point(458, 351);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(106, 33);
            submit_btn.TabIndex = 24;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // compute_btn
            // 
            compute_btn.Location = new Point(262, 195);
            compute_btn.Name = "compute_btn";
            compute_btn.Size = new Size(106, 33);
            compute_btn.TabIndex = 23;
            compute_btn.Text = "Compute";
            compute_btn.UseVisualStyleBackColor = true;
            compute_btn.Click += compute_btn_Click;
            // 
            // quantity_txtbox
            // 
            quantity_txtbox.Location = new Point(399, 129);
            quantity_txtbox.Name = "quantity_txtbox";
            quantity_txtbox.Size = new Size(136, 23);
            quantity_txtbox.TabIndex = 22;
            // 
            // discount_txtbox
            // 
            discount_txtbox.Location = new Point(305, 88);
            discount_txtbox.Name = "discount_txtbox";
            discount_txtbox.Size = new Size(230, 23);
            discount_txtbox.TabIndex = 21;
            // 
            // price_txtbox
            // 
            price_txtbox.Location = new Point(103, 134);
            price_txtbox.Name = "price_txtbox";
            price_txtbox.Size = new Size(169, 23);
            price_txtbox.TabIndex = 20;
            // 
            // item_txtbox
            // 
            item_txtbox.Location = new Point(42, 88);
            item_txtbox.Name = "item_txtbox";
            item_txtbox.Size = new Size(230, 23);
            item_txtbox.TabIndex = 19;
            // 
            // payment_label
            // 
            payment_label.AutoSize = true;
            payment_label.Font = new Font("Segoe UI", 15F);
            payment_label.Location = new Point(103, 349);
            payment_label.Name = "payment_label";
            payment_label.Size = new Size(169, 28);
            payment_label.TabIndex = 18;
            payment_label.Text = "Payment Received";
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Font = new Font("Segoe UI", 15F);
            quantity_label.Location = new Point(305, 129);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(88, 28);
            quantity_label.TabIndex = 17;
            quantity_label.Text = "Quantity";
            // 
            // discount_label
            // 
            discount_label.AutoSize = true;
            discount_label.Font = new Font("Segoe UI", 15F);
            discount_label.Location = new Point(387, 46);
            discount_label.Name = "discount_label";
            discount_label.Size = new Size(89, 28);
            discount_label.TabIndex = 16;
            discount_label.Text = "Discount";
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Font = new Font("Segoe UI", 15F);
            price_label.Location = new Point(39, 129);
            price_label.Name = "price_label";
            price_label.Size = new Size(58, 28);
            price_label.TabIndex = 15;
            price_label.Text = "Price:";
            // 
            // total_label
            // 
            total_label.AutoSize = true;
            total_label.Font = new Font("Segoe UI", 15F);
            total_label.Location = new Point(103, 294);
            total_label.Name = "total_label";
            total_label.Size = new Size(130, 28);
            total_label.TabIndex = 14;
            total_label.Text = "Total Amount";
            // 
            // item_label
            // 
            item_label.AutoSize = true;
            item_label.Font = new Font("Segoe UI", 15F);
            item_label.Location = new Point(42, 46);
            item_label.Name = "item_label";
            item_label.Size = new Size(55, 28);
            item_label.TabIndex = 13;
            item_label.Text = "Item:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(157, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(157, 22);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // totalAmount_lbl
            // 
            totalAmount_lbl.AutoSize = true;
            totalAmount_lbl.Location = new Point(244, 305);
            totalAmount_lbl.Name = "totalAmount_lbl";
            totalAmount_lbl.Size = new Size(28, 15);
            totalAmount_lbl.TabIndex = 27;
            totalAmount_lbl.Text = "0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(103, 413);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 28;
            label1.Text = "Change:";
            // 
            // change_lbl
            // 
            change_lbl.AutoSize = true;
            change_lbl.Location = new Point(191, 424);
            change_lbl.Name = "change_lbl";
            change_lbl.Size = new Size(28, 15);
            change_lbl.TabIndex = 29;
            change_lbl.Text = "0.00";
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(change_lbl);
            Controls.Add(label1);
            Controls.Add(totalAmount_lbl);
            Controls.Add(payment_txtbox);
            Controls.Add(submit_btn);
            Controls.Add(compute_btn);
            Controls.Add(quantity_txtbox);
            Controls.Add(discount_txtbox);
            Controls.Add(price_txtbox);
            Controls.Add(item_txtbox);
            Controls.Add(payment_label);
            Controls.Add(quantity_label);
            Controls.Add(discount_label);
            Controls.Add(price_label);
            Controls.Add(total_label);
            Controls.Add(item_label);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            Text = "frmPurchaseDiscountedItem";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox payment_txtbox;
        private Button submit_btn;
        private Button compute_btn;
        private TextBox quantity_txtbox;
        private TextBox discount_txtbox;
        private TextBox price_txtbox;
        private TextBox item_txtbox;
        private Label payment_label;
        private Label quantity_label;
        private Label discount_label;
        private Label price_label;
        private Label total_label;
        private Label item_label;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private Label totalAmount_lbl;
        private Label label1;
        private Label change_lbl;
    }
}