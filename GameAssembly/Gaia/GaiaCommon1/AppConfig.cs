/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace GaiaCommon1
{
	public class AppConfig // TypeDefIndex: 9152
	{
		// Fields
		public const string VERSION = "1"; // Metadata: 0x00778C6C
		public readonly string CfgVersion; // 0x10
		public readonly double LastUpdated; // 0x18
		public readonly string MinUnity; // 0x20
		public readonly string Name; // 0x28
		public readonly Texture2D Logo; // 0x30
		public readonly string NameSpace; // 0x38
		public readonly string Folder; // 0x40
		public readonly string ScriptsFolder; // 0x48
		public readonly string EditorScriptsFolder; // 0x50
		public readonly string DocsFolder; // 0x58
		public readonly string DocsFolderSpaced; // 0x60
		public readonly string MajorVersion; // 0x68
		public readonly string MinorVersion; // 0x70
		public readonly string PatchVersion; // 0x78
		public readonly string Version; // 0x80
		public readonly SystemLanguage[] AvailableLanguages; // 0x88
		public readonly string TutorialsLink; // 0x90
		public readonly string DiscordLink; // 0x98
		public readonly string SupportLink; // 0xA0
		public readonly string ASLink; // 0xA8
		public readonly string NewsURLStripped; // 0xB0
		public readonly bool HasWelcome; // 0xB8
	
		// Properties
		public string NewsURL { get; } // 0x00000001816F0020-0x00000001816F0230 
	
		// Constructors
		public AppConfig(string minUnity, string name, SystemLanguage[] availableLanguages); // 0x00000001816EFDD0-0x00000001816F0020
		public AppConfig(string cfgVersion, double lastUpdated, string minUnity, string name, Texture2D logo, string nameSpace, string folder, string scriptsFolder, string editorScriptsFolder, string docsFolder, string majorVer, string minorVer, string patchVer, SystemLanguage[] availableLang, string tutorialsLink, string discordLink, string supportLink, string asLink, string newsURL, bool hasWelcome); // 0x00000001816EFA30-0x00000001816EFDD0
	}
}
