namespace ColorScalingApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.oryginalImageField = new System.Windows.Forms.PictureBox();
            this.modifiedImageBox = new System.Windows.Forms.PictureBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.sliderR = new System.Windows.Forms.Label();
            this.sliderG = new System.Windows.Forms.Label();
            this.sliderB = new System.Windows.Forms.Label();
            this.oryginalImgLabel = new System.Windows.Forms.Label();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.modifiedImgLabel = new System.Windows.Forms.Label();
            this.scaleRgbButton = new System.Windows.Forms.Button();
            this.numOfThreadsBox = new System.Windows.Forms.GroupBox();
            this.currNumOfThreads = new System.Windows.Forms.Label();
            this.currentNumOfThreads = new System.Windows.Forms.Label();
            this.sliderThread = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.defNumOfThreads = new System.Windows.Forms.RadioButton();
            this.thred64 = new System.Windows.Forms.RadioButton();
            this.thred32 = new System.Windows.Forms.RadioButton();
            this.thred16 = new System.Windows.Forms.RadioButton();
            this.thred8 = new System.Windows.Forms.RadioButton();
            this.thred4 = new System.Windows.Forms.RadioButton();
            this.thred2 = new System.Windows.Forms.RadioButton();
            this.thred1 = new System.Windows.Forms.RadioButton();
            this.chooseDllBox = new System.Windows.Forms.GroupBox();
            this.cRButton = new System.Windows.Forms.RadioButton();
            this.asmRButton = new System.Windows.Forms.RadioButton();
            this.valueOfRed = new System.Windows.Forms.Label();
            this.valueOfGreen = new System.Windows.Forms.Label();
            this.valueOfBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oryginalImageField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.numOfThreadsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.chooseDllBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oryginalImageField
            // 
            this.oryginalImageField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oryginalImageField.Location = new System.Drawing.Point(85, 73);
            this.oryginalImageField.Name = "oryginalImageField";
            this.oryginalImageField.Size = new System.Drawing.Size(248, 214);
            this.oryginalImageField.TabIndex = 0;
            this.oryginalImageField.TabStop = false;
            // 
            // modifiedImageBox
            // 
            this.modifiedImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifiedImageBox.Location = new System.Drawing.Point(406, 73);
            this.modifiedImageBox.Name = "modifiedImageBox";
            this.modifiedImageBox.Size = new System.Drawing.Size(248, 214);
            this.modifiedImageBox.TabIndex = 1;
            this.modifiedImageBox.TabStop = false;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(85, 309);
            this.trackBarRed.Maximum = 100;
            this.trackBarRed.Minimum = -100;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(248, 45);
            this.trackBarRed.TabIndex = 2;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(85, 360);
            this.trackBarGreen.Maximum = 100;
            this.trackBarGreen.Minimum = -100;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(248, 45);
            this.trackBarGreen.TabIndex = 3;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(85, 405);
            this.trackBarBlue.Maximum = 100;
            this.trackBarBlue.Minimum = -100;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(248, 45);
            this.trackBarBlue.TabIndex = 4;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // sliderR
            // 
            this.sliderR.AutoSize = true;
            this.sliderR.Location = new System.Drawing.Point(31, 309);
            this.sliderR.Name = "sliderR";
            this.sliderR.Size = new System.Drawing.Size(18, 13);
            this.sliderR.TabIndex = 5;
            this.sliderR.Text = "R:";
            // 
            // sliderG
            // 
            this.sliderG.AutoSize = true;
            this.sliderG.Location = new System.Drawing.Point(31, 350);
            this.sliderG.Name = "sliderG";
            this.sliderG.Size = new System.Drawing.Size(18, 13);
            this.sliderG.TabIndex = 6;
            this.sliderG.Text = "G:";
            // 
            // sliderB
            // 
            this.sliderB.AutoSize = true;
            this.sliderB.Location = new System.Drawing.Point(32, 392);
            this.sliderB.Name = "sliderB";
            this.sliderB.Size = new System.Drawing.Size(17, 13);
            this.sliderB.TabIndex = 7;
            this.sliderB.Text = "B:";
            // 
            // oryginalImgLabel
            // 
            this.oryginalImgLabel.AutoSize = true;
            this.oryginalImgLabel.Location = new System.Drawing.Point(82, 57);
            this.oryginalImgLabel.Name = "oryginalImgLabel";
            this.oryginalImgLabel.Size = new System.Drawing.Size(77, 13);
            this.oryginalImgLabel.TabIndex = 8;
            this.oryginalImgLabel.Text = "Oryginal Image";
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(406, 309);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(248, 45);
            this.loadImageButton.TabIndex = 9;
            this.loadImageButton.Text = "Load image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(406, 462);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(248, 45);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save modified image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearImageButton
            // 
            this.clearImageButton.Location = new System.Drawing.Point(406, 360);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(248, 45);
            this.clearImageButton.TabIndex = 11;
            this.clearImageButton.Text = "Clear image field";
            this.clearImageButton.UseVisualStyleBackColor = true;
            this.clearImageButton.Click += new System.EventHandler(this.clearImageButton_Click);
            // 
            // modifiedImgLabel
            // 
            this.modifiedImgLabel.AutoSize = true;
            this.modifiedImgLabel.Location = new System.Drawing.Point(403, 57);
            this.modifiedImgLabel.Name = "modifiedImgLabel";
            this.modifiedImgLabel.Size = new System.Drawing.Size(78, 13);
            this.modifiedImgLabel.TabIndex = 12;
            this.modifiedImgLabel.Text = "Modified image";
            // 
            // scaleRgbButton
            // 
            this.scaleRgbButton.Location = new System.Drawing.Point(406, 411);
            this.scaleRgbButton.Name = "scaleRgbButton";
            this.scaleRgbButton.Size = new System.Drawing.Size(248, 45);
            this.scaleRgbButton.TabIndex = 13;
            this.scaleRgbButton.Text = "Scale RGB";
            this.scaleRgbButton.UseVisualStyleBackColor = true;
            this.scaleRgbButton.Click += new System.EventHandler(this.scaleRgbButton_Click);
            // 
            // numOfThreadsBox
            // 
            this.numOfThreadsBox.Controls.Add(this.currNumOfThreads);
            this.numOfThreadsBox.Controls.Add(this.currentNumOfThreads);
            this.numOfThreadsBox.Controls.Add(this.sliderThread);
            this.numOfThreadsBox.Controls.Add(this.trackBar1);
            this.numOfThreadsBox.Controls.Add(this.defNumOfThreads);
            this.numOfThreadsBox.Controls.Add(this.thred64);
            this.numOfThreadsBox.Controls.Add(this.thred32);
            this.numOfThreadsBox.Controls.Add(this.thred16);
            this.numOfThreadsBox.Controls.Add(this.thred8);
            this.numOfThreadsBox.Controls.Add(this.thred4);
            this.numOfThreadsBox.Controls.Add(this.thred2);
            this.numOfThreadsBox.Controls.Add(this.thred1);
            this.numOfThreadsBox.Location = new System.Drawing.Point(64, 456);
            this.numOfThreadsBox.Name = "numOfThreadsBox";
            this.numOfThreadsBox.Size = new System.Drawing.Size(286, 162);
            this.numOfThreadsBox.TabIndex = 18;
            this.numOfThreadsBox.TabStop = false;
            this.numOfThreadsBox.Text = "Number of threads";
            // 
            // currNumOfThreads
            // 
            this.currNumOfThreads.AutoSize = true;
            this.currNumOfThreads.Location = new System.Drawing.Point(135, 136);
            this.currNumOfThreads.Name = "currNumOfThreads";
            this.currNumOfThreads.Size = new System.Drawing.Size(13, 13);
            this.currNumOfThreads.TabIndex = 29;
            this.currNumOfThreads.Text = "1";
            // 
            // currentNumOfThreads
            // 
            this.currentNumOfThreads.AutoSize = true;
            this.currentNumOfThreads.Location = new System.Drawing.Point(6, 136);
            this.currentNumOfThreads.Name = "currentNumOfThreads";
            this.currentNumOfThreads.Size = new System.Drawing.Size(135, 13);
            this.currentNumOfThreads.TabIndex = 28;
            this.currentNumOfThreads.Text = "Current number of threads: ";
            // 
            // sliderThread
            // 
            this.sliderThread.AutoSize = true;
            this.sliderThread.Location = new System.Drawing.Point(6, 65);
            this.sliderThread.Name = "sliderThread";
            this.sliderThread.Size = new System.Drawing.Size(193, 17);
            this.sliderThread.TabIndex = 27;
            this.sliderThread.TabStop = true;
            this.sliderThread.Text = "Choose number of threds from slider";
            this.sliderThread.UseVisualStyleBackColor = true;
            this.sliderThread.UseWaitCursor = true;
            this.sliderThread.CheckedChanged += new System.EventHandler(this.sliderThread_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(14, 88);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(263, 45);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // defNumOfThreads
            // 
            this.defNumOfThreads.AutoSize = true;
            this.defNumOfThreads.Checked = true;
            this.defNumOfThreads.Location = new System.Drawing.Point(6, 42);
            this.defNumOfThreads.Name = "defNumOfThreads";
            this.defNumOfThreads.Size = new System.Drawing.Size(147, 17);
            this.defNumOfThreads.TabIndex = 24;
            this.defNumOfThreads.TabStop = true;
            this.defNumOfThreads.Text = "Default number of threads";
            this.defNumOfThreads.UseVisualStyleBackColor = true;
            this.defNumOfThreads.CheckedChanged += new System.EventHandler(this.defNumOfThreads_CheckedChanged);
            // 
            // thred64
            // 
            this.thred64.AutoSize = true;
            this.thred64.Location = new System.Drawing.Point(240, 19);
            this.thred64.Name = "thred64";
            this.thred64.Size = new System.Drawing.Size(37, 17);
            this.thred64.TabIndex = 19;
            this.thred64.TabStop = true;
            this.thred64.Text = "64";
            this.thred64.UseVisualStyleBackColor = true;
            this.thred64.CheckedChanged += new System.EventHandler(this.thred64_CheckedChanged);
            // 
            // thred32
            // 
            this.thred32.AutoSize = true;
            this.thred32.Location = new System.Drawing.Point(197, 19);
            this.thred32.Name = "thred32";
            this.thred32.Size = new System.Drawing.Size(37, 17);
            this.thred32.TabIndex = 19;
            this.thred32.TabStop = true;
            this.thred32.Text = "32";
            this.thred32.UseVisualStyleBackColor = true;
            this.thred32.CheckedChanged += new System.EventHandler(this.thred32_CheckedChanged);
            // 
            // thred16
            // 
            this.thred16.AutoSize = true;
            this.thred16.Location = new System.Drawing.Point(154, 19);
            this.thred16.Name = "thred16";
            this.thred16.Size = new System.Drawing.Size(37, 17);
            this.thred16.TabIndex = 23;
            this.thred16.TabStop = true;
            this.thred16.Text = "16";
            this.thred16.UseVisualStyleBackColor = true;
            this.thred16.CheckedChanged += new System.EventHandler(this.thred16_CheckedChanged);
            // 
            // thred8
            // 
            this.thred8.AutoSize = true;
            this.thred8.Location = new System.Drawing.Point(117, 19);
            this.thred8.Name = "thred8";
            this.thred8.Size = new System.Drawing.Size(31, 17);
            this.thred8.TabIndex = 22;
            this.thred8.TabStop = true;
            this.thred8.Text = "8";
            this.thred8.UseVisualStyleBackColor = true;
            this.thred8.CheckedChanged += new System.EventHandler(this.thred8_CheckedChanged);
            // 
            // thred4
            // 
            this.thred4.AutoSize = true;
            this.thred4.Location = new System.Drawing.Point(80, 19);
            this.thred4.Name = "thred4";
            this.thred4.Size = new System.Drawing.Size(31, 17);
            this.thred4.TabIndex = 21;
            this.thred4.TabStop = true;
            this.thred4.Text = "4";
            this.thred4.UseVisualStyleBackColor = true;
            this.thred4.CheckedChanged += new System.EventHandler(this.thred4_CheckedChanged);
            // 
            // thred2
            // 
            this.thred2.AutoSize = true;
            this.thred2.Location = new System.Drawing.Point(43, 19);
            this.thred2.Name = "thred2";
            this.thred2.Size = new System.Drawing.Size(31, 17);
            this.thred2.TabIndex = 20;
            this.thred2.TabStop = true;
            this.thred2.Text = "2";
            this.thred2.UseVisualStyleBackColor = true;
            this.thred2.CheckedChanged += new System.EventHandler(this.thred2_CheckedChanged);
            // 
            // thred1
            // 
            this.thred1.AutoSize = true;
            this.thred1.Location = new System.Drawing.Point(6, 19);
            this.thred1.Name = "thred1";
            this.thred1.Size = new System.Drawing.Size(31, 17);
            this.thred1.TabIndex = 19;
            this.thred1.TabStop = true;
            this.thred1.Text = "1";
            this.thred1.UseVisualStyleBackColor = true;
            this.thred1.CheckedChanged += new System.EventHandler(this.thred1_CheckedChanged);
            // 
            // chooseDllBox
            // 
            this.chooseDllBox.Controls.Add(this.cRButton);
            this.chooseDllBox.Controls.Add(this.asmRButton);
            this.chooseDllBox.Location = new System.Drawing.Point(64, 638);
            this.chooseDllBox.Name = "chooseDllBox";
            this.chooseDllBox.Size = new System.Drawing.Size(206, 52);
            this.chooseDllBox.TabIndex = 25;
            this.chooseDllBox.TabStop = false;
            this.chooseDllBox.Text = "DLL";
            // 
            // cRButton
            // 
            this.cRButton.AutoSize = true;
            this.cRButton.Checked = true;
            this.cRButton.Location = new System.Drawing.Point(117, 19);
            this.cRButton.Name = "cRButton";
            this.cRButton.Size = new System.Drawing.Size(39, 17);
            this.cRButton.TabIndex = 1;
            this.cRButton.TabStop = true;
            this.cRButton.Text = "C#";
            this.cRButton.UseVisualStyleBackColor = true;
            // 
            // asmRButton
            // 
            this.asmRButton.AutoSize = true;
            this.asmRButton.Location = new System.Drawing.Point(43, 19);
            this.asmRButton.Name = "asmRButton";
            this.asmRButton.Size = new System.Drawing.Size(48, 17);
            this.asmRButton.TabIndex = 0;
            this.asmRButton.Text = "ASM";
            this.asmRButton.UseVisualStyleBackColor = true;
            // 
            // valueOfRed
            // 
            this.valueOfRed.AutoSize = true;
            this.valueOfRed.Location = new System.Drawing.Point(55, 309);
            this.valueOfRed.Name = "valueOfRed";
            this.valueOfRed.Size = new System.Drawing.Size(22, 13);
            this.valueOfRed.TabIndex = 26;
            this.valueOfRed.Text = "1,0";
            // 
            // valueOfGreen
            // 
            this.valueOfGreen.AutoSize = true;
            this.valueOfGreen.Location = new System.Drawing.Point(55, 350);
            this.valueOfGreen.Name = "valueOfGreen";
            this.valueOfGreen.Size = new System.Drawing.Size(22, 13);
            this.valueOfGreen.TabIndex = 27;
            this.valueOfGreen.Text = "1.0";
            // 
            // valueOfBlue
            // 
            this.valueOfBlue.AutoSize = true;
            this.valueOfBlue.Location = new System.Drawing.Point(55, 392);
            this.valueOfBlue.Name = "valueOfBlue";
            this.valueOfBlue.Size = new System.Drawing.Size(22, 13);
            this.valueOfBlue.TabIndex = 28;
            this.valueOfBlue.Text = "1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 734);
            this.Controls.Add(this.valueOfBlue);
            this.Controls.Add(this.valueOfGreen);
            this.Controls.Add(this.valueOfRed);
            this.Controls.Add(this.chooseDllBox);
            this.Controls.Add(this.numOfThreadsBox);
            this.Controls.Add(this.scaleRgbButton);
            this.Controls.Add(this.modifiedImgLabel);
            this.Controls.Add(this.clearImageButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.oryginalImgLabel);
            this.Controls.Add(this.sliderB);
            this.Controls.Add(this.sliderG);
            this.Controls.Add(this.sliderR);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.modifiedImageBox);
            this.Controls.Add(this.oryginalImageField);
            this.Name = "Form1";
            this.Text = "ColorScalingApp";
            ((System.ComponentModel.ISupportInitialize)(this.oryginalImageField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiedImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.numOfThreadsBox.ResumeLayout(false);
            this.numOfThreadsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.chooseDllBox.ResumeLayout(false);
            this.chooseDllBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox oryginalImageField;
        private System.Windows.Forms.PictureBox modifiedImageBox;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label sliderR;
        private System.Windows.Forms.Label sliderG;
        private System.Windows.Forms.Label sliderB;
        private System.Windows.Forms.Label oryginalImgLabel;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.Label modifiedImgLabel;
        private System.Windows.Forms.Button scaleRgbButton;
        private System.Windows.Forms.GroupBox numOfThreadsBox;
        private System.Windows.Forms.RadioButton thred1;
        private System.Windows.Forms.RadioButton thred2;
        private System.Windows.Forms.RadioButton thred32;
        private System.Windows.Forms.RadioButton thred16;
        private System.Windows.Forms.RadioButton thred8;
        private System.Windows.Forms.RadioButton thred4;
        private System.Windows.Forms.RadioButton thred64;
        private System.Windows.Forms.RadioButton defNumOfThreads;
        private System.Windows.Forms.GroupBox chooseDllBox;
        private System.Windows.Forms.RadioButton cRButton;
        private System.Windows.Forms.RadioButton asmRButton;
        private System.Windows.Forms.RadioButton sliderThread;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label currentNumOfThreads;
        private System.Windows.Forms.Label currNumOfThreads;
        private System.Windows.Forms.Label valueOfRed;
        private System.Windows.Forms.Label valueOfGreen;
        private System.Windows.Forms.Label valueOfBlue;
    }
}

