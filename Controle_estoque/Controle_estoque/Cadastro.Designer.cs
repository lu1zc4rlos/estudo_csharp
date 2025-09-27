namespace Controle_estoque {
    partial class Cadastro {
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
            txtQuantidade = new TextBox();
            label3 = new Label();
            txtPreco = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(269, 253);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 13;
            button1.Text = "Cadastrar produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(269, 196);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(160, 27);
            txtQuantidade.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 203);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 11;
            label3.Text = "Quantidade:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(269, 137);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(160, 27);
            txtPreco.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 144);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 9;
            label2.Text = "Preço do produto:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(269, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(265, 27);
            txtNome.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 87);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome do produto:";
            // 
            // button2
            // 
            button2.Location = new Point(234, 288);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 14;
            button2.Text = "Voltar para tela principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 365);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtQuantidade);
            Controls.Add(label3);
            Controls.Add(txtPreco);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtQuantidade;
        private Label label3;
        private TextBox txtPreco;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Button button2;
    }
}