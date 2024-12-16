
namespace task12._12
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
            dgv = new DataGridView();
            name_tb = new TextBox();
            desc_tb = new TextBox();
            cat_tb = new TextBox();
            insert_btn = new Button();
            update_btn = new Button();
            clear_btn = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(377, 12);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(427, 447);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // name_tb
            // 
            name_tb.Location = new Point(53, 32);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(125, 27);
            name_tb.TabIndex = 1;
            // 
            // desc_tb
            // 
            desc_tb.Location = new Point(53, 85);
            desc_tb.Name = "desc_tb";
            desc_tb.Size = new Size(125, 27);
            desc_tb.TabIndex = 2;
            desc_tb.TextChanged += textBox2_TextChanged;
            // 
            // cat_tb
            // 
            cat_tb.Location = new Point(53, 139);
            cat_tb.Name = "cat_tb";
            cat_tb.Size = new Size(125, 27);
            cat_tb.TabIndex = 3;
            // 
            // insert_btn
            // 
            insert_btn.Location = new Point(53, 227);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(94, 29);
            insert_btn.TabIndex = 4;
            insert_btn.Text = "button1";
            insert_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(183, 227);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(94, 29);
            update_btn.TabIndex = 5;
            update_btn.Text = "button2";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(53, 314);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(94, 29);
            clear_btn.TabIndex = 6;
            clear_btn.Text = "button3";
            clear_btn.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(183, 314);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 7;
            delete.Text = "button4";
            delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(clear_btn);
            Controls.Add(update_btn);
            Controls.Add(insert_btn);
            Controls.Add(cat_tb);
            Controls.Add(desc_tb);
            Controls.Add(name_tb);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgv;
        private TextBox name_tb;
        private TextBox desc_tb;
        private TextBox cat_tb;
        private Button insert_btn;
        private Button update_btn;
        private Button clear_btn;
        private Button delete;
    }
}
