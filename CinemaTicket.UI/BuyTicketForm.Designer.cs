
namespace CinemaTicket.UI
{
    partial class BuyTicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.lblTicketHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnInc = new System.Windows.Forms.Button();
            this.tbTicketUnit = new System.Windows.Forms.TextBox();
            this.btnDecr = new System.Windows.Forms.Button();
            this.lblTicketUnit = new System.Windows.Forms.Label();
            this.cbTicketSession = new System.Windows.Forms.ComboBox();
            this.lblTicketSession = new System.Windows.Forms.Label();
            this.cbTicketSalon = new System.Windows.Forms.ComboBox();
            this.lblTicketSalon = new System.Windows.Forms.Label();
            this.tbTicketFilm = new System.Windows.Forms.TextBox();
            this.lblTicketFilm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnCloseTicket);
            this.panel1.Controls.Add(this.lblTicketHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.FlatAppearance.BorderSize = 0;
            this.btnCloseTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTicket.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseTicket.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCloseTicket.Location = new System.Drawing.Point(823, 15);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(25, 25);
            this.btnCloseTicket.TabIndex = 0;
            this.btnCloseTicket.Text = "X";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // lblTicketHeader
            // 
            this.lblTicketHeader.AutoSize = true;
            this.lblTicketHeader.Font = new System.Drawing.Font("LG Display-Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketHeader.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTicketHeader.Location = new System.Drawing.Point(15, 13);
            this.lblTicketHeader.Name = "lblTicketHeader";
            this.lblTicketHeader.Size = new System.Drawing.Size(102, 25);
            this.lblTicketHeader.TabIndex = 0;
            this.lblTicketHeader.Text = "Buy Ticket";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.btnInc);
            this.panel2.Controls.Add(this.tbTicketUnit);
            this.panel2.Controls.Add(this.btnDecr);
            this.panel2.Controls.Add(this.lblTicketUnit);
            this.panel2.Controls.Add(this.cbTicketSession);
            this.panel2.Controls.Add(this.lblTicketSession);
            this.panel2.Controls.Add(this.cbTicketSalon);
            this.panel2.Controls.Add(this.lblTicketSalon);
            this.panel2.Controls.Add(this.tbTicketFilm);
            this.panel2.Controls.Add(this.lblTicketFilm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 411);
            this.panel2.TabIndex = 1;
            // 
            // btnBuy
            // 
            this.btnBuy.FlatAppearance.BorderSize = 2;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("LG Display-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuy.Location = new System.Drawing.Point(533, 355);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(315, 44);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("LG Display-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrice.Location = new System.Drawing.Point(15, 359);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 28);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price ...₺";
            // 
            // btnInc
            // 
            this.btnInc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInc.FlatAppearance.BorderSize = 0;
            this.btnInc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInc.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInc.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnInc.Location = new System.Drawing.Point(364, 167);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(35, 35);
            this.btnInc.TabIndex = 9;
            this.btnInc.Text = "+";
            this.btnInc.UseVisualStyleBackColor = false;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // tbTicketUnit
            // 
            this.tbTicketUnit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbTicketUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTicketUnit.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTicketUnit.ForeColor = System.Drawing.Color.DarkOrange;
            this.tbTicketUnit.Location = new System.Drawing.Point(128, 173);
            this.tbTicketUnit.Name = "tbTicketUnit";
            this.tbTicketUnit.ReadOnly = true;
            this.tbTicketUnit.Size = new System.Drawing.Size(230, 26);
            this.tbTicketUnit.TabIndex = 8;
            this.tbTicketUnit.Text = "1";
            this.tbTicketUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDecr
            // 
            this.btnDecr.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDecr.FlatAppearance.BorderSize = 0;
            this.btnDecr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecr.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecr.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDecr.Location = new System.Drawing.Point(87, 167);
            this.btnDecr.Name = "btnDecr";
            this.btnDecr.Size = new System.Drawing.Size(35, 35);
            this.btnDecr.TabIndex = 7;
            this.btnDecr.Text = "-";
            this.btnDecr.UseVisualStyleBackColor = false;
            this.btnDecr.Click += new System.EventHandler(this.btnDecr_Click);
            // 
            // lblTicketUnit
            // 
            this.lblTicketUnit.AutoSize = true;
            this.lblTicketUnit.Font = new System.Drawing.Font("LG Display-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketUnit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTicketUnit.Location = new System.Drawing.Point(16, 178);
            this.lblTicketUnit.Name = "lblTicketUnit";
            this.lblTicketUnit.Size = new System.Drawing.Size(64, 15);
            this.lblTicketUnit.TabIndex = 6;
            this.lblTicketUnit.Text = "Ticket Unit";
            // 
            // cbTicketSession
            // 
            this.cbTicketSession.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbTicketSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTicketSession.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTicketSession.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbTicketSession.FormattingEnabled = true;
            this.cbTicketSession.Location = new System.Drawing.Point(533, 172);
            this.cbTicketSession.Name = "cbTicketSession";
            this.cbTicketSession.Size = new System.Drawing.Size(315, 27);
            this.cbTicketSession.TabIndex = 5;
            // 
            // lblTicketSession
            // 
            this.lblTicketSession.AutoSize = true;
            this.lblTicketSession.Font = new System.Drawing.Font("LG Display-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketSession.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTicketSession.Location = new System.Drawing.Point(466, 178);
            this.lblTicketSession.Name = "lblTicketSession";
            this.lblTicketSession.Size = new System.Drawing.Size(48, 15);
            this.lblTicketSession.TabIndex = 4;
            this.lblTicketSession.Text = "Session";
            // 
            // cbTicketSalon
            // 
            this.cbTicketSalon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbTicketSalon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTicketSalon.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTicketSalon.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbTicketSalon.FormattingEnabled = true;
            this.cbTicketSalon.Location = new System.Drawing.Point(533, 31);
            this.cbTicketSalon.Name = "cbTicketSalon";
            this.cbTicketSalon.Size = new System.Drawing.Size(315, 27);
            this.cbTicketSalon.TabIndex = 3;
            this.cbTicketSalon.SelectedIndexChanged += new System.EventHandler(this.cbTicketSalon_SelectedIndexChanged);
            // 
            // lblTicketSalon
            // 
            this.lblTicketSalon.AutoSize = true;
            this.lblTicketSalon.Font = new System.Drawing.Font("LG Display-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketSalon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTicketSalon.Location = new System.Drawing.Point(466, 37);
            this.lblTicketSalon.Name = "lblTicketSalon";
            this.lblTicketSalon.Size = new System.Drawing.Size(36, 15);
            this.lblTicketSalon.TabIndex = 2;
            this.lblTicketSalon.Text = "Salon";
            // 
            // tbTicketFilm
            // 
            this.tbTicketFilm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbTicketFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTicketFilm.Font = new System.Drawing.Font("LG Display-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTicketFilm.ForeColor = System.Drawing.Color.DarkOrange;
            this.tbTicketFilm.Location = new System.Drawing.Point(85, 32);
            this.tbTicketFilm.Name = "tbTicketFilm";
            this.tbTicketFilm.ReadOnly = true;
            this.tbTicketFilm.Size = new System.Drawing.Size(317, 26);
            this.tbTicketFilm.TabIndex = 1;
            // 
            // lblTicketFilm
            // 
            this.lblTicketFilm.AutoSize = true;
            this.lblTicketFilm.Font = new System.Drawing.Font("LG Display-Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketFilm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTicketFilm.Location = new System.Drawing.Point(16, 37);
            this.lblTicketFilm.Name = "lblTicketFilm";
            this.lblTicketFilm.Size = new System.Drawing.Size(63, 15);
            this.lblTicketFilm.TabIndex = 0;
            this.lblTicketFilm.Text = "Film Name";
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyTicketForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.Label lblTicketHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTicketSession;
        private System.Windows.Forms.Label lblTicketSession;
        private System.Windows.Forms.ComboBox cbTicketSalon;
        private System.Windows.Forms.Label lblTicketSalon;
        private System.Windows.Forms.TextBox tbTicketFilm;
        private System.Windows.Forms.Label lblTicketFilm;
        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.TextBox tbTicketUnit;
        private System.Windows.Forms.Button btnDecr;
        private System.Windows.Forms.Label lblTicketUnit;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblPrice;
    }
}