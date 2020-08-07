/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Crosstales.Common.Model.Enum;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public abstract class BaseHelper // TypeDefIndex: 9731
	{
		// Fields
		public static readonly CultureInfo BaseCulture; // 0x00
		protected static readonly Regex lineEndingsRegex; // 0x08
		protected static readonly Regex cleanSpacesRegex; // 0x10
		protected static readonly Regex cleanTagsRegex; // 0x18
		protected static readonly System.Random rnd; // 0x20
		protected const string file_prefix = "file://"; // Metadata: 0x0077AA24
	
		// Properties
		public static bool isInternetAvailable { get; } // 0x00000001810769D0-0x00000001810769F0 
		public static bool isWindowsPlatform { get; } // 0x0000000180380B60-0x0000000180380B70 
		public static bool isMacOSPlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isLinuxPlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isStandalonePlatform { get; } // 0x00000001810769F0-0x0000000181076A40 
		public static bool isAndroidPlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isIOSPlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isTvOSPlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isWSAPlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isXboxOnePlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isPS4Platform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isWebGLPlatform { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isWebPlatform { get; } // 0x0000000181076AB0-0x0000000181076B00 
		public static bool isWindowsBasedPlatform { get; } // 0x0000000181076B00-0x0000000181076B50 
		public static bool isWSABasedPlatform { get; } // 0x0000000181076A40-0x0000000181076AB0 
		public static bool isAppleBasedPlatform { get; } // 0x0000000181076800-0x0000000181076880 
		public static bool isIOSBasedPlatform { get; } // 0x0000000181076960-0x00000001810769D0 
		public static bool isEditor { get; } // 0x00000001810768E0-0x0000000181076960 
		public static bool isWindowsEditor { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isMacOSEditor { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isLinuxEditor { get; } // 0x0000000180380950-0x0000000180380960 
		public static bool isEditorMode { get; } // 0x0000000181076880-0x00000001810768E0 
		public static bool isIL2CPP { get; } // 0x0000000180380B60-0x0000000180380B70 
		public static Crosstales.Common.Model.Enum.Platform CurrentPlatform { get; } // 0x00000001810766D0-0x0000000181076720 
		public static string StreamingAssetsPath { get; } // 0x0000000181076720-0x0000000181076800 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9732
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<X509ChainStatus, bool> <>9__59_0; // 0x08
			public static Func<string, bool> <>9__62_0; // 0x10
			public static Func<string, string> <>9__62_1; // 0x18
	
			// Constructors
			static <>c(); // 0x000000018108D5B0-0x000000018108D610
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RemoteCertificateValidationCallback>b__59_0(X509ChainStatus t); // 0x000000018108D200-0x000000018108D210
			internal bool <GetFiles>b__62_0(string extension); // 0x000000018108D130-0x000000018108D1A0
			internal string <GetFiles>b__62_1(string q); // 0x00000001804EC160-0x00000001804EC170
		}
	
		// Constructors
		protected BaseHelper(); // 0x0000000180373240-0x0000000180373250
		static BaseHelper(); // 0x0000000181076310-0x0000000181076430
	
		// Methods
		public static bool OpenURL(string url); // 0x00000001810752D0-0x0000000181075380
		public static string CreateString(string replaceChars, int stringLength); // 0x0000000181073AC0-0x0000000181073C20
		public static bool hasActiveClip(AudioSource source); // 0x0000000181076B50-0x0000000181076C90
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors); // 0x0000000181075380-0x0000000181075730
		public static string ValidatePath(string path, bool addEndDelimiter = true /* Metadata: 0x0077AA10 */); // 0x0000000181076140-0x0000000181076310
		public static string ValidateFile(string path); // 0x0000000181075F10-0x0000000181076140
		public static string[] GetFiles(string path, bool isRecursive = false /* Metadata: 0x0077AA11 */, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181074A70-0x0000000181074EA0
		public static string[] GetDirectories(string path, bool isRecursive = false /* Metadata: 0x0077AA12 */); // 0x0000000181074880-0x0000000181074A70
		public static string ValidURLFromFilePath(string path); // 0x0000000181075CC0-0x0000000181075F10
		public static string CleanUrl(string url, bool removeProtocol = true /* Metadata: 0x0077AA13 */, bool removeWWW = true /* Metadata: 0x0077AA14 */, bool removeSlash = true /* Metadata: 0x0077AA15 */); // 0x00000001810736B0-0x00000001810738F0
		public static string ClearTags(string text); // 0x0000000181073A20-0x0000000181073AC0
		public static string ClearSpaces(string text); // 0x0000000181073990-0x0000000181073A20
		public static string ClearLineEndings(string text); // 0x00000001810738F0-0x0000000181073990
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true /* Metadata: 0x0077AA16 */, int skipHeaderLines = 0 /* Metadata: 0x0077AA17 */, int skipFooterLines = 0 /* Metadata: 0x0077AA1B */); // 0x0000000181075A70-0x0000000181075CC0
		public static string FormatBytesToHRF(long bytes); // 0x0000000181073EE0-0x0000000181074180
		public static string FormatSecondsToHourMinSec(double seconds); // 0x0000000181074180-0x0000000181074880
		public static Color HSVToRGB(float h, float s, float v, float a = 1f /* Metadata: 0x0077AA1F */); // 0x0000000181074EA0-0x0000000181075050
		public static bool isValidURL(string url); // 0x0000000181076C90-0x0000000181076D90
		public static void FileCopy(string inputFile, string outputFile, bool move = false /* Metadata: 0x0077AA23 */); // 0x0000000181073C20-0x0000000181073EE0
		public static void ShowFileLocation(string file); // 0x0000000181075730-0x0000000181075A70
		public static void OpenFile(string file); // 0x0000000181075050-0x00000001810752D0
		public static string getIP(string host); // 0x0000000181076430-0x00000001810766D0
	}
}
