using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WindowsApplication2.My;
using WindowsApplication2.My.Resources;

namespace WindowsApplication2
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private IContainer components;

		[AccessedThroughProperty("WBrowser1")]
		private WebBrowser _WBrowser1;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[AccessedThroughProperty("LstBxToFlw")]
		private ListBox _LstBxToFlw;

		[AccessedThroughProperty("Tmr1")]
		private Timer _Tmr1;

		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[AccessedThroughProperty("LstBox2")]
		private ListBox _LstBox2;

		[AccessedThroughProperty("BtnStop")]
		private Button _BtnStop;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		[AccessedThroughProperty("Label1")]
		private ToolStripStatusLabel _Label1;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("RadioButton3")]
		private RadioButton _RadioButton3;

		[AccessedThroughProperty("RadioButton2")]
		private RadioButton _RadioButton2;

		[AccessedThroughProperty("RadioButton1")]
		private RadioButton _RadioButton1;

		[AccessedThroughProperty("RadioButton4")]
		private RadioButton _RadioButton4;

		[AccessedThroughProperty("BtnPause")]
		private Button _BtnPause;

		[AccessedThroughProperty("ToolStripProgressBar1")]
		private ToolStripProgressBar _ToolStripProgressBar1;

		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("RadioButton5")]
		private RadioButton _RadioButton5;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("NUDpages")]
		private NumericUpDown _NUDpages;

		[AccessedThroughProperty("lblLstCnt")]
		private ToolStripStatusLabel _lblLstCnt;

		[AccessedThroughProperty("ToolStripProgressBar2")]
		private ToolStripProgressBar _ToolStripProgressBar2;

		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		[AccessedThroughProperty("TmrLike")]
		private Timer _TmrLike;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("NudPicPgMax")]
		private NumericUpDown _NudPicPgMax;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		[AccessedThroughProperty("ShortcutsToolStripMenuItem")]
		private ToolStripMenuItem _ShortcutsToolStripMenuItem;

		[AccessedThroughProperty("MyFollowersToolStripMenuItem")]
		private ToolStripMenuItem _MyFollowersToolStripMenuItem;

		[AccessedThroughProperty("MyFollowingsToolStripMenuItem")]
		private ToolStripMenuItem _MyFollowingsToolStripMenuItem;

		[AccessedThroughProperty("PeopleWhoDontFollowMeBackToolStripMenuItem")]
		private ToolStripMenuItem _PeopleWhoDontFollowMeBackToolStripMenuItem;

		[AccessedThroughProperty("PeopleWhoIDontFollowBackToolStripMenuItem")]
		private ToolStripMenuItem _PeopleWhoIDontFollowBackToolStripMenuItem;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[AccessedThroughProperty("TxtTag")]
		private TextBox _TxtTag;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("ShortcutsToolStripMenuItem1")]
		private ToolStripMenuItem _ShortcutsToolStripMenuItem1;

		[AccessedThroughProperty("SdToolStripMenuItem")]
		private ToolStripMenuItem _SdToolStripMenuItem;

		[AccessedThroughProperty("MyFollowingsToolStripMenuItem1")]
		private ToolStripMenuItem _MyFollowingsToolStripMenuItem1;

		[AccessedThroughProperty("PeopleWhoDontFollowMeBackToolStripMenuItem1")]
		private ToolStripMenuItem _PeopleWhoDontFollowMeBackToolStripMenuItem1;

		[AccessedThroughProperty("PeopleWhoIDontFollowBackToolStripMenuItem1")]
		private ToolStripMenuItem _PeopleWhoIDontFollowBackToolStripMenuItem1;

		[AccessedThroughProperty("ToolStripProgressBar3")]
		private ToolStripProgressBar _ToolStripProgressBar3;

		[AccessedThroughProperty("ToolStripProgressBar4")]
		private ToolStripProgressBar _ToolStripProgressBar4;

		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel _ToolStripStatusLabel1;

		[AccessedThroughProperty("ToolStripStatusLabel2")]
		private ToolStripStatusLabel _ToolStripStatusLabel2;

		[AccessedThroughProperty("FileToolStripMenuItem")]
		private ToolStripMenuItem _FileToolStripMenuItem;

		[AccessedThroughProperty("ExitToolStripMenuItem")]
		private ToolStripMenuItem _ExitToolStripMenuItem;

		[AccessedThroughProperty("TasksToolStripMenuItem")]
		private ToolStripMenuItem _TasksToolStripMenuItem;

		[AccessedThroughProperty("FollowWhoFollowsMeToolStripMenuItem")]
		private ToolStripMenuItem _FollowWhoFollowsMeToolStripMenuItem;

		[AccessedThroughProperty("FollowEveryoneOnThisPageToolStripMenuItem")]
		private ToolStripMenuItem _FollowEveryoneOnThisPageToolStripMenuItem;

		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripSeparator _ToolStripMenuItem1;

		[AccessedThroughProperty("UnfollowWhoDontFollowMeBackToolStripMenuItem")]
		private ToolStripMenuItem _UnfollowWhoDontFollowMeBackToolStripMenuItem;

		[AccessedThroughProperty("UnfollowEveryoneToolStripMenuItem")]
		private ToolStripMenuItem _UnfollowEveryoneToolStripMenuItem;

		[AccessedThroughProperty("UnfollowEveryoneOnThisPageToolStripMenuItem")]
		private ToolStripMenuItem _UnfollowEveryoneOnThisPageToolStripMenuItem;

		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripSeparator _ToolStripMenuItem2;

		[AccessedThroughProperty("LikePicturesOnThisPageToolStripMenuItem")]
		private ToolStripMenuItem _LikePicturesOnThisPageToolStripMenuItem;

		[AccessedThroughProperty("ClearTaskLogToolStripMenuItem")]
		private ToolStripMenuItem _ClearTaskLogToolStripMenuItem;

		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripSeparator _ToolStripMenuItem3;

		[AccessedThroughProperty("StopToolStripMenuItem")]
		private ToolStripMenuItem _StopToolStripMenuItem;

		[AccessedThroughProperty("PauseToolStripMenuItem")]
		private ToolStripMenuItem _PauseToolStripMenuItem;

		[AccessedThroughProperty("ReciprocalRelationshipToolStripMenuItem")]
		private ToolStripMenuItem _ReciprocalRelationshipToolStripMenuItem;

		[AccessedThroughProperty("BrowserToolStripMenuItem")]
		private ToolStripMenuItem _BrowserToolStripMenuItem;

		[AccessedThroughProperty("ReloadToolStripMenuItem")]
		private ToolStripMenuItem _ReloadToolStripMenuItem;

		[AccessedThroughProperty("StopToolStripMenuItem1")]
		private ToolStripMenuItem _StopToolStripMenuItem1;

		[AccessedThroughProperty("RadioButton6")]
		private RadioButton _RadioButton6;

		[AccessedThroughProperty("LoginToolStripMenuItem")]
		private ToolStripMenuItem _LoginToolStripMenuItem;

		[AccessedThroughProperty("ToolStripMenuItem4")]
		private ToolStripSeparator _ToolStripMenuItem4;

		[AccessedThroughProperty("LogoutToolStripMenuItem")]
		private ToolStripMenuItem _LogoutToolStripMenuItem;

		[AccessedThroughProperty("ChkLoop")]
		private CheckBox _ChkLoop;

		private string TmrCode;

		private string LoginTemp_TmrCode;

		private string Login_UN;

		private string Login_PW;

		private string PauseTmrCd;

		private int FlwMyIndx;

		private int SecCountr;

		private int BotSpeed;

		private int followedCount;

		private int mkListTiming;

		private int GotPageCount;

		private int PgeLoadWaitCntr;

		private int MkList2Cntr;

		private bool Unfollowing;

		private bool PicLikeMode;

		private int LikeCount;

		private bool RequestedFlw;

		private int ReqNum;

		private string LastUserNm;

		internal virtual ToolStripMenuItem BrowserToolStripMenuItem
		{
			get
			{
				return this._BrowserToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.BrowserToolStripMenuItem_Click);
				if (this._BrowserToolStripMenuItem != null)
				{
					this._BrowserToolStripMenuItem.Click -= eventHandler;
				}
				this._BrowserToolStripMenuItem = value;
				if (this._BrowserToolStripMenuItem != null)
				{
					this._BrowserToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual Button BtnPause
		{
			get
			{
				return this._BtnPause;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.BtnPause_TextChanged);
				Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.BtnPause_EnabledChanged);
				Form1 form12 = this;
				EventHandler eventHandler2 = new EventHandler(form12.BtnPause_Click);
				if (this._BtnPause != null)
				{
					this._BtnPause.TextChanged -= eventHandler;
					this._BtnPause.EnabledChanged -= eventHandler1;
					this._BtnPause.Click -= eventHandler2;
				}
				this._BtnPause = value;
				if (this._BtnPause != null)
				{
					this._BtnPause.TextChanged += eventHandler;
					this._BtnPause.EnabledChanged += eventHandler1;
					this._BtnPause.Click += eventHandler2;
				}
			}
		}

		internal virtual Button BtnStop
		{
			get
			{
				return this._BtnStop;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.BtnStop_EnabledChanged);
				Form1 form11 = this;
				EventHandler eventHandler1 = new EventHandler(form11.Button4_Click);
				if (this._BtnStop != null)
				{
					this._BtnStop.EnabledChanged -= eventHandler;
					this._BtnStop.Click -= eventHandler1;
				}
				this._BtnStop = value;
				if (this._BtnStop != null)
				{
					this._BtnStop.EnabledChanged += eventHandler;
					this._BtnStop.Click += eventHandler1;
				}
			}
		}

		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= eventHandler;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button3_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= eventHandler;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button4
		{
			get
			{
				return this._Button4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button4_Click_1);
				if (this._Button4 != null)
				{
					this._Button4.Click -= eventHandler;
				}
				this._Button4 = value;
				if (this._Button4 != null)
				{
					this._Button4.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button5
		{
			get
			{
				return this._Button5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button5_Click);
				if (this._Button5 != null)
				{
					this._Button5.Click -= eventHandler;
				}
				this._Button5 = value;
				if (this._Button5 != null)
				{
					this._Button5.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button6
		{
			get
			{
				return this._Button6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button6_Click);
				if (this._Button6 != null)
				{
					this._Button6.Click -= eventHandler;
				}
				this._Button6 = value;
				if (this._Button6 != null)
				{
					this._Button6.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button9
		{
			get
			{
				return this._Button9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button9_Click);
				if (this._Button9 != null)
				{
					this._Button9.Click -= eventHandler;
				}
				this._Button9 = value;
				if (this._Button9 != null)
				{
					this._Button9.Click += eventHandler;
				}
			}
		}

		internal virtual CheckBox ChkLoop
		{
			get
			{
				return this._ChkLoop;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ChkLoop = value;
			}
		}

		internal virtual ToolStripMenuItem ClearTaskLogToolStripMenuItem
		{
			get
			{
				return this._ClearTaskLogToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ClearTaskLogToolStripMenuItem_Click);
				if (this._ClearTaskLogToolStripMenuItem != null)
				{
					this._ClearTaskLogToolStripMenuItem.Click -= eventHandler;
				}
				this._ClearTaskLogToolStripMenuItem = value;
				if (this._ClearTaskLogToolStripMenuItem != null)
				{
					this._ClearTaskLogToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ExitToolStripMenuItem_Click);
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click -= eventHandler;
				}
				this._ExitToolStripMenuItem = value;
				if (this._ExitToolStripMenuItem != null)
				{
					this._ExitToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem FileToolStripMenuItem
		{
			get
			{
				return this._FileToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.FileToolStripMenuItem_Click);
				if (this._FileToolStripMenuItem != null)
				{
					this._FileToolStripMenuItem.Click -= eventHandler;
				}
				this._FileToolStripMenuItem = value;
				if (this._FileToolStripMenuItem != null)
				{
					this._FileToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem FollowEveryoneOnThisPageToolStripMenuItem
		{
			get
			{
				return this._FollowEveryoneOnThisPageToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.FollowEveryoneOnThisPageToolStripMenuItem_Click);
				if (this._FollowEveryoneOnThisPageToolStripMenuItem != null)
				{
					this._FollowEveryoneOnThisPageToolStripMenuItem.Click -= eventHandler;
				}
				this._FollowEveryoneOnThisPageToolStripMenuItem = value;
				if (this._FollowEveryoneOnThisPageToolStripMenuItem != null)
				{
					this._FollowEveryoneOnThisPageToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem FollowWhoFollowsMeToolStripMenuItem
		{
			get
			{
				return this._FollowWhoFollowsMeToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.FollowWhoFollowsMeToolStripMenuItem_Click);
				if (this._FollowWhoFollowsMeToolStripMenuItem != null)
				{
					this._FollowWhoFollowsMeToolStripMenuItem.Click -= eventHandler;
				}
				this._FollowWhoFollowsMeToolStripMenuItem = value;
				if (this._FollowWhoFollowsMeToolStripMenuItem != null)
				{
					this._FollowWhoFollowsMeToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.GroupBox3_Enter);
				if (this._GroupBox3 != null)
				{
					this._GroupBox3.Enter -= eventHandler;
				}
				this._GroupBox3 = value;
				if (this._GroupBox3 != null)
				{
					this._GroupBox3.Enter += eventHandler;
				}
			}
		}

		internal virtual ToolStripStatusLabel Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Label1_Click_1);
				if (this._Label1 != null)
				{
					this._Label1.Click -= eventHandler;
				}
				this._Label1 = value;
				if (this._Label1 != null)
				{
					this._Label1.Click += eventHandler;
				}
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Label5_Click);
				if (this._Label5 != null)
				{
					this._Label5.Click -= eventHandler;
				}
				this._Label5 = value;
				if (this._Label5 != null)
				{
					this._Label5.Click += eventHandler;
				}
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Label6_Click);
				if (this._Label6 != null)
				{
					this._Label6.Click -= eventHandler;
				}
				this._Label6 = value;
				if (this._Label6 != null)
				{
					this._Label6.Click += eventHandler;
				}
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		internal virtual ToolStripStatusLabel lblLstCnt
		{
			get
			{
				return this._lblLstCnt;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblLstCnt = value;
			}
		}

		internal virtual ToolStripMenuItem LikePicturesOnThisPageToolStripMenuItem
		{
			get
			{
				return this._LikePicturesOnThisPageToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LikePicturesOnThisPageToolStripMenuItem = value;
			}
		}

		internal virtual ToolStripMenuItem LoginToolStripMenuItem
		{
			get
			{
				return this._LoginToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.LoginToolStripMenuItem_Click);
				if (this._LoginToolStripMenuItem != null)
				{
					this._LoginToolStripMenuItem.Click -= eventHandler;
				}
				this._LoginToolStripMenuItem = value;
				if (this._LoginToolStripMenuItem != null)
				{
					this._LoginToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem LogoutToolStripMenuItem
		{
			get
			{
				return this._LogoutToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.LogoutToolStripMenuItem_Click);
				if (this._LogoutToolStripMenuItem != null)
				{
					this._LogoutToolStripMenuItem.Click -= eventHandler;
				}
				this._LogoutToolStripMenuItem = value;
				if (this._LogoutToolStripMenuItem != null)
				{
					this._LogoutToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ListBox LstBox2
		{
			get
			{
				return this._LstBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LstBox2 = value;
			}
		}

		internal virtual ListBox LstBxToFlw
		{
			get
			{
				return this._LstBxToFlw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.LstBxToFlw_SelectedIndexChanged);
				if (this._LstBxToFlw != null)
				{
					this._LstBxToFlw.SelectedIndexChanged -= eventHandler;
				}
				this._LstBxToFlw = value;
				if (this._LstBxToFlw != null)
				{
					this._LstBxToFlw.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual MenuStrip MenuStrip1
		{
			get
			{
				return this._MenuStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip1 = value;
			}
		}

		internal virtual ToolStripMenuItem MyFollowersToolStripMenuItem
		{
			get
			{
				return this._MyFollowersToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.MyFollowersToolStripMenuItem_Click);
				if (this._MyFollowersToolStripMenuItem != null)
				{
					this._MyFollowersToolStripMenuItem.Click -= eventHandler;
				}
				this._MyFollowersToolStripMenuItem = value;
				if (this._MyFollowersToolStripMenuItem != null)
				{
					this._MyFollowersToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem MyFollowingsToolStripMenuItem
		{
			get
			{
				return this._MyFollowingsToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.MyFollowingsToolStripMenuItem_Click);
				if (this._MyFollowingsToolStripMenuItem != null)
				{
					this._MyFollowingsToolStripMenuItem.Click -= eventHandler;
				}
				this._MyFollowingsToolStripMenuItem = value;
				if (this._MyFollowingsToolStripMenuItem != null)
				{
					this._MyFollowingsToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem MyFollowingsToolStripMenuItem1
		{
			get
			{
				return this._MyFollowingsToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.MyFollowingsToolStripMenuItem1_Click);
				if (this._MyFollowingsToolStripMenuItem1 != null)
				{
					this._MyFollowingsToolStripMenuItem1.Click -= eventHandler;
				}
				this._MyFollowingsToolStripMenuItem1 = value;
				if (this._MyFollowingsToolStripMenuItem1 != null)
				{
					this._MyFollowingsToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		internal virtual NumericUpDown NUDpages
		{
			get
			{
				return this._NUDpages;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.NumericUpDown1_ValueChanged);
				if (this._NUDpages != null)
				{
					this._NUDpages.ValueChanged -= eventHandler;
				}
				this._NUDpages = value;
				if (this._NUDpages != null)
				{
					this._NUDpages.ValueChanged += eventHandler;
				}
			}
		}

		internal virtual NumericUpDown NudPicPgMax
		{
			get
			{
				return this._NudPicPgMax;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.NudPicPgMax_ValueChanged);
				if (this._NudPicPgMax != null)
				{
					this._NudPicPgMax.ValueChanged -= eventHandler;
				}
				this._NudPicPgMax = value;
				if (this._NudPicPgMax != null)
				{
					this._NudPicPgMax.ValueChanged += eventHandler;
				}
			}
		}

		internal virtual Panel Panel1
		{
			get
			{
				return this._Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				PaintEventHandler paintEventHandler = new PaintEventHandler(form1.Panel1_Paint);
				if (this._Panel1 != null)
				{
					this._Panel1.Paint -= paintEventHandler;
				}
				this._Panel1 = value;
				if (this._Panel1 != null)
				{
					this._Panel1.Paint += paintEventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem PauseToolStripMenuItem
		{
			get
			{
				return this._PauseToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.PauseToolStripMenuItem_Click);
				if (this._PauseToolStripMenuItem != null)
				{
					this._PauseToolStripMenuItem.Click -= eventHandler;
				}
				this._PauseToolStripMenuItem = value;
				if (this._PauseToolStripMenuItem != null)
				{
					this._PauseToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem PeopleWhoDontFollowMeBackToolStripMenuItem
		{
			get
			{
				return this._PeopleWhoDontFollowMeBackToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.PeopleWhoDontFollowMeBackToolStripMenuItem_Click);
				if (this._PeopleWhoDontFollowMeBackToolStripMenuItem != null)
				{
					this._PeopleWhoDontFollowMeBackToolStripMenuItem.Click -= eventHandler;
				}
				this._PeopleWhoDontFollowMeBackToolStripMenuItem = value;
				if (this._PeopleWhoDontFollowMeBackToolStripMenuItem != null)
				{
					this._PeopleWhoDontFollowMeBackToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem PeopleWhoDontFollowMeBackToolStripMenuItem1
		{
			get
			{
				return this._PeopleWhoDontFollowMeBackToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.PeopleWhoDontFollowMeBackToolStripMenuItem1_Click);
				if (this._PeopleWhoDontFollowMeBackToolStripMenuItem1 != null)
				{
					this._PeopleWhoDontFollowMeBackToolStripMenuItem1.Click -= eventHandler;
				}
				this._PeopleWhoDontFollowMeBackToolStripMenuItem1 = value;
				if (this._PeopleWhoDontFollowMeBackToolStripMenuItem1 != null)
				{
					this._PeopleWhoDontFollowMeBackToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem PeopleWhoIDontFollowBackToolStripMenuItem
		{
			get
			{
				return this._PeopleWhoIDontFollowBackToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.PeopleWhoIDontFollowBackToolStripMenuItem_Click);
				if (this._PeopleWhoIDontFollowBackToolStripMenuItem != null)
				{
					this._PeopleWhoIDontFollowBackToolStripMenuItem.Click -= eventHandler;
				}
				this._PeopleWhoIDontFollowBackToolStripMenuItem = value;
				if (this._PeopleWhoIDontFollowBackToolStripMenuItem != null)
				{
					this._PeopleWhoIDontFollowBackToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem PeopleWhoIDontFollowBackToolStripMenuItem1
		{
			get
			{
				return this._PeopleWhoIDontFollowBackToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.PeopleWhoIDontFollowBackToolStripMenuItem1_Click);
				if (this._PeopleWhoIDontFollowBackToolStripMenuItem1 != null)
				{
					this._PeopleWhoIDontFollowBackToolStripMenuItem1.Click -= eventHandler;
				}
				this._PeopleWhoIDontFollowBackToolStripMenuItem1 = value;
				if (this._PeopleWhoIDontFollowBackToolStripMenuItem1 != null)
				{
					this._PeopleWhoIDontFollowBackToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		internal virtual RadioButton RadioButton1
		{
			get
			{
				return this._RadioButton1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.RadioButton1_CheckedChanged);
				if (this._RadioButton1 != null)
				{
					this._RadioButton1.CheckedChanged -= eventHandler;
				}
				this._RadioButton1 = value;
				if (this._RadioButton1 != null)
				{
					this._RadioButton1.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual RadioButton RadioButton2
		{
			get
			{
				return this._RadioButton2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.RadioButton2_CheckedChanged);
				if (this._RadioButton2 != null)
				{
					this._RadioButton2.CheckedChanged -= eventHandler;
				}
				this._RadioButton2 = value;
				if (this._RadioButton2 != null)
				{
					this._RadioButton2.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual RadioButton RadioButton3
		{
			get
			{
				return this._RadioButton3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.RadioButton3_CheckedChanged);
				if (this._RadioButton3 != null)
				{
					this._RadioButton3.CheckedChanged -= eventHandler;
				}
				this._RadioButton3 = value;
				if (this._RadioButton3 != null)
				{
					this._RadioButton3.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual RadioButton RadioButton4
		{
			get
			{
				return this._RadioButton4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.RadioButton4_CheckedChanged);
				if (this._RadioButton4 != null)
				{
					this._RadioButton4.CheckedChanged -= eventHandler;
				}
				this._RadioButton4 = value;
				if (this._RadioButton4 != null)
				{
					this._RadioButton4.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual RadioButton RadioButton5
		{
			get
			{
				return this._RadioButton5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.RadioButton5_CheckedChanged);
				if (this._RadioButton5 != null)
				{
					this._RadioButton5.CheckedChanged -= eventHandler;
				}
				this._RadioButton5 = value;
				if (this._RadioButton5 != null)
				{
					this._RadioButton5.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual RadioButton RadioButton6
		{
			get
			{
				return this._RadioButton6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.RadioButton6_CheckedChanged);
				if (this._RadioButton6 != null)
				{
					this._RadioButton6.CheckedChanged -= eventHandler;
				}
				this._RadioButton6 = value;
				if (this._RadioButton6 != null)
				{
					this._RadioButton6.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem ReciprocalRelationshipToolStripMenuItem
		{
			get
			{
				return this._ReciprocalRelationshipToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ReciprocalRelationshipToolStripMenuItem_Click);
				if (this._ReciprocalRelationshipToolStripMenuItem != null)
				{
					this._ReciprocalRelationshipToolStripMenuItem.Click -= eventHandler;
				}
				this._ReciprocalRelationshipToolStripMenuItem = value;
				if (this._ReciprocalRelationshipToolStripMenuItem != null)
				{
					this._ReciprocalRelationshipToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem ReloadToolStripMenuItem
		{
			get
			{
				return this._ReloadToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.ReloadToolStripMenuItem_Click);
				if (this._ReloadToolStripMenuItem != null)
				{
					this._ReloadToolStripMenuItem.Click -= eventHandler;
				}
				this._ReloadToolStripMenuItem = value;
				if (this._ReloadToolStripMenuItem != null)
				{
					this._ReloadToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem SdToolStripMenuItem
		{
			get
			{
				return this._SdToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.SdToolStripMenuItem_Click);
				if (this._SdToolStripMenuItem != null)
				{
					this._SdToolStripMenuItem.Click -= eventHandler;
				}
				this._SdToolStripMenuItem = value;
				if (this._SdToolStripMenuItem != null)
				{
					this._SdToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem ShortcutsToolStripMenuItem
		{
			get
			{
				return this._ShortcutsToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShortcutsToolStripMenuItem = value;
			}
		}

		internal virtual ToolStripMenuItem ShortcutsToolStripMenuItem1
		{
			get
			{
				return this._ShortcutsToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShortcutsToolStripMenuItem1 = value;
			}
		}

		internal virtual StatusStrip StatusStrip1
		{
			get
			{
				return this._StatusStrip1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				ToolStripItemClickedEventHandler toolStripItemClickedEventHandler = new ToolStripItemClickedEventHandler(form1.StatusStrip1_ItemClicked);
				if (this._StatusStrip1 != null)
				{
					this._StatusStrip1.ItemClicked -= toolStripItemClickedEventHandler;
				}
				this._StatusStrip1 = value;
				if (this._StatusStrip1 != null)
				{
					this._StatusStrip1.ItemClicked += toolStripItemClickedEventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem StopToolStripMenuItem
		{
			get
			{
				return this._StopToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.StopToolStripMenuItem_Click);
				if (this._StopToolStripMenuItem != null)
				{
					this._StopToolStripMenuItem.Click -= eventHandler;
				}
				this._StopToolStripMenuItem = value;
				if (this._StopToolStripMenuItem != null)
				{
					this._StopToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem StopToolStripMenuItem1
		{
			get
			{
				return this._StopToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.StopToolStripMenuItem1_Click);
				if (this._StopToolStripMenuItem1 != null)
				{
					this._StopToolStripMenuItem1.Click -= eventHandler;
				}
				this._StopToolStripMenuItem1 = value;
				if (this._StopToolStripMenuItem1 != null)
				{
					this._StopToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem TasksToolStripMenuItem
		{
			get
			{
				return this._TasksToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TasksToolStripMenuItem = value;
			}
		}

		internal virtual Timer Timer1
		{
			get
			{
				return this._Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		internal virtual Timer Tmr1
		{
			get
			{
				return this._Tmr1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Tmr1_Tick);
				if (this._Tmr1 != null)
				{
					this._Tmr1.Tick -= eventHandler;
				}
				this._Tmr1 = value;
				if (this._Tmr1 != null)
				{
					this._Tmr1.Tick += eventHandler;
				}
			}
		}

		internal virtual Timer TmrLike
		{
			get
			{
				return this._TmrLike;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.TmrLike_Tick);
				if (this._TmrLike != null)
				{
					this._TmrLike.Tick -= eventHandler;
				}
				this._TmrLike = value;
				if (this._TmrLike != null)
				{
					this._TmrLike.Tick += eventHandler;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripMenuItem1
		{
			get
			{
				return this._ToolStripMenuItem1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem1 = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripMenuItem2
		{
			get
			{
				return this._ToolStripMenuItem2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem2 = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripMenuItem3
		{
			get
			{
				return this._ToolStripMenuItem3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem3 = value;
			}
		}

		internal virtual ToolStripSeparator ToolStripMenuItem4
		{
			get
			{
				return this._ToolStripMenuItem4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripMenuItem4 = value;
			}
		}

		internal virtual ToolStripProgressBar ToolStripProgressBar1
		{
			get
			{
				return this._ToolStripProgressBar1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripProgressBar1 = value;
			}
		}

		internal virtual ToolStripProgressBar ToolStripProgressBar2
		{
			get
			{
				return this._ToolStripProgressBar2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripProgressBar2 = value;
			}
		}

		internal virtual ToolStripProgressBar ToolStripProgressBar3
		{
			get
			{
				return this._ToolStripProgressBar3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripProgressBar3 = value;
			}
		}

		internal virtual ToolStripProgressBar ToolStripProgressBar4
		{
			get
			{
				return this._ToolStripProgressBar4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripProgressBar4 = value;
			}
		}

		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabel1 = value;
			}
		}

		internal virtual ToolStripStatusLabel ToolStripStatusLabel2
		{
			get
			{
				return this._ToolStripStatusLabel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripStatusLabel2 = value;
			}
		}

		internal virtual TextBox TxtTag
		{
			get
			{
				return this._TxtTag;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.TextBox1_TextChanged);
				Form1 form11 = this;
				KeyEventHandler keyEventHandler = new KeyEventHandler(form11.TxtTag_KeyUp);
				Form1 form12 = this;
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(form12.TxtTag_KeyPress);
				Form1 form13 = this;
				KeyEventHandler keyEventHandler1 = new KeyEventHandler(form13.TxtTag_KeyDown);
				if (this._TxtTag != null)
				{
					this._TxtTag.TextChanged -= eventHandler;
					this._TxtTag.KeyUp -= keyEventHandler;
					this._TxtTag.KeyPress -= keyPressEventHandler;
					this._TxtTag.KeyDown -= keyEventHandler1;
				}
				this._TxtTag = value;
				if (this._TxtTag != null)
				{
					this._TxtTag.TextChanged += eventHandler;
					this._TxtTag.KeyUp += keyEventHandler;
					this._TxtTag.KeyPress += keyPressEventHandler;
					this._TxtTag.KeyDown += keyEventHandler1;
				}
			}
		}

		internal virtual ToolStripMenuItem UnfollowEveryoneOnThisPageToolStripMenuItem
		{
			get
			{
				return this._UnfollowEveryoneOnThisPageToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.UnfollowEveryoneOnThisPageToolStripMenuItem_Click);
				if (this._UnfollowEveryoneOnThisPageToolStripMenuItem != null)
				{
					this._UnfollowEveryoneOnThisPageToolStripMenuItem.Click -= eventHandler;
				}
				this._UnfollowEveryoneOnThisPageToolStripMenuItem = value;
				if (this._UnfollowEveryoneOnThisPageToolStripMenuItem != null)
				{
					this._UnfollowEveryoneOnThisPageToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem UnfollowEveryoneToolStripMenuItem
		{
			get
			{
				return this._UnfollowEveryoneToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.UnfollowEveryoneToolStripMenuItem_Click);
				if (this._UnfollowEveryoneToolStripMenuItem != null)
				{
					this._UnfollowEveryoneToolStripMenuItem.Click -= eventHandler;
				}
				this._UnfollowEveryoneToolStripMenuItem = value;
				if (this._UnfollowEveryoneToolStripMenuItem != null)
				{
					this._UnfollowEveryoneToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem UnfollowWhoDontFollowMeBackToolStripMenuItem
		{
			get
			{
				return this._UnfollowWhoDontFollowMeBackToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.UnfollowWhoDontFollowMeBackToolStripMenuItem_Click);
				if (this._UnfollowWhoDontFollowMeBackToolStripMenuItem != null)
				{
					this._UnfollowWhoDontFollowMeBackToolStripMenuItem.Click -= eventHandler;
				}
				this._UnfollowWhoDontFollowMeBackToolStripMenuItem = value;
				if (this._UnfollowWhoDontFollowMeBackToolStripMenuItem != null)
				{
					this._UnfollowWhoDontFollowMeBackToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual WebBrowser WBrowser1
		{
			get
			{
				return this._WBrowser1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Form1 form1 = this;
				WebBrowserDocumentCompletedEventHandler webBrowserDocumentCompletedEventHandler = new WebBrowserDocumentCompletedEventHandler(form1.WebBrowser1_DocumentCompleted);
				Form1 form11 = this;
				WebBrowserNavigatingEventHandler webBrowserNavigatingEventHandler = new WebBrowserNavigatingEventHandler(form11.WBrowser1_Navigating);
				Form1 form12 = this;
				WebBrowserNavigatedEventHandler webBrowserNavigatedEventHandler = new WebBrowserNavigatedEventHandler(form12.WBrowser1_Navigated);
				if (this._WBrowser1 != null)
				{
					this._WBrowser1.DocumentCompleted -= webBrowserDocumentCompletedEventHandler;
					this._WBrowser1.Navigating -= webBrowserNavigatingEventHandler;
					this._WBrowser1.Navigated -= webBrowserNavigatedEventHandler;
				}
				this._WBrowser1 = value;
				if (this._WBrowser1 != null)
				{
					this._WBrowser1.DocumentCompleted += webBrowserDocumentCompletedEventHandler;
					this._WBrowser1.Navigating += webBrowserNavigatingEventHandler;
					this._WBrowser1.Navigated += webBrowserNavigatedEventHandler;
				}
			}
		}

		public Form1()
		{
			Form1 form1 = this;
			base.Load += new EventHandler(form1.Form1_Load);
			this.InitializeComponent();
		}

		private void BrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void BtnPause_Click(object sender, EventArgs e)
		{
			if (this.PicLikeMode)
			{
				if (Operators.CompareString(this.BtnPause.Text, "Resume", false) != 0)
				{
					this.pauseBot();
					this.TmrLike.Enabled = false;
				}
				else
				{
					this.ResumeBot();
					this.TmrLike.Enabled = true;
				}
			}
			else if (Operators.CompareString(this.TmrCode, "Bot_Paused", false) != 0)
			{
				this.pauseBot();
			}
			else
			{
				this.ResumeBot();
			}
		}

		private void BtnPause_EnabledChanged(object sender, EventArgs e)
		{
			this.PauseToolStripMenuItem.Enabled = this.BtnPause.Enabled;
		}

		private void BtnPause_TextChanged(object sender, EventArgs e)
		{
			this.PauseToolStripMenuItem.Text = this.BtnPause.Text;
			this.PauseToolStripMenuItem.Image = this.BtnPause.Image;
		}

		private void BtnStop_EnabledChanged(object sender, EventArgs e)
		{
			this.StopToolStripMenuItem.Enabled = this.BtnStop.Enabled;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.BtnStop.PerformClick();
			this.Label5.Text = string.Concat("( ", Conversions.ToString(decimal.Multiply(this.NUDpages.Value, new decimal((long)50))), " People )");
			this.Unfollowing = true;
			this.WBrowser1.ScriptErrorsSuppressed = true;
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/myFollowings/");
			this.TmrCode = "UWFme_1";
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			this.FlwMyIndx = checked(this.LstBxToFlw.Items.Count - 2);
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			this.Label5.Text = string.Concat("( ", Conversions.ToString(decimal.Multiply(this.NUDpages.Value, new decimal((long)50))), " People )");
			this.BtnStop.PerformClick();
			this.Unfollowing = false;
			this.StartListing();
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			this.TmrCode = "FollowMy_4";
			this.stopBot();
			this.LstBox2.Items.Add("Task Stoped....");
			this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
		}

		private void Button4_Click_1(object sender, EventArgs e)
		{
			this.BtnStop.PerformClick();
			this.Label5.Text = string.Concat("( ", Conversions.ToString(decimal.Multiply(this.NUDpages.Value, new decimal((long)10))), " People )");
			this.Unfollowing = false;
			this.WBrowser1.ScriptErrorsSuppressed = true;
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/followersEx");
			this.TmrCode = "FWFme_1";
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			// 
			// Current member / type: System.Void WindowsApplication2.Form1::Button5_Click(System.Object,System.EventArgs)
			// File path: F:\master hack\Hackpack V2\Hackpack\Bots\Instagram Bot.exe
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void Button5_Click(System.Object,System.EventArgs)
			// 
			// Object reference not set to an instance of an object.
			//    at ..() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 112
			//    at ..( ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 26
			//    at ..BuildTree( ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\FastDominatorTreeBuilder.cs:line 25
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DominatorTreeDependentStep.cs:line 18
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 68
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
			//    at ..() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
			//    at ..(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		private void Button6_Click(object sender, EventArgs e)
		{
			this.BtnStop.PerformClick();
			this.Label5.Text = string.Concat("( ", Conversions.ToString(decimal.Multiply(this.NUDpages.Value, new decimal((long)10))), " People )");
			this.Unfollowing = true;
			this.WBrowser1.ScriptErrorsSuppressed = true;
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/followingsEx");
			this.TmrCode = "UWFme_1";
		}

		private void Button7_Click(object sender, EventArgs e)
		{
		}

		private void Button8_Click(object sender, EventArgs e)
		{
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			this.BtnStop.PerformClick();
			this.BtnStop.Enabled = true;
			this.BtnPause.Enabled = true;
			this.PicLikeMode = true;
			this.LstBox2.Items.Add("like Pictures Started....");
			this.GotPageCount = 1;
			this.PgeLoadWaitCntr = 0;
			this.LstBox2.Items.Add("Making List Started....");
			this.LstBox2.Items.Add("...Pages Added: 1");
			this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
			this.TmrCode = "LikeMorePage_1";
			this.LikeCount = -1;
			this.ToolStripProgressBar4.Value = 0;
			this.ToolStripProgressBar4.Visible = true;
			this.Tmr1.Enabled = true;
		}

		private void ClearTaskLogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LstBox2.Items.Clear();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		private void FileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.BtnPause.Text, "Resume", false) != 0)
			{
				this.PauseToolStripMenuItem.Image = Resources.Player_pause2;
			}
			else
			{
				this.PauseToolStripMenuItem.Image = Resources.Player_play2;
			}
		}

		private void FollowEveryoneOnThisPageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Button3.PerformClick();
		}

		private void FollowWhoFollowsMeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Button4.PerformClick();
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Form1_Load(object sender, EventArgs e)
		{
			HttpWebResponse response = (HttpWebResponse)WebRequest.Create("http://tdsolomons.blogspot.com/2012/04/softwares.html").GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string end = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			response.Close();
			if (end.Contains("Instagram Bot - MAKE DEAD(3) = TRUE"))
			{
				Interaction.MsgBox("Trial has ended. Your Bot is Dead!", MsgBoxStyle.Critical, null);
				Interaction.SaveSetting(Application.CompanyName, "TrialMode", "TrialEnded", "True");
				ProjectData.EndApp();
			}
			if (end.Contains("Instagram Bot - MAKE DEAD = FALES"))
			{
				int num = checked(end.IndexOf("(((((") + 6);
				int num1 = end.IndexOf(")))))");
				if (num != -1 & checked(num1 - num) > 0 & num1 != -1)
				{
					Interaction.MsgBox(string.Concat("A Message from bot's Master : ", Strings.Mid(end, num, checked(checked(num1 - num) + 1))), MsgBoxStyle.Information, null);
				}
			}
			this.NUDpages.Value = new decimal((long)5);
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/myFollowers/");
			this.BtnPause.Image = Resources.Player_play2;
			this.BtnStop.Image = Resources.Player_stop2;
			this.Button9.Image = Resources.Favorite2;
			this.ToolStripStatusLabel2.Text = "";
			this.ToolStripStatusLabel1.Text = "";
		}

		private void GroupBox3_Enter(object sender, EventArgs e)
		{
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.WBrowser1 = new WebBrowser();
			this.Button2 = new Button();
			this.LstBxToFlw = new ListBox();
			this.Tmr1 = new Timer(this.components);
			this.Button3 = new Button();
			this.LstBox2 = new ListBox();
			this.Panel1 = new Panel();
			this.ChkLoop = new CheckBox();
			this.Button5 = new Button();
			this.TxtTag = new TextBox();
			this.Label8 = new Label();
			this.Button1 = new Button();
			this.GroupBox3 = new GroupBox();
			this.NudPicPgMax = new NumericUpDown();
			this.Button9 = new Button();
			this.Label6 = new Label();
			this.Label2 = new Label();
			this.Button4 = new Button();
			this.Label5 = new Label();
			this.Label4 = new Label();
			this.NUDpages = new NumericUpDown();
			this.Label3 = new Label();
			this.Button6 = new Button();
			this.BtnPause = new Button();
			this.GroupBox1 = new GroupBox();
			this.RadioButton6 = new RadioButton();
			this.RadioButton5 = new RadioButton();
			this.RadioButton4 = new RadioButton();
			this.RadioButton3 = new RadioButton();
			this.RadioButton2 = new RadioButton();
			this.RadioButton1 = new RadioButton();
			this.BtnStop = new Button();
			this.StatusStrip1 = new StatusStrip();
			this.ToolStripProgressBar3 = new ToolStripProgressBar();
			this.ToolStripStatusLabel2 = new ToolStripStatusLabel();
			this.ToolStripProgressBar4 = new ToolStripProgressBar();
			this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
			this.ToolStripProgressBar2 = new ToolStripProgressBar();
			this.ToolStripProgressBar1 = new ToolStripProgressBar();
			this.lblLstCnt = new ToolStripStatusLabel();
			this.Label1 = new ToolStripStatusLabel();
			this.Timer1 = new Timer(this.components);
			this.TmrLike = new Timer(this.components);
			this.MenuStrip1 = new MenuStrip();
			this.FileToolStripMenuItem = new ToolStripMenuItem();
			this.LogoutToolStripMenuItem = new ToolStripMenuItem();
			this.LoginToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem4 = new ToolStripSeparator();
			this.PauseToolStripMenuItem = new ToolStripMenuItem();
			this.StopToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem3 = new ToolStripSeparator();
			this.ClearTaskLogToolStripMenuItem = new ToolStripMenuItem();
			this.ExitToolStripMenuItem = new ToolStripMenuItem();
			this.TasksToolStripMenuItem = new ToolStripMenuItem();
			this.FollowWhoFollowsMeToolStripMenuItem = new ToolStripMenuItem();
			this.FollowEveryoneOnThisPageToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem1 = new ToolStripSeparator();
			this.UnfollowWhoDontFollowMeBackToolStripMenuItem = new ToolStripMenuItem();
			this.UnfollowEveryoneToolStripMenuItem = new ToolStripMenuItem();
			this.UnfollowEveryoneOnThisPageToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem2 = new ToolStripSeparator();
			this.LikePicturesOnThisPageToolStripMenuItem = new ToolStripMenuItem();
			this.ShortcutsToolStripMenuItem1 = new ToolStripMenuItem();
			this.SdToolStripMenuItem = new ToolStripMenuItem();
			this.MyFollowingsToolStripMenuItem1 = new ToolStripMenuItem();
			this.PeopleWhoDontFollowMeBackToolStripMenuItem1 = new ToolStripMenuItem();
			this.PeopleWhoIDontFollowBackToolStripMenuItem1 = new ToolStripMenuItem();
			this.ReciprocalRelationshipToolStripMenuItem = new ToolStripMenuItem();
			this.BrowserToolStripMenuItem = new ToolStripMenuItem();
			this.ReloadToolStripMenuItem = new ToolStripMenuItem();
			this.StopToolStripMenuItem1 = new ToolStripMenuItem();
			this.ShortcutsToolStripMenuItem = new ToolStripMenuItem();
			this.MyFollowersToolStripMenuItem = new ToolStripMenuItem();
			this.MyFollowingsToolStripMenuItem = new ToolStripMenuItem();
			this.PeopleWhoDontFollowMeBackToolStripMenuItem = new ToolStripMenuItem();
			this.PeopleWhoIDontFollowBackToolStripMenuItem = new ToolStripMenuItem();
			this.Panel1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			((ISupportInitialize)this.NudPicPgMax).BeginInit();
			((ISupportInitialize)this.NUDpages).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.WBrowser1.Dock = DockStyle.Fill;
			WebBrowser wBrowser1 = this.WBrowser1;
			Point point = new Point(0, 197);
			wBrowser1.Location = point;
			WebBrowser webBrowser = this.WBrowser1;
			System.Drawing.Size size = new System.Drawing.Size(20, 20);
			webBrowser.MinimumSize = size;
			this.WBrowser1.Name = "WBrowser1";
			WebBrowser wBrowser11 = this.WBrowser1;
			size = new System.Drawing.Size(1281, 321);
			wBrowser11.Size = size;
			this.WBrowser1.TabIndex = 0;
			Button button2 = this.Button2;
			point = new Point(1095, 26);
			button2.Location = point;
			this.Button2.Name = "Button2";
			Button button = this.Button2;
			size = new System.Drawing.Size(101, 35);
			button.Size = size;
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Visible = false;
			this.LstBxToFlw.FormattingEnabled = true;
			this.LstBxToFlw.HorizontalScrollbar = true;
			ListBox lstBxToFlw = this.LstBxToFlw;
			point = new Point(1148, 52);
			lstBxToFlw.Location = point;
			this.LstBxToFlw.Name = "LstBxToFlw";
			ListBox listBox = this.LstBxToFlw;
			size = new System.Drawing.Size(258, 82);
			listBox.Size = size;
			this.LstBxToFlw.TabIndex = 3;
			this.LstBxToFlw.Visible = false;
			this.Tmr1.Enabled = true;
			this.Tmr1.Interval = 400;
			Button button3 = this.Button3;
			point = new Point(12, 68);
			button3.Location = point;
			this.Button3.Name = "Button3";
			Button button31 = this.Button3;
			size = new System.Drawing.Size(222, 27);
			button31.Size = size;
			this.Button3.TabIndex = 4;
			this.Button3.Text = "Follow Everyone on This Page";
			this.Button3.UseVisualStyleBackColor = true;
			this.LstBox2.FormattingEnabled = true;
			this.LstBox2.HorizontalScrollbar = true;
			ListBox lstBox2 = this.LstBox2;
			point = new Point(814, 27);
			lstBox2.Location = point;
			this.LstBox2.Name = "LstBox2";
			ListBox lstBox21 = this.LstBox2;
			size = new System.Drawing.Size(275, 134);
			lstBox21.Size = size;
			this.LstBox2.TabIndex = 5;
			this.Panel1.Controls.Add(this.ChkLoop);
			this.Panel1.Controls.Add(this.Button5);
			this.Panel1.Controls.Add(this.TxtTag);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.GroupBox3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Button4);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.NUDpages);
			this.Panel1.Controls.Add(this.LstBxToFlw);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Button6);
			this.Panel1.Controls.Add(this.BtnPause);
			this.Panel1.Controls.Add(this.Button2);
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Controls.Add(this.LstBox2);
			this.Panel1.Controls.Add(this.BtnStop);
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Dock = DockStyle.Top;
			Panel panel1 = this.Panel1;
			point = new Point(0, 24);
			panel1.Location = point;
			this.Panel1.Name = "Panel1";
			Panel panel = this.Panel1;
			size = new System.Drawing.Size(1281, 173);
			panel.Size = size;
			this.Panel1.TabIndex = 9;
			this.ChkLoop.AutoSize = true;
			CheckBox chkLoop = this.ChkLoop;
			point = new Point(708, 24);
			chkLoop.Location = point;
			this.ChkLoop.Name = "ChkLoop";
			CheckBox checkBox = this.ChkLoop;
			size = new System.Drawing.Size(83, 17);
			checkBox.Size = size;
			this.ChkLoop.TabIndex = 27;
			this.ChkLoop.Text = "Loop Follow";
			this.ChkLoop.UseVisualStyleBackColor = true;
			Button button5 = this.Button5;
			point = new Point(443, 7);
			button5.Location = point;
			this.Button5.Name = "Button5";
			Button button51 = this.Button5;
			size = new System.Drawing.Size(50, 24);
			button51.Size = size;
			this.Button5.TabIndex = 26;
			this.Button5.Text = "Go";
			this.Button5.UseVisualStyleBackColor = true;
			TextBox txtTag = this.TxtTag;
			point = new Point(322, 10);
			txtTag.Location = point;
			this.TxtTag.Name = "TxtTag";
			TextBox textBox = this.TxtTag;
			size = new System.Drawing.Size(115, 20);
			textBox.Size = size;
			this.TxtTag.TabIndex = 25;
			this.Label8.AutoSize = true;
			Label label8 = this.Label8;
			point = new Point(241, 10);
			label8.Location = point;
			this.Label8.Name = "Label8";
			Label label = this.Label8;
			size = new System.Drawing.Size(75, 13);
			label.Size = size;
			this.Label8.TabIndex = 24;
			this.Label8.Text = "Search # tag :";
			Button button1 = this.Button1;
			point = new Point(12, 133);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button11 = this.Button1;
			size = new System.Drawing.Size(222, 27);
			button11.Size = size;
			this.Button1.TabIndex = 23;
			this.Button1.Text = "Unfollow Everyone ";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.NudPicPgMax);
			this.GroupBox3.Controls.Add(this.Button9);
			this.GroupBox3.Controls.Add(this.Label6);
			GroupBox groupBox3 = this.GroupBox3;
			point = new Point(244, 33);
			groupBox3.Location = point;
			this.GroupBox3.Name = "GroupBox3";
			GroupBox groupBox = this.GroupBox3;
			size = new System.Drawing.Size(249, 134);
			groupBox.Size = size;
			this.GroupBox3.TabIndex = 22;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Like Pictures";
			NumericUpDown nudPicPgMax = this.NudPicPgMax;
			point = new Point(95, 28);
			nudPicPgMax.Location = point;
			this.NudPicPgMax.Name = "NudPicPgMax";
			NumericUpDown numericUpDown = this.NudPicPgMax;
			size = new System.Drawing.Size(80, 20);
			numericUpDown.Size = size;
			this.NudPicPgMax.TabIndex = 20;
			NumericUpDown nudPicPgMax1 = this.NudPicPgMax;
			int[] numArray = new int[] { 1, 0, 0, 0 };
			decimal num = new decimal(numArray);
			nudPicPgMax1.Value = num;
			this.Button9.Image = (Image)componentResourceManager.GetObject("Button9.Image");
			this.Button9.ImageAlign = ContentAlignment.MiddleLeft;
			Button button9 = this.Button9;
			point = new Point(36, 74);
			button9.Location = point;
			this.Button9.Name = "Button9";
			Button button91 = this.Button9;
			size = new System.Drawing.Size(177, 27);
			button91.Size = size;
			this.Button9.TabIndex = 19;
			this.Button9.Text = "Like Pictures on this page";
			this.Button9.UseVisualStyleBackColor = true;
			this.Label6.AutoSize = true;
			Label label6 = this.Label6;
			point = new Point(13, 31);
			label6.Location = point;
			this.Label6.Name = "Label6";
			Label label61 = this.Label6;
			size = new System.Drawing.Size(66, 13);
			label61.Size = size;
			this.Label6.TabIndex = 21;
			this.Label6.Text = "Max Pages :";
			this.Label2.AutoSize = true;
			this.Label2.Dock = DockStyle.Right;
			this.Label2.ForeColor = SystemColors.HotTrack;
			Label label2 = this.Label2;
			point = new Point(1057, 0);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(224, 13);
			label21.Size = size;
			this.Label2.TabIndex = 18;
			this.Label2.Text = "This is a Trial Version, You have few days left.";
			this.Label2.Visible = false;
			Button button4 = this.Button4;
			point = new Point(12, 35);
			button4.Location = point;
			this.Button4.Name = "Button4";
			Button button41 = this.Button4;
			size = new System.Drawing.Size(222, 27);
			button41.Size = size;
			this.Button4.TabIndex = 17;
			this.Button4.Text = "Follow who follows me";
			this.Button4.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			Label label5 = this.Label5;
			point = new Point(161, 9);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new System.Drawing.Size(39, 13);
			label51.Size = size;
			this.Label5.TabIndex = 16;
			this.Label5.Text = "Label5";
			this.Label4.AutoSize = true;
			Label label4 = this.Label4;
			point = new Point(12, 9);
			label4.Location = point;
			this.Label4.Name = "Label4";
			Label label41 = this.Label4;
			size = new System.Drawing.Size(66, 13);
			label41.Size = size;
			this.Label4.TabIndex = 15;
			this.Label4.Text = "Max Pages :";
			NumericUpDown nUDpages = this.NUDpages;
			point = new Point(84, 7);
			nUDpages.Location = point;
			NumericUpDown nUDpages1 = this.NUDpages;
			numArray = new int[] { 1, 0, 0, 0 };
			num = new decimal(numArray);
			nUDpages1.Minimum = num;
			this.NUDpages.Name = "NUDpages";
			NumericUpDown numericUpDown1 = this.NUDpages;
			size = new System.Drawing.Size(71, 20);
			numericUpDown1.Size = size;
			this.NUDpages.TabIndex = 14;
			NumericUpDown nUDpages2 = this.NUDpages;
			numArray = new int[] { 10, 0, 0, 0 };
			num = new decimal(numArray);
			nUDpages2.Value = num;
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(811, 9);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new System.Drawing.Size(58, 13);
			label31.Size = size;
			this.Label3.TabIndex = 13;
			this.Label3.Text = "Task Log :";
			Button button6 = this.Button6;
			point = new Point(12, 101);
			button6.Location = point;
			this.Button6.Name = "Button6";
			Button button61 = this.Button6;
			size = new System.Drawing.Size(222, 26);
			button61.Size = size;
			this.Button6.TabIndex = 11;
			this.Button6.Text = "Unfollow who don't follow me  back";
			this.Button6.UseVisualStyleBackColor = true;
			this.BtnPause.Enabled = false;
			this.BtnPause.Image = Resources.Player_pause2;
			Button btnPause = this.BtnPause;
			point = new Point(698, 70);
			btnPause.Location = point;
			this.BtnPause.Name = "BtnPause";
			Button btnPause1 = this.BtnPause;
			size = new System.Drawing.Size(102, 40);
			btnPause1.Size = size;
			this.BtnPause.TabIndex = 9;
			this.BtnPause.Text = "Pause";
			this.BtnPause.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.BtnPause.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.RadioButton6);
			this.GroupBox1.Controls.Add(this.RadioButton5);
			this.GroupBox1.Controls.Add(this.RadioButton4);
			this.GroupBox1.Controls.Add(this.RadioButton3);
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(499, 3);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox11 = this.GroupBox1;
			size = new System.Drawing.Size(183, 164);
			groupBox11.Size = size;
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Speed ";
			this.RadioButton6.AutoSize = true;
			RadioButton radioButton6 = this.RadioButton6;
			point = new Point(22, 138);
			radioButton6.Location = point;
			this.RadioButton6.Name = "RadioButton6";
			RadioButton radioButton = this.RadioButton6;
			size = new System.Drawing.Size(82, 17);
			radioButton.Size = size;
			this.RadioButton6.TabIndex = 5;
			this.RadioButton6.Text = "Even Faster";
			this.RadioButton6.UseVisualStyleBackColor = true;
			this.RadioButton6.Visible = false;
			this.RadioButton5.AutoSize = true;
			RadioButton radioButton5 = this.RadioButton5;
			point = new Point(22, 23);
			radioButton5.Location = point;
			this.RadioButton5.Name = "RadioButton5";
			RadioButton radioButton51 = this.RadioButton5;
			size = new System.Drawing.Size(57, 17);
			radioButton51.Size = size;
			this.RadioButton5.TabIndex = 4;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "Slower";
			this.RadioButton5.UseVisualStyleBackColor = true;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Checked = true;
			RadioButton radioButton4 = this.RadioButton4;
			point = new Point(22, 46);
			radioButton4.Location = point;
			this.RadioButton4.Name = "RadioButton4";
			RadioButton radioButton41 = this.RadioButton4;
			size = new System.Drawing.Size(48, 17);
			radioButton41.Size = size;
			this.RadioButton4.TabIndex = 3;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "Slow";
			this.RadioButton4.UseVisualStyleBackColor = true;
			this.RadioButton3.AutoSize = true;
			RadioButton radioButton3 = this.RadioButton3;
			point = new Point(22, 115);
			radioButton3.Location = point;
			this.RadioButton3.Name = "RadioButton3";
			RadioButton radioButton31 = this.RadioButton3;
			size = new System.Drawing.Size(54, 17);
			radioButton31.Size = size;
			this.RadioButton3.TabIndex = 2;
			this.RadioButton3.Text = "Faster";
			this.RadioButton3.UseVisualStyleBackColor = true;
			this.RadioButton2.AutoSize = true;
			RadioButton radioButton2 = this.RadioButton2;
			point = new Point(22, 92);
			radioButton2.Location = point;
			this.RadioButton2.Name = "RadioButton2";
			RadioButton radioButton21 = this.RadioButton2;
			size = new System.Drawing.Size(45, 17);
			radioButton21.Size = size;
			this.RadioButton2.TabIndex = 1;
			this.RadioButton2.Text = "Fast";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton1.AutoSize = true;
			RadioButton radioButton1 = this.RadioButton1;
			point = new Point(22, 69);
			radioButton1.Location = point;
			this.RadioButton1.Name = "RadioButton1";
			RadioButton radioButton11 = this.RadioButton1;
			size = new System.Drawing.Size(131, 17);
			radioButton11.Size = size;
			this.RadioButton1.TabIndex = 0;
			this.RadioButton1.Text = "Normal (Recomended)";
			this.RadioButton1.UseVisualStyleBackColor = true;
			this.BtnStop.Enabled = false;
			this.BtnStop.Image = Resources.Player_stop2;
			Button btnStop = this.BtnStop;
			point = new Point(698, 116);
			btnStop.Location = point;
			this.BtnStop.Name = "BtnStop";
			Button btnStop1 = this.BtnStop;
			size = new System.Drawing.Size(102, 38);
			btnStop1.Size = size;
			this.BtnStop.TabIndex = 6;
			this.BtnStop.Text = "Stop";
			this.BtnStop.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.BtnStop.UseVisualStyleBackColor = true;
			ToolStripItemCollection items = this.StatusStrip1.Items;
			ToolStripItem[] toolStripProgressBar3 = new ToolStripItem[] { this.ToolStripProgressBar3, this.ToolStripStatusLabel2, this.ToolStripProgressBar4, this.ToolStripStatusLabel1 };
			items.AddRange(toolStripProgressBar3);
			StatusStrip statusStrip1 = this.StatusStrip1;
			point = new Point(0, 518);
			statusStrip1.Location = point;
			this.StatusStrip1.Name = "StatusStrip1";
			StatusStrip statusStrip = this.StatusStrip1;
			size = new System.Drawing.Size(1281, 22);
			statusStrip.Size = size;
			this.StatusStrip1.TabIndex = 10;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripProgressBar3.Name = "ToolStripProgressBar3";
			ToolStripProgressBar toolStripProgressBar = this.ToolStripProgressBar3;
			size = new System.Drawing.Size(100, 16);
			toolStripProgressBar.Size = size;
			this.ToolStripProgressBar3.Visible = false;
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			ToolStripStatusLabel toolStripStatusLabel2 = this.ToolStripStatusLabel2;
			size = new System.Drawing.Size(121, 17);
			toolStripStatusLabel2.Size = size;
			this.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2";
			this.ToolStripProgressBar4.Name = "ToolStripProgressBar4";
			ToolStripProgressBar toolStripProgressBar4 = this.ToolStripProgressBar4;
			size = new System.Drawing.Size(100, 16);
			toolStripProgressBar4.Size = size;
			this.ToolStripProgressBar4.Visible = false;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			ToolStripStatusLabel toolStripStatusLabel1 = this.ToolStripStatusLabel1;
			size = new System.Drawing.Size(121, 17);
			toolStripStatusLabel1.Size = size;
			this.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1";
			this.ToolStripProgressBar2.Alignment = ToolStripItemAlignment.Right;
			this.ToolStripProgressBar2.BackColor = SystemColors.ControlDark;
			this.ToolStripProgressBar2.Name = "ToolStripProgressBar2";
			ToolStripProgressBar toolStripProgressBar2 = this.ToolStripProgressBar2;
			size = new System.Drawing.Size(100, 16);
			toolStripProgressBar2.Size = size;
			this.ToolStripProgressBar2.Style = ProgressBarStyle.Continuous;
			this.ToolStripProgressBar2.Value = 50;
			this.ToolStripProgressBar2.Visible = false;
			this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
			ToolStripProgressBar toolStripProgressBar1 = this.ToolStripProgressBar1;
			size = new System.Drawing.Size(100, 16);
			toolStripProgressBar1.Size = size;
			this.lblLstCnt.Name = "lblLstCnt";
			ToolStripStatusLabel toolStripStatusLabel = this.lblLstCnt;
			size = new System.Drawing.Size(10, 17);
			toolStripStatusLabel.Size = size;
			this.lblLstCnt.Text = " ";
			this.Label1.Name = "Label1";
			ToolStripStatusLabel label1 = this.Label1;
			size = new System.Drawing.Size(77, 17);
			label1.Size = size;
			this.Label1.Text = "Status: Ready";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 500000;
			this.TmrLike.Interval = 700;
			ToolStripItemCollection toolStripItemCollections = this.MenuStrip1.Items;
			toolStripProgressBar3 = new ToolStripItem[] { this.FileToolStripMenuItem, this.TasksToolStripMenuItem, this.ShortcutsToolStripMenuItem1, this.BrowserToolStripMenuItem };
			toolStripItemCollections.AddRange(toolStripProgressBar3);
			MenuStrip menuStrip1 = this.MenuStrip1;
			point = new Point(0, 0);
			menuStrip1.Location = point;
			this.MenuStrip1.Name = "MenuStrip1";
			MenuStrip menuStrip = this.MenuStrip1;
			size = new System.Drawing.Size(1281, 24);
			menuStrip.Size = size;
			this.MenuStrip1.TabIndex = 11;
			this.MenuStrip1.Text = "MenuStrip1";
			ToolStripItemCollection dropDownItems = this.FileToolStripMenuItem.DropDownItems;
			toolStripProgressBar3 = new ToolStripItem[] { this.LogoutToolStripMenuItem, this.LoginToolStripMenuItem, this.ToolStripMenuItem4, this.PauseToolStripMenuItem, this.StopToolStripMenuItem, this.ToolStripMenuItem3, this.ClearTaskLogToolStripMenuItem, this.ExitToolStripMenuItem };
			dropDownItems.AddRange(toolStripProgressBar3);
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			ToolStripMenuItem fileToolStripMenuItem = this.FileToolStripMenuItem;
			size = new System.Drawing.Size(37, 20);
			fileToolStripMenuItem.Size = size;
			this.FileToolStripMenuItem.Text = "&File";
			this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
			ToolStripMenuItem logoutToolStripMenuItem = this.LogoutToolStripMenuItem;
			size = new System.Drawing.Size(168, 22);
			logoutToolStripMenuItem.Size = size;
			this.LogoutToolStripMenuItem.Text = "Logout";
			this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
			ToolStripMenuItem loginToolStripMenuItem = this.LoginToolStripMenuItem;
			size = new System.Drawing.Size(168, 22);
			loginToolStripMenuItem.Size = size;
			this.LoginToolStripMenuItem.Text = "Login...";
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			ToolStripSeparator toolStripMenuItem4 = this.ToolStripMenuItem4;
			size = new System.Drawing.Size(165, 6);
			toolStripMenuItem4.Size = size;
			this.PauseToolStripMenuItem.Image = Resources.Player_pause2;
			this.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem";
			ToolStripMenuItem pauseToolStripMenuItem = this.PauseToolStripMenuItem;
			size = new System.Drawing.Size(168, 22);
			pauseToolStripMenuItem.Size = size;
			this.PauseToolStripMenuItem.Text = "Pause";
			this.StopToolStripMenuItem.Image = Resources.Player_stop2;
			this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
			ToolStripMenuItem stopToolStripMenuItem = this.StopToolStripMenuItem;
			size = new System.Drawing.Size(168, 22);
			stopToolStripMenuItem.Size = size;
			this.StopToolStripMenuItem.Text = "Stop";
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			ToolStripSeparator toolStripMenuItem3 = this.ToolStripMenuItem3;
			size = new System.Drawing.Size(165, 6);
			toolStripMenuItem3.Size = size;
			this.ClearTaskLogToolStripMenuItem.Name = "ClearTaskLogToolStripMenuItem";
			ToolStripMenuItem clearTaskLogToolStripMenuItem = this.ClearTaskLogToolStripMenuItem;
			size = new System.Drawing.Size(168, 22);
			clearTaskLogToolStripMenuItem.Size = size;
			this.ClearTaskLogToolStripMenuItem.Text = "Clear the Task log";
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.Space | Keys.Prior | Keys.PageUp | Keys.Next | Keys.PageDown | Keys.End | Keys.D0 | Keys.D1 | Keys.D2 | Keys.D3 | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.NumPad0 | Keys.NumPad1 | Keys.NumPad2 | Keys.NumPad3 | Keys.F1 | Keys.F2 | Keys.F3 | Keys.F4 | Keys.Alt;
			ToolStripMenuItem exitToolStripMenuItem = this.ExitToolStripMenuItem;
			size = new System.Drawing.Size(168, 22);
			exitToolStripMenuItem.Size = size;
			this.ExitToolStripMenuItem.Text = "E&xit";
			ToolStripItemCollection dropDownItems1 = this.TasksToolStripMenuItem.DropDownItems;
			toolStripProgressBar3 = new ToolStripItem[] { this.FollowWhoFollowsMeToolStripMenuItem, this.FollowEveryoneOnThisPageToolStripMenuItem, this.ToolStripMenuItem1, this.UnfollowWhoDontFollowMeBackToolStripMenuItem, this.UnfollowEveryoneToolStripMenuItem, this.UnfollowEveryoneOnThisPageToolStripMenuItem, this.ToolStripMenuItem2, this.LikePicturesOnThisPageToolStripMenuItem };
			dropDownItems1.AddRange(toolStripProgressBar3);
			this.TasksToolStripMenuItem.Name = "TasksToolStripMenuItem";
			ToolStripMenuItem tasksToolStripMenuItem = this.TasksToolStripMenuItem;
			size = new System.Drawing.Size(48, 20);
			tasksToolStripMenuItem.Size = size;
			this.TasksToolStripMenuItem.Text = "Tasks";
			this.FollowWhoFollowsMeToolStripMenuItem.Name = "FollowWhoFollowsMeToolStripMenuItem";
			ToolStripMenuItem followWhoFollowsMeToolStripMenuItem = this.FollowWhoFollowsMeToolStripMenuItem;
			size = new System.Drawing.Size(266, 22);
			followWhoFollowsMeToolStripMenuItem.Size = size;
			this.FollowWhoFollowsMeToolStripMenuItem.Text = "Follow who follows me";
			this.FollowEveryoneOnThisPageToolStripMenuItem.Name = "FollowEveryoneOnThisPageToolStripMenuItem";
			ToolStripMenuItem followEveryoneOnThisPageToolStripMenuItem = this.FollowEveryoneOnThisPageToolStripMenuItem;
			size = new System.Drawing.Size(266, 22);
			followEveryoneOnThisPageToolStripMenuItem.Size = size;
			this.FollowEveryoneOnThisPageToolStripMenuItem.Text = "Follow Everyone on This Page";
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			ToolStripSeparator toolStripMenuItem1 = this.ToolStripMenuItem1;
			size = new System.Drawing.Size(263, 6);
			toolStripMenuItem1.Size = size;
			this.UnfollowWhoDontFollowMeBackToolStripMenuItem.Name = "UnfollowWhoDontFollowMeBackToolStripMenuItem";
			ToolStripMenuItem unfollowWhoDontFollowMeBackToolStripMenuItem = this.UnfollowWhoDontFollowMeBackToolStripMenuItem;
			size = new System.Drawing.Size(266, 22);
			unfollowWhoDontFollowMeBackToolStripMenuItem.Size = size;
			this.UnfollowWhoDontFollowMeBackToolStripMenuItem.Text = "Unfollow who don't follow me  back";
			this.UnfollowEveryoneToolStripMenuItem.Name = "UnfollowEveryoneToolStripMenuItem";
			ToolStripMenuItem unfollowEveryoneToolStripMenuItem = this.UnfollowEveryoneToolStripMenuItem;
			size = new System.Drawing.Size(266, 22);
			unfollowEveryoneToolStripMenuItem.Size = size;
			this.UnfollowEveryoneToolStripMenuItem.Text = "Unfollow Everyone ";
			this.UnfollowEveryoneOnThisPageToolStripMenuItem.Name = "UnfollowEveryoneOnThisPageToolStripMenuItem";
			ToolStripMenuItem unfollowEveryoneOnThisPageToolStripMenuItem = this.UnfollowEveryoneOnThisPageToolStripMenuItem;
			size = new System.Drawing.Size(266, 22);
			unfollowEveryoneOnThisPageToolStripMenuItem.Size = size;
			this.UnfollowEveryoneOnThisPageToolStripMenuItem.Text = "Unfollow Everyone on this page";
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			ToolStripSeparator toolStripMenuItem2 = this.ToolStripMenuItem2;
			size = new System.Drawing.Size(263, 6);
			toolStripMenuItem2.Size = size;
			this.LikePicturesOnThisPageToolStripMenuItem.Image = Resources.Favorite2;
			this.LikePicturesOnThisPageToolStripMenuItem.Name = "LikePicturesOnThisPageToolStripMenuItem";
			ToolStripMenuItem likePicturesOnThisPageToolStripMenuItem = this.LikePicturesOnThisPageToolStripMenuItem;
			size = new System.Drawing.Size(266, 22);
			likePicturesOnThisPageToolStripMenuItem.Size = size;
			this.LikePicturesOnThisPageToolStripMenuItem.Text = "Like Pictures on this page";
			ToolStripItemCollection toolStripItemCollections1 = this.ShortcutsToolStripMenuItem1.DropDownItems;
			toolStripProgressBar3 = new ToolStripItem[] { this.SdToolStripMenuItem, this.MyFollowingsToolStripMenuItem1, this.PeopleWhoDontFollowMeBackToolStripMenuItem1, this.PeopleWhoIDontFollowBackToolStripMenuItem1, this.ReciprocalRelationshipToolStripMenuItem };
			toolStripItemCollections1.AddRange(toolStripProgressBar3);
			this.ShortcutsToolStripMenuItem1.Name = "ShortcutsToolStripMenuItem1";
			ToolStripMenuItem shortcutsToolStripMenuItem1 = this.ShortcutsToolStripMenuItem1;
			size = new System.Drawing.Size(69, 20);
			shortcutsToolStripMenuItem1.Size = size;
			this.ShortcutsToolStripMenuItem1.Text = "Shortcuts";
			this.SdToolStripMenuItem.Name = "SdToolStripMenuItem";
			ToolStripMenuItem sdToolStripMenuItem = this.SdToolStripMenuItem;
			size = new System.Drawing.Size(253, 22);
			sdToolStripMenuItem.Size = size;
			this.SdToolStripMenuItem.Text = "My Followers";
			this.MyFollowingsToolStripMenuItem1.Name = "MyFollowingsToolStripMenuItem1";
			ToolStripMenuItem myFollowingsToolStripMenuItem1 = this.MyFollowingsToolStripMenuItem1;
			size = new System.Drawing.Size(253, 22);
			myFollowingsToolStripMenuItem1.Size = size;
			this.MyFollowingsToolStripMenuItem1.Text = "My Followings";
			this.PeopleWhoDontFollowMeBackToolStripMenuItem1.Name = "PeopleWhoDontFollowMeBackToolStripMenuItem1";
			ToolStripMenuItem peopleWhoDontFollowMeBackToolStripMenuItem1 = this.PeopleWhoDontFollowMeBackToolStripMenuItem1;
			size = new System.Drawing.Size(253, 22);
			peopleWhoDontFollowMeBackToolStripMenuItem1.Size = size;
			this.PeopleWhoDontFollowMeBackToolStripMenuItem1.Text = "People Who Dont Follow Me Back";
			this.PeopleWhoIDontFollowBackToolStripMenuItem1.Name = "PeopleWhoIDontFollowBackToolStripMenuItem1";
			ToolStripMenuItem peopleWhoIDontFollowBackToolStripMenuItem1 = this.PeopleWhoIDontFollowBackToolStripMenuItem1;
			size = new System.Drawing.Size(253, 22);
			peopleWhoIDontFollowBackToolStripMenuItem1.Size = size;
			this.PeopleWhoIDontFollowBackToolStripMenuItem1.Text = "People Who I Dont Follow Back";
			this.ReciprocalRelationshipToolStripMenuItem.Name = "ReciprocalRelationshipToolStripMenuItem";
			ToolStripMenuItem reciprocalRelationshipToolStripMenuItem = this.ReciprocalRelationshipToolStripMenuItem;
			size = new System.Drawing.Size(253, 22);
			reciprocalRelationshipToolStripMenuItem.Size = size;
			this.ReciprocalRelationshipToolStripMenuItem.Text = "Reciprocal relationship";
			ToolStripItemCollection dropDownItems2 = this.BrowserToolStripMenuItem.DropDownItems;
			toolStripProgressBar3 = new ToolStripItem[] { this.ReloadToolStripMenuItem, this.StopToolStripMenuItem1 };
			dropDownItems2.AddRange(toolStripProgressBar3);
			this.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem";
			ToolStripMenuItem browserToolStripMenuItem = this.BrowserToolStripMenuItem;
			size = new System.Drawing.Size(61, 20);
			browserToolStripMenuItem.Size = size;
			this.BrowserToolStripMenuItem.Text = "Browser";
			this.ReloadToolStripMenuItem.Image = Resources.Rotate;
			this.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem";
			this.ReloadToolStripMenuItem.ShortcutKeys = Keys.F5;
			ToolStripMenuItem reloadToolStripMenuItem = this.ReloadToolStripMenuItem;
			size = new System.Drawing.Size(144, 22);
			reloadToolStripMenuItem.Size = size;
			this.ReloadToolStripMenuItem.Text = "Reload";
			this.StopToolStripMenuItem1.Image = Resources.Cancel;
			this.StopToolStripMenuItem1.Name = "StopToolStripMenuItem1";
			this.StopToolStripMenuItem1.ShortcutKeys = Keys.MButton | Keys.ShiftKey | Keys.Capital | Keys.CapsLock | Keys.Space | Keys.Home | Keys.D0 | Keys.D4 | Keys.D | Keys.P | Keys.T | Keys.NumPad0 | Keys.NumPad4 | Keys.F1 | Keys.F5 | Keys.Control;
			ToolStripMenuItem stopToolStripMenuItem1 = this.StopToolStripMenuItem1;
			size = new System.Drawing.Size(144, 22);
			stopToolStripMenuItem1.Size = size;
			this.StopToolStripMenuItem1.Text = "Stop";
			this.ShortcutsToolStripMenuItem.Name = "ShortcutsToolStripMenuItem";
			ToolStripMenuItem shortcutsToolStripMenuItem = this.ShortcutsToolStripMenuItem;
			size = new System.Drawing.Size(69, 20);
			shortcutsToolStripMenuItem.Size = size;
			this.ShortcutsToolStripMenuItem.Text = "Shortcuts";
			this.MyFollowersToolStripMenuItem.Name = "MyFollowersToolStripMenuItem";
			ToolStripMenuItem myFollowersToolStripMenuItem = this.MyFollowersToolStripMenuItem;
			size = new System.Drawing.Size(254, 22);
			myFollowersToolStripMenuItem.Size = size;
			this.MyFollowersToolStripMenuItem.Text = "My Followers";
			this.MyFollowingsToolStripMenuItem.Name = "MyFollowingsToolStripMenuItem";
			ToolStripMenuItem myFollowingsToolStripMenuItem = this.MyFollowingsToolStripMenuItem;
			size = new System.Drawing.Size(254, 22);
			myFollowingsToolStripMenuItem.Size = size;
			this.MyFollowingsToolStripMenuItem.Text = "My Followings";
			this.PeopleWhoDontFollowMeBackToolStripMenuItem.Name = "PeopleWhoDontFollowMeBackToolStripMenuItem";
			ToolStripMenuItem peopleWhoDontFollowMeBackToolStripMenuItem = this.PeopleWhoDontFollowMeBackToolStripMenuItem;
			size = new System.Drawing.Size(254, 22);
			peopleWhoDontFollowMeBackToolStripMenuItem.Size = size;
			this.PeopleWhoDontFollowMeBackToolStripMenuItem.Text = "People who don't follow me  back";
			this.PeopleWhoIDontFollowBackToolStripMenuItem.Name = "PeopleWhoIDontFollowBackToolStripMenuItem";
			ToolStripMenuItem peopleWhoIDontFollowBackToolStripMenuItem = this.PeopleWhoIDontFollowBackToolStripMenuItem;
			size = new System.Drawing.Size(254, 22);
			peopleWhoIDontFollowBackToolStripMenuItem.Size = size;
			this.PeopleWhoIDontFollowBackToolStripMenuItem.Text = "People who I don't follow back";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(1281, 540);
			this.ClientSize = size;
			this.Controls.Add(this.WBrowser1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.MenuStrip1);
			this.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form1";
			this.Text = "Instagram Bot";
			this.WindowState = FormWindowState.Maximized;
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			((ISupportInitialize)this.NudPicPgMax).EndInit();
			((ISupportInitialize)this.NUDpages).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void Label1_Click(object sender, EventArgs e)
		{
		}

		private void Label1_Click_1(object sender, EventArgs e)
		{
		}

		private void Label5_Click(object sender, EventArgs e)
		{
		}

		private void Label6_Click(object sender, EventArgs e)
		{
		}

		private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Navigate("https://instagram.com/accounts/login/?next=/oauth/authorize%3Fclient_id%3Dd9494686198d4dfeb954979a3e270e5e%26redirect_uri%3Dhttp%253A%252F%252Fstatigr.am%26response_type%3Dcode%26scope%3Dlikes%2Bcomments%2Brelationships");
		}

		private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Navigate("https://instagram.com/accounts/login/");
		}

		private void LstBxToFlw_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void MyFollowersToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void MyFollowingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void MyFollowingsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/myFollowings/");
		}

		private void NudPicPgMax_ValueChanged(object sender, EventArgs e)
		{
		}

		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.Label5.Text = string.Concat("( ", Conversions.ToString(decimal.Multiply(this.NUDpages.Value, new decimal((long)50))), " People )");
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void pauseBot()
		{
			if (!this.PicLikeMode)
			{
				this.PauseTmrCd = this.TmrCode;
				this.TmrCode = "Bot_Paused";
			}
			else
			{
				this.TmrLike.Enabled = false;
			}
			this.BtnPause.Text = "Resume";
			this.BtnPause.Image = Resources.Player_play2;
			this.LstBox2.Items.Add("Task Paused....");
			this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
		}

		private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BtnPause.PerformClick();
		}

		private void PeopleWhoDontFollowMeBackToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PeopleWhoDontFollowMeBackToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/followingsEx");
		}

		private void PeopleWhoIDontFollowBackToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PeopleWhoIDontFollowBackToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/followersEx");
		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RadioButton1.Checked)
			{
				this.BotSpeed = 5;
			}
		}

		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RadioButton2.Checked)
			{
				this.BotSpeed = 7;
			}
		}

		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RadioButton4.Checked)
			{
				this.BotSpeed = 8;
			}
		}

		private void RadioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RadioButton4.Checked)
			{
				this.BotSpeed = 3;
			}
		}

		private void RadioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RadioButton5.Checked)
			{
				this.BotSpeed = 1;
			}
		}

		private void RadioButton6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RadioButton6.Checked)
			{
				this.BotSpeed = 11;
			}
		}

		private void ReciprocalRelationshipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/both");
		}

		private void ReloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Refresh();
		}

		private void ResumeBot()
		{
			if (!this.PicLikeMode)
			{
				this.TmrCode = this.PauseTmrCd;
				this.Tmr1.Enabled = true;
			}
			else
			{
				this.TmrLike.Enabled = true;
			}
			this.BtnPause.Text = "Pause";
			this.BtnPause.Image = Resources.Player_pause2;
			this.LstBox2.Items.Add("Task Resumed....");
			this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
		}

		private void SdToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Navigate("http://statigr.am/viewer.php#/myFollowers/");
		}

		private void StartFollow()
		{
			IEnumerator enumerator = null;
			this.WBrowser1.ScriptErrorsSuppressed = true;
			this.Tmr1.Enabled = true;
			this.TmrCode = "FollowMy_1";
			this.LstBxToFlw.Items.Clear();
			if (!this.Unfollowing)
			{
				this.LstBox2.Items.Add("Following New List Started....");
			}
			else
			{
				this.LstBox2.Items.Add("Unfollowing New List Started....");
			}
			HtmlElementCollection elementsByTagName = this.WBrowser1.Document.GetElementsByTagName("a");
			try
			{
				enumerator = elementsByTagName.GetEnumerator();
				while (enumerator.MoveNext())
				{
					HtmlElement current = (HtmlElement)enumerator.Current;
					if (Operators.CompareString(current.OuterHtml, null, false) == 0 || !(current.OuterHtml.ToString().ToLower().Contains("a href=\"#/user/") & !current.OuterHtml.ToString().Contains("lienPhotoGrid")))
					{
						continue;
					}
					string str = current.OuterHtml.ToString();
					int num = checked(str.IndexOf("\"") + 3);
					int num1 = str.IndexOf("\">", num);
					this.LstBxToFlw.Items.Add(string.Concat("http://statigr.am/viewer.php#", Strings.Mid(str, num, checked(checked(num1 - num) + 1))));
					this.BtnStop.Enabled = true;
					this.BtnPause.Enabled = true;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (this.LstBxToFlw.Items.Count > 0)
			{
				this.TmrCode = "FollowMy_2";
				this.FlwMyIndx = 0;
				this.ToolStripProgressBar4.Visible = true;
				this.ToolStripProgressBar3.Visible = true;
			}
			else if (this.Unfollowing)
			{
				Interaction.MsgBox("Can't find any followers in this page.", MsgBoxStyle.Exclamation, null);
			}
			else if (!this.ChkLoop.Checked)
			{
				Interaction.MsgBox("Can't find any unfollowing People in this page.", MsgBoxStyle.Exclamation, null);
			}
			else
			{
				this.TmrCode = "LoopNext_1";
				this.MkList2Cntr = 0;
				this.LstBox2.Items.Add("No one to follow...");
				this.LstBox2.Items.Add("Starting a new list...");
				this.LstBox2.Items.Add("http://statigr.am/viewer.php#/tag/car/");
				this.WBrowser1.Navigate("http://statigr.am/viewer.php#/tag/car/");
			}
			this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
		}

		private void StartListing()
		{
			if (decimal.Compare(this.NUDpages.Value, decimal.One) <= 0)
			{
				this.StartFollow();
			}
			else
			{
				this.Tmr1.Enabled = true;
				this.TmrCode = "MakeList_1";
				this.GotPageCount = 1;
				this.PgeLoadWaitCntr = 0;
				this.LstBox2.Items.Add("Making List Started....");
				this.LstBox2.Items.Add("...Pages Added: 1");
				this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
			}
			this.followedCount = 0;
		}

		private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		private void stopBot()
		{
			this.BtnPause.Enabled = false;
			this.BtnStop.Enabled = false;
			this.ToolStripProgressBar4.Visible = false;
			this.ToolStripProgressBar3.Visible = false;
			this.ToolStripStatusLabel2.Text = "";
			this.BtnPause.Image = Resources.Player_pause2;
			if (this.PicLikeMode)
			{
				this.TmrLike.Enabled = false;
				this.PicLikeMode = false;
			}
		}

		private void StopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BtnStop.PerformClick();
		}

		private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.WBrowser1.Stop();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			HttpWebResponse response = (HttpWebResponse)WebRequest.Create("http://tdsolomons.blogspot.com/2012/04/softwares.html").GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string end = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			response.Close();
			if (end.Contains("Instagram Bot - MAKE DEAD(3) = TRUE"))
			{
				Interaction.MsgBox("Trial has ended. Your Bot is Dead!", MsgBoxStyle.Critical, null);
				Interaction.SaveSetting(Application.CompanyName, "TrialMode", "TrialEnded", "True");
				ProjectData.EndApp();
			}
			this.Timer1.Enabled = true;
		}

		private void Tmr1_Tick(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			IEnumerator enumerator2 = null;
			IEnumerator enumerator3 = null;
			IEnumerator enumerator4 = null;
			IEnumerator enumerator5 = null;
			if (Operators.CompareString(this.TmrCode, "Login_1", false) == 0)
			{
				this.Tmr1.Enabled = false;
				this.TmrCode = this.LoginTemp_TmrCode;
				if (this.WBrowser1.Document.ToString().Contains("Please enter a correct username and password"))
				{
					this.Login_UN = null;
					Interaction.MsgBox("Please enter a correct username and password. Note that both fields are case-sensitive.", MsgBoxStyle.Exclamation, null);
					MyProject.Forms.Dialog1.TxtBxPw.Text = null;
					MyProject.Forms.Dialog1.TxtBxUN.Text = null;
				}
				if (Operators.CompareString(this.Login_UN, null, false) == 0)
				{
					if (MyProject.Forms.Dialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					{
						return;
					}
					this.Login_UN = MyProject.Forms.Dialog1.TxtBxUN.Text;
					this.Login_PW = MyProject.Forms.Dialog1.TxtBxPw.Text;
				}
				this.WBrowser1.Document.GetElementById("id_username").SetAttribute("value", this.Login_UN);
				this.WBrowser1.Document.GetElementById("id_password").SetAttribute("value", this.Login_PW);
				HtmlElementCollection elementsByTagName = this.WBrowser1.Document.GetElementsByTagName("input");
				try
				{
					enumerator = elementsByTagName.GetEnumerator();
					while (enumerator.MoveNext())
					{
						HtmlElement current = (HtmlElement)enumerator.Current;
						if (Operators.CompareString(current.OuterHtml, null, false) == 0 || !current.OuterHtml.ToString().Contains("submit"))
						{
							continue;
						}
						current.InvokeMember("click");
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.Tmr1.Enabled = true;
			}
			if (Operators.CompareString(this.TmrCode, "MakeList_1", false) == 0)
			{
				this.Tmr1.Enabled = false;
				this.PgeLoadWaitCntr = checked(this.PgeLoadWaitCntr + 5);
				HtmlElementCollection htmlElementCollections = this.WBrowser1.Document.GetElementsByTagName("a");
				bool flag = false;
				try
				{
					enumerator1 = htmlElementCollections.GetEnumerator();
					while (enumerator1.MoveNext())
					{
						HtmlElement htmlElement = (HtmlElement)enumerator1.Current;
						if (Operators.CompareString(htmlElement.OuterHtml, null, false) == 0 || !(htmlElement.OuterHtml.ToString().Contains("more-gettaggrid-") | htmlElement.OuterHtml.ToString().Contains("more-followingsex-") | htmlElement.OuterHtml.ToString().Contains("more-followersex-") | htmlElement.OuterHtml.ToString().Contains("more-followers-") | htmlElement.OuterHtml.ToString().Contains("more-followings-")))
						{
							continue;
						}
						htmlElement.InvokeMember("click");
						this.LstBox2.Items.Add(string.Concat("...Pages Added: ", Conversions.ToString(checked(this.GotPageCount + 1))));
						flag = true;
						this.GotPageCount = checked(this.GotPageCount + 1);
						this.PgeLoadWaitCntr = 0;
					}
				}
				finally
				{
					if (enumerator1 is IDisposable)
					{
						(enumerator1 as IDisposable).Dispose();
					}
				}
				if (!flag & this.PgeLoadWaitCntr > 100)
				{
					this.LstBox2.Items.Add(string.Concat("...Only ", Conversions.ToString(this.GotPageCount), " pages are avilable."));
					this.MkList2Cntr = 0;
					this.TmrCode = "MakeList_2";
				}
				if (decimal.Compare(new decimal(this.GotPageCount), this.NUDpages.Value) >= 0)
				{
					this.LstBox2.Items.Add("...Continued.");
					this.MkList2Cntr = 0;
					this.TmrCode = "MakeList_2";
				}
				this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
				this.Tmr1.Enabled = true;
			}
			if (Operators.CompareString(this.TmrCode, "MakeList_2", false) == 0)
			{
				this.MkList2Cntr = checked(this.MkList2Cntr + 6);
				if (this.MkList2Cntr > 100)
				{
					this.Tmr1.Enabled = false;
					this.StartFollow();
				}
			}
			if (Operators.CompareString(this.TmrCode, "LoopNext_1", false) == 0)
			{
				this.MkList2Cntr = checked(this.MkList2Cntr + 1);
				if (this.MkList2Cntr > 100)
				{
					this.StartListing();
					this.MkList2Cntr = 1;
				}
			}
			if (Operators.CompareString(this.TmrCode, "FollowMy_2", false) == 0)
			{
				this.Tmr1.Enabled = false;
				if (this.FlwMyIndx > checked(this.LstBxToFlw.Items.Count - 1))
				{
					if (!this.ChkLoop.Checked)
					{
						this.TmrCode = "FollowMy_4";
						this.ToolStripProgressBar4.Visible = false;
						this.LstBox2.Items.Add("Task Completed.......");
						this.BtnPause.Enabled = false;
						this.BtnStop.Enabled = false;
						this.stopBot();
					}
					else
					{
						this.TmrCode = "LoopNext_1";
						this.MkList2Cntr = 0;
						this.LstBox2.Items.Add("End of the Listd...");
						this.LstBox2.Items.Add("Starting a new list...");
						if (this.LstBxToFlw.Items.Count >= 3)
						{
							string str = this.LstBxToFlw.Items[checked((int)Math.Round((double)((float)(1f + VBMath.Rnd((float)(checked(this.LstBxToFlw.Items.Count - 2)))))))].ToString();
							int num = str.IndexOf("user/");
							string str1 = string.Concat("http://statigr.am/viewer.php#/followings", Strings.Mid(str, checked(num + 5), checked(checked(str.Length - 1) - (checked(num + 5)))));
							this.LstBox2.Items.Add(str1);
							this.WBrowser1.Navigate(str1);
						}
						else
						{
							this.LstBox2.Items.Add("http://statigr.am/viewer.php#/tag/girl/");
							this.WBrowser1.Navigate("http://statigr.am/viewer.php#/tag/girl/");
						}
					}
				}
				else if (this.SecCountr > 100 | this.FlwMyIndx == 0)
				{
					this.TmrCode = "FollowMy_3";
					this.LstBxToFlw.SelectedIndex = this.FlwMyIndx;
					this.ToolStripStatusLabel2.Text = string.Concat(Conversions.ToString(this.FlwMyIndx), "/", Conversions.ToString(this.LstBxToFlw.Items.Count));
					this.RequestedFlw = false;
					this.SecCountr = 0;
					try
					{
						this.WBrowser1.Navigate(this.LstBxToFlw.Items[this.FlwMyIndx].ToString());
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						this.TmrCode = "FollowMy_2";
						this.pauseBot();
						Interaction.MsgBox("Cannot Navigate, Try Resume.", MsgBoxStyle.Exclamation, null);
						ProjectData.ClearProjectError();
					}
				}
				if (this.SecCountr <= 100)
				{
					HtmlElementCollection elementsByTagName1 = this.WBrowser1.Document.GetElementsByTagName("img");
					try
					{
						enumerator2 = elementsByTagName1.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							HtmlElement current1 = (HtmlElement)enumerator2.Current;
							if (Operators.CompareString(current1.OuterHtml, null, false) == 0)
							{
								continue;
							}
							current1.SetAttribute("src", "");
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.ToolStripProgressBar3.Value = this.SecCountr;
					this.SecCountr = checked(this.SecCountr + this.BotSpeed);
					string str2 = "";
					HtmlElementCollection htmlElementCollections1 = this.WBrowser1.Document.GetElementsByTagName("span");
					try
					{
						enumerator3 = htmlElementCollections1.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							HtmlElement htmlElement1 = (HtmlElement)enumerator3.Current;
							if (!htmlElement1.OuterHtml.ToString().Contains("class=\"username\">"))
							{
								continue;
							}
							int num1 = checked(htmlElement1.OuterHtml.ToString().LastIndexOf("class=\"username\">") + 18);
							int num2 = htmlElement1.OuterHtml.ToString().IndexOf("<", num1);
							str2 = Strings.Mid(htmlElement1.OuterHtml.ToString(), num1, checked(num2 - num1));
							if (!(Operators.CompareString(this.LastUserNm, str2, false) != 0 & this.RequestedFlw))
							{
								continue;
							}
							this.RequestedFlw = false;
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					HtmlElementCollection elementsByTagName2 = this.WBrowser1.Document.GetElementsByTagName("a");
					try
					{
						enumerator4 = elementsByTagName2.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							HtmlElement current2 = (HtmlElement)enumerator4.Current;
							if (current2.OuterHtml.ToString().Contains("javascript:history.back();"))
							{
								this.LstBox2.Items.Add("Skipped : Account is private");
								this.SecCountr = checked(this.SecCountr + 105);
							}
							if (Operators.CompareString(current2.OuterHtml, null, false) == 0)
							{
								continue;
							}
							if (this.Unfollowing)
							{
								if (!current2.OuterHtml.ToString().Contains("unfollowAction user-relation-action"))
								{
									continue;
								}
								current2.InvokeMember("click");
							}
							else if (current2.OuterHtml.ToString().Contains("unfollowAction user-relation-action"))
							{
								this.LstBox2.Items.Add("Skipped : Already Following...");
								this.SecCountr = 101;
							}
							else
							{
								if (current2.OuterHtml.ToString().Contains("followAction user-relation-action") & !this.RequestedFlw)
								{
									current2.InvokeMember("click");
									this.RequestedFlw = true;
									this.LastUserNm = str2;
									this.LstBox2.Items.Add(string.Concat("Followed.. ", str2));
								}
								if (!current2.OuterHtml.ToString().Contains("user-relation-action unfollowAction"))
								{
									continue;
								}
								this.SecCountr = 101;
								if (this.LstBox2.Items.Count > 10000)
								{
									this.LstBox2.Items.Clear();
								}
							}
						}
					}
					finally
					{
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
					this.Tmr1.Enabled = true;
				}
				this.LstBox2.Items.Add(string.Concat(this.SecCountr.ToString(), ", ", this.RequestedFlw.ToString()));
				this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
			}
			if (Operators.CompareString(this.TmrCode, "FWFme_2", false) == 0)
			{
				this.MkList2Cntr = checked(this.MkList2Cntr + 5);
				if (this.MkList2Cntr > 100)
				{
					this.StartListing();
					this.MkList2Cntr = 0;
				}
			}
			if (Operators.CompareString(this.TmrCode, "UWFme_2", false) == 0)
			{
				this.MkList2Cntr = checked(this.MkList2Cntr + 5);
				if (this.MkList2Cntr > 100)
				{
					this.StartListing();
					this.MkList2Cntr = 0;
				}
			}
			if (Operators.CompareString(this.TmrCode, "LikeMorePage_1", false) == 0)
			{
				this.Tmr1.Enabled = false;
				this.PgeLoadWaitCntr = checked(this.PgeLoadWaitCntr + 5);
				HtmlElementCollection htmlElementCollections2 = this.WBrowser1.Document.GetElementsByTagName("a");
				bool flag1 = false;
				try
				{
					enumerator5 = htmlElementCollections2.GetEnumerator();
					while (enumerator5.MoveNext())
					{
						HtmlElement htmlElement2 = (HtmlElement)enumerator5.Current;
						if (Operators.CompareString(htmlElement2.OuterHtml, null, false) == 0 || !(htmlElement2.OuterHtml.ToString().Contains("more-getfeedgrid-") | htmlElement2.OuterHtml.ToString().Contains("more-gettaggrid-")))
						{
							continue;
						}
						htmlElement2.InvokeMember("click");
						this.LstBox2.Items.Add(string.Concat("...Pages Added: ", Conversions.ToString(checked(this.GotPageCount + 1))));
						flag1 = true;
						this.GotPageCount = checked(this.GotPageCount + 1);
						this.PgeLoadWaitCntr = 0;
					}
				}
				finally
				{
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				if (!flag1 & this.PgeLoadWaitCntr > 100)
				{
					this.LstBox2.Items.Add(string.Concat("...Only ", Conversions.ToString(this.GotPageCount), " pages are avilable."));
					this.MkList2Cntr = 0;
					this.TmrCode = "23342";
					this.TmrLike.Enabled = true;
				}
				if (decimal.Compare(new decimal(this.GotPageCount), this.NudPicPgMax.Value) >= 0)
				{
					this.LstBox2.Items.Add("...Continued.");
					this.MkList2Cntr = 0;
					this.TmrCode = "234234";
					this.TmrLike.Enabled = true;
				}
				this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
				this.Tmr1.Enabled = true;
			}
		}

		private void TmrLike_Tick(object sender, EventArgs e)
		{
			int num = 0;
			int num1;
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			int num2;
			int num3;
			HtmlElementCollection elementsByTagName = this.WBrowser1.Document.GetElementsByTagName("a");
			bool flag = false;
			try
			{
				enumerator = elementsByTagName.GetEnumerator();
				while (enumerator.MoveNext())
				{
					HtmlElement current = (HtmlElement)enumerator.Current;
					if (Operators.CompareString(current.OuterHtml, null, false) == 0 || !current.OuterHtml.ToString().Contains("like_picto_unselected likeAction"))
					{
						continue;
					}
					num = checked(num + 1);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			try
			{
				enumerator1 = elementsByTagName.GetEnumerator();
				while (enumerator1.MoveNext())
				{
					HtmlElement htmlElement = (HtmlElement)enumerator1.Current;
					if (Operators.CompareString(htmlElement.OuterHtml, null, false) == 0)
					{
						this.LstBox2.Items.Add("Task Completed...");
						this.stopBot();
						if (this.LikeCount != -1)
						{
							this.ToolStripStatusLabel2.Text = string.Concat(Conversions.ToString(checked(this.LikeCount - num)), "/", Conversions.ToString(this.LikeCount));
							num1 = checked((int)Math.Round((double)(checked(this.LikeCount - num)) / (double)this.LikeCount * 100));
							if (num1 > 0 & num1 <= this.ToolStripProgressBar4.Maximum)
							{
								this.ToolStripProgressBar4.Value = checked((int)Math.Round((double)(checked(this.LikeCount - num)) / (double)this.LikeCount * 100));
							}
							if (checked(this.LikeCount - num) < 0)
							{
								this.LikeCount = -1;
							}
						}
						else
						{
							this.LikeCount = num;
						}
						if (!flag)
						{
							num2 = this.LstBox2.Items.Add("No more Pictures to like...");
							num3 = this.LstBox2.Items.Add("Task Completed...");
							this.ToolStripStatusLabel2.Text = "";
							this.stopBot();
						}
						this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
						return;
					}
					else
					{
						if (!htmlElement.OuterHtml.ToString().Contains("like_picto_unselected likeAction"))
						{
							continue;
						}
						htmlElement.InvokeMember("click");
						flag = true;
						num = checked(num + 1);
						this.LstBox2.Items.Add("like...");
						if (this.LikeCount != -1)
						{
							this.ToolStripStatusLabel2.Text = string.Concat(Conversions.ToString(checked(this.LikeCount - num)), "/", Conversions.ToString(this.LikeCount));
							num1 = checked((int)Math.Round((double)(checked(this.LikeCount - num)) / (double)this.LikeCount * 100));
							if (num1 > 0 & num1 <= this.ToolStripProgressBar4.Maximum)
							{
								this.ToolStripProgressBar4.Value = checked((int)Math.Round((double)(checked(this.LikeCount - num)) / (double)this.LikeCount * 100));
							}
							if (checked(this.LikeCount - num) < 0)
							{
								this.LikeCount = -1;
							}
						}
						else
						{
							this.LikeCount = num;
						}
						if (!flag)
						{
							num2 = this.LstBox2.Items.Add("No more Pictures to like...");
							num3 = this.LstBox2.Items.Add("Task Completed...");
							this.ToolStripStatusLabel2.Text = "";
							this.stopBot();
						}
						this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
						return;
					}
				}
			}
			finally
			{
				if (enumerator1 is IDisposable)
				{
					(enumerator1 as IDisposable).Dispose();
				}
			}
			if (this.LikeCount != -1)
			{
				this.ToolStripStatusLabel2.Text = string.Concat(Conversions.ToString(checked(this.LikeCount - num)), "/", Conversions.ToString(this.LikeCount));
				num1 = checked((int)Math.Round((double)(checked(this.LikeCount - num)) / (double)this.LikeCount * 100));
				if (num1 > 0 & num1 <= this.ToolStripProgressBar4.Maximum)
				{
					this.ToolStripProgressBar4.Value = checked((int)Math.Round((double)(checked(this.LikeCount - num)) / (double)this.LikeCount * 100));
				}
				if (checked(this.LikeCount - num) < 0)
				{
					this.LikeCount = -1;
				}
			}
			else
			{
				this.LikeCount = num;
			}
			if (!flag)
			{
				num2 = this.LstBox2.Items.Add("No more Pictures to like...");
				num3 = this.LstBox2.Items.Add("Task Completed...");
				this.ToolStripStatusLabel2.Text = "";
				this.stopBot();
			}
			this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
		}

		private void TxtTag_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void TxtTag_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void TxtTag_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.Button5.PerformClick();
			}
		}

		private void UnfollowEveryoneOnThisPageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BtnStop.PerformClick();
			this.Label5.Text = string.Concat("( ", Conversions.ToString(decimal.Multiply(this.NUDpages.Value, new decimal((long)50))), " People )");
			this.Unfollowing = true;
			this.StartListing();
		}

		private void UnfollowEveryoneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Button1.PerformClick();
		}

		private void UnfollowWhoDontFollowMeBackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Button6.PerformClick();
		}

		private void WBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			// 
			// Current member / type: System.Void WindowsApplication2.Form1::WBrowser1_Navigated(System.Object,System.Windows.Forms.WebBrowserNavigatedEventArgs)
			// File path: F:\master hack\Hackpack V2\Hackpack\Bots\Instagram Bot.exe
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void WBrowser1_Navigated(System.Object,System.Windows.Forms.WebBrowserNavigatedEventArgs)
			// 
			// Object reference not set to an instance of an object.
			//    at ..() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 112
			//    at ..( ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 26
			//    at ..BuildTree( ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\FastDominatorTreeBuilder.cs:line 25
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DominatorTreeDependentStep.cs:line 18
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 68
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
			//    at ..() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
			//    at ..(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		private void WBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			// 
			// Current member / type: System.Void WindowsApplication2.Form1::WBrowser1_Navigating(System.Object,System.Windows.Forms.WebBrowserNavigatingEventArgs)
			// File path: F:\master hack\Hackpack V2\Hackpack\Bots\Instagram Bot.exe
			// 
			// Product version: 2019.1.118.0
			// Exception in: System.Void WBrowser1_Navigating(System.Object,System.Windows.Forms.WebBrowserNavigatingEventArgs)
			// 
			// Object reference not set to an instance of an object.
			//    at ..() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 112
			//    at ..( ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 26
			//    at ..BuildTree( ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\FastDominatorTreeBuilder.cs:line 25
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DominatorTreeDependentStep.cs:line 18
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 68
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
			//    at ..(ILogicalConstruct ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
			//    at ..() in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
			//    at ..(DecompilationContext ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
			//    at ..(MethodBody ,  , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
			//    at ..(MethodBody , ILanguage ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
			//    at Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 95
			//    at Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 58
			//    at ..(ILanguage , MethodDefinition ,  ) in C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 117
			// 
			// mailto: JustDecompilePublicFeedback@telerik.com

		}

		private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			IEnumerator enumerator = null;
			IEnumerator enumerator1 = null;
			this.ToolStripStatusLabel1.Text = "Status: Loading Complete. ";
			this.ToolStripStatusLabel1.Image = null;
			if (this.WBrowser1.Url.ToString().Contains("instagram.com/accounts/login"))
			{
				this.LoginTemp_TmrCode = this.TmrCode;
				this.TmrCode = "Login_1";
				return;
			}
			if (Operators.CompareString(this.TmrCode, "FollowMy_1", false) == 0)
			{
				this.LstBxToFlw.Items.Clear();
				HtmlElementCollection elementsByTagName = this.WBrowser1.Document.GetElementsByTagName("a");
				try
				{
					enumerator = elementsByTagName.GetEnumerator();
					while (enumerator.MoveNext())
					{
						HtmlElement current = (HtmlElement)enumerator.Current;
						if (Operators.CompareString(current.OuterHtml, null, false) == 0 || !(current.OuterHtml.ToString().Contains("<a href=\"#/user/") & !current.OuterHtml.ToString().Contains("class=\"lienPhotoGrid")))
						{
							continue;
						}
						string str = current.OuterHtml.ToString();
						int num = checked(str.IndexOf("\"") + 3);
						int num1 = str.IndexOf("\">", num);
						this.LstBxToFlw.Items.Add(string.Concat("http://statigr.am/viewer.php#", Strings.Mid(str, num, checked(checked(num1 - num) + 1))));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (this.LstBxToFlw.Items.Count > 0)
				{
					this.TmrCode = "FollowMy_2";
					this.FlwMyIndx = 0;
				}
			}
			if (Operators.CompareString(this.TmrCode, "FollowMy_3", false) == 0)
			{
				this.LstBox2.Items.Add("Quick load complete..");
				HtmlElementCollection htmlElementCollections = this.WBrowser1.Document.GetElementsByTagName("a");
				try
				{
					enumerator1 = htmlElementCollections.GetEnumerator();
					while (enumerator1.MoveNext())
					{
						HtmlElement htmlElement = (HtmlElement)enumerator1.Current;
						if (htmlElement.OuterHtml.ToString().Contains("Oops... this account is private."))
						{
							this.LstBox2.Items.Add("Skipped : Account is private");
							this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
						}
						if (Operators.CompareString(htmlElement.OuterHtml, null, false) == 0)
						{
							continue;
						}
						if (this.Unfollowing)
						{
							if (!htmlElement.OuterHtml.ToString().Contains("unfollowAction user-relation-action"))
							{
								continue;
							}
							htmlElement.InvokeMember("click");
							this.LstBox2.Items.Add(string.Concat(Conversions.ToString(checked(this.FlwMyIndx + 1)), ". Unfollowed ", this.LstBxToFlw.Items[this.FlwMyIndx].ToString()));
							this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
							this.followedCount = checked(this.followedCount + 1);
						}
						else if (htmlElement.OuterHtml.ToString().Contains("unfollowAction user-relation-action"))
						{
							this.LstBox2.Items.Add("Skipped : Already Following...");
							this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
						}
						else
						{
							if (!(htmlElement.OuterHtml.ToString().Contains("followAction user-relation-action") & !this.RequestedFlw))
							{
								continue;
							}
							this.LstBox2.Items.Add(string.Concat(Conversions.ToString(checked(this.FlwMyIndx + 1)), ". Followed ", this.LstBxToFlw.Items[this.FlwMyIndx].ToString()));
							this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
							this.followedCount = checked(this.followedCount + 1);
						}
					}
				}
				finally
				{
					if (enumerator1 is IDisposable)
					{
						(enumerator1 as IDisposable).Dispose();
					}
				}
				this.ToolStripProgressBar4.Value = checked((int)Math.Round((double)this.FlwMyIndx / (double)this.LstBxToFlw.Items.Count * (double)this.ToolStripProgressBar4.Maximum));
				this.FlwMyIndx = checked(this.FlwMyIndx + 1);
				this.RequestedFlw = false;
				this.TmrCode = "FollowMy_2";
				this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
				this.Tmr1.Enabled = true;
			}
			if (Operators.CompareString(this.TmrCode, "FWFme_1", false) == 0)
			{
				this.TmrCode = "FWFme_2";
				this.MkList2Cntr = 0;
				this.LstBox2.Items.Add("Waiting...");
				this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
			}
			if (Operators.CompareString(this.TmrCode, "UWFme_1", false) == 0)
			{
				this.TmrCode = "UWFme_2";
				this.MkList2Cntr = 0;
				this.LstBox2.Items.Add("Unfollow Started...");
				this.LstBox2.Items.Add("Waiting...");
				this.LstBox2.SelectedIndex = checked(this.LstBox2.Items.Count - 1);
			}
		}
	}
}