namespace Tinder
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
            this.tinderLogo = new System.Windows.Forms.PictureBox();
            this.getStartedButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.birthdayInput = new System.Windows.Forms.TextBox();
            this.birthMonthInput = new System.Windows.Forms.TextBox();
            this.birthYearInput = new System.Windows.Forms.TextBox();
            this.maleButton = new System.Windows.Forms.Button();
            this.femaleButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.modelPicture = new System.Windows.Forms.PictureBox();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tinderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tinderLogo
            // 
            this.tinderLogo.BackColor = System.Drawing.Color.Transparent;
            this.tinderLogo.BackgroundImage = global::Tinder.Properties.Resources.Tinder_Logo;
            this.tinderLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tinderLogo.Location = new System.Drawing.Point(55, 37);
            this.tinderLogo.Name = "tinderLogo";
            this.tinderLogo.Size = new System.Drawing.Size(183, 107);
            this.tinderLogo.TabIndex = 0;
            this.tinderLogo.TabStop = false;
            // 
            // getStartedButton
            // 
            this.getStartedButton.Location = new System.Drawing.Point(87, 434);
            this.getStartedButton.Name = "getStartedButton";
            this.getStartedButton.Size = new System.Drawing.Size(110, 35);
            this.getStartedButton.TabIndex = 1;
            this.getStartedButton.Text = "Get Started";
            this.getStartedButton.UseVisualStyleBackColor = true;
            this.getStartedButton.Click += new System.EventHandler(this.getStartedButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Location = new System.Drawing.Point(41, 372);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(206, 59);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "By clicking get started, you agree with our Terms. Learn how we process your data" +
    " in our Privacy Policy and Cookies Policies.";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(147, 240);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(123, 20);
            this.nameInput.TabIndex = 3;
            // 
            // birthdayInput
            // 
            this.birthdayInput.Location = new System.Drawing.Point(133, 280);
            this.birthdayInput.Name = "birthdayInput";
            this.birthdayInput.Size = new System.Drawing.Size(29, 20);
            this.birthdayInput.TabIndex = 4;
            // 
            // birthMonthInput
            // 
            this.birthMonthInput.Location = new System.Drawing.Point(168, 280);
            this.birthMonthInput.Name = "birthMonthInput";
            this.birthMonthInput.Size = new System.Drawing.Size(29, 20);
            this.birthMonthInput.TabIndex = 5;
            // 
            // birthYearInput
            // 
            this.birthYearInput.Location = new System.Drawing.Point(203, 280);
            this.birthYearInput.Name = "birthYearInput";
            this.birthYearInput.Size = new System.Drawing.Size(67, 20);
            this.birthYearInput.TabIndex = 6;
            // 
            // maleButton
            // 
            this.maleButton.Location = new System.Drawing.Point(131, 315);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(64, 23);
            this.maleButton.TabIndex = 7;
            this.maleButton.Text = "Female";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.Click += new System.EventHandler(this.maleButton_Click);
            // 
            // femaleButton
            // 
            this.femaleButton.Location = new System.Drawing.Point(203, 315);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(65, 23);
            this.femaleButton.TabIndex = 8;
            this.femaleButton.Text = "Male";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.Click += new System.EventHandler(this.femaleButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(12, 232);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(106, 35);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Enter Your Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthLabel
            // 
            this.birthLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthLabel.Location = new System.Drawing.Point(12, 273);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(106, 27);
            this.birthLabel.TabIndex = 10;
            this.birthLabel.Text = "Enter Your Birthday:";
            this.birthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genderLabel
            // 
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Location = new System.Drawing.Point(12, 311);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(106, 27);
            this.genderLabel.TabIndex = 11;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(24, 396);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(110, 35);
            this.option1.TabIndex = 12;
            this.option1.Text = "Right";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(160, 396);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(110, 35);
            this.option2.TabIndex = 13;
            this.option2.Text = "Left";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(263, 334);
            this.mainLabel.TabIndex = 14;
            this.mainLabel.Text = ".....";
            // 
            // modelPicture
            // 
            this.modelPicture.Location = new System.Drawing.Point(24, 85);
            this.modelPicture.Name = "modelPicture";
            this.modelPicture.Size = new System.Drawing.Size(232, 224);
            this.modelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.modelPicture.TabIndex = 15;
            this.modelPicture.TabStop = false;
            // 
            // option1Label
            // 
            this.option1Label.BackColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(64, 381);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(204, 50);
            this.option1Label.TabIndex = 16;
            this.option1Label.Text = "...";
            // 
            // option2Label
            // 
            this.option2Label.BackColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(64, 434);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(204, 48);
            this.option2Label.TabIndex = 17;
            this.option2Label.Text = "...";
            // 
            // option3Label
            // 
            this.option3Label.BackColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(64, 331);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(204, 50);
            this.option3Label.TabIndex = 18;
            this.option3Label.Text = "...";
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(12, 341);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(43, 28);
            this.option3.TabIndex = 19;
            this.option3.Text = "C";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tinder.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(287, 481);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.modelPicture);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.birthYearInput);
            this.Controls.Add(this.birthMonthInput);
            this.Controls.Add(this.birthdayInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.getStartedButton);
            this.Controls.Add(this.tinderLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tinderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tinderLogo;
        private System.Windows.Forms.Button getStartedButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox birthdayInput;
        private System.Windows.Forms.TextBox birthMonthInput;
        private System.Windows.Forms.TextBox birthYearInput;
        private System.Windows.Forms.Button maleButton;
        private System.Windows.Forms.Button femaleButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.PictureBox modelPicture;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Button option3;
    }
}

