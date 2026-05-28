namespace MyRestaurant5
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
            label1 = new Label();
            txtCustomerName = new TextBox();
            numTea = new NumericUpDown();
            numEgg = new NumericUpDown();
            numChicken = new NumericUpDown();
            btnSendToCook = new Button();
            btnReceiveRequest = new Button();
            lstRequests = new ListBox();
            txtResults = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numTea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEgg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChicken).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 19);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Receive request from:";
            label1.Click += label1_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(300, 12);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // numTea
            // 
            numTea.Location = new Point(92, 72);
            numTea.Name = "numTea";
            numTea.Size = new Size(150, 27);
            numTea.TabIndex = 2;
            // 
            // numEgg
            // 
            numEgg.Location = new Point(92, 133);
            numEgg.Name = "numEgg";
            numEgg.Size = new Size(150, 27);
            numEgg.TabIndex = 3;
            // 
            // numChicken
            // 
            numChicken.Location = new Point(92, 196);
            numChicken.Name = "numChicken";
            numChicken.Size = new Size(150, 27);
            numChicken.TabIndex = 4;
            // 
            // btnSendToCook
            // 
            btnSendToCook.Location = new Point(92, 296);
            btnSendToCook.Name = "btnSendToCook";
            btnSendToCook.Size = new Size(94, 29);
            btnSendToCook.TabIndex = 5;
            btnSendToCook.Text = "Send all Customer requests to the Cook";
            btnSendToCook.UseVisualStyleBackColor = true;
            btnSendToCook.Click += btnSendToCook_Click;
            // 
            // btnReceiveRequest
            // 
            btnReceiveRequest.Location = new Point(92, 245);
            btnReceiveRequest.Name = "btnReceiveRequest";
            btnReceiveRequest.Size = new Size(94, 29);
            btnReceiveRequest.TabIndex = 6;
            btnReceiveRequest.Text = "Receive Request";
            btnReceiveRequest.UseVisualStyleBackColor = true;
            btnReceiveRequest.Click += btnReceiveRequest_Click;
            // 
            // lstRequests
            // 
            lstRequests.FormattingEnabled = true;
            lstRequests.Location = new Point(354, 110);
            lstRequests.Name = "lstRequests";
            lstRequests.Size = new Size(275, 104);
            lstRequests.TabIndex = 7;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(354, 279);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(325, 146);
            txtResults.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 9;
            label2.Text = "Tea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 140);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 10;
            label3.Text = "Egg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 203);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 11;
            label4.Text = "Chicken";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 245);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Result";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 79);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 13;
            label6.Text = "Orders";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResults);
            Controls.Add(lstRequests);
            Controls.Add(btnReceiveRequest);
            Controls.Add(btnSendToCook);
            Controls.Add(numChicken);
            Controls.Add(numEgg);
            Controls.Add(numTea);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numTea).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEgg).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChicken).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private NumericUpDown numTea;
        private NumericUpDown numEgg;
        private NumericUpDown numChicken;
        private Button btnSendToCook;
        private Button btnReceiveRequest;
        private ListBox lstRequests;
        private TextBox txtResults;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
