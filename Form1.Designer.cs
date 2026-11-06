namespace Lucky_Cafe_Order
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            chkStudentMember = new CheckBox();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            grpDrinkType = new GroupBox();
            rdoJuice = new RadioButton();
            rdoCoffee = new RadioButton();
            rdoTea = new RadioButton();
            lblDrink = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            lblCustomerInf = new Label();
            grpOrderList = new GroupBox();
            lblLuckyMessage = new Label();
            lblTotalPrice = new Label();
            lblBeforeDiscount = new Label();
            lblMemberDiscount = new Label();
            lblOrderList = new Label();
            lstOrderList = new ListBox();
            btnCalculateOrder = new Button();
            btnSaveToFile = new Button();
            btnLoadFromFile = new Button();
            btnClear = new Button();
            lblFinalTotal = new Label();
            lblFinalLucky = new Label();

            groupBox1.SuspendLayout();
            grpDrinkType.SuspendLayout();
            grpOrderList.SuspendLayout();
            SuspendLayout();

            // lblTitle
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(21, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(201, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lucky Cafe Order";

            // groupBox1
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(chkStudentMember);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Controls.Add(grpDrinkType);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(lblCustomerName);
            groupBox1.Controls.Add(lblCustomerInf);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 445);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;

            // chkStudentMember
            chkStudentMember.AutoSize = true;
            chkStudentMember.Location = new Point(239, 347);
            chkStudentMember.Name = "chkStudentMember";
            chkStudentMember.Size = new Size(209, 24);
            chkStudentMember.TabIndex = 7;
            chkStudentMember.Text = "Student Member (10% Off)";
            chkStudentMember.UseVisualStyleBackColor = true;

            // txtQuantity
            txtQuantity.Location = new Point(122, 341);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(88, 30);
            txtQuantity.TabIndex = 6;

            // lblQuantity
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(27, 344);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";

            // grpDrinkType
            grpDrinkType.Controls.Add(rdoJuice);
            grpDrinkType.Controls.Add(rdoCoffee);
            grpDrinkType.Controls.Add(rdoTea);
            grpDrinkType.Controls.Add(lblDrink);
            grpDrinkType.Location = new Point(9, 159);
            grpDrinkType.Name = "grpDrinkType";
            grpDrinkType.Size = new Size(398, 133);
            grpDrinkType.TabIndex = 4;
            grpDrinkType.TabStop = false;

            // rdoJuice
            rdoJuice.AutoSize = true;
            rdoJuice.Location = new Point(38, 86);
            rdoJuice.Name = "rdoJuice";
            rdoJuice.Size = new Size(92, 24);
            rdoJuice.TabIndex = 6;
            rdoJuice.TabStop = true;
            rdoJuice.Text = "Juice ($3)";
            rdoJuice.UseVisualStyleBackColor = true;

            // rdoCoffee
            rdoCoffee.AutoSize = true;
            rdoCoffee.Location = new Point(38, 56);
            rdoCoffee.Name = "rdoCoffee";
            rdoCoffee.Size = new Size(104, 24);
            rdoCoffee.TabIndex = 5;
            rdoCoffee.TabStop = true;
            rdoCoffee.Text = "Coffee ($2)";
            rdoCoffee.UseVisualStyleBackColor = true;

            // rdoTea
            rdoTea.AutoSize = true;
            rdoTea.Location = new Point(38, 26);
            rdoTea.Name = "rdoTea";
            rdoTea.Size = new Size(83, 24);
            rdoTea.TabIndex = 4;
            rdoTea.TabStop = true;
            rdoTea.Text = "Tea ($1)";
            rdoTea.UseVisualStyleBackColor = true;

            // lblDrink
            lblDrink.AutoSize = true;
            lblDrink.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDrink.ForeColor = Color.RoyalBlue;
            lblDrink.Location = new Point(27, 0);
            lblDrink.Name = "lblDrink";
            lblDrink.Size = new Size(84, 20);
            lblDrink.TabIndex = 3;
            lblDrink.Text = "Drink Type";
            lblDrink.Click += lblDrink_Click;

            // txtCustomerName
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Location = new Point(9, 109);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(398, 27);
            txtCustomerName.TabIndex = 2;

            // lblCustomerName
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10.2F);
            lblCustomerName.Location = new Point(9, 71);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(139, 23);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name:";

            // lblCustomerInf
            lblCustomerInf.AutoSize = true;
            lblCustomerInf.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblCustomerInf.ForeColor = Color.FromArgb(0, 0, 192);
            lblCustomerInf.Location = new Point(9, 24);
            lblCustomerInf.Name = "lblCustomerInf";
            lblCustomerInf.Size = new Size(180, 23);
            lblCustomerInf.TabIndex = 0;
            lblCustomerInf.Text = "Customer Information";
            lblCustomerInf.Click += lblCustomerName_Click;

            // grpOrderList
            grpOrderList.BackColor = Color.White;
            grpOrderList.Controls.Add(lblLuckyMessage);
            grpOrderList.Controls.Add(lblTotalPrice);
            grpOrderList.Controls.Add(lblBeforeDiscount);
            grpOrderList.Controls.Add(lblMemberDiscount);
            grpOrderList.Controls.Add(lblOrderList);
            grpOrderList.Controls.Add(lstOrderList);
            grpOrderList.Location = new Point(518, 68);
            grpOrderList.Name = "grpOrderList";
            grpOrderList.Size = new Size(436, 445);
            grpOrderList.TabIndex = 2;
            grpOrderList.TabStop = false;
            grpOrderList.Enter += grpOrderList_Enter;

            // lblLuckyMessage
            lblLuckyMessage.AutoSize = true;
            lblLuckyMessage.Location = new Point(6, 296);
            lblLuckyMessage.Name = "lblLuckyMessage";
            lblLuckyMessage.Size = new Size(110, 20);
            lblLuckyMessage.TabIndex = 5;
            lblLuckyMessage.Text = "Lucky Message:";

            // lblTotalPrice
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(6, 258);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(144, 20);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Total After Discount:";

            // lblBeforeDiscount
            lblBeforeDiscount.AutoSize = true;
            lblBeforeDiscount.Location = new Point(6, 219);
            lblBeforeDiscount.Name = "lblBeforeDiscount";
            lblBeforeDiscount.Size = new Size(155, 20);
            lblBeforeDiscount.TabIndex = 3;
            lblBeforeDiscount.Text = "Total Before Discount:";

            // lblMemberDiscount
            lblMemberDiscount.AutoSize = true;
            lblMemberDiscount.Location = new Point(6, 185);
            lblMemberDiscount.Name = "lblMemberDiscount";
            lblMemberDiscount.Size = new Size(130, 20);
            lblMemberDiscount.TabIndex = 2;
            lblMemberDiscount.Text = "Member Discount:";

            // lblOrderList
            lblOrderList.BackColor = Color.FromArgb(192, 192, 255);
            lblOrderList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblOrderList.ForeColor = Color.DarkBlue;
            lblOrderList.Location = new Point(0, 0);
            lblOrderList.Name = "lblOrderList";
            lblOrderList.Size = new Size(436, 36);
            lblOrderList.TabIndex = 1;
            lblOrderList.Text = "Order List";

            // lstOrderList
            lstOrderList.FormattingEnabled = true;
            lstOrderList.Location = new Point(0, 37);
            lstOrderList.Name = "lstOrderList";
            lstOrderList.Size = new Size(436, 124);
            lstOrderList.TabIndex = 0;

            // btnCalculateOrder
            btnCalculateOrder.BackColor = Color.FromArgb(224, 224, 224);
            btnCalculateOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculateOrder.Location = new Point(19, 544);
            btnCalculateOrder.Name = "btnCalculateOrder";
            btnCalculateOrder.Size = new Size(170, 38);
            btnCalculateOrder.TabIndex = 3;
            btnCalculateOrder.Text = "Calculate Order";
            btnCalculateOrder.UseVisualStyleBackColor = false;
            btnCalculateOrder.Click += btnCalculateOrder_Click;

            // btnSaveToFile
            btnSaveToFile.BackColor = Color.FromArgb(224, 224, 224);
            btnSaveToFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveToFile.Location = new Point(208, 544);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(160, 37);
            btnSaveToFile.TabIndex = 4;
            btnSaveToFile.Text = "Save To File";
            btnSaveToFile.UseVisualStyleBackColor = false;
            btnSaveToFile.Click += btnSaveToFile_Click;

            // btnLoadFromFile
            btnLoadFromFile.BackColor = Color.FromArgb(224, 224, 224);
            btnLoadFromFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLoadFromFile.Location = new Point(393, 544);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(160, 37);
            btnLoadFromFile.TabIndex = 5;
            btnLoadFromFile.Text = "Load From File";
            btnLoadFromFile.UseVisualStyleBackColor = false;
            btnLoadFromFile.Click += btnLoadFromFile_Click;

            // btnClear
            btnClear.BackColor = Color.FromArgb(224, 224, 224);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(590, 544);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 37);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // lblFinalTotal
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblFinalTotal.ForeColor = Color.FromArgb(0, 0, 192);
            lblFinalTotal.Location = new Point(56, 609);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(103, 23);
            lblFinalTotal.TabIndex = 7;
            lblFinalTotal.Text = "Total Price: ";

            // lblFinalLucky
            lblFinalLucky.AutoSize = true;
            lblFinalLucky.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblFinalLucky.ForeColor = Color.FromArgb(255, 128, 0);
            lblFinalLucky.Location = new Point(59, 641);
            lblFinalLucky.Name = "lblFinalLucky";
            lblFinalLucky.Size = new Size(134, 23);
            lblFinalLucky.TabIndex = 8;
            lblFinalLucky.Text = "Lucky Message:";

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 690);
            Controls.Add(lblFinalLucky);
            Controls.Add(lblFinalTotal);
            Controls.Add(btnClear);
            Controls.Add(btnLoadFromFile);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnCalculateOrder);
            Controls.Add(grpOrderList);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Lucky Cafe Order";

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpDrinkType.ResumeLayout(false);
            grpDrinkType.PerformLayout();
            grpOrderList.ResumeLayout(false);
            grpOrderList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox1;
        private Label lblCustomerInf;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblDrink;
        private GroupBox grpDrinkType;
        private RadioButton rdoTea;
        private RadioButton rdoCoffee;
        private RadioButton rdoJuice;
        private Label lblQuantity;
        private CheckBox chkStudentMember;
        private TextBox txtQuantity;
        private GroupBox grpOrderList;
        private ListBox lstOrderList;
        private Label lblOrderList;
        private Label lblMemberDiscount;
        private Label lblBeforeDiscount;
        private Label lblTotalPrice;
        private Label lblLuckyMessage;
        private Button btnCalculateOrder;
        private Button btnSaveToFile;
        private Button btnLoadFromFile;
        private Button btnClear;
        private Label lblFinalTotal;
        private Label lblFinalLucky;
    }
}