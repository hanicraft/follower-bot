using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsApplication2
{
	[DesignerGenerated]
	public class Dialog1 : Form
	{
		private IContainer components;

		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		[AccessedThroughProperty("TxtBxPw")]
		private TextBox _TxtBxPw;

		[AccessedThroughProperty("TxtBxUN")]
		private TextBox _TxtBxUN;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		internal virtual Button Cancel_Button
		{
			get
			{
				return this._Cancel_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Dialog1 dialog1 = this;
				EventHandler eventHandler = new EventHandler(dialog1.Cancel_Button_Click);
				if (this._Cancel_Button != null)
				{
					this._Cancel_Button.Click -= eventHandler;
				}
				this._Cancel_Button = value;
				if (this._Cancel_Button != null)
				{
					this._Cancel_Button.Click += eventHandler;
				}
			}
		}

		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
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

		internal virtual Button OK_Button
		{
			get
			{
				return this._OK_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				Dialog1 dialog1 = this;
				EventHandler eventHandler = new EventHandler(dialog1.OK_Button_Click);
				if (this._OK_Button != null)
				{
					this._OK_Button.Click -= eventHandler;
				}
				this._OK_Button = value;
				if (this._OK_Button != null)
				{
					this._OK_Button.Click += eventHandler;
				}
			}
		}

		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get
			{
				return this._TableLayoutPanel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TableLayoutPanel1 = value;
			}
		}

		internal virtual TextBox TxtBxPw
		{
			get
			{
				return this._TxtBxPw;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TxtBxPw = value;
			}
		}

		internal virtual TextBox TxtBxUN
		{
			get
			{
				return this._TxtBxUN;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TxtBxUN = value;
			}
		}

		public Dialog1()
		{
			Dialog1 dialog1 = this;
			base.Load += new EventHandler(dialog1.Dialog1_Load);
			this.InitializeComponent();
		}

		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void Dialog1_Load(object sender, EventArgs e)
		{
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

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.TableLayoutPanel1 = new TableLayoutPanel();
			this.OK_Button = new Button();
			this.Cancel_Button = new Button();
			this.TxtBxPw = new TextBox();
			this.TxtBxUN = new TextBox();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.TableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel1;
			Point point = new Point(219, 143);
			tableLayoutPanel1.Location = point;
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			TableLayoutPanel tableLayoutPanel = this.TableLayoutPanel1;
			System.Drawing.Size size = new System.Drawing.Size(146, 29);
			tableLayoutPanel.Size = size;
			this.TableLayoutPanel1.TabIndex = 0;
			this.OK_Button.Anchor = AnchorStyles.None;
			Button oKButton = this.OK_Button;
			point = new Point(3, 3);
			oKButton.Location = point;
			this.OK_Button.Name = "OK_Button";
			Button button = this.OK_Button;
			size = new System.Drawing.Size(67, 23);
			button.Size = size;
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.Anchor = AnchorStyles.None;
			this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Button cancelButton = this.Cancel_Button;
			point = new Point(76, 3);
			cancelButton.Location = point;
			this.Cancel_Button.Name = "Cancel_Button";
			Button cancelButton1 = this.Cancel_Button;
			size = new System.Drawing.Size(67, 23);
			cancelButton1.Size = size;
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			TextBox txtBxPw = this.TxtBxPw;
			point = new Point(160, 86);
			txtBxPw.Location = point;
			this.TxtBxPw.Name = "TxtBxPw";
			TextBox textBox = this.TxtBxPw;
			size = new System.Drawing.Size(126, 20);
			textBox.Size = size;
			this.TxtBxPw.TabIndex = 11;
			TextBox txtBxUN = this.TxtBxUN;
			point = new Point(160, 56);
			txtBxUN.Location = point;
			this.TxtBxUN.Name = "TxtBxUN";
			TextBox txtBxUN1 = this.TxtBxUN;
			size = new System.Drawing.Size(126, 20);
			txtBxUN1.Size = size;
			this.TxtBxUN.TabIndex = 10;
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(69, 89);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label = this.Label2;
			size = new System.Drawing.Size(59, 13);
			label.Size = size;
			this.Label2.TabIndex = 9;
			this.Label2.Text = "Password :";
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(69, 59);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label11 = this.Label1;
			size = new System.Drawing.Size(61, 13);
			label11.Size = size;
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Username :";
			this.AcceptButton = this.OK_Button;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			size = new System.Drawing.Size(377, 184);
			this.ClientSize = size;
			this.Controls.Add(this.TxtBxPw);
			this.Controls.Add(this.TxtBxUN);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dialog1";
			this.ShowInTaskbar = false;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Instagram Login";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void OK_Button_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.TxtBxUN.Text, null, false) == 0)
			{
				Interaction.MsgBox("Please enter Username.", MsgBoxStyle.Exclamation, null);
				return;
			}
			if (Operators.CompareString(this.TxtBxPw.Text, null, false) == 0)
			{
				Interaction.MsgBox("Please enter Password.", MsgBoxStyle.Exclamation, null);
				return;
			}
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
	}
}