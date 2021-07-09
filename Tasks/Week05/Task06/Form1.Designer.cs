
namespace Task06
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
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxKuza = new System.Windows.Forms.ComboBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.comboBoxMotor = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelKuza = new System.Windows.Forms.Label();
            this.labelMotor = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.listViewCar = new System.Windows.Forms.ListView();
            this.columnHeaderBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFuel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKuza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMotor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadeColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "BMW",
            "Mercedes",
            "Audi"});
            this.comboBoxBrand.Location = new System.Drawing.Point(105, 31);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBrand.TabIndex = 0;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // comboBoxKuza
            // 
            this.comboBoxKuza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKuza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKuza.FormattingEnabled = true;
            this.comboBoxKuza.Items.AddRange(new object[] {
            "Kuza1",
            "Kuza2",
            "Kuza3"});
            this.comboBoxKuza.Location = new System.Drawing.Point(105, 221);
            this.comboBoxKuza.Name = "comboBoxKuza";
            this.comboBoxKuza.Size = new System.Drawing.Size(121, 26);
            this.comboBoxKuza.TabIndex = 1;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "Fuel1",
            "Fuel2",
            "Fuel3"});
            this.comboBoxFuel.Location = new System.Drawing.Point(105, 156);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(121, 26);
            this.comboBoxFuel.TabIndex = 2;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(105, 96);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 26);
            this.comboBoxModel.TabIndex = 3;
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "Speed1",
            "Speed2",
            "Speed3"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(105, 278);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(121, 26);
            this.comboBoxSpeed.TabIndex = 4;
            // 
            // comboBoxMotor
            // 
            this.comboBoxMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMotor.FormattingEnabled = true;
            this.comboBoxMotor.Items.AddRange(new object[] {
            "Motor1",
            "Motor2",
            "Motor3"});
            this.comboBoxMotor.Location = new System.Drawing.Point(105, 340);
            this.comboBoxMotor.Name = "comboBoxMotor";
            this.comboBoxMotor.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMotor.TabIndex = 5;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(53, 39);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(47, 18);
            this.labelBrand.TabIndex = 6;
            this.labelBrand.Text = "Brand";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(49, 99);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 18);
            this.labelModel.TabIndex = 7;
            this.labelModel.Text = "Model";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuel.Location = new System.Drawing.Point(27, 159);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(72, 18);
            this.labelFuel.TabIndex = 8;
            this.labelFuel.Text = "Fuel Type";
            // 
            // labelKuza
            // 
            this.labelKuza.AutoSize = true;
            this.labelKuza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKuza.Location = new System.Drawing.Point(27, 224);
            this.labelKuza.Name = "labelKuza";
            this.labelKuza.Size = new System.Drawing.Size(78, 18);
            this.labelKuza.TabIndex = 9;
            this.labelKuza.Text = "Kuza Type";
            // 
            // labelMotor
            // 
            this.labelMotor.AutoSize = true;
            this.labelMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotor.Location = new System.Drawing.Point(49, 343);
            this.labelMotor.Name = "labelMotor";
            this.labelMotor.Size = new System.Drawing.Size(48, 18);
            this.labelMotor.TabIndex = 10;
            this.labelMotor.Text = "Motor";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(49, 281);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(50, 18);
            this.labelSpeed.TabIndex = 11;
            this.labelSpeed.Text = "Speed";
            // 
            // listViewCar
            // 
            this.listViewCar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBrand,
            this.columnHeaderModel,
            this.columnHeaderFuel,
            this.columnHeaderKuza,
            this.columnHeaderSpeed,
            this.columnHeaderMotor,
            this.columnHeadeColor,
            this.columnHeaderDate});
            this.listViewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCar.HideSelection = false;
            this.listViewCar.Location = new System.Drawing.Point(285, 99);
            this.listViewCar.Name = "listViewCar";
            this.listViewCar.Size = new System.Drawing.Size(490, 208);
            this.listViewCar.TabIndex = 12;
            this.listViewCar.UseCompatibleStateImageBehavior = false;
            this.listViewCar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBrand
            // 
            this.columnHeaderBrand.Text = "Brand";
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Model";
            // 
            // columnHeaderFuel
            // 
            this.columnHeaderFuel.Text = "Fuel";
            // 
            // columnHeaderKuza
            // 
            this.columnHeaderKuza.Text = "Kuza";
            // 
            // columnHeaderSpeed
            // 
            this.columnHeaderSpeed.Text = "Speed";
            // 
            // columnHeaderMotor
            // 
            this.columnHeaderMotor.Text = "Motor";
            // 
            // columnHeadeColor
            // 
            this.columnHeadeColor.Text = "Color";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(409, 37);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 13;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(678, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 46);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Color";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(509, 41);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.listViewCar);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelMotor);
            this.Controls.Add(this.labelKuza);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.comboBoxMotor);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxFuel);
            this.Controls.Add(this.comboBoxKuza);
            this.Controls.Add(this.comboBoxBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxKuza;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.ComboBox comboBoxMotor;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelKuza;
        private System.Windows.Forms.Label labelMotor;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.ListView listViewCar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ColumnHeader columnHeaderBrand;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderFuel;
        private System.Windows.Forms.ColumnHeader columnHeaderKuza;
        private System.Windows.Forms.ColumnHeader columnHeaderSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderMotor;
        private System.Windows.Forms.ColumnHeader columnHeadeColor;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
    }
}

