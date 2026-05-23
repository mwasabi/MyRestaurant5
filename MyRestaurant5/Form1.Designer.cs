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
            numTea.Location = new Point(21, 69);
            numTea.Name = "numTea";
            numTea.Size = new Size(150, 27);
            numTea.TabIndex = 2;
            // 
            // numEgg
            // 
            numEgg.Location = new Point(21, 114);
            numEgg.Name = "numEgg";
            numEgg.Size = new Size(150, 27);
            numEgg.TabIndex = 3;
            // 
            // numChicken
            // 
            numChicken.Location = new Point(21, 158);
            numChicken.Name = "numChicken";
            numChicken.Size = new Size(150, 27);
            numChicken.TabIndex = 4;
            // 
            // btnSendToCook
            // 
            btnSendToCook.Location = new Point(21, 254);
            btnSendToCook.Name = "btnSendToCook";
            btnSendToCook.Size = new Size(94, 29);
            btnSendToCook.TabIndex = 5;
            btnSendToCook.Text = "Send all Customer requests to the Cook";
            btnSendToCook.UseVisualStyleBackColor = true;
            btnSendToCook.Click += btnSendToCook_Click;
            // 
            // btnReceiveRequest
            // 
            btnReceiveRequest.Location = new Point(21, 205);
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
            lstRequests.Location = new Point(21, 318);
            lstRequests.Name = "lstRequests";
            lstRequests.Size = new Size(275, 104);
            lstRequests.TabIndex = 7;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(404, 276);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(325, 146);
            txtResults.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
