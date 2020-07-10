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

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public abstract class BaseHelper // TypeDefIndex: 9945
	{
		// Fields
		public static readonly CultureInfo BaseCulture; // 0x00
		protected static readonly Regex lineEndingsRegex; // 0x08
		protected static readonly Regex cleanSpacesRegex; // 0x10
		protected static readonly Regex cleanTagsRegex; // 0x18
		protected static readonly System.Random rnd; // 0x20
		protected const string file_prefix = "file://"; // Metadata: 0x00746759
	
		// Properties
		public static bool isInternetAvailable { get; } // 0x00000001815CCAF0-0x00000001815CCB10 
		public static bool isWindowsPlatform { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public static bool isMacOSPlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isLinuxPlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isStandalonePlatform { get; } // 0x00000001815CCB10-0x00000001815CCB60 
		public static bool isAndroidPlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isIOSPlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isTvOSPlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isWSAPlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isXboxOnePlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isPS4Platform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isWebGLPlatform { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isWebPlatform { get; } // 0x00000001815CCBD0-0x00000001815CCC20 
		public static bool isWindowsBasedPlatform { get; } // 0x00000001815CCC20-0x00000001815CCC70 
		public static bool isWSABasedPlatform { get; } // 0x00000001815CCB60-0x00000001815CCBD0 
		public static bool isAppleBasedPlatform { get; } // 0x00000001815CC920-0x00000001815CC9A0 
		public static bool isIOSBasedPlatform { get; } // 0x00000001815CCA80-0x00000001815CCAF0 
		public static bool isEditor { get; } // 0x00000001815CCA00-0x00000001815CCA80 
		public static bool isWindowsEditor { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isMacOSEditor { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isLinuxEditor { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public static bool isEditorMode { get; } // 0x00000001815CC9A0-0x00000001815CCA00 
		public static bool isIL2CPP { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public static Crosstales.Common.Model.Enum.Platform CurrentPlatform { get; } // 0x00000001815CC7F0-0x00000001815CC840 
		public static string StreamingAssetsPath { get; } // 0x00000001815CC840-0x00000001815CC920 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9946
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<X509ChainStatus, bool> <>9__59_0; // 0x08
			public static Func<string, bool> <>9__62_0; // 0x10
			public static Func<string, string> <>9__62_1; // 0x18
	
			// Constructors
			static <>c(); // 0x00000001815ED950-0x00000001815ED9B0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RemoteCertificateValidationCallback>b__59_0(X509ChainStatus t); // 0x00000001815ED5A0-0x00000001815ED5B0
			internal bool <GetFiles>b__62_0(string extension); // 0x00000001815ED4D0-0x00000001815ED540
			internal string <GetFiles>b__62_1(string q); // 0x00000001804DE840-0x00000001804DE850
		}
	
		// Constructors
		protected BaseHelper(); // 0x000000018036B6C0-0x000000018036B6D0
		static BaseHelper(); // 0x00000001815CC410-0x00000001815CC530
	
		// Methods
		public static bool OpenURL(string url); // 0x00000001815CB380-0x00000001815CB430
		public static string CreateString(string replaceChars, int stringLength); // 0x00000001815C9AF0-0x00000001815C9C50
		public static bool hasActiveClip(AudioSource source); // 0x00000001815CCC70-0x00000001815CCDB0
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors); // 0x00000001815CB430-0x00000001815CB800
		public static string ValidatePath(string path, bool addEndDelimiter = true /* Metadata: 0x00746745 */); // 0x00000001815CC230-0x00000001815CC410
		public static string ValidateFile(string path); // 0x00000001815CC000-0x00000001815CC230
		public static string[] GetFiles(string path, bool isRecursive = false /* Metadata: 0x00746746 */, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815CAB00-0x00000001815CAF40
		public static string[] GetDirectories(string path, bool isRecursive = false /* Metadata: 0x00746747 */); // 0x00000001815CA910-0x00000001815CAB00
		public static string ValidURLFromFilePath(string path); // 0x00000001815CBDB0-0x00000001815CC000
		public static string CleanUrl(string url, bool removeProtocol = true /* Metadata: 0x00746748 */, bool removeWWW = true /* Metadata: 0x00746749 */, bool removeSlash = true /* Metadata: 0x0074674A */); // 0x00000001815C96D0-0x00000001815C9920
		public static string ClearTags(string text); // 0x00000001815C9A50-0x00000001815C9AF0
		public static string ClearSpaces(string text); // 0x00000001815C99C0-0x00000001815C9A50
		public static string ClearLineEndings(string text); // 0x00000001815C9920-0x00000001815C99C0
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true /* Metadata: 0x0074674B */, int skipHeaderLines = 0 /* Metadata: 0x0074674C */, int skipFooterLines = 0 /* Metadata: 0x00746750 */); // 0x00000001815CBB50-0x00000001815CBDB0
		public static string FormatBytesToHRF(long bytes); // 0x00000001815C9F10-0x00000001815CA1D0
		public static string FormatSecondsToHourMinSec(double seconds); // 0x00000001815CA1D0-0x00000001815CA910
		public static Color HSVToRGB(float h, float s, float v, float a = 1f /* Metadata: 0x00746754 */); // 0x00000001815CAF40-0x00000001815CB0F0
		public static bool isValidURL(string url); // 0x00000001815CCDB0-0x00000001815CCEB0
		public static void FileCopy(string inputFile, string outputFile, bool move = false /* Metadata: 0x00746758 */); // 0x00000001815C9C50-0x00000001815C9F10
		public static void ShowFileLocation(string file); // 0x00000001815CB800-0x00000001815CBB50
		public static void OpenFile(string file); // 0x00000001815CB0F0-0x00000001815CB380
		public static string getIP(string host); // 0x00000001815CC530-0x00000001815CC7F0
	}
}
