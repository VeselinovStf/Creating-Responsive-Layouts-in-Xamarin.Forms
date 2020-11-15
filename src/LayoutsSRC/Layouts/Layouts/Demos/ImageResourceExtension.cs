using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
	[ContentProperty("Source")]
	public class ImageResourceExtension : IMarkupExtension
	{
		private static Assembly _assembly = System.Reflection.Assembly.GetAssembly(typeof(ImageResourceExtension));

		public string Source { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Source == null)
				return null;
			
			return ImageSource.FromResource(Source, _assembly);
		}
	}
}
