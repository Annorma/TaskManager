namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.tbNameProc = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.LisViewProcc = new System.Windows.Forms.ListView();
            this.btnStopProc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimeUp = new System.Windows.Forms.Button();
            this.btnUpdateListView = new System.Windows.Forms.Button();
            this.tbUpDown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNotepad
            // 
            this.btnNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNotepad.Location = new System.Drawing.Point(393, 21);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(108, 26);
            this.btnNotepad.TabIndex = 0;
            this.btnNotepad.Text = "Notepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(621, 21);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(108, 26);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaint.Location = new System.Drawing.Point(507, 21);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(108, 26);
            this.btnPaint.TabIndex = 2;
            this.btnPaint.Text = "MSPaint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbNameProc
            // 
            this.tbNameProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameProc.Location = new System.Drawing.Point(163, 22);
            this.tbNameProc.Name = "tbNameProc";
            this.tbNameProc.Size = new System.Drawing.Size(199, 26);
            this.tbNameProc.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(163, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(199, 26);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btn_Click);
            // 
            // LisViewProcc
            // 
            this.LisViewProcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LisViewProcc.HideSelection = false;
            this.LisViewProcc.Location = new System.Drawing.Point(16, 91);
            this.LisViewProcc.Name = "LisViewProcc";
            this.LisViewProcc.Size = new System.Drawing.Size(1161, 560);
            this.LisViewProcc.TabIndex = 5;
            this.LisViewProcc.UseCompatibleStateImageBehavior = false;
            this.LisViewProcc.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // btnStopProc
            // 
            this.btnStopProc.Enabled = false;
            this.btnStopProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopProc.ForeColor = System.Drawing.Color.Black;
            this.btnStopProc.Location = new System.Drawing.Point(1020, 53);
            this.btnStopProc.Name = "btnStopProc";
            this.btnStopProc.Size = new System.Drawing.Size(108, 26);
            this.btnStopProc.TabIndex = 6;
            this.btnStopProc.Text = "End process";
            this.btnStopProc.UseVisualStyleBackColor = true;
            this.btnStopProc.Click += new System.EventHandler(this.btnStopProc_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimeUp
            // 
            this.btnTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimeUp.Location = new System.Drawing.Point(17, 54);
            this.btnTimeUp.Name = "btnTimeUp";
            this.btnTimeUp.Size = new System.Drawing.Size(57, 26);
            this.btnTimeUp.TabIndex = 9;
            this.btnTimeUp.Text = "Confirm";
            this.btnTimeUp.UseVisualStyleBackColor = true;
            this.btnTimeUp.Click += new System.EventHandler(this.btnTimeUp_Click);
            // 
            // btnUpdateListView
            // 
            this.btnUpdateListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateListView.Location = new System.Drawing.Point(1020, 22);
            this.btnUpdateListView.Name = "btnUpdateListView";
            this.btnUpdateListView.Size = new System.Drawing.Size(108, 26);
            this.btnUpdateListView.TabIndex = 10;
            this.btnUpdateListView.Text = "Update";
            this.btnUpdateListView.UseVisualStyleBackColor = true;
            this.btnUpdateListView.Click += new System.EventHandler(this.btnUpdateListView_Click);
            // 
            // tbUpDown
            // 
            this.tbUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUpDown.Location = new System.Drawing.Point(17, 22);
            this.tbUpDown.Name = "tbUpDown";
            this.tbUpDown.Size = new System.Drawing.Size(56, 26);
            this.tbUpDown.TabIndex = 11;
            this.tbUpDown.Text = "15";
            this.tbUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "sec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1189, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUpDown);
            this.Controls.Add(this.btnUpdateListView);
            this.Controls.Add(this.btnTimeUp);
            this.Controls.Add(this.btnStopProc);
            this.Controls.Add(this.LisViewProcc);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbNameProc);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnNotepad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.TextBox tbNameProc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStopProc;
        protected System.Windows.Forms.ListView LisViewProcc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTimeUp;
        private System.Windows.Forms.Button btnUpdateListView;
        private System.Windows.Forms.TextBox tbUpDown;
        private System.Windows.Forms.Label label1;
    }
}

