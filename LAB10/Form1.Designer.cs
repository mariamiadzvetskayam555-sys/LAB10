namespace LAB10
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
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            comboBoxEvent = new ComboBox();
            radioButtonInPerson = new RadioButton();
            radioButtonInAbsentia = new RadioButton();
            checkBoxNotification = new CheckBox();
            buttonSend = new Button();
            labelResult = new Label();
            buttonDelete = new Button();
            labelName = new Label();
            labelAge = new Label();
            labelProject = new Label();
            labelForm = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.GhostWhite;
            textBoxName.Cursor = Cursors.Hand;
            textBoxName.Location = new Point(197, 54);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(259, 39);
            textBoxName.TabIndex = 0;
            // 
            // textBoxAge
            // 
            textBoxAge.BackColor = Color.GhostWhite;
            textBoxAge.Cursor = Cursors.Hand;
            textBoxAge.Location = new Point(239, 103);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(214, 39);
            textBoxAge.TabIndex = 1;
            // 
            // comboBoxEvent
            // 
            comboBoxEvent.BackColor = Color.Thistle;
            comboBoxEvent.Cursor = Cursors.Hand;
            comboBoxEvent.FormattingEnabled = true;
            comboBoxEvent.Location = new Point(32, 148);
            comboBoxEvent.Name = "comboBoxEvent";
            comboBoxEvent.Size = new Size(313, 40);
            comboBoxEvent.TabIndex = 2;
            comboBoxEvent.Text = "Выберите мероприятие";
            // 
            // radioButtonInPerson
            // 
            radioButtonInPerson.AutoSize = true;
            radioButtonInPerson.Cursor = Cursors.Hand;
            radioButtonInPerson.Location = new Point(361, 243);
            radioButtonInPerson.Name = "radioButtonInPerson";
            radioButtonInPerson.Size = new Size(114, 36);
            radioButtonInPerson.TabIndex = 3;
            radioButtonInPerson.TabStop = true;
            radioButtonInPerson.Text = "очное";
            radioButtonInPerson.UseVisualStyleBackColor = true;
            // 
            // radioButtonInAbsentia
            // 
            radioButtonInAbsentia.AutoSize = true;
            radioButtonInAbsentia.Cursor = Cursors.Hand;
            radioButtonInAbsentia.Location = new Point(361, 201);
            radioButtonInAbsentia.Name = "radioButtonInAbsentia";
            radioButtonInAbsentia.Size = new Size(137, 36);
            radioButtonInAbsentia.TabIndex = 4;
            radioButtonInAbsentia.TabStop = true;
            radioButtonInAbsentia.Text = "заочное";
            radioButtonInAbsentia.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotification
            // 
            checkBoxNotification.AutoSize = true;
            checkBoxNotification.Cursor = Cursors.Hand;
            checkBoxNotification.Location = new Point(32, 310);
            checkBoxNotification.Name = "checkBoxNotification";
            checkBoxNotification.Size = new Size(425, 36);
            checkBoxNotification.TabIndex = 5;
            checkBoxNotification.Text = "Согласны получать уведомления?";
            checkBoxNotification.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.Thistle;
            buttonSend.Cursor = Cursors.Hand;
            buttonSend.Location = new Point(24, 406);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(280, 46);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "Отправить анкету";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(24, 455);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(132, 32);
            labelResult.TabIndex = 7;
            labelResult.Text = "Результат: ";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.InactiveCaption;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Location = new Point(477, 406);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Очистить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Thistle;
            labelName.Location = new Point(32, 54);
            labelName.Name = "labelName";
            labelName.Size = new Size(159, 32);
            labelName.TabIndex = 9;
            labelName.Text = "Введите имя:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.BackColor = Color.Thistle;
            labelAge.Location = new Point(32, 103);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(201, 32);
            labelAge.TabIndex = 10;
            labelAge.Text = "Введите возраст:";
            // 
            // labelProject
            // 
            labelProject.AutoSize = true;
            labelProject.Font = new Font("Monotype Corsiva", 13.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelProject.ForeColor = Color.DeepPink;
            labelProject.Location = new Point(209, 6);
            labelProject.Name = "labelProject";
            labelProject.Size = new Size(484, 45);
            labelProject.TabIndex = 11;
            labelProject.Text = "Анкета участника мероприятия";
            // 
            // labelForm
            // 
            labelForm.AutoSize = true;
            labelForm.BackColor = Color.Thistle;
            labelForm.Location = new Point(32, 201);
            labelForm.Name = "labelForm";
            labelForm.Size = new Size(310, 32);
            labelForm.TabIndex = 12;
            labelForm.Text = "Выберите формат участия:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 561);
            Controls.Add(labelForm);
            Controls.Add(labelProject);
            Controls.Add(labelAge);
            Controls.Add(labelName);
            Controls.Add(buttonDelete);
            Controls.Add(labelResult);
            Controls.Add(buttonSend);
            Controls.Add(checkBoxNotification);
            Controls.Add(radioButtonInAbsentia);
            Controls.Add(radioButtonInPerson);
            Controls.Add(comboBoxEvent);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxAge;
        private ComboBox comboBoxEvent;
        private RadioButton radioButtonInPerson;
        private RadioButton radioButtonInAbsentia;
        private CheckBox checkBoxNotification;
        private Button buttonSend;
        private Label labelResult;
        private Button buttonDelete;
        private Label labelName;
        private Label labelAge;
        private Label labelProject;
        private Label labelForm;
    }
}
