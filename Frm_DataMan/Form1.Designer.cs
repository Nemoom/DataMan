namespace Frm_DataMan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_Result = new System.Windows.Forms.Panel();
            this.lbl_Grade = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.TextBox();
            this.splitContainer_Right = new System.Windows.Forms.SplitContainer();
            this.panel_RightUp = new System.Windows.Forms.Panel();
            this.splitContainer_Setting = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SavePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Server = new System.Windows.Forms.RadioButton();
            this.rb_Client = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Port_Comm = new System.Windows.Forms.TextBox();
            this.txt_IP_Comm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Port_DataMan = new System.Windows.Forms.TextBox();
            this.txt_IP_DataMan = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveSetting = new System.Windows.Forms.Button();
            this.splitContainer_Show = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.splitContainer_TCP = new System.Windows.Forms.SplitContainer();
            this.lbl_TCP_Mess = new System.Windows.Forms.Label();
            this.txt_TCP_Mess = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.lbl_DataMan_Mess = new System.Windows.Forms.Label();
            this.txt_DataMan_Mess = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_Error_Message = new System.Windows.Forms.TextBox();
            this.bgw_DataMan = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bgw_TCP = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Right)).BeginInit();
            this.splitContainer_Right.Panel1.SuspendLayout();
            this.splitContainer_Right.SuspendLayout();
            this.panel_RightUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Setting)).BeginInit();
            this.splitContainer_Setting.Panel1.SuspendLayout();
            this.splitContainer_Setting.Panel2.SuspendLayout();
            this.splitContainer_Setting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Show)).BeginInit();
            this.splitContainer_Show.Panel1.SuspendLayout();
            this.splitContainer_Show.Panel2.SuspendLayout();
            this.splitContainer_Show.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_TCP)).BeginInit();
            this.splitContainer_TCP.Panel1.SuspendLayout();
            this.splitContainer_TCP.Panel2.SuspendLayout();
            this.splitContainer_TCP.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_Result);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Code);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer_Right);
            this.splitContainer1.Size = new System.Drawing.Size(830, 521);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel_Result
            // 
            this.panel_Result.BackColor = System.Drawing.SystemColors.Info;
            this.panel_Result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Result.Controls.Add(this.lbl_Grade);
            this.panel_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Result.Location = new System.Drawing.Point(0, 0);
            this.panel_Result.Name = "panel_Result";
            this.panel_Result.Size = new System.Drawing.Size(565, 412);
            this.panel_Result.TabIndex = 3;
            // 
            // lbl_Grade
            // 
            this.lbl_Grade.BackColor = System.Drawing.Color.White;
            this.lbl_Grade.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Grade.ForeColor = System.Drawing.Color.Black;
            this.lbl_Grade.Location = new System.Drawing.Point(9, 7);
            this.lbl_Grade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Grade.Name = "lbl_Grade";
            this.lbl_Grade.Size = new System.Drawing.Size(186, 39);
            this.lbl_Grade.TabIndex = 1;
            // 
            // lbl_Code
            // 
            this.lbl_Code.BackColor = System.Drawing.Color.White;
            this.lbl_Code.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Code.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Code.Location = new System.Drawing.Point(0, 412);
            this.lbl_Code.Multiline = true;
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.ReadOnly = true;
            this.lbl_Code.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.lbl_Code.Size = new System.Drawing.Size(565, 105);
            this.lbl_Code.TabIndex = 0;
            this.lbl_Code.Text = "解码内容:";
            // 
            // splitContainer_Right
            // 
            this.splitContainer_Right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Right.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Right.IsSplitterFixed = true;
            this.splitContainer_Right.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Right.Name = "splitContainer_Right";
            this.splitContainer_Right.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Right.Panel1
            // 
            this.splitContainer_Right.Panel1.Controls.Add(this.panel_RightUp);
            // 
            // splitContainer_Right.Panel2
            // 
            this.splitContainer_Right.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer_Right.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer_Right.Panel2.BackgroundImage")));
            this.splitContainer_Right.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer_Right.Panel2.DoubleClick += new System.EventHandler(this.splitContainer2_Panel2_DoubleClick);
            this.splitContainer_Right.Size = new System.Drawing.Size(257, 521);
            this.splitContainer_Right.SplitterDistance = 395;
            this.splitContainer_Right.TabIndex = 0;
            // 
            // panel_RightUp
            // 
            this.panel_RightUp.AutoScroll = true;
            this.panel_RightUp.Controls.Add(this.splitContainer_Setting);
            this.panel_RightUp.Controls.Add(this.splitContainer_Show);
            this.panel_RightUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_RightUp.Location = new System.Drawing.Point(0, 0);
            this.panel_RightUp.Name = "panel_RightUp";
            this.panel_RightUp.Size = new System.Drawing.Size(253, 391);
            this.panel_RightUp.TabIndex = 0;
            // 
            // splitContainer_Setting
            // 
            this.splitContainer_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer_Setting.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Setting.IsSplitterFixed = true;
            this.splitContainer_Setting.Location = new System.Drawing.Point(0, 377);
            this.splitContainer_Setting.Name = "splitContainer_Setting";
            this.splitContainer_Setting.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Setting.Panel1
            // 
            this.splitContainer_Setting.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer_Setting.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer_Setting.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer_Setting.Panel2
            // 
            this.splitContainer_Setting.Panel2.Controls.Add(this.btn_Cancel);
            this.splitContainer_Setting.Panel2.Controls.Add(this.btn_SaveSetting);
            this.splitContainer_Setting.Size = new System.Drawing.Size(236, 467);
            this.splitContainer_Setting.SplitterDistance = 429;
            this.splitContainer_Setting.TabIndex = 1;
            this.splitContainer_Setting.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Browse);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_SavePath);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 151);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "保存设置";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Browse.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Browse.Location = new System.Drawing.Point(167, 125);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(58, 24);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "浏览";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "结果保存路径:";
            // 
            // txt_SavePath
            // 
            this.txt_SavePath.Location = new System.Drawing.Point(14, 52);
            this.txt_SavePath.Multiline = true;
            this.txt_SavePath.Name = "txt_SavePath";
            this.txt_SavePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_SavePath.Size = new System.Drawing.Size(212, 67);
            this.txt_SavePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Server);
            this.groupBox2.Controls.Add(this.rb_Client);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Port_Comm);
            this.groupBox2.Controls.Add(this.txt_IP_Comm);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 157);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通信设置";
            this.groupBox2.Visible = false;
            // 
            // rb_Server
            // 
            this.rb_Server.AutoSize = true;
            this.rb_Server.Location = new System.Drawing.Point(122, 31);
            this.rb_Server.Name = "rb_Server";
            this.rb_Server.Size = new System.Drawing.Size(90, 24);
            this.rb_Server.TabIndex = 5;
            this.rb_Server.Text = "服务器";
            this.rb_Server.UseVisualStyleBackColor = true;
            this.rb_Server.CheckedChanged += new System.EventHandler(this.rb_Server_CheckedChanged);
            // 
            // rb_Client
            // 
            this.rb_Client.AutoSize = true;
            this.rb_Client.Checked = true;
            this.rb_Client.Location = new System.Drawing.Point(24, 31);
            this.rb_Client.Name = "rb_Client";
            this.rb_Client.Size = new System.Drawing.Size(90, 24);
            this.rb_Client.TabIndex = 4;
            this.rb_Client.TabStop = true;
            this.rb_Client.Text = "客户端";
            this.rb_Client.UseVisualStyleBackColor = true;
            this.rb_Client.CheckedChanged += new System.EventHandler(this.rb_Client_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "端口号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP:";
            // 
            // txt_Port_Comm
            // 
            this.txt_Port_Comm.Location = new System.Drawing.Point(129, 114);
            this.txt_Port_Comm.Name = "txt_Port_Comm";
            this.txt_Port_Comm.Size = new System.Drawing.Size(68, 30);
            this.txt_Port_Comm.TabIndex = 1;
            // 
            // txt_IP_Comm
            // 
            this.txt_IP_Comm.Location = new System.Drawing.Point(52, 70);
            this.txt_IP_Comm.Name = "txt_IP_Comm";
            this.txt_IP_Comm.Size = new System.Drawing.Size(174, 30);
            this.txt_IP_Comm.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Port_DataMan);
            this.groupBox1.Controls.Add(this.txt_IP_DataMan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读码器设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txt_Port_DataMan
            // 
            this.txt_Port_DataMan.Location = new System.Drawing.Point(129, 72);
            this.txt_Port_DataMan.Name = "txt_Port_DataMan";
            this.txt_Port_DataMan.Size = new System.Drawing.Size(68, 30);
            this.txt_Port_DataMan.TabIndex = 1;
            // 
            // txt_IP_DataMan
            // 
            this.txt_IP_DataMan.Location = new System.Drawing.Point(52, 27);
            this.txt_IP_DataMan.Name = "txt_IP_DataMan";
            this.txt_IP_DataMan.Size = new System.Drawing.Size(174, 30);
            this.txt_IP_DataMan.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(122, -1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(101, 30);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveSetting
            // 
            this.btn_SaveSetting.Location = new System.Drawing.Point(14, -1);
            this.btn_SaveSetting.Name = "btn_SaveSetting";
            this.btn_SaveSetting.Size = new System.Drawing.Size(101, 30);
            this.btn_SaveSetting.TabIndex = 0;
            this.btn_SaveSetting.Text = "保存设置";
            this.btn_SaveSetting.UseVisualStyleBackColor = true;
            this.btn_SaveSetting.Click += new System.EventHandler(this.btn_SaveSetting_Click);
            // 
            // splitContainer_Show
            // 
            this.splitContainer_Show.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer_Show.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Show.Name = "splitContainer_Show";
            this.splitContainer_Show.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Show.Panel1
            // 
            this.splitContainer_Show.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer_Show.Panel1.Controls.Add(this.groupBox6);
            // 
            // splitContainer_Show.Panel2
            // 
            this.splitContainer_Show.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer_Show.Size = new System.Drawing.Size(236, 377);
            this.splitContainer_Show.SplitterDistance = 239;
            this.splitContainer_Show.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.splitContainer_TCP);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 138);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TCP通信状态";
            this.groupBox4.Visible = false;
            // 
            // splitContainer_TCP
            // 
            this.splitContainer_TCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_TCP.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_TCP.Location = new System.Drawing.Point(3, 26);
            this.splitContainer_TCP.Name = "splitContainer_TCP";
            this.splitContainer_TCP.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_TCP.Panel1
            // 
            this.splitContainer_TCP.Panel1.Controls.Add(this.lbl_TCP_Mess);
            // 
            // splitContainer_TCP.Panel2
            // 
            this.splitContainer_TCP.Panel2.Controls.Add(this.txt_TCP_Mess);
            this.splitContainer_TCP.Size = new System.Drawing.Size(230, 109);
            this.splitContainer_TCP.SplitterDistance = 57;
            this.splitContainer_TCP.TabIndex = 0;
            // 
            // lbl_TCP_Mess
            // 
            this.lbl_TCP_Mess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TCP_Mess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TCP_Mess.Location = new System.Drawing.Point(11, 10);
            this.lbl_TCP_Mess.Name = "lbl_TCP_Mess";
            this.lbl_TCP_Mess.Size = new System.Drawing.Size(209, 36);
            this.lbl_TCP_Mess.TabIndex = 0;
            this.lbl_TCP_Mess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_TCP_Mess
            // 
            this.txt_TCP_Mess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TCP_Mess.Location = new System.Drawing.Point(0, 0);
            this.txt_TCP_Mess.Multiline = true;
            this.txt_TCP_Mess.Name = "txt_TCP_Mess";
            this.txt_TCP_Mess.ReadOnly = true;
            this.txt_TCP_Mess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_TCP_Mess.Size = new System.Drawing.Size(230, 48);
            this.txt_TCP_Mess.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.splitContainer6);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(236, 98);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "读码器状态";
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.Location = new System.Drawing.Point(3, 26);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.lbl_DataMan_Mess);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.txt_DataMan_Mess);
            this.splitContainer6.Size = new System.Drawing.Size(230, 92);
            this.splitContainer6.SplitterDistance = 62;
            this.splitContainer6.TabIndex = 0;
            // 
            // lbl_DataMan_Mess
            // 
            this.lbl_DataMan_Mess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DataMan_Mess.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_DataMan_Mess.Location = new System.Drawing.Point(11, 12);
            this.lbl_DataMan_Mess.Name = "lbl_DataMan_Mess";
            this.lbl_DataMan_Mess.Size = new System.Drawing.Size(209, 36);
            this.lbl_DataMan_Mess.TabIndex = 0;
            this.lbl_DataMan_Mess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_DataMan_Mess
            // 
            this.txt_DataMan_Mess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_DataMan_Mess.Location = new System.Drawing.Point(0, 0);
            this.txt_DataMan_Mess.Multiline = true;
            this.txt_DataMan_Mess.Name = "txt_DataMan_Mess";
            this.txt_DataMan_Mess.ReadOnly = true;
            this.txt_DataMan_Mess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_DataMan_Mess.Size = new System.Drawing.Size(230, 26);
            this.txt_DataMan_Mess.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_Error_Message);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(236, 134);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "信息";
            // 
            // txt_Error_Message
            // 
            this.txt_Error_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Error_Message.Location = new System.Drawing.Point(3, 26);
            this.txt_Error_Message.Multiline = true;
            this.txt_Error_Message.Name = "txt_Error_Message";
            this.txt_Error_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Error_Message.Size = new System.Drawing.Size(230, 105);
            this.txt_Error_Message.TabIndex = 0;
            // 
            // bgw_DataMan
            // 
            this.bgw_DataMan.WorkerSupportsCancellation = true;
            this.bgw_DataMan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DataMan_DoWork);
            this.bgw_DataMan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_DataMan_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bgw_TCP
            // 
            this.bgw_TCP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_TCP_DoWork);
            this.bgw_TCP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_TCP_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 521);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "读码结果界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Result.ResumeLayout(false);
            this.splitContainer_Right.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Right)).EndInit();
            this.splitContainer_Right.ResumeLayout(false);
            this.panel_RightUp.ResumeLayout(false);
            this.splitContainer_Setting.Panel1.ResumeLayout(false);
            this.splitContainer_Setting.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Setting)).EndInit();
            this.splitContainer_Setting.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer_Show.Panel1.ResumeLayout(false);
            this.splitContainer_Show.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Show)).EndInit();
            this.splitContainer_Show.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.splitContainer_TCP.Panel1.ResumeLayout(false);
            this.splitContainer_TCP.Panel2.ResumeLayout(false);
            this.splitContainer_TCP.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_TCP)).EndInit();
            this.splitContainer_TCP.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_Grade;
        private System.ComponentModel.BackgroundWorker bgw_DataMan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer_Right;
        private System.Windows.Forms.Panel panel_RightUp;
        private System.Windows.Forms.SplitContainer splitContainer_Setting;
        private System.Windows.Forms.SplitContainer splitContainer_Show;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Label lbl_DataMan_Mess;
        private System.Windows.Forms.TextBox txt_DataMan_Mess;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_Error_Message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SaveSetting;
        private System.Windows.Forms.Panel panel_Result;
        private System.Windows.Forms.TextBox lbl_Code;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SavePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Server;
        private System.Windows.Forms.RadioButton rb_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Port_Comm;
        private System.Windows.Forms.TextBox txt_IP_Comm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Port_DataMan;
        private System.Windows.Forms.TextBox txt_IP_DataMan;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.ComponentModel.BackgroundWorker bgw_TCP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer_TCP;
        private System.Windows.Forms.Label lbl_TCP_Mess;
        private System.Windows.Forms.TextBox txt_TCP_Mess;
    }
}

