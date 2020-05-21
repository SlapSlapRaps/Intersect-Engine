using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmMapType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapType));
            this.lblMapTypes = new System.Windows.Forms.Label();
            this.lstMapTypes = new System.Windows.Forms.TreeView();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChronological = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.chkWalkThroughPlayers = new System.Windows.Forms.CheckBox();
            this.chkAttackNpcs = new System.Windows.Forms.CheckBox();
            this.chkAttackPlayers = new System.Windows.Forms.CheckBox();
            this.chkDropItems = new System.Windows.Forms.CheckBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.scrlColor = new System.Windows.Forms.HScrollBar();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chkArena = new System.Windows.Forms.CheckBox();
            this.chkTrade = new System.Windows.Forms.CheckBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMapTypes
            // 
            this.lblMapTypes.AutoSize = true;
            this.lblMapTypes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMapTypes.Location = new System.Drawing.Point(11, 42);
            this.lblMapTypes.Name = "lblMapTypes";
            this.lblMapTypes.Size = new System.Drawing.Size(60, 13);
            this.lblMapTypes.TabIndex = 1;
            this.lblMapTypes.Text = "Map Types";
            this.lblMapTypes.Click += new System.EventHandler(this.lblMapTypes_Click);
            // 
            // lstMapTypes
            // 
            this.lstMapTypes.AllowDrop = true;
            this.lstMapTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstMapTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMapTypes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstMapTypes.HideSelection = false;
            this.lstMapTypes.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstMapTypes.Location = new System.Drawing.Point(14, 58);
            this.lstMapTypes.Name = "lstMapTypes";
            this.lstMapTypes.Size = new System.Drawing.Size(191, 211);
            this.lstMapTypes.TabIndex = 30;
            this.lstMapTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lstMapTypes_AfterSelect);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.btnChronological,
            this.toolStripSeparator4,
            this.toolStripSeparator3,
            this.toolStripItemUndo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(413, 25);
            this.toolStrip.TabIndex = 45;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnChronological
            // 
            this.btnChronological.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChronological.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnChronological.Image = ((System.Drawing.Image)(resources.GetObject("btnChronological.Image")));
            this.btnChronological.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChronological.Name = "btnChronological";
            this.btnChronological.Size = new System.Drawing.Size(23, 22);
            this.btnChronological.Text = "Order Chronologically";
            this.btnChronological.Click += new System.EventHandler(this.btnChronological_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(209, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(254, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 46;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // chkWalkThroughPlayers
            // 
            this.chkWalkThroughPlayers.AutoSize = true;
            this.chkWalkThroughPlayers.ForeColor = System.Drawing.SystemColors.Control;
            this.chkWalkThroughPlayers.Location = new System.Drawing.Point(212, 84);
            this.chkWalkThroughPlayers.Name = "chkWalkThroughPlayers";
            this.chkWalkThroughPlayers.Size = new System.Drawing.Size(153, 17);
            this.chkWalkThroughPlayers.TabIndex = 48;
            this.chkWalkThroughPlayers.Text = "Can Walk Through Players";
            this.chkWalkThroughPlayers.UseVisualStyleBackColor = true;
            this.chkWalkThroughPlayers.CheckedChanged += new System.EventHandler(this.chkWalkThroughPlayers_CheckedChanged);
            // 
            // chkAttackNpcs
            // 
            this.chkAttackNpcs.AutoSize = true;
            this.chkAttackNpcs.ForeColor = System.Drawing.SystemColors.Control;
            this.chkAttackNpcs.Location = new System.Drawing.Point(211, 107);
            this.chkAttackNpcs.Name = "chkAttackNpcs";
            this.chkAttackNpcs.Size = new System.Drawing.Size(107, 17);
            this.chkAttackNpcs.TabIndex = 49;
            this.chkAttackNpcs.Text = "Can Attack Npcs";
            this.chkAttackNpcs.UseVisualStyleBackColor = true;
            this.chkAttackNpcs.CheckedChanged += new System.EventHandler(this.chkAttackNpcs_CheckedChanged);
            // 
            // chkAttackPlayers
            // 
            this.chkAttackPlayers.AutoSize = true;
            this.chkAttackPlayers.ForeColor = System.Drawing.SystemColors.Control;
            this.chkAttackPlayers.Location = new System.Drawing.Point(212, 130);
            this.chkAttackPlayers.Name = "chkAttackPlayers";
            this.chkAttackPlayers.Size = new System.Drawing.Size(116, 17);
            this.chkAttackPlayers.TabIndex = 50;
            this.chkAttackPlayers.Text = "Can Attack Players";
            this.chkAttackPlayers.UseVisualStyleBackColor = true;
            this.chkAttackPlayers.CheckedChanged += new System.EventHandler(this.chkAttackPlayers_CheckedChanged);
            // 
            // chkDropItems
            // 
            this.chkDropItems.AutoSize = true;
            this.chkDropItems.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDropItems.Location = new System.Drawing.Point(211, 153);
            this.chkDropItems.Name = "chkDropItems";
            this.chkDropItems.Size = new System.Drawing.Size(126, 17);
            this.chkDropItems.TabIndex = 51;
            this.chkDropItems.Text = "Drop Items On Death";
            this.chkDropItems.UseVisualStyleBackColor = true;
            this.chkDropItems.CheckedChanged += new System.EventHandler(this.chkDropItems_CheckedChanged);
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.Location = new System.Drawing.Point(212, 237);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(32, 32);
            this.pnlColor.TabIndex = 53;
            this.pnlColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColor_Paint_1);
            // 
            // scrlColor
            // 
            this.scrlColor.LargeChange = 1;
            this.scrlColor.Location = new System.Drawing.Point(254, 241);
            this.scrlColor.Maximum = 8;
            this.scrlColor.Name = "scrlColor";
            this.scrlColor.Size = new System.Drawing.Size(145, 28);
            this.scrlColor.TabIndex = 55;
            this.scrlColor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlColor_Scroll);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(209, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(190, 28);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(190, 28);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(209, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Map Name Color";
            // 
            // chkArena
            // 
            this.chkArena.AutoSize = true;
            this.chkArena.ForeColor = System.Drawing.SystemColors.Control;
            this.chkArena.Location = new System.Drawing.Point(211, 176);
            this.chkArena.Name = "chkArena";
            this.chkArena.Size = new System.Drawing.Size(157, 17);
            this.chkArena.TabIndex = 59;
            this.chkArena.Text = "Is Arena (No PvP Penalties)";
            this.chkArena.UseVisualStyleBackColor = true;
            this.chkArena.CheckedChanged += new System.EventHandler(this.chkArena_CheckedChanged);
            // 
            // chkTrade
            // 
            this.chkTrade.AutoSize = true;
            this.chkTrade.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTrade.Location = new System.Drawing.Point(211, 199);
            this.chkTrade.Name = "chkTrade";
            this.chkTrade.Size = new System.Drawing.Size(76, 17);
            this.chkTrade.TabIndex = 60;
            this.chkTrade.Text = "Can Trade";
            this.chkTrade.UseVisualStyleBackColor = true;
            this.chkTrade.CheckedChanged += new System.EventHandler(this.chkTrade_CheckedChanged);
            // 
            // FrmMapType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(413, 314);
            this.ControlBox = false;
            this.Controls.Add(this.chkTrade);
            this.Controls.Add(this.chkArena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.scrlColor);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.chkDropItems);
            this.Controls.Add(this.chkAttackPlayers);
            this.Controls.Add(this.chkAttackNpcs);
            this.Controls.Add(this.chkWalkThroughPlayers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lstMapTypes);
            this.Controls.Add(this.lblMapTypes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMapType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Types Editor";
            this.Load += new System.EventHandler(this.FrmMapType_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog clrSelector;
        private System.Windows.Forms.Label lblMapTypes;
        public System.Windows.Forms.TreeView lstMapTypes;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnChronological;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private System.Windows.Forms.CheckBox chkWalkThroughPlayers;
        private System.Windows.Forms.CheckBox chkAttackNpcs;
        private System.Windows.Forms.CheckBox chkAttackPlayers;
        private System.Windows.Forms.CheckBox chkDropItems;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.HScrollBar scrlColor;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkArena;
        private System.Windows.Forms.CheckBox chkTrade;
    }
}