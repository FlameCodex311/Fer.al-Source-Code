/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.FB.Wrapper
{
	internal static class NativeMethods // TypeDefIndex: 9932
	{
		// Nested types
		public delegate int BrowseCallbackProc(IntPtr hwnd, int uMsg, IntPtr lParam, IntPtr lpData); // TypeDefIndex: 9933; 0x00000001815CCF80-0x00000001815CD280
	
		internal struct OpenFileName // TypeDefIndex: 9934
		{
			// Fields
			public int structSize; // 0x00
			public IntPtr dlgOwner; // 0x08
			public IntPtr instance; // 0x10
			public string filter; // 0x18
			public string customFilter; // 0x20
			public int maxCustFilter; // 0x28
			public int filterIndex; // 0x2C
			public IntPtr file; // 0x30
			public int maxFile; // 0x38
			public string fileTitle; // 0x40
			public int maxFileTitle; // 0x48
			public string initialDir; // 0x50
			public string title; // 0x58
			public int flags; // 0x60
			public ushort fileOffset; // 0x64
			public ushort fileExtension; // 0x66
			public string defExt; // 0x68
			public string custData; // 0x70
			public IntPtr hook; // 0x78
			public string templateName; // 0x80
			public IntPtr reservedPtr; // 0x88
			public int reservedInt; // 0x90
			public int flagsEx; // 0x94
		}
	
		internal struct BROWSEINFO // TypeDefIndex: 9935
		{
			// Fields
			public IntPtr dlgOwner; // 0x00
			public IntPtr pidlRoot; // 0x08
			public IntPtr pszDisplayName; // 0x10
			public string lpszTitle; // 0x18
			public uint ulFlags; // 0x20
			public BrowseCallbackProc lpfn; // 0x28
			public IntPtr lParam; // 0x30
			public int iImage; // 0x38
		}
	
		// Methods
		public static extern bool GetOpenFileName(ref OpenFileName ofn); // 0x00000001815E9C90-0x00000001815E9E40
		public static extern bool GetSaveFileName(ref OpenFileName sfn); // 0x00000001815E9E40-0x00000001815E9FF0
		internal static extern IntPtr SHBrowseForFolder(ref BROWSEINFO lpbi); // 0x00000001815E9FF0-0x00000001815EA1B0
		internal static extern bool SHGetPathFromIDList(IntPtr pidl, IntPtr pszPath); // 0x00000001815EA1B0-0x00000001815EA260
		internal static extern IntPtr GetActiveWindow(); // 0x00000001815E9AB0-0x00000001815E9B40
		public static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, int wParam, IntPtr lParam); // 0x00000001815EA260-0x00000001815EA320
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, string lParam); // 0x00000001815EA320-0x00000001815EA400
	}
}
