using System;
using Eto.Forms;
using Eto.Drawing;
using a = Android;
using av = Android.Views;
using aw = Android.Widget;

namespace Eto.Platform.Android.Forms
{
	public interface IAndroidControl
	{
		av.View ContainerControl { get; }
	}

	public abstract class AndroidControl<T, TWidget> : WidgetHandler<T, TWidget>, IControl, IAndroidControl
		where TWidget: Control
	{
		public abstract av.View ContainerControl { get; }

		public void Invalidate()
		{
			throw new NotImplementedException();
		}

		public void Invalidate(Rectangle rect)
		{
			throw new NotImplementedException();
		}

		public void SuspendLayout()
		{
			throw new NotImplementedException();
		}

		public void ResumeLayout()
		{
			throw new NotImplementedException();
		}

		public void Focus()
		{
			throw new NotImplementedException();
		}

		public virtual void OnPreLoad(EventArgs e)
		{
		}

		public virtual void OnLoad(EventArgs e)
		{
		}

		public virtual void OnLoadComplete(EventArgs e)
		{
		}

		public virtual void OnUnLoad(EventArgs e)
		{
		}

		public virtual void SetParent(Container parent)
		{
		}

		public virtual void MapPlatformAction(string systemAction, BaseAction action)
		{
		}

		public PointF PointFromScreen(PointF point)
		{
			throw new NotImplementedException();
		}

		public PointF PointToScreen(PointF point)
		{
			throw new NotImplementedException();
		}

		Color? backgroundColor;
		public Color BackgroundColor
		{
			get { return backgroundColor ?? Colors.Transparent; }
			set
			{
				backgroundColor = value;
				ContainerControl.SetBackgroundColor(value.ToAndroid());
			}
		}

		public Size Size
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool Enabled
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public bool HasFocus
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool Visible
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public virtual Point Location
		{
			get
			{
				throw new NotImplementedException();
			}
			set { }
		}

	}
}
