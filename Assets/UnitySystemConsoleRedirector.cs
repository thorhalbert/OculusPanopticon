using System;
using System.IO;
using System.Text;

using UnityEngine;

/// <summary>
/// Redirects writes to System.Console to Unity3D's Debug.Log.
/// </summary>
/// <author>
/// Jackson Dunstan, http://jacksondunstan.com/articles/2986
/// </author>
public static class UnitySystemConsoleRedirector
{
	private class UnityTextWriter : TextWriter
	{
		private StringBuilder buffer = new StringBuilder();

		public UnityTextWriter()
        {
			// Attach to the callback (try not to attach multiple times)

			//try
			//{
			//	Application.logMessageReceived -= doLogCallBack;
			//}
			//finally
			//{
			//	Application.logMessageReceived += doLogCallBack;
			//}
        }

		private void doLogCallBack(string condition, string stacktrace, LogType type)
        {
			// EventPlane.Log.DebugCallback(condition, stacktrace, (int)type);
        }

		public override void Flush()
		{
			//Debug.Log(buffer.ToString());  // Comment out if we're tapping debug above
			//EventPlane.Log.UnityConsole(buffer.ToString());
			//buffer.Length = 0;
		}

		public override void Write(string value)
		{
			buffer.Append(value);
			if (value != null)
			{
				var len = value.Length;
				if (len > 0)
				{
					var lastChar = value[len - 1];
					if (lastChar == '\n')
					{
						Flush();
					}
				}
			}
		}

		public override void Write(char value)
		{
			buffer.Append(value);
			if (value == '\n')
			{
				Flush();
			}
		}

		public override void Write(char[] value, int index, int count)
		{
			Write(new string(value, index, count));
		}

		public override Encoding Encoding
		{
			get { return Encoding.Default; }
		}
	}

	public static void Redirect()
	{
		Console.SetOut(new UnityTextWriter());
	}
}