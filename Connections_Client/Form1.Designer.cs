namespace Connections_Client
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
            this.startCityInput = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.endCityInput = new System.Windows.Forms.TextBox();
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ArrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ArrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startCityInput
            // 
            this.startCityInput.Location = new System.Drawing.Point(97, 50);
            this.startCityInput.Name = "startCityInput";
            this.startCityInput.Size = new System.Drawing.Size(175, 22);
            this.startCityInput.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(342, 300);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(51, 17);
            this.Output.TabIndex = 1;
            this.Output.Text = "Output";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(332, 183);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // endCityInput
            // 
            this.endCityInput.Location = new System.Drawing.Point(97, 94);
            this.endCityInput.Name = "endCityInput";
            this.endCityInput.Size = new System.Drawing.Size(175, 22);
            this.endCityInput.TabIndex = 3;
            // 
            // DepartureDatePicker
            // 
            this.DepartureDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureDatePicker.Location = new System.Drawing.Point(513, 50);
            this.DepartureDatePicker.Name = "DepartureDatePicker";
            this.DepartureDatePicker.Size = new System.Drawing.Size(126, 22);
            this.DepartureDatePicker.TabIndex = 4;
            // 
            // ArrivalDatePicker
            // 
            this.ArrivalDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ArrivalDatePicker.Location = new System.Drawing.Point(513, 94);
            this.ArrivalDatePicker.Name = "ArrivalDatePicker";
            this.ArrivalDatePicker.Size = new System.Drawing.Size(126, 22);
            this.ArrivalDatePicker.TabIndex = 5;
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DepartureTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DepartureTimePicker.Location = new System.Drawing.Point(645, 50);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.ShowUpDown = true;
            this.DepartureTimePicker.Size = new System.Drawing.Size(109, 22);
            this.DepartureTimePicker.TabIndex = 6;
            // 
            // ArrivalTimePicker
            // 
            this.ArrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ArrivalTimePicker.Location = new System.Drawing.Point(645, 94);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.ShowUpDown = true;
            this.ArrivalTimePicker.Size = new System.Drawing.Size(109, 22);
            this.ArrivalTimePicker.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Departure time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Arrival Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArrivalTimePicker);
            this.Controls.Add(this.DepartureTimePicker);
            this.Controls.Add(this.ArrivalDatePicker);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.endCityInput);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.startCityInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startCityInput;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox endCityInput;
        private System.Windows.Forms.DateTimePicker DepartureDatePicker;
        private System.Windows.Forms.DateTimePicker ArrivalDatePicker;
        private System.Windows.Forms.DateTimePicker DepartureTimePicker;
        private System.Windows.Forms.DateTimePicker ArrivalTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

