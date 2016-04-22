using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;

//入住单添加

namespace HotelManagementSystem.LiveListManagement
{
	/// <summary>
	/// AddLiveListManagement 的摘要说明。
	/// </summary>
	public class AddLiveListManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtLiveID;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.DateTimePicker dtAccountTime;
		private System.Windows.Forms.CheckBox cbAccount;
		private System.Windows.Forms.CheckBox cbVIP;
		private System.Windows.Forms.CheckBox cbKSecret;
		private System.Windows.Forms.CheckBox cbWake;
		private System.Windows.Forms.CheckBox cbBreakfast;
		private System.Windows.Forms.TextBox txtPayType;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox txtAccountMoney;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txtBillMoney;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtSay;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtPhoneGrade;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.DateTimePicker dtEndTime;
		private System.Windows.Forms.DateTimePicker dtArrTime;
		private System.Windows.Forms.CheckBox cbBed;
		private System.Windows.Forms.TextBox txtAddBedPrice;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtSalesman;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtOperator;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtCompany;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtClient;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtReasom;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtLPrice;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtRPrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPNum;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtVipID;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtOrderID;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddLiveListManagement()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLiveID = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.dtAccountTime = new System.Windows.Forms.DateTimePicker();
			this.cbAccount = new System.Windows.Forms.CheckBox();
			this.cbVIP = new System.Windows.Forms.CheckBox();
			this.cbKSecret = new System.Windows.Forms.CheckBox();
			this.cbWake = new System.Windows.Forms.CheckBox();
			this.cbBreakfast = new System.Windows.Forms.CheckBox();
			this.txtPayType = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.txtAccountMoney = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txtBillMoney = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.txtSay = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txtPhoneGrade = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.dtEndTime = new System.Windows.Forms.DateTimePicker();
			this.dtArrTime = new System.Windows.Forms.DateTimePicker();
			this.cbBed = new System.Windows.Forms.CheckBox();
			this.txtAddBedPrice = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtSalesman = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtOperator = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtCompany = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtClient = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtMoney = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtReasom = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtLPrice = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtRPrice = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPNum = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtState = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPlace = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtVipID = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLiveID);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.dtAccountTime);
			this.groupBox1.Controls.Add(this.cbAccount);
			this.groupBox1.Controls.Add(this.cbVIP);
			this.groupBox1.Controls.Add(this.cbKSecret);
			this.groupBox1.Controls.Add(this.cbWake);
			this.groupBox1.Controls.Add(this.cbBreakfast);
			this.groupBox1.Controls.Add(this.txtPayType);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.txtAccountMoney);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Controls.Add(this.txtBillMoney);
			this.groupBox1.Controls.Add(this.label27);
			this.groupBox1.Controls.Add(this.txtSay);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.txtPhoneGrade);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.dtEndTime);
			this.groupBox1.Controls.Add(this.dtArrTime);
			this.groupBox1.Controls.Add(this.cbBed);
			this.groupBox1.Controls.Add(this.txtAddBedPrice);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.txtSalesman);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.txtOperator);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.txtPhone);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.txtCompany);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.txtClient);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtMoney);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtReasom);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtDiscount);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtLPrice);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtRPrice);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtPNum);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtState);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPlace);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRoomID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtVipID);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.txtOrderID);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Location = new System.Drawing.Point(4, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(712, 352);
			this.groupBox1.TabIndex = 101;
			this.groupBox1.TabStop = false;
			// 
			// txtLiveID
			// 
			this.txtLiveID.Location = new System.Drawing.Point(104, 24);
			this.txtLiveID.Name = "txtLiveID";
			this.txtLiveID.Size = new System.Drawing.Size(128, 21);
			this.txtLiveID.TabIndex = 68;
			this.txtLiveID.Text = "";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(16, 26);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(80, 23);
			this.label31.TabIndex = 67;
			this.label31.Text = "入住单号";
			// 
			// dtAccountTime
			// 
			this.dtAccountTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtAccountTime.Location = new System.Drawing.Point(568, 148);
			this.dtAccountTime.Name = "dtAccountTime";
			this.dtAccountTime.Size = new System.Drawing.Size(128, 21);
			this.dtAccountTime.TabIndex = 66;
			// 
			// cbAccount
			// 
			this.cbAccount.Location = new System.Drawing.Point(616, 312);
			this.cbAccount.Name = "cbAccount";
			this.cbAccount.Size = new System.Drawing.Size(80, 24);
			this.cbAccount.TabIndex = 65;
			this.cbAccount.Text = "是否结帐";
			// 
			// cbVIP
			// 
			this.cbVIP.Location = new System.Drawing.Point(504, 312);
			this.cbVIP.Name = "cbVIP";
			this.cbVIP.Size = new System.Drawing.Size(80, 24);
			this.cbVIP.TabIndex = 64;
			this.cbVIP.Text = "VIP";
			// 
			// cbKSecret
			// 
			this.cbKSecret.Location = new System.Drawing.Point(616, 280);
			this.cbKSecret.Name = "cbKSecret";
			this.cbKSecret.Size = new System.Drawing.Size(80, 24);
			this.cbKSecret.TabIndex = 63;
			this.cbKSecret.Text = "保密";
			// 
			// cbWake
			// 
			this.cbWake.Location = new System.Drawing.Point(504, 280);
			this.cbWake.Name = "cbWake";
			this.cbWake.Size = new System.Drawing.Size(80, 24);
			this.cbWake.TabIndex = 62;
			this.cbWake.Text = "叫醒";
			// 
			// cbBreakfast
			// 
			this.cbBreakfast.Location = new System.Drawing.Point(616, 248);
			this.cbBreakfast.Name = "cbBreakfast";
			this.cbBreakfast.Size = new System.Drawing.Size(80, 24);
			this.cbBreakfast.TabIndex = 61;
			this.cbBreakfast.Text = "早餐";
			// 
			// txtPayType
			// 
			this.txtPayType.Location = new System.Drawing.Point(568, 180);
			this.txtPayType.Name = "txtPayType";
			this.txtPayType.Size = new System.Drawing.Size(128, 21);
			this.txtPayType.TabIndex = 58;
			this.txtPayType.Text = "";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(480, 184);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(80, 23);
			this.label30.TabIndex = 57;
			this.label30.Text = "付帐方式";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(480, 151);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(80, 23);
			this.label29.TabIndex = 55;
			this.label29.Text = "结帐日期";
			// 
			// txtAccountMoney
			// 
			this.txtAccountMoney.Location = new System.Drawing.Point(568, 117);
			this.txtAccountMoney.Name = "txtAccountMoney";
			this.txtAccountMoney.Size = new System.Drawing.Size(128, 21);
			this.txtAccountMoney.TabIndex = 54;
			this.txtAccountMoney.Text = "";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(480, 122);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(80, 23);
			this.label28.TabIndex = 53;
			this.label28.Text = "结帐金额";
			// 
			// txtBillMoney
			// 
			this.txtBillMoney.Location = new System.Drawing.Point(568, 86);
			this.txtBillMoney.Name = "txtBillMoney";
			this.txtBillMoney.Size = new System.Drawing.Size(128, 21);
			this.txtBillMoney.TabIndex = 52;
			this.txtBillMoney.Text = "";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(480, 91);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 23);
			this.label27.TabIndex = 51;
			this.label27.Text = "应收帐款";
			// 
			// txtSay
			// 
			this.txtSay.Location = new System.Drawing.Point(568, 55);
			this.txtSay.Name = "txtSay";
			this.txtSay.Size = new System.Drawing.Size(128, 21);
			this.txtSay.TabIndex = 50;
			this.txtSay.Text = "";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(480, 58);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 49;
			this.label26.Text = "特要说明";
			// 
			// txtPhoneGrade
			// 
			this.txtPhoneGrade.Location = new System.Drawing.Point(568, 24);
			this.txtPhoneGrade.Name = "txtPhoneGrade";
			this.txtPhoneGrade.Size = new System.Drawing.Size(128, 21);
			this.txtPhoneGrade.TabIndex = 48;
			this.txtPhoneGrade.Text = "";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(480, 25);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(80, 23);
			this.label25.TabIndex = 47;
			this.label25.Text = "电话等级";
			// 
			// dtEndTime
			// 
			this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtEndTime.Location = new System.Drawing.Point(104, 227);
			this.dtEndTime.Name = "dtEndTime";
			this.dtEndTime.Size = new System.Drawing.Size(128, 21);
			this.dtEndTime.TabIndex = 46;
			// 
			// dtArrTime
			// 
			this.dtArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtArrTime.Location = new System.Drawing.Point(104, 198);
			this.dtArrTime.Name = "dtArrTime";
			this.dtArrTime.Size = new System.Drawing.Size(128, 21);
			this.dtArrTime.TabIndex = 45;
			// 
			// cbBed
			// 
			this.cbBed.Location = new System.Drawing.Point(504, 248);
			this.cbBed.Name = "cbBed";
			this.cbBed.Size = new System.Drawing.Size(80, 24);
			this.cbBed.TabIndex = 44;
			this.cbBed.Text = "是否加床";
			// 
			// txtAddBedPrice
			// 
			this.txtAddBedPrice.Location = new System.Drawing.Point(568, 213);
			this.txtAddBedPrice.Name = "txtAddBedPrice";
			this.txtAddBedPrice.Size = new System.Drawing.Size(128, 21);
			this.txtAddBedPrice.TabIndex = 43;
			this.txtAddBedPrice.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(480, 217);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 23);
			this.label22.TabIndex = 42;
			this.label22.Text = "加床价格";
			// 
			// txtSalesman
			// 
			this.txtSalesman.Location = new System.Drawing.Point(336, 313);
			this.txtSalesman.Name = "txtSalesman";
			this.txtSalesman.Size = new System.Drawing.Size(128, 21);
			this.txtSalesman.TabIndex = 41;
			this.txtSalesman.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(248, 317);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(80, 23);
			this.label21.TabIndex = 40;
			this.label21.Text = "业务员";
			// 
			// txtOperator
			// 
			this.txtOperator.Location = new System.Drawing.Point(336, 285);
			this.txtOperator.Name = "txtOperator";
			this.txtOperator.Size = new System.Drawing.Size(128, 21);
			this.txtOperator.TabIndex = 39;
			this.txtOperator.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(248, 288);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(80, 23);
			this.label20.TabIndex = 38;
			this.label20.Text = "操作员";
			// 
			// txtRemark
			// 
			this.txtRemark.Location = new System.Drawing.Point(336, 256);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(128, 21);
			this.txtRemark.TabIndex = 37;
			this.txtRemark.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(248, 257);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 23);
			this.label19.TabIndex = 36;
			this.label19.Text = "备注";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(336, 227);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(128, 21);
			this.txtPhone.TabIndex = 35;
			this.txtPhone.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(248, 230);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 34;
			this.label18.Text = "联系电话";
			// 
			// txtCompany
			// 
			this.txtCompany.Location = new System.Drawing.Point(336, 198);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.Size = new System.Drawing.Size(128, 21);
			this.txtCompany.TabIndex = 33;
			this.txtCompany.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(248, 201);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "预订公司";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(336, 170);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(128, 21);
			this.txtID.TabIndex = 31;
			this.txtID.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(248, 176);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 24);
			this.label16.TabIndex = 30;
			this.label16.Text = "身份证";
			// 
			// txtClient
			// 
			this.txtClient.Location = new System.Drawing.Point(336, 141);
			this.txtClient.Name = "txtClient";
			this.txtClient.Size = new System.Drawing.Size(128, 21);
			this.txtClient.TabIndex = 29;
			this.txtClient.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(248, 144);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 24);
			this.label15.TabIndex = 28;
			this.label15.Text = "预订人";
			// 
			// txtMoney
			// 
			this.txtMoney.Location = new System.Drawing.Point(336, 111);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new System.Drawing.Size(128, 21);
			this.txtMoney.TabIndex = 27;
			this.txtMoney.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(248, 113);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 24);
			this.label14.TabIndex = 26;
			this.label14.Text = "预收款";
			// 
			// txtReasom
			// 
			this.txtReasom.Location = new System.Drawing.Point(336, 82);
			this.txtReasom.Name = "txtReasom";
			this.txtReasom.Size = new System.Drawing.Size(128, 21);
			this.txtReasom.TabIndex = 25;
			this.txtReasom.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(248, 87);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 24);
			this.label13.TabIndex = 24;
			this.label13.Text = "折扣原因";
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(336, 53);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(128, 21);
			this.txtDiscount.TabIndex = 23;
			this.txtDiscount.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(248, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 24);
			this.label12.TabIndex = 22;
			this.label12.Text = "折扣";
			// 
			// txtLPrice
			// 
			this.txtLPrice.Location = new System.Drawing.Point(336, 24);
			this.txtLPrice.Name = "txtLPrice";
			this.txtLPrice.Size = new System.Drawing.Size(128, 21);
			this.txtLPrice.TabIndex = 21;
			this.txtLPrice.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(248, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 24);
			this.label11.TabIndex = 20;
			this.label11.Text = "入住价格";
			// 
			// txtRPrice
			// 
			this.txtRPrice.Location = new System.Drawing.Point(104, 314);
			this.txtRPrice.Name = "txtRPrice";
			this.txtRPrice.Size = new System.Drawing.Size(128, 21);
			this.txtRPrice.TabIndex = 19;
			this.txtRPrice.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 317);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 24);
			this.label10.TabIndex = 18;
			this.label10.Text = "客房价格";
			// 
			// txtPNum
			// 
			this.txtPNum.Location = new System.Drawing.Point(104, 285);
			this.txtPNum.Name = "txtPNum";
			this.txtPNum.Size = new System.Drawing.Size(128, 21);
			this.txtPNum.TabIndex = 17;
			this.txtPNum.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 288);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 24);
			this.label9.TabIndex = 16;
			this.label9.Text = "入住人数";
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(104, 256);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(128, 21);
			this.txtState.TabIndex = 15;
			this.txtState.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 258);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "单据状态";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "离店时间";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "抵店时间";
			// 
			// txtPlace
			// 
			this.txtPlace.Location = new System.Drawing.Point(104, 169);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.Size = new System.Drawing.Size(128, 21);
			this.txtPlace.TabIndex = 9;
			this.txtPlace.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "客房位置";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(104, 140);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(128, 21);
			this.txtName.TabIndex = 7;
			this.txtName.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "客房类型";
			// 
			// txtRoomID
			// 
			this.txtRoomID.Location = new System.Drawing.Point(104, 111);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(128, 21);
			this.txtRoomID.TabIndex = 5;
			this.txtRoomID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "客房编号";
			// 
			// txtVipID
			// 
			this.txtVipID.Location = new System.Drawing.Point(104, 82);
			this.txtVipID.Name = "txtVipID";
			this.txtVipID.Size = new System.Drawing.Size(128, 21);
			this.txtVipID.TabIndex = 3;
			this.txtVipID.Text = "";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 85);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 23);
			this.label23.TabIndex = 2;
			this.label23.Text = "会员编号";
			// 
			// txtOrderID
			// 
			this.txtOrderID.Location = new System.Drawing.Point(104, 53);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Size = new System.Drawing.Size(128, 21);
			this.txtOrderID.TabIndex = 1;
			this.txtOrderID.Text = "";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(16, 56);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(80, 23);
			this.label24.TabIndex = 0;
			this.label24.Text = "预订单号";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(480, 392);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 102;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(592, 392);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 103;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "入住单", new System.Data.Common.DataColumnMapping[] {
																																																new System.Data.Common.DataColumnMapping("入住单号", "入住单号"),
																																																new System.Data.Common.DataColumnMapping("预订单号", "预订单号"),
																																																new System.Data.Common.DataColumnMapping("会员编号", "会员编号"),
																																																new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
																																																new System.Data.Common.DataColumnMapping("客房类型", "客房类型"),
																																																new System.Data.Common.DataColumnMapping("客房位置", "客房位置"),
																																																new System.Data.Common.DataColumnMapping("抵店时间", "抵店时间"),
																																																new System.Data.Common.DataColumnMapping("离店时间", "离店时间"),
																																																new System.Data.Common.DataColumnMapping("单据状态", "单据状态"),
																																																new System.Data.Common.DataColumnMapping("入住人数", "入住人数"),
																																																new System.Data.Common.DataColumnMapping("客房价格", "客房价格"),
																																																new System.Data.Common.DataColumnMapping("入住价格", "入住价格"),
																																																new System.Data.Common.DataColumnMapping("折扣", "折扣"),
																																																new System.Data.Common.DataColumnMapping("折扣原因", "折扣原因"),
																																																new System.Data.Common.DataColumnMapping("是否加床", "是否加床"),
																																																new System.Data.Common.DataColumnMapping("加床价格", "加床价格"),
																																																new System.Data.Common.DataColumnMapping("预收款", "预收款"),
																																																new System.Data.Common.DataColumnMapping("预订人", "预订人"),
																																																new System.Data.Common.DataColumnMapping("身份证", "身份证"),
																																																new System.Data.Common.DataColumnMapping("预订公司", "预订公司"),
																																																new System.Data.Common.DataColumnMapping("联系电话", "联系电话"),
																																																new System.Data.Common.DataColumnMapping("备注", "备注"),
																																																new System.Data.Common.DataColumnMapping("操作员", "操作员"),
																																																new System.Data.Common.DataColumnMapping("业务员", "业务员"),
																																																new System.Data.Common.DataColumnMapping("早餐", "早餐"),
																																																new System.Data.Common.DataColumnMapping("叫醒", "叫醒"),
																																																new System.Data.Common.DataColumnMapping("保密", "保密"),
																																																new System.Data.Common.DataColumnMapping("VIP", "VIP"),
																																																new System.Data.Common.DataColumnMapping("电话等级", "电话等级"),
																																																new System.Data.Common.DataColumnMapping("特要说明", "特要说明"),
																																																new System.Data.Common.DataColumnMapping("应收帐款", "应收帐款"),
																																																new System.Data.Common.DataColumnMapping("是否结帐", "是否结帐"),
																																																new System.Data.Common.DataColumnMapping("结帐金额", "结帐金额"),
																																																new System.Data.Common.DataColumnMapping("结帐日期", "结帐日期"),
																																																new System.Data.Common.DataColumnMapping("付帐方式", "付帐方式")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 入住单 WHERE (入住单号 = @Original_入住单号) AND (VIP = @Original_VIP OR @Origin" +
				"al_VIP IS NULL AND VIP IS NULL) AND (业务员 = @Original_业务员 OR @Original_业务员 IS NUL" +
				"L AND 业务员 IS NULL) AND (付帐方式 = @Original_付帐方式 OR @Original_付帐方式 IS NULL AND 付帐方式" +
				" IS NULL) AND (会员编号 = @Original_会员编号 OR @Original_会员编号 IS NULL AND 会员编号 IS NULL)" +
				" AND (保密 = @Original_保密 OR @Original_保密 IS NULL AND 保密 IS NULL) AND (入住人数 = @Ori" +
				"ginal_入住人数 OR @Original_入住人数 IS NULL AND 入住人数 IS NULL) AND (入住价格 = @Original_入住价" +
				"格 OR @Original_入住价格 IS NULL AND 入住价格 IS NULL) AND (加床价格 = @Original_加床价格 OR @Ori" +
				"ginal_加床价格 IS NULL AND 加床价格 IS NULL) AND (单据状态 = @Original_单据状态 OR @Original_单据状" +
				"态 IS NULL AND 单据状态 IS NULL) AND (叫醒 = @Original_叫醒 OR @Original_叫醒 IS NULL AND 叫" +
				"醒 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (客" +
				"房价格 = @Original_客房价格 OR @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房位置 = @Or" +
				"iginal_客房位置 OR @Original_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房类型 = @Original_客房" +
				"类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (客房编号 = @Original_客房编号) AND (" +
				"应收帐款 = @Original_应收帐款 OR @Original_应收帐款 IS NULL AND 应收帐款 IS NULL) AND (折扣 = @Ori" +
				"ginal_折扣 OR @Original_折扣 IS NULL AND 折扣 IS NULL) AND (折扣原因 = @Original_折扣原因 OR @" +
				"Original_折扣原因 IS NULL AND 折扣原因 IS NULL) AND (抵店时间 = @Original_抵店时间 OR @Original_" +
				"抵店时间 IS NULL AND 抵店时间 IS NULL) AND (操作员 = @Original_操作员 OR @Original_操作员 IS NULL" +
				" AND 操作员 IS NULL) AND (早餐 = @Original_早餐 OR @Original_早餐 IS NULL AND 早餐 IS NULL)" +
				" AND (是否加床 = @Original_是否加床 OR @Original_是否加床 IS NULL AND 是否加床 IS NULL) AND (是否结" +
				"帐 = @Original_是否结帐 OR @Original_是否结帐 IS NULL AND 是否结帐 IS NULL) AND (特要说明 = @Orig" +
				"inal_特要说明 OR @Original_特要说明 IS NULL AND 特要说明 IS NULL) AND (电话等级 = @Original_电话等级" +
				" OR @Original_电话等级 IS NULL AND 电话等级 IS NULL) AND (离店时间 = @Original_离店时间 OR @Orig" +
				"inal_离店时间 IS NULL AND 离店时间 IS NULL) AND (结帐日期 = @Original_结帐日期 OR @Original_结帐日期" +
				" IS NULL AND 结帐日期 IS NULL) AND (结帐金额 = @Original_结帐金额 OR @Original_结帐金额 IS NULL " +
				"AND 结帐金额 IS NULL) AND (联系电话 = @Original_联系电话 OR @Original_联系电话 IS NULL AND 联系电话 " +
				"IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND " +
				"(预收款 = @Original_预收款 OR @Original_预收款 IS NULL AND 预收款 IS NULL) AND (预订人 = @Origi" +
				"nal_预订人 OR @Original_预订人 IS NULL AND 预订人 IS NULL) AND (预订公司 = @Original_预订公司 OR " +
				"@Original_预订公司 IS NULL AND 预订公司 IS NULL) AND (预订单号 = @Original_预订单号 OR @Original" +
				"_预订单号 IS NULL AND 预订单号 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住单号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VIP", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VIP", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_业务员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "业务员", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_付帐方式", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "付帐方式", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_会员编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "会员编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_保密", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "保密", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住人数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单据状态", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单据状态", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_叫醒", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "叫醒", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_应收帐款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "应收帐款", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣原因", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣原因", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_抵店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "抵店时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_操作员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "操作员", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_早餐", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "早餐", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否加床", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否结帐", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否结帐", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_特要说明", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "特要说明", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电话等级", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话等级", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_离店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "离店时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结帐日期", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "结帐日期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结帐金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "结帐金额", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订人", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订人", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订公司", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订公司", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订单号", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 入住单(入住单号, 预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格, 入住价格, 折扣, 折扣原因, 是否加床, 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员, 早餐, 叫醒, 保密, VIP, 电话等级, 特要说明, 应收帐款, 是否结帐, 结帐金额, 结帐日期, 付帐方式) VALUES (@入住单号, @预订单号, @会员编号, @客房编号, @客房类型, @客房位置, @抵店时间, @离店时间, @单据状态, @入住人数, @客房价格, @入住价格, @折扣, @折扣原因, @是否加床, @加床价格, @预收款, @预订人, @身份证, @预订公司, @联系电话, @备注, @操作员, @业务员, @早餐, @叫醒, @保密, @VIP, @电话等级, @特要说明, @应收帐款, @是否结帐, @结帐金额, @结帐日期, @付帐方式); SELECT 入住单号, 预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格, 入住价格, 折扣, 折扣原因, 是否加床, 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员, 早餐, 叫醒, 保密, VIP, 电话等级, 特要说明, 应收帐款, 是否结帐, 结帐金额, 结帐日期, 付帐方式 FROM 入住单 WHERE (入住单号 = @入住单号)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住单号", System.Data.SqlDbType.VarChar, 10, "入住单号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订单号", System.Data.SqlDbType.VarChar, 10, "预订单号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@会员编号", System.Data.SqlDbType.VarChar, 10, "会员编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@抵店时间", System.Data.SqlDbType.DateTime, 4, "抵店时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@离店时间", System.Data.SqlDbType.DateTime, 4, "离店时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单据状态", System.Data.SqlDbType.VarChar, 10, "单据状态"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住人数", System.Data.SqlDbType.Int, 4, "入住人数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣原因", System.Data.SqlDbType.VarChar, 40, "折扣原因"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否加床", System.Data.SqlDbType.Bit, 1, "是否加床"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订人", System.Data.SqlDbType.VarChar, 10, "预订人"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订公司", System.Data.SqlDbType.VarChar, 40, "预订公司"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 13, "联系电话"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@操作员", System.Data.SqlDbType.VarChar, 10, "操作员"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@业务员", System.Data.SqlDbType.VarChar, 10, "业务员"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@早餐", System.Data.SqlDbType.Bit, 1, "早餐"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@叫醒", System.Data.SqlDbType.Bit, 1, "叫醒"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@保密", System.Data.SqlDbType.Bit, 1, "保密"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VIP", System.Data.SqlDbType.Bit, 1, "VIP"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话等级", System.Data.SqlDbType.VarChar, 10, "电话等级"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@特要说明", System.Data.SqlDbType.VarChar, 40, "特要说明"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@应收帐款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "应收帐款", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否结帐", System.Data.SqlDbType.Bit, 1, "是否结帐"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结帐金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "结帐金额", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结帐日期", System.Data.SqlDbType.DateTime, 4, "结帐日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@付帐方式", System.Data.SqlDbType.VarChar, 10, "付帐方式"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 入住单号, 预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格, 入住价格, 折扣" +
				", 折扣原因, 是否加床, 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员, 早餐, 叫醒, 保密, VIP, 电话" +
				"等级, 特要说明, 应收帐款, 是否结帐, 结帐金额, 结帐日期, 付帐方式 FROM 入住单";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE 入住单 SET 入住单号 = @入住单号, 预订单号 = @预订单号, 会员编号 = @会员编号, 客房编号 = @客房编号, 客房类型 = @客房" +
				"类型, 客房位置 = @客房位置, 抵店时间 = @抵店时间, 离店时间 = @离店时间, 单据状态 = @单据状态, 入住人数 = @入住人数, 客房价格 =" +
				" @客房价格, 入住价格 = @入住价格, 折扣 = @折扣, 折扣原因 = @折扣原因, 是否加床 = @是否加床, 加床价格 = @加床价格, 预收款 = " +
				"@预收款, 预订人 = @预订人, 身份证 = @身份证, 预订公司 = @预订公司, 联系电话 = @联系电话, 备注 = @备注, 操作员 = @操作员, " +
				"业务员 = @业务员, 早餐 = @早餐, 叫醒 = @叫醒, 保密 = @保密, VIP = @VIP, 电话等级 = @电话等级, 特要说明 = @特要说明" +
				", 应收帐款 = @应收帐款, 是否结帐 = @是否结帐, 结帐金额 = @结帐金额, 结帐日期 = @结帐日期, 付帐方式 = @付帐方式 WHERE (入住" +
				"单号 = @Original_入住单号) AND (VIP = @Original_VIP OR @Original_VIP IS NULL AND VIP I" +
				"S NULL) AND (业务员 = @Original_业务员 OR @Original_业务员 IS NULL AND 业务员 IS NULL) AND (" +
				"付帐方式 = @Original_付帐方式 OR @Original_付帐方式 IS NULL AND 付帐方式 IS NULL) AND (会员编号 = @O" +
				"riginal_会员编号 OR @Original_会员编号 IS NULL AND 会员编号 IS NULL) AND (保密 = @Original_保密 " +
				"OR @Original_保密 IS NULL AND 保密 IS NULL) AND (入住人数 = @Original_入住人数 OR @Original_" +
				"入住人数 IS NULL AND 入住人数 IS NULL) AND (入住价格 = @Original_入住价格 OR @Original_入住价格 IS N" +
				"ULL AND 入住价格 IS NULL) AND (加床价格 = @Original_加床价格 OR @Original_加床价格 IS NULL AND 加" +
				"床价格 IS NULL) AND (单据状态 = @Original_单据状态 OR @Original_单据状态 IS NULL AND 单据状态 IS NU" +
				"LL) AND (叫醒 = @Original_叫醒 OR @Original_叫醒 IS NULL AND 叫醒 IS NULL) AND (备注 = @Or" +
				"iginal_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (客房价格 = @Original_客房价格 OR " +
				"@Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房位置 = @Original_客房位置 OR @Original" +
				"_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS " +
				"NULL AND 客房类型 IS NULL) AND (客房编号 = @Original_客房编号) AND (应收帐款 = @Original_应收帐款 OR" +
				" @Original_应收帐款 IS NULL AND 应收帐款 IS NULL) AND (折扣 = @Original_折扣 OR @Original_折扣" +
				" IS NULL AND 折扣 IS NULL) AND (折扣原因 = @Original_折扣原因 OR @Original_折扣原因 IS NULL AN" +
				"D 折扣原因 IS NULL) AND (抵店时间 = @Original_抵店时间 OR @Original_抵店时间 IS NULL AND 抵店时间 IS" +
				" NULL) AND (操作员 = @Original_操作员 OR @Original_操作员 IS NULL AND 操作员 IS NULL) AND (早" +
				"餐 = @Original_早餐 OR @Original_早餐 IS NULL AND 早餐 IS NULL) AND (是否加床 = @Original_是" +
				"否加床 OR @Original_是否加床 IS NULL AND 是否加床 IS NULL) AND (是否结帐 = @Original_是否结帐 OR @O" +
				"riginal_是否结帐 IS NULL AND 是否结帐 IS NULL) AND (特要说明 = @Original_特要说明 OR @Original_特" +
				"要说明 IS NULL AND 特要说明 IS NULL) AND (电话等级 = @Original_电话等级 OR @Original_电话等级 IS NU" +
				"LL AND 电话等级 IS NULL) AND (离店时间 = @Original_离店时间 OR @Original_离店时间 IS NULL AND 离店" +
				"时间 IS NULL) AND (结帐日期 = @Original_结帐日期 OR @Original_结帐日期 IS NULL AND 结帐日期 IS NUL" +
				"L) AND (结帐金额 = @Original_结帐金额 OR @Original_结帐金额 IS NULL AND 结帐金额 IS NULL) AND (联" +
				"系电话 = @Original_联系电话 OR @Original_联系电话 IS NULL AND 联系电话 IS NULL) AND (身份证 = @Ori" +
				"ginal_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (预收款 = @Original_预收款 OR " +
				"@Original_预收款 IS NULL AND 预收款 IS NULL) AND (预订人 = @Original_预订人 OR @Original_预订人" +
				" IS NULL AND 预订人 IS NULL) AND (预订公司 = @Original_预订公司 OR @Original_预订公司 IS NULL A" +
				"ND 预订公司 IS NULL) AND (预订单号 = @Original_预订单号 OR @Original_预订单号 IS NULL AND 预订单号 I" +
				"S NULL); SELECT 入住单号, 预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格" +
				", 入住价格, 折扣, 折扣原因, 是否加床, 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员, 早餐, 叫醒, 保" +
				"密, VIP, 电话等级, 特要说明, 应收帐款, 是否结帐, 结帐金额, 结帐日期, 付帐方式 FROM 入住单 WHERE (入住单号 = @入住单号)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住单号", System.Data.SqlDbType.VarChar, 10, "入住单号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订单号", System.Data.SqlDbType.VarChar, 10, "预订单号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@会员编号", System.Data.SqlDbType.VarChar, 10, "会员编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@抵店时间", System.Data.SqlDbType.DateTime, 4, "抵店时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@离店时间", System.Data.SqlDbType.DateTime, 4, "离店时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单据状态", System.Data.SqlDbType.VarChar, 10, "单据状态"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住人数", System.Data.SqlDbType.Int, 4, "入住人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣原因", System.Data.SqlDbType.VarChar, 40, "折扣原因"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否加床", System.Data.SqlDbType.Bit, 1, "是否加床"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订人", System.Data.SqlDbType.VarChar, 10, "预订人"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订公司", System.Data.SqlDbType.VarChar, 40, "预订公司"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 13, "联系电话"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@操作员", System.Data.SqlDbType.VarChar, 10, "操作员"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@业务员", System.Data.SqlDbType.VarChar, 10, "业务员"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@早餐", System.Data.SqlDbType.Bit, 1, "早餐"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@叫醒", System.Data.SqlDbType.Bit, 1, "叫醒"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@保密", System.Data.SqlDbType.Bit, 1, "保密"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VIP", System.Data.SqlDbType.Bit, 1, "VIP"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话等级", System.Data.SqlDbType.VarChar, 10, "电话等级"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@特要说明", System.Data.SqlDbType.VarChar, 40, "特要说明"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@应收帐款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "应收帐款", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否结帐", System.Data.SqlDbType.Bit, 1, "是否结帐"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结帐金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "结帐金额", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结帐日期", System.Data.SqlDbType.DateTime, 4, "结帐日期"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@付帐方式", System.Data.SqlDbType.VarChar, 10, "付帐方式"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住单号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VIP", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VIP", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_业务员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "业务员", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_付帐方式", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "付帐方式", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_会员编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "会员编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_保密", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "保密", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住人数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单据状态", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单据状态", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_叫醒", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "叫醒", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_应收帐款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "应收帐款", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣原因", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣原因", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_抵店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "抵店时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_操作员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "操作员", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_早餐", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "早餐", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否加床", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否结帐", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否结帐", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_特要说明", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "特要说明", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电话等级", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话等级", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_离店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "离店时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结帐日期", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "结帐日期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结帐金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "结帐金额", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订人", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订人", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订公司", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订公司", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订单号", System.Data.DataRowVersion.Original, null));
			// 
			// sqlCommand1
			// 
			this.sqlCommand1.CommandText = "dbo.[PROC_入住单历史]";
			this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlCommand1.Connection = this.conn;
			this.sqlCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住单号", System.Data.SqlDbType.VarChar, 10));
			// 
			// AddLiveListManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(720, 438);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(728, 472);
			this.MinimumSize = new System.Drawing.Size(728, 472);
			this.Name = "AddLiveListManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "入住单添加";
			this.Load += new System.EventHandler(this.AddLiveListManagement_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void AddLiveListManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(this.txtLiveID.Text.Trim() == "" || this.txtOrderID.Text.Trim() == "" || this.txtRoomID.Text.Trim() == "" || 
				this.txtPNum.Text.Trim() == "" || this.txtRPrice.Text.Trim() == "" || this.txtLPrice.Text.Trim() == "" || this.txtDiscount.Text.Trim() == "" ||
				this.txtAddBedPrice.Text.Trim() == "" || this.txtMoney.Text.Trim() == "" || this.txtAccountMoney.Text.Trim() == "" || this.txtBillMoney.Text.Trim() == "")
			{
				MessageBox.Show("入住单号、预订单号、客房编号、入住人数、客房价格、入住价格、折扣、加床价格、预收款、应收帐款、结帐金额不能空");
			}
			else
			{
				try
				{
					HotelDataSet.入住单Row dr = ds.入住单.New入住单Row();
					dr.入住单号 = this.txtLiveID.Text.Trim();
					dr.预订单号 = this.txtOrderID.Text.Trim();
					dr.会员编号 = this.txtVipID.Text.Trim();
					dr.客房编号 = this.txtRoomID.Text.Trim();
					dr.客房类型 = this.txtName.Text.Trim();
					dr.客房位置 = this.txtPlace.Text.Trim();
					dr.抵店时间 = this.dtArrTime.Value;
					dr.离店时间 = this.dtEndTime.Value;
					dr.单据状态 = this.txtState.Text.Trim();
					dr.入住人数 = Int32.Parse(this.txtPNum.Text.Trim());
					dr.客房价格 = decimal.Parse(this.txtRPrice.Text.Trim());
					dr.入住价格 = decimal.Parse(this.txtLPrice.Text.Trim());
					dr.折扣 = float.Parse(this.txtDiscount.Text.Trim());
					dr.折扣原因 = this.txtReasom.Text.Trim();
					dr.是否加床 = this.cbBed.Checked;
					dr.加床价格 = decimal.Parse(this.txtAddBedPrice.Text.Trim());
					dr.预收款 = decimal.Parse(this.txtMoney.Text.Trim());
					dr.预订人 = this.txtClient.Text.Trim();
					dr.身份证 = this.txtID.Text.Trim();
					dr.预订公司 = this.txtCompany.Text.Trim();
					dr.联系电话 = this.txtPhone.Text.Trim();
					dr.备注 = this.txtRemark.Text.Trim();
					dr.操作员 = this.txtOperator.Text.Trim();
					dr.业务员 = this.txtSalesman.Text.Trim();
					dr.早餐 = this.cbBreakfast.Checked;
					dr.叫醒 = this.cbWake.Checked;
					dr.保密 = this.cbKSecret.Checked;
					dr.VIP = this.cbVIP.Checked;
					dr.电话等级 = this.txtPhoneGrade.Text.Trim();
					dr.特要说明 = this.txtSay.Text.Trim();
					dr.应收帐款 = decimal.Parse(this.txtBillMoney.Text.Trim());
					dr.是否结帐 = this.cbAccount.Checked;
					dr.结帐金额 = decimal.Parse(this.txtAccountMoney.Text.Trim());
					dr.结帐日期 = this.dtAccountTime.Value;
					dr.付帐方式 = this.txtPayType.Text.Trim();
					this.ds.入住单.Add入住单Row(dr);
					da.Update(ds,"入住单");
					conn.Open();
					this.sqlCommand1.Parameters["@入住单号"].Value = this.txtLiveID.Text.Trim();
					this.sqlCommand1.ExecuteNonQuery();
					conn.Close();
					MessageBox.Show("数据保存成功");
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		    this.Close();
		}
	}
}
