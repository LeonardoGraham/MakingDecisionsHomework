
namespace MakingDecisionsHomework
{
    partial class WorkshopSelector
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
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.registrationAnswerLabel = new System.Windows.Forms.Label();
            this.lodgingAnswerLabel = new System.Windows.Forms.Label();
            this.totalAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.ItemHeight = 15;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(12, 29);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(136, 94);
            this.workshopListBox.TabIndex = 0;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 15;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(154, 29);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(120, 94);
            this.locationListBox.TabIndex = 1;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.locationLabel.Location = new System.Drawing.Point(154, 9);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(80, 17);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Location";
            // 
            // workshopLabel
            // 
            this.workshopLabel.AutoSize = true;
            this.workshopLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workshopLabel.Location = new System.Drawing.Point(12, 9);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(80, 17);
            this.workshopLabel.TabIndex = 3;
            this.workshopLabel.Text = "Workshop";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(111, 129);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(81, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationLabel.Location = new System.Drawing.Point(12, 155);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(134, 17);
            this.registrationLabel.TabIndex = 5;
            this.registrationLabel.Text = "Registration: ";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lodgingLabel.Location = new System.Drawing.Point(12, 172);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(89, 17);
            this.lodgingLabel.TabIndex = 6;
            this.lodgingLabel.Text = "Lodging: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(12, 189);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(71, 17);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total: ";
            // 
            // registrationAnswerLabel
            // 
            this.registrationAnswerLabel.AutoSize = true;
            this.registrationAnswerLabel.Location = new System.Drawing.Point(138, 155);
            this.registrationAnswerLabel.Name = "registrationAnswerLabel";
            this.registrationAnswerLabel.Size = new System.Drawing.Size(0, 15);
            this.registrationAnswerLabel.TabIndex = 8;
            // 
            // lodgingAnswerLabel
            // 
            this.lodgingAnswerLabel.AutoSize = true;
            this.lodgingAnswerLabel.Location = new System.Drawing.Point(138, 172);
            this.lodgingAnswerLabel.Name = "lodgingAnswerLabel";
            this.lodgingAnswerLabel.Size = new System.Drawing.Size(0, 15);
            this.lodgingAnswerLabel.TabIndex = 9;
            // 
            // totalAnswerLabel
            // 
            this.totalAnswerLabel.AutoSize = true;
            this.totalAnswerLabel.Location = new System.Drawing.Point(138, 189);
            this.totalAnswerLabel.Name = "totalAnswerLabel";
            this.totalAnswerLabel.Size = new System.Drawing.Size(0, 15);
            this.totalAnswerLabel.TabIndex = 10;
            // 
            // WorkshopSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 232);
            this.Controls.Add(this.totalAnswerLabel);
            this.Controls.Add(this.lodgingAnswerLabel);
            this.Controls.Add(this.registrationAnswerLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.workshopLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.workshopListBox);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "WorkshopSelector";
            this.Text = "Workshop Selector";
            this.Load += new System.EventHandler(this.WorkshopSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label registrationAnswerLabel;
        private System.Windows.Forms.Label lodgingAnswerLabel;
        private System.Windows.Forms.Label totalAnswerLabel;
    }
}

