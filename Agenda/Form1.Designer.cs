using System.ComponentModel;

namespace Agenda
{
    partial class Form1
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
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtTelefone = new MaskedTextBox();
            label3 = new Label();
            btInserir = new Button();
            btAlterar = new Button();
            btLocalizar = new Button();
            btExcluir = new Button();
            dGDados = new DataGridView();
            btNext = new Button();
            ((ISupportInitialize)dGDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(91, 12);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(122, 27);
            txtId.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 51);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(122, 27);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(91, 88);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(122, 27);
            txtTelefone.TabIndex = 5;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // btInserir
            // 
            btInserir.Font = new Font("Noto Sans JP", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInserir.ImageAlign = ContentAlignment.BottomLeft;
            btInserir.Location = new Point(18, 123);
            btInserir.Margin = new Padding(3, 4, 3, 4);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(93, 39);
            btInserir.TabIndex = 6;
            btInserir.Text = "Inserir";
            btInserir.UseVisualStyleBackColor = true;
            btInserir.Click += btInserir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Noto Sans JP", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.Location = new Point(17, 170);
            btAlterar.Margin = new Padding(3, 4, 3, 4);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(94, 39);
            btAlterar.TabIndex = 7;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btLocalizar
            // 
            btLocalizar.Font = new Font("Noto Sans JP", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLocalizar.Location = new Point(18, 217);
            btLocalizar.Margin = new Padding(3, 4, 3, 4);
            btLocalizar.Name = "btLocalizar";
            btLocalizar.Size = new Size(93, 39);
            btLocalizar.TabIndex = 8;
            btLocalizar.Text = "Localizar";
            btLocalizar.UseVisualStyleBackColor = true;
            btLocalizar.Click += btLocalizar_Click;
            // 
            // btExcluir
            // 
            btExcluir.DialogResult = DialogResult.Continue;
            btExcluir.Font = new Font("Noto Sans JP SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.Location = new Point(114, 123);
            btExcluir.Margin = new Padding(3, 4, 3, 4);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(99, 39);
            btExcluir.TabIndex = 9;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // dGDados
            // 
            dGDados.BackgroundColor = SystemColors.GradientActiveCaption;
            dGDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGDados.GridColor = Color.Black;
            dGDados.Location = new Point(219, 12);
            dGDados.Margin = new Padding(3, 4, 3, 4);
            dGDados.Name = "dGDados";
            dGDados.ReadOnly = true;
            dGDados.RowHeadersWidth = 51;
            dGDados.Size = new Size(423, 265);
            dGDados.TabIndex = 10;
            dGDados.CellClick += dGDados_CellClick;
            // 
            // btNext
            // 
            btNext.Font = new Font("Noto Sans JP", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNext.Location = new Point(114, 170);
            btNext.Margin = new Padding(3, 4, 3, 4);
            btNext.Name = "btNext";
            btNext.Size = new Size(99, 39);
            btNext.TabIndex = 11;
            btNext.Text = "Próxima";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 289);
            Controls.Add(btNext);
            Controls.Add(dGDados);
            Controls.Add(btExcluir);
            Controls.Add(btLocalizar);
            Controls.Add(btAlterar);
            Controls.Add(btInserir);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Agenda";
            Load += Form1_Load;
            ((ISupportInitialize)dGDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private MaskedTextBox txtTelefone;
        private Label label3;
        private Button btInserir;
        private Button btAlterar;
        private Button btLocalizar;
        private Button btExcluir;
        private DataGridView dGDados;
        private Button btNext;
    }
}
