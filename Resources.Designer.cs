using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsApplication2.My.Resources
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[HideModuleName]
	internal static class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		internal static Bitmap Cancel
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(WindowsApplication2.My.Resources.Resources.ResourceManager.GetObject("Cancel", WindowsApplication2.My.Resources.Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return WindowsApplication2.My.Resources.Resources.resourceCulture;
			}
			set
			{
				WindowsApplication2.My.Resources.Resources.resourceCulture = value;
			}
		}

		internal static Bitmap Favorite2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(WindowsApplication2.My.Resources.Resources.ResourceManager.GetObject("Favorite2", WindowsApplication2.My.Resources.Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap loading2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(WindowsApplication2.My.Resources.Resources.ResourceManager.GetObject("loading2", WindowsApplication2.My.Resources.Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap Player_pause2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(WindowsApplication2.My.Resources.Resources.ResourceManager.GetObject("Player_pause2", WindowsApplication2.My.Resources.Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap Player_play2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(WindowsApplication2.My.Resources.Resources.ResourceManager.GetObject("Player_play2", WindowsApplication2.My.Resources.Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		internal static Bitmap Player_stop2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(WindowsApplication2.My.Resources.Resources.ResourceManager.GetObject("Player_stop2", WindowsApplication2.My.Resources.Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(WindowsApplication2.My.Resources.Resources.resourceMan, null))
				{
					WindowsApplication2.My.Resources.Resources.resourceMan = new System.Resources.ResourceManager("WindowsApplication2.Resources", typeof(WindowsApplication2.My.Resources.Resources).Assembly);
				}
				return WindowsApplication2.My.Resources.Resources.resourceMan;
			}
		}

		internal static Bitmap Rotate
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(WindowsApplication2.My.Resources.Resources.ResourceManager.GetObject("Rotate", WindowsApplication2.My.Resources.Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}
	}
}