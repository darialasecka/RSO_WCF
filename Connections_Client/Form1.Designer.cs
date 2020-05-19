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
            this.SuspendLayout();
            // 
            // startCityInput
            // 
            this.startCityInput.Location = new System.Drawing.Point(67, 50);
            this.startCityInput.Name = "startCityInput";
            this.startCityInput.Size = new System.Drawing.Size(100, 22);
            this.startCityInput.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(326, 242);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(51, 17);
            this.Output.TabIndex = 1;
            this.Output.Text = "Output";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(67, 179);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // endCityInput
            // 
            this.endCityInput.Location = new System.Drawing.Point(67, 94);
            this.endCityInput.Name = "endCityInput";
            this.endCityInput.Size = new System.Drawing.Size(100, 22);
            this.endCityInput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

