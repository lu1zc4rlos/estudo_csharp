namespace Controle_estoque {
    partial class Retirar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button1 = new Button();
            txtRetirar = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(284, 179);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 11;
            button1.Text = "Retirar produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRetirar
            // 
            txtRetirar.Location = new Point(276, 126);
            txtRetirar.Name = "txtRetirar";
            txtRetirar.Size = new Size(160, 27);
            txtRetirar.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 133);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 9;
            label3.Text = "Quantidade a ser retirada:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(239, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(265, 27);
            txtNome.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 74);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome do produto:";
            // 
            // button2
            // 
            button2.Location = new Point(241, 214);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 15;
            button2.Text = "Voltar para tela principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Retirar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 274);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtRetirar);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Retirar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retirar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtRetirar;
        private Label label3;
        private TextBox txtNome;
        private Label label1;
        private Button button2;
    }
}