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
            this.directLabel = new System.Windows.Forms.Label();
            this.showConnectionsButton = new System.Windows.Forms.Button();
            this.endCityInput = new System.Windows.Forms.TextBox();
            this.DepartureDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ArrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ArrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.indirecLabel = new System.Windows.Forms.Label();
            this.DirectListView = new System.Windows.Forms.ListView();
            this.chConnections = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndirectListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // startCityInput
            // 
            this.startCityInput.Location = new System.Drawing.Point(97, 50);
            this.startCityInput.Name = "startCityInput";
            this.startCityInput.Size = new System.Drawing.Size(175, 22);
            this.startCityInput.TabIndex = 0;
            // 
            // directLabel
            // 
            this.directLabel.AutoSize = true;
            this.directLabel.Location = new System.Drawing.Point(158, 199);
            this.directLabel.Name = "directLabel";
            this.directLabel.Size = new System.Drawing.Size(45, 17);
            this.directLabel.TabIndex = 1;
            this.directLabel.Text = "Direct";
            // 
            // showConnectionsButton
            // 
            this.showConnectionsButton.Location = new System.Drawing.Point(277, 141);
            this.showConnectionsButton.Name = "showConnectionsButton";
            this.showConnectionsButton.Size = new System.Drawing.Size(194, 41);
            this.showConnectionsButton.TabIndex = 2;
            this.showConnectionsButton.Text = "Show Connections";
            this.showConnectionsButton.UseVisualStyleBackColor = true;
            this.showConnectionsButton.Click += new System.EventHandler(this.ok_button_Click);
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
            this.DepartureDatePicker.Checked = false;
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
            this.ArrivalTimePicker.Checked = false;
            this.ArrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ArrivalTimePicker.Location = new System.Drawing.Point(645, 94);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.ShowUpDown = true;
            this.ArrivalTimePicker.Size = new System.Drawing.Size(109, 22);
            this.ArrivalTimePicker.TabIndex = 7;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(37, 54);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 17);
            this.fromLabel.TabIndex = 8;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(40, 98);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 9;
            this.toLabel.Text = "To:";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Location = new System.Drawing.Point(401, 50);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(106, 17);
            this.departureLabel.TabIndex = 10;
            this.departureLabel.Text = "Departure time:";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Location = new System.Drawing.Point(404, 94);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(87, 17);
            this.arrivalLabel.TabIndex = 11;
            this.arrivalLabel.Text = "Arrival Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(587, 13);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 17);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "Time";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(158, 13);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 16;
            this.cityLabel.Text = "City";
            // 
            // indirecLabel
            // 
            this.indirecLabel.AutoSize = true;
            this.indirecLabel.Location = new System.Drawing.Point(572, 199);
            this.indirecLabel.Name = "indirecLabel";
            this.indirecLabel.Size = new System.Drawing.Size(54, 17);
            this.indirecLabel.TabIndex = 18;
            this.indirecLabel.Text = "Indirect";
            // 
            // DirectListView
            // 
            this.DirectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chConnections});
            this.DirectListView.GridLines = true;
            this.DirectListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.DirectListView.HideSelection = false;
            this.DirectListView.Location = new System.Drawing.Point(12, 229);
            this.DirectListView.Name = "DirectListView";
            this.DirectListView.Size = new System.Drawing.Size(349, 196);
            this.DirectListView.TabIndex = 19;
            this.DirectListView.UseCompatibleStateImageBehavior = false;
            this.DirectListView.View = System.Windows.Forms.View.Details;
            // 
            // chConnections
            // 
            this.chConnections.Text = " ";
            this.chConnections.Width = 1000;
            // 
            // IndirectListView
            // 
            this.IndirectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.IndirectListView.GridLines = true;
            this.IndirectListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.IndirectListView.HideSelection = false;
            this.IndirectListView.Location = new System.Drawing.Point(426, 229);
            this.IndirectListView.Name = "IndirectListView";
            this.IndirectListView.Size = new System.Drawing.Size(349, 196);
            this.IndirectListView.TabIndex = 20;
            this.IndirectListView.UseCompatibleStateImageBehavior = false;
            this.IndirectListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IndirectListView);
            this.Controls.Add(this.DirectListView);
            this.Controls.Add(this.indirecLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.ArrivalTimePicker);
            this.Controls.Add(this.DepartureTimePicker);
            this.Controls.Add(this.ArrivalDatePicker);
            this.Controls.Add(this.DepartureDatePicker);
            this.Controls.Add(this.endCityInput);
            this.Controls.Add(this.showConnectionsButton);
            this.Controls.Add(this.directLabel);
            this.Controls.Add(this.startCityInput);
            this.Name = "Form1";
            this.Text = "Plane Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startCityInput;
        private System.Windows.Forms.Label directLabel;
        private System.Windows.Forms.Button showConnectionsButton;
        private System.Windows.Forms.TextBox endCityInput;
        private System.Windows.Forms.DateTimePicker DepartureDatePicker;
        private System.Windows.Forms.DateTimePicker ArrivalDatePicker;
        private System.Windows.Forms.DateTimePicker DepartureTimePicker;
        private System.Windows.Forms.DateTimePicker ArrivalTimePicker;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label indirecLabel;
        private System.Windows.Forms.ListView DirectListView;
        private System.Windows.Forms.ColumnHeader chConnections;
        private System.Windows.Forms.ListView IndirectListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

