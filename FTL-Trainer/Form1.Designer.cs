namespace FTL_Trainer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tB_FuelCurrent = new System.Windows.Forms.TextBox();
            this.bn_ApplyFuel = new System.Windows.Forms.Button();
            this.tB_FuelUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_MissUser1 = new System.Windows.Forms.TextBox();
            this.bn_ApplyMiss1 = new System.Windows.Forms.Button();
            this.tB_MissCurrent1 = new System.Windows.Forms.TextBox();
            this.tB_DroneUser1 = new System.Windows.Forms.TextBox();
            this.bn_ApplyDrone1 = new System.Windows.Forms.Button();
            this.tB_DroneCurrent1 = new System.Windows.Forms.TextBox();
            this.tB_DroneUser2 = new System.Windows.Forms.TextBox();
            this.bn_ApplyDrone2 = new System.Windows.Forms.Button();
            this.tB_DroneCurrent2 = new System.Windows.Forms.TextBox();
            this.tB_MissUser2 = new System.Windows.Forms.TextBox();
            this.bn_ApplyMiss2 = new System.Windows.Forms.Button();
            this.tB_MissCurrent2 = new System.Windows.Forms.TextBox();
            this.tB_EnergyUser = new System.Windows.Forms.TextBox();
            this.bn_ApplyEnergy = new System.Windows.Forms.Button();
            this.tB_EnergyCurrent = new System.Windows.Forms.TextBox();
            this.tB_ScrapUser = new System.Windows.Forms.TextBox();
            this.bn_ApplyScrap = new System.Windows.Forms.Button();
            this.tB_ScrapCurrent = new System.Windows.Forms.TextBox();
            this.bn_ApplyAll = new System.Windows.Forms.Button();
            this.bn_Exit = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.label_status = new System.Windows.Forms.Label();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.tB_HealthUser = new System.Windows.Forms.TextBox();
            this.bn_ApplyHealth = new System.Windows.Forms.Button();
            this.tB_HealthCurrent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_FuelCurrent
            // 
            this.tB_FuelCurrent.Location = new System.Drawing.Point(50, 28);
            this.tB_FuelCurrent.Name = "tB_FuelCurrent";
            this.tB_FuelCurrent.ReadOnly = true;
            this.tB_FuelCurrent.Size = new System.Drawing.Size(73, 20);
            this.tB_FuelCurrent.TabIndex = 0;
            // 
            // bn_ApplyFuel
            // 
            this.bn_ApplyFuel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyFuel.Location = new System.Drawing.Point(207, 26);
            this.bn_ApplyFuel.Name = "bn_ApplyFuel";
            this.bn_ApplyFuel.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyFuel.TabIndex = 30;
            this.bn_ApplyFuel.Text = "Apply";
            this.bn_ApplyFuel.UseVisualStyleBackColor = true;
            this.bn_ApplyFuel.Click += new System.EventHandler(this.bn_ApplyFuel_Click);
            // 
            // tB_FuelUser
            // 
            this.tB_FuelUser.Location = new System.Drawing.Point(128, 28);
            this.tB_FuelUser.Name = "tB_FuelUser";
            this.tB_FuelUser.Size = new System.Drawing.Size(73, 20);
            this.tB_FuelUser.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(125, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wish Value:";
            // 
            // tB_MissUser1
            // 
            this.tB_MissUser1.Location = new System.Drawing.Point(128, 57);
            this.tB_MissUser1.Name = "tB_MissUser1";
            this.tB_MissUser1.Size = new System.Drawing.Size(73, 20);
            this.tB_MissUser1.TabIndex = 21;
            // 
            // bn_ApplyMiss1
            // 
            this.bn_ApplyMiss1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyMiss1.Location = new System.Drawing.Point(207, 55);
            this.bn_ApplyMiss1.Name = "bn_ApplyMiss1";
            this.bn_ApplyMiss1.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyMiss1.TabIndex = 31;
            this.bn_ApplyMiss1.Text = "Apply";
            this.bn_ApplyMiss1.UseVisualStyleBackColor = true;
            this.bn_ApplyMiss1.Click += new System.EventHandler(this.bn_ApplyMiss1_Click);
            // 
            // tB_MissCurrent1
            // 
            this.tB_MissCurrent1.Location = new System.Drawing.Point(50, 57);
            this.tB_MissCurrent1.Name = "tB_MissCurrent1";
            this.tB_MissCurrent1.ReadOnly = true;
            this.tB_MissCurrent1.Size = new System.Drawing.Size(73, 20);
            this.tB_MissCurrent1.TabIndex = 1;
            // 
            // tB_DroneUser1
            // 
            this.tB_DroneUser1.Location = new System.Drawing.Point(128, 115);
            this.tB_DroneUser1.Name = "tB_DroneUser1";
            this.tB_DroneUser1.Size = new System.Drawing.Size(73, 20);
            this.tB_DroneUser1.TabIndex = 23;
            // 
            // bn_ApplyDrone1
            // 
            this.bn_ApplyDrone1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyDrone1.Location = new System.Drawing.Point(207, 113);
            this.bn_ApplyDrone1.Name = "bn_ApplyDrone1";
            this.bn_ApplyDrone1.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyDrone1.TabIndex = 33;
            this.bn_ApplyDrone1.Text = "Apply";
            this.bn_ApplyDrone1.UseVisualStyleBackColor = true;
            this.bn_ApplyDrone1.Click += new System.EventHandler(this.bn_ApplyDrone1_Click);
            // 
            // tB_DroneCurrent1
            // 
            this.tB_DroneCurrent1.Location = new System.Drawing.Point(50, 115);
            this.tB_DroneCurrent1.Name = "tB_DroneCurrent1";
            this.tB_DroneCurrent1.ReadOnly = true;
            this.tB_DroneCurrent1.Size = new System.Drawing.Size(73, 20);
            this.tB_DroneCurrent1.TabIndex = 3;
            // 
            // tB_DroneUser2
            // 
            this.tB_DroneUser2.Location = new System.Drawing.Point(128, 144);
            this.tB_DroneUser2.Name = "tB_DroneUser2";
            this.tB_DroneUser2.Size = new System.Drawing.Size(73, 20);
            this.tB_DroneUser2.TabIndex = 24;
            // 
            // bn_ApplyDrone2
            // 
            this.bn_ApplyDrone2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyDrone2.Location = new System.Drawing.Point(207, 142);
            this.bn_ApplyDrone2.Name = "bn_ApplyDrone2";
            this.bn_ApplyDrone2.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyDrone2.TabIndex = 34;
            this.bn_ApplyDrone2.Text = "Apply";
            this.bn_ApplyDrone2.UseVisualStyleBackColor = true;
            this.bn_ApplyDrone2.Click += new System.EventHandler(this.bn_ApplyDrone2_Click);
            // 
            // tB_DroneCurrent2
            // 
            this.tB_DroneCurrent2.Location = new System.Drawing.Point(50, 144);
            this.tB_DroneCurrent2.Name = "tB_DroneCurrent2";
            this.tB_DroneCurrent2.ReadOnly = true;
            this.tB_DroneCurrent2.Size = new System.Drawing.Size(73, 20);
            this.tB_DroneCurrent2.TabIndex = 4;
            // 
            // tB_MissUser2
            // 
            this.tB_MissUser2.Location = new System.Drawing.Point(128, 86);
            this.tB_MissUser2.Name = "tB_MissUser2";
            this.tB_MissUser2.Size = new System.Drawing.Size(73, 20);
            this.tB_MissUser2.TabIndex = 22;
            // 
            // bn_ApplyMiss2
            // 
            this.bn_ApplyMiss2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyMiss2.Location = new System.Drawing.Point(207, 84);
            this.bn_ApplyMiss2.Name = "bn_ApplyMiss2";
            this.bn_ApplyMiss2.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyMiss2.TabIndex = 32;
            this.bn_ApplyMiss2.Text = "Apply";
            this.bn_ApplyMiss2.UseVisualStyleBackColor = true;
            this.bn_ApplyMiss2.Click += new System.EventHandler(this.bn_ApplyMiss2_Click);
            // 
            // tB_MissCurrent2
            // 
            this.tB_MissCurrent2.Location = new System.Drawing.Point(50, 86);
            this.tB_MissCurrent2.Name = "tB_MissCurrent2";
            this.tB_MissCurrent2.ReadOnly = true;
            this.tB_MissCurrent2.Size = new System.Drawing.Size(73, 20);
            this.tB_MissCurrent2.TabIndex = 2;
            // 
            // tB_EnergyUser
            // 
            this.tB_EnergyUser.Location = new System.Drawing.Point(127, 202);
            this.tB_EnergyUser.Name = "tB_EnergyUser";
            this.tB_EnergyUser.Size = new System.Drawing.Size(73, 20);
            this.tB_EnergyUser.TabIndex = 26;
            // 
            // bn_ApplyEnergy
            // 
            this.bn_ApplyEnergy.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyEnergy.Location = new System.Drawing.Point(206, 200);
            this.bn_ApplyEnergy.Name = "bn_ApplyEnergy";
            this.bn_ApplyEnergy.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyEnergy.TabIndex = 36;
            this.bn_ApplyEnergy.Text = "Apply";
            this.bn_ApplyEnergy.UseVisualStyleBackColor = true;
            this.bn_ApplyEnergy.Click += new System.EventHandler(this.bn_ApplyEnergy_Click);
            // 
            // tB_EnergyCurrent
            // 
            this.tB_EnergyCurrent.Location = new System.Drawing.Point(49, 202);
            this.tB_EnergyCurrent.Name = "tB_EnergyCurrent";
            this.tB_EnergyCurrent.ReadOnly = true;
            this.tB_EnergyCurrent.Size = new System.Drawing.Size(73, 20);
            this.tB_EnergyCurrent.TabIndex = 6;
            // 
            // tB_ScrapUser
            // 
            this.tB_ScrapUser.Location = new System.Drawing.Point(127, 231);
            this.tB_ScrapUser.Name = "tB_ScrapUser";
            this.tB_ScrapUser.Size = new System.Drawing.Size(73, 20);
            this.tB_ScrapUser.TabIndex = 27;
            // 
            // bn_ApplyScrap
            // 
            this.bn_ApplyScrap.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyScrap.Location = new System.Drawing.Point(206, 229);
            this.bn_ApplyScrap.Name = "bn_ApplyScrap";
            this.bn_ApplyScrap.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyScrap.TabIndex = 37;
            this.bn_ApplyScrap.Text = "Apply";
            this.bn_ApplyScrap.UseVisualStyleBackColor = true;
            this.bn_ApplyScrap.Click += new System.EventHandler(this.bn_ApplyScrap_Click);
            // 
            // tB_ScrapCurrent
            // 
            this.tB_ScrapCurrent.Location = new System.Drawing.Point(49, 231);
            this.tB_ScrapCurrent.Name = "tB_ScrapCurrent";
            this.tB_ScrapCurrent.ReadOnly = true;
            this.tB_ScrapCurrent.Size = new System.Drawing.Size(73, 20);
            this.tB_ScrapCurrent.TabIndex = 7;
            // 
            // bn_ApplyAll
            // 
            this.bn_ApplyAll.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyAll.Location = new System.Drawing.Point(207, 268);
            this.bn_ApplyAll.Name = "bn_ApplyAll";
            this.bn_ApplyAll.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyAll.TabIndex = 28;
            this.bn_ApplyAll.Text = "Apply All";
            this.bn_ApplyAll.UseVisualStyleBackColor = true;
            this.bn_ApplyAll.Click += new System.EventHandler(this.bn_ApplyAll_Click);
            // 
            // bn_Exit
            // 
            this.bn_Exit.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_Exit.Location = new System.Drawing.Point(12, 276);
            this.bn_Exit.Name = "bn_Exit";
            this.bn_Exit.Size = new System.Drawing.Size(111, 23);
            this.bn_Exit.TabIndex = 29;
            this.bn_Exit.Text = "Exit";
            this.bn_Exit.UseVisualStyleBackColor = true;
            this.bn_Exit.Click += new System.EventHandler(this.bn_Exit_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FTL_Trainer.Properties.Resources.Scrap;
            this.pictureBox7.Location = new System.Drawing.Point(8, 225);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FTL_Trainer.Properties.Resources.Energy;
            this.pictureBox6.Location = new System.Drawing.Point(11, 196);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FTL_Trainer.Properties.Resources.Miss;
            this.pictureBox5.Location = new System.Drawing.Point(16, 80);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FTL_Trainer.Properties.Resources.Drone;
            this.pictureBox4.Location = new System.Drawing.Point(16, 138);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FTL_Trainer.Properties.Resources.Drone;
            this.pictureBox3.Location = new System.Drawing.Point(16, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FTL_Trainer.Properties.Resources.Miss;
            this.pictureBox2.Location = new System.Drawing.Point(16, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FTL_Trainer.Properties.Resources.Fuel;
            this.pictureBox1.Location = new System.Drawing.Point(16, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timerProcess
            // 
            this.timerProcess.Interval = 300;
            this.timerProcess.Tick += new System.EventHandler(this.timerProcess_Tick);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Yellow;
            this.label_status.Location = new System.Drawing.Point(187, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(102, 13);
            this.label_status.TabIndex = 32;
            this.label_status.Text = "Wait for the Game :)";
            // 
            // timerRead
            // 
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::FTL_Trainer.Properties.Resources.Health;
            this.pictureBox8.Location = new System.Drawing.Point(15, 167);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 36;
            this.pictureBox8.TabStop = false;
            // 
            // tB_HealthUser
            // 
            this.tB_HealthUser.Location = new System.Drawing.Point(127, 173);
            this.tB_HealthUser.Name = "tB_HealthUser";
            this.tB_HealthUser.Size = new System.Drawing.Size(73, 20);
            this.tB_HealthUser.TabIndex = 25;
            // 
            // bn_ApplyHealth
            // 
            this.bn_ApplyHealth.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ApplyHealth.Location = new System.Drawing.Point(206, 171);
            this.bn_ApplyHealth.Name = "bn_ApplyHealth";
            this.bn_ApplyHealth.Size = new System.Drawing.Size(76, 23);
            this.bn_ApplyHealth.TabIndex = 35;
            this.bn_ApplyHealth.Text = "Apply";
            this.bn_ApplyHealth.UseVisualStyleBackColor = true;
            this.bn_ApplyHealth.Click += new System.EventHandler(this.bn_ApplyHealth_Click);
            // 
            // tB_HealthCurrent
            // 
            this.tB_HealthCurrent.Location = new System.Drawing.Point(49, 173);
            this.tB_HealthCurrent.Name = "tB_HealthCurrent";
            this.tB_HealthCurrent.ReadOnly = true;
            this.tB_HealthCurrent.Size = new System.Drawing.Size(73, 20);
            this.tB_HealthCurrent.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FTL_Trainer.Properties.Resources.BackImage;
            this.ClientSize = new System.Drawing.Size(294, 311);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.tB_HealthUser);
            this.Controls.Add(this.bn_ApplyHealth);
            this.Controls.Add(this.tB_HealthCurrent);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.bn_Exit);
            this.Controls.Add(this.bn_ApplyAll);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.tB_ScrapUser);
            this.Controls.Add(this.bn_ApplyScrap);
            this.Controls.Add(this.tB_ScrapCurrent);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tB_EnergyUser);
            this.Controls.Add(this.bn_ApplyEnergy);
            this.Controls.Add(this.tB_EnergyCurrent);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tB_MissUser2);
            this.Controls.Add(this.bn_ApplyMiss2);
            this.Controls.Add(this.tB_MissCurrent2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tB_DroneUser2);
            this.Controls.Add(this.bn_ApplyDrone2);
            this.Controls.Add(this.tB_DroneCurrent2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tB_DroneUser1);
            this.Controls.Add(this.bn_ApplyDrone1);
            this.Controls.Add(this.tB_DroneCurrent1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tB_MissUser1);
            this.Controls.Add(this.bn_ApplyMiss1);
            this.Controls.Add(this.tB_MissCurrent1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_FuelUser);
            this.Controls.Add(this.bn_ApplyFuel);
            this.Controls.Add(this.tB_FuelCurrent);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_FuelCurrent;
        private System.Windows.Forms.Button bn_ApplyFuel;
        private System.Windows.Forms.TextBox tB_FuelUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tB_MissUser1;
        private System.Windows.Forms.Button bn_ApplyMiss1;
        private System.Windows.Forms.TextBox tB_MissCurrent1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tB_DroneUser1;
        private System.Windows.Forms.Button bn_ApplyDrone1;
        private System.Windows.Forms.TextBox tB_DroneCurrent1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tB_DroneUser2;
        private System.Windows.Forms.Button bn_ApplyDrone2;
        private System.Windows.Forms.TextBox tB_DroneCurrent2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tB_MissUser2;
        private System.Windows.Forms.Button bn_ApplyMiss2;
        private System.Windows.Forms.TextBox tB_MissCurrent2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tB_EnergyUser;
        private System.Windows.Forms.Button bn_ApplyEnergy;
        private System.Windows.Forms.TextBox tB_EnergyCurrent;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox tB_ScrapUser;
        private System.Windows.Forms.Button bn_ApplyScrap;
        private System.Windows.Forms.TextBox tB_ScrapCurrent;
        private System.Windows.Forms.Button bn_ApplyAll;
        private System.Windows.Forms.Button bn_Exit;
        private System.Windows.Forms.Timer timerProcess;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox tB_HealthUser;
        private System.Windows.Forms.Button bn_ApplyHealth;
        private System.Windows.Forms.TextBox tB_HealthCurrent;
    }
}

