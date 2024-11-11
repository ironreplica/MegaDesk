namespace MegaDesk
{
    partial class AddNewQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deskDrawerAmountBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialTypeBox = new System.Windows.Forms.ComboBox();
            this.shippingTimeFrameBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.deskDepthTxt = new System.Windows.Forms.TextBox();
            this.deskWidthTxt = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.WidthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DeskDrawerAmountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ShippingTimeFrameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDrawerAmountErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingTimeFrameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MegaDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Todays Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desk Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desk Depth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Desk Drawer Amount:";
            // 
            // deskDrawerAmountBox
            // 
            this.deskDrawerAmountBox.FormattingEnabled = true;
            this.deskDrawerAmountBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.deskDrawerAmountBox.Location = new System.Drawing.Point(244, 247);
            this.deskDrawerAmountBox.Name = "deskDrawerAmountBox";
            this.deskDrawerAmountBox.Size = new System.Drawing.Size(121, 24);
            this.deskDrawerAmountBox.TabIndex = 6;
            this.deskDrawerAmountBox.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDrawerAmount_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Material Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Shipping Timeframe:";
            // 
            // materialTypeBox
            // 
            this.materialTypeBox.FormattingEnabled = true;
            this.materialTypeBox.Items.AddRange(new object[] {
            "Oak",
            "Cedar",
            "Spruce",
            "Red Oak"});
            this.materialTypeBox.Location = new System.Drawing.Point(244, 297);
            this.materialTypeBox.Name = "materialTypeBox";
            this.materialTypeBox.Size = new System.Drawing.Size(121, 24);
            this.materialTypeBox.TabIndex = 9;
            // 
            // shippingTimeFrameBox
            // 
            this.shippingTimeFrameBox.FormattingEnabled = true;
            this.shippingTimeFrameBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.shippingTimeFrameBox.Location = new System.Drawing.Point(244, 342);
            this.shippingTimeFrameBox.Name = "shippingTimeFrameBox";
            this.shippingTimeFrameBox.Size = new System.Drawing.Size(121, 24);
            this.shippingTimeFrameBox.TabIndex = 10;
            this.shippingTimeFrameBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShippingTimeframe_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Todays Date";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(244, 108);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(121, 22);
            this.nameTxtBox.TabIndex = 12;
            this.nameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameBox_Validating);
            // 
            // deskDepthTxt
            // 
            this.deskDepthTxt.Location = new System.Drawing.Point(244, 200);
            this.deskDepthTxt.Name = "deskDepthTxt";
            this.deskDepthTxt.Size = new System.Drawing.Size(121, 22);
            this.deskDepthTxt.TabIndex = 13;
            this.deskDepthTxt.Validating += new System.ComponentModel.CancelEventHandler(this.DepthBox_Validating);
            // 
            // deskWidthTxt
            // 
            this.deskWidthTxt.Location = new System.Drawing.Point(244, 152);
            this.deskWidthTxt.Name = "deskWidthTxt";
            this.deskWidthTxt.Size = new System.Drawing.Size(121, 22);
            this.deskWidthTxt.TabIndex = 14;
            this.deskWidthTxt.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 36);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(244, 375);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(175, 57);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // WidthErrorProvider
            // 
            this.WidthErrorProvider.ContainerControl = this;
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            this.DepthErrorProvider.ContainerControl = this;
            // 
            // DeskDrawerAmountErrorProvider
            // 
            this.DeskDrawerAmountErrorProvider.ContainerControl = this;
            // 
            // ShippingTimeFrameErrorProvider
            // 
            this.ShippingTimeFrameErrorProvider.ContainerControl = this;
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 434);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.deskWidthTxt);
            this.Controls.Add(this.deskDepthTxt);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.shippingTimeFrameBox);
            this.Controls.Add(this.materialTypeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deskDrawerAmountBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewQuote";
            this.Text = "Add a new quote";
            ((System.ComponentModel.ISupportInitialize)(this.WidthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDrawerAmountErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShippingTimeFrameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox deskDrawerAmountBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox materialTypeBox;
        private System.Windows.Forms.ComboBox shippingTimeFrameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox deskDepthTxt;
        private System.Windows.Forms.TextBox deskWidthTxt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider WidthErrorProvider;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider DepthErrorProvider;
        private System.Windows.Forms.ErrorProvider DeskDrawerAmountErrorProvider;
        private System.Windows.Forms.ErrorProvider ShippingTimeFrameErrorProvider;
    }
}