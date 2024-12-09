namespace Library
{
    partial class LibraryForm
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
            bookName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            authorName = new TextBox();
            bookGenre = new TextBox();
            bookYearPublished = new TextBox();
            buttonSave = new Button();
            buttonDelete = new Button();
            bookList = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 55);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Name:";
            // 
            // bookName
            // 
            bookName.Location = new Point(139, 52);
            bookName.Name = "bookName";
            bookName.Size = new Size(176, 23);
            bookName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 111);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "Author Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 161);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 211);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 0;
            label4.Text = "Year Published: ";
            // 
            // authorName
            // 
            authorName.Location = new Point(139, 108);
            authorName.Name = "authorName";
            authorName.Size = new Size(176, 23);
            authorName.TabIndex = 1;
            // 
            // bookGenre
            // 
            bookGenre.Location = new Point(139, 158);
            bookGenre.Name = "bookGenre";
            bookGenre.Size = new Size(176, 23);
            bookGenre.TabIndex = 1;
            // 
            // bookYearPublished
            // 
            bookYearPublished.Location = new Point(139, 208);
            bookYearPublished.Name = "bookYearPublished";
            bookYearPublished.Size = new Size(176, 23);
            bookYearPublished.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(38, 300);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(104, 41);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(211, 300);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(104, 41);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // bookList
            // 
            bookList.FormattingEnabled = true;
            bookList.ItemHeight = 15;
            bookList.Location = new Point(369, 52);
            bookList.Name = "bookList";
            bookList.Size = new Size(289, 289);
            bookList.TabIndex = 3;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 387);
            Controls.Add(bookList);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(bookYearPublished);
            Controls.Add(bookGenre);
            Controls.Add(authorName);
            Controls.Add(bookName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LibraryForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private TextBox bookName;
        private TextBox authorName;
        private TextBox bookGenre;
        private TextBox bookYearPublished;
        private Button buttonSave;
        private Button buttonDelete;
        private ListBox bookList;
    }
}
