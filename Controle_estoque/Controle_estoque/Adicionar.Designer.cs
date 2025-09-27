namespace Controle_estoque {
    partial class Adicionar {
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
            label1 = new Label();
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 60);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(206, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(265, 27);
            txtNome.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(243, 112);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(160, 27);
            txtQuantidade.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 119);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantidade a ser adicionada:";
            // 
            // button1
            // 
            button1.Location = new Point(251, 165);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 6;
            button1.Text = "Adicionar produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(206, 213);
            button2.Name = "button2";
            button2.Size = new Size(195, 29);
            button2.TabIndex = 7;
            button2.Text = "Voltar para tela principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Adicionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 286);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtQuantidade);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Adicionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}