
namespace W3DS
{
    partial class W3DS
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
            this.label1 = new System.Windows.Forms.Label();
            this.WAVs_Folder_Button = new System.Windows.Forms.Button();
            this.WAVs_Folder_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Master_Transcript_Button = new System.Windows.Forms.Button();
            this.Master_Transcript_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Speaker_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Copy_WAVs_Button = new System.Windows.Forms.Button();
            this.Copy_WAVs_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Remove_Lines_Button = new System.Windows.Forms.Button();
            this.Remove_Lines_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Generate_Validation_Button = new System.Windows.Forms.Button();
            this.Generate_Validation_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "WAVs Folder";
            // 
            // WAVs_Folder_Button
            // 
            this.WAVs_Folder_Button.Location = new System.Drawing.Point(12, 27);
            this.WAVs_Folder_Button.Name = "WAVs_Folder_Button";
            this.WAVs_Folder_Button.Size = new System.Drawing.Size(75, 23);
            this.WAVs_Folder_Button.TabIndex = 1;
            this.WAVs_Folder_Button.Text = "Browse...";
            this.WAVs_Folder_Button.UseVisualStyleBackColor = true;
            this.WAVs_Folder_Button.Click += new System.EventHandler(this.WAVs_Folder_Button_Click);
            // 
            // WAVs_Folder_Label
            // 
            this.WAVs_Folder_Label.AutoSize = true;
            this.WAVs_Folder_Label.Location = new System.Drawing.Point(93, 31);
            this.WAVs_Folder_Label.Name = "WAVs_Folder_Label";
            this.WAVs_Folder_Label.Size = new System.Drawing.Size(38, 15);
            this.WAVs_Folder_Label.TabIndex = 2;
            this.WAVs_Folder_Label.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Master Transcript";
            // 
            // Master_Transcript_Button
            // 
            this.Master_Transcript_Button.Location = new System.Drawing.Point(12, 90);
            this.Master_Transcript_Button.Name = "Master_Transcript_Button";
            this.Master_Transcript_Button.Size = new System.Drawing.Size(75, 23);
            this.Master_Transcript_Button.TabIndex = 4;
            this.Master_Transcript_Button.Text = "Browse...";
            this.Master_Transcript_Button.UseVisualStyleBackColor = true;
            this.Master_Transcript_Button.Click += new System.EventHandler(this.Master_Transcript_Button_Click);
            // 
            // Master_Transcript_Label
            // 
            this.Master_Transcript_Label.AutoSize = true;
            this.Master_Transcript_Label.Location = new System.Drawing.Point(93, 94);
            this.Master_Transcript_Label.Name = "Master_Transcript_Label";
            this.Master_Transcript_Label.Size = new System.Drawing.Size(38, 15);
            this.Master_Transcript_Label.TabIndex = 5;
            this.Master_Transcript_Label.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Speaker Name";
            // 
            // Speaker_Name
            // 
            this.Speaker_Name.Location = new System.Drawing.Point(12, 153);
            this.Speaker_Name.Name = "Speaker_Name";
            this.Speaker_Name.Size = new System.Drawing.Size(119, 23);
            this.Speaker_Name.TabIndex = 7;
            this.Speaker_Name.TextChanged += new System.EventHandler(this.Speaker_Name_Text_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Copy WAVs and Generate Training Filelist";
            // 
            // Copy_WAVs_Button
            // 
            this.Copy_WAVs_Button.Location = new System.Drawing.Point(12, 261);
            this.Copy_WAVs_Button.Name = "Copy_WAVs_Button";
            this.Copy_WAVs_Button.Size = new System.Drawing.Size(75, 23);
            this.Copy_WAVs_Button.TabIndex = 9;
            this.Copy_WAVs_Button.Text = "Start";
            this.Copy_WAVs_Button.UseVisualStyleBackColor = true;
            this.Copy_WAVs_Button.Click += new System.EventHandler(this.Copy_WAVs_Button_Click);
            // 
            // Copy_WAVs_Label
            // 
            this.Copy_WAVs_Label.AutoSize = true;
            this.Copy_WAVs_Label.Location = new System.Drawing.Point(93, 265);
            this.Copy_WAVs_Label.Name = "Copy_WAVs_Label";
            this.Copy_WAVs_Label.Size = new System.Drawing.Size(38, 15);
            this.Copy_WAVs_Label.TabIndex = 10;
            this.Copy_WAVs_Label.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Remove User-deleted Lines from Training Filelist";
            // 
            // Remove_Lines_Button
            // 
            this.Remove_Lines_Button.Location = new System.Drawing.Point(12, 324);
            this.Remove_Lines_Button.Name = "Remove_Lines_Button";
            this.Remove_Lines_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Lines_Button.TabIndex = 12;
            this.Remove_Lines_Button.Text = "Start";
            this.Remove_Lines_Button.UseVisualStyleBackColor = true;
            this.Remove_Lines_Button.Click += new System.EventHandler(this.Remove_Lines_Button_Click);
            // 
            // Remove_Lines_Label
            // 
            this.Remove_Lines_Label.AutoSize = true;
            this.Remove_Lines_Label.Location = new System.Drawing.Point(93, 328);
            this.Remove_Lines_Label.Name = "Remove_Lines_Label";
            this.Remove_Lines_Label.Size = new System.Drawing.Size(38, 15);
            this.Remove_Lines_Label.TabIndex = 13;
            this.Remove_Lines_Label.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Generate Validation Filelist";
            // 
            // Generate_Validation_Button
            // 
            this.Generate_Validation_Button.Location = new System.Drawing.Point(12, 387);
            this.Generate_Validation_Button.Name = "Generate_Validation_Button";
            this.Generate_Validation_Button.Size = new System.Drawing.Size(75, 23);
            this.Generate_Validation_Button.TabIndex = 15;
            this.Generate_Validation_Button.Text = "Start";
            this.Generate_Validation_Button.UseVisualStyleBackColor = true;
            this.Generate_Validation_Button.Click += new System.EventHandler(this.Generate_Validation_Button_Click);
            // 
            // Generate_Validation_Label
            // 
            this.Generate_Validation_Label.AutoSize = true;
            this.Generate_Validation_Label.Location = new System.Drawing.Point(93, 391);
            this.Generate_Validation_Label.Name = "Generate_Validation_Label";
            this.Generate_Validation_Label.Size = new System.Drawing.Size(44, 15);
            this.Generate_Validation_Label.TabIndex = 16;
            this.Generate_Validation_Label.Text = "label11";
            // 
            // W3DS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Generate_Validation_Label);
            this.Controls.Add(this.Generate_Validation_Button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Remove_Lines_Label);
            this.Controls.Add(this.Remove_Lines_Button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Copy_WAVs_Label);
            this.Controls.Add(this.Copy_WAVs_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Speaker_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Master_Transcript_Label);
            this.Controls.Add(this.Master_Transcript_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WAVs_Folder_Label);
            this.Controls.Add(this.WAVs_Folder_Button);
            this.Controls.Add(this.label1);
            this.Name = "W3DS";
            this.Text = "Witcher 3 Dialogue Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WAVs_Folder_Button;
        private System.Windows.Forms.Label WAVs_Folder_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Master_Transcript_Button;
        private System.Windows.Forms.Label Master_Transcript_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Speaker_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Copy_WAVs_Button;
        private System.Windows.Forms.Label Copy_WAVs_Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Remove_Lines_Button;
        private System.Windows.Forms.Label Remove_Lines_Label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Generate_Validation_Button;
        private System.Windows.Forms.Label Generate_Validation_Label;
    }
}

