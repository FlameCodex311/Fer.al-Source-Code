/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public static class DebugConsole // TypeDefIndex: 15705
	{
		// Fields
		private static Dictionary<object, List<ConsoleMethodInfo>> _buttonMethods; // 0x00
		private static Dictionary<object, List<ConsoleFieldInfo>> _buttonFields; // 0x08
		private static Dictionary<string, ConsoleMethodInfo> methods; // 0x10
		public static Action<ConsoleMethodInfo> OnCommandAdded; // 0x18
		public static Action<ConsoleMethodInfo> OnCommandRemoved; // 0x20
		public static Action OnDebugMethodsChanged; // 0x28
		public static Dictionary<Type, ParseFunction> parseFunctions; // 0x30
		public static Dictionary<Type, string> typeReadableNames; // 0x38
		private static List<string> commandArguments; // 0x40
		private static readonly string[] inputDelimiters; // 0x48
	
		// Properties
		public static Dictionary<object, List<ConsoleMethodInfo>> ButtonMethods { get; } // 0x0000000181123E20-0x0000000181123E80 
		public static Dictionary<object, List<ConsoleFieldInfo>> ButtonFields { get; } // 0x0000000181123DC0-0x0000000181123E20 
		public static Dictionary<string, ConsoleMethodInfo> Methods { get; } // 0x0000000181123E80-0x0000000181123EE0 
	
		// Nested types
		public delegate bool ParseFunction(string input, out object output); // TypeDefIndex: 15706; 0x0000000180B1E320-0x0000000180B1E7C0
	
		// Constructors
		static DebugConsole(); // 0x0000000181123B20-0x0000000181123DC0
	
		// Methods
		private static void InitDebugConsole(); // 0x0000000181122230-0x0000000181123190
		[ConsoleCommand] // 0x000000018015DE60-0x000000018015DEB0
		public static string LogAllCommands(); // 0x0000000181123190-0x00000001811231C0
		[ConsoleCommand] // 0x000000018015E0A0-0x000000018015E0F0
		public static string LogSystemInfo(); // 0x00000001811231C0-0x00000001811231F0
		public static void AddCommandInstance(string command, string description, string methodName, object instance); // 0x00000001803581E0-0x00000001803581F0
		public static void AddCommandStatic(string command, string description, string methodName, Type ownerType); // 0x00000001803581E0-0x00000001803581F0
		public static void RemoveCommand(string command); // 0x00000001803581E0-0x00000001803581F0
		private static void AddCommand(string command, string description, string methodName, Type ownerType, object instance = null); // 0x00000001811211B0-0x00000001811213F0
		private static void AddCommand(string command, string description, MethodInfo method, object instance = null); // 0x00000001811207D0-0x00000001811211B0
		public static string ExecuteCommand(string command); // 0x00000001811220C0-0x00000001811220F0
		public static void AddDebugButtons(object inObject); // 0x00000001803581E0-0x00000001803581F0
		public static void AddDebugButton<T>(T inDelegate, string inButtonText, object inId, string inButtonGroup = "General" /* Metadata: 0x00784E62 */, bool inCloseOnClick = false /* Metadata: 0x00784E6D */)
			where T : Delegate;
		public static void RemoveDebugButtons(object inId); // 0x00000001803581E0-0x00000001803581F0
		private static void AddDebugButtonMethod(MethodInfo inMethod, DebugButtonAttribute inAttribute, object inTarget, object inId = null); // 0x00000001803581E0-0x00000001803581F0
		public static void AddDebugField(string inFieldName, object inTarget, string inFieldText, object inId, string inGroup = "General" /* Metadata: 0x00784E6E */, bool inReadonly = false /* Metadata: 0x00784E79 */); // 0x00000001803581E0-0x00000001803581F0
		private static void AddDebugButtonField(FieldInfo inField, DebugFieldAttribute inAttribute, object inTarget, object inId); // 0x00000001811216F0-0x00000001811219D0
		private static void AddDebugButtonField(PropertyInfo inProperty, DebugFieldAttribute inAttribute, object inTarget, object inId); // 0x00000001811213F0-0x00000001811216F0
		private static int IndexOfDelimiter(char c); // 0x0000000181122120-0x0000000181122230
		private static int IndexOfChar(string command, char c, int startIndex); // 0x00000001811220F0-0x0000000181122120
		private static bool ParseString(string input, out object output); // 0x00000001811237B0-0x00000001811237D0
		private static bool ParseBool(string input, out object output); // 0x00000001811231F0-0x00000001811232F0
		private static bool ParseInt(string input, out object output); // 0x00000001811235D0-0x0000000181123640
		private static bool ParseUInt(string input, out object output); // 0x00000001811237D0-0x0000000181123840
		private static bool ParseLong(string input, out object output); // 0x0000000181123640-0x00000001811236C0
		private static bool ParseULong(string input, out object output); // 0x0000000181123840-0x00000001811238C0
		private static bool ParseByte(string input, out object output); // 0x00000001811232F0-0x0000000181123360
		private static bool ParseSByte(string input, out object output); // 0x00000001811236C0-0x0000000181123730
		private static bool ParseShort(string input, out object output); // 0x0000000181123730-0x00000001811237B0
		private static bool ParseUShort(string input, out object output); // 0x00000001811238C0-0x0000000181123940
		private static bool ParseChar(string input, out object output); // 0x0000000181123360-0x00000001811233F0
		private static bool ParseFloat(string input, out object output); // 0x0000000181123530-0x00000001811235B0
		private static bool ParseDouble(string input, out object output); // 0x0000000181123490-0x0000000181123530
		private static bool ParseDecimal(string input, out object output); // 0x00000001811233F0-0x0000000181123490
		private static bool ParseVector2(string input, out object output); // 0x0000000181123940-0x00000001811239E0
		private static bool ParseVector3(string input, out object output); // 0x00000001811239E0-0x0000000181123A80
		private static bool ParseVector4(string input, out object output); // 0x0000000181123A80-0x0000000181123B20
		private static bool ParseGameObject(string input, out object output); // 0x00000001811235B0-0x00000001811235D0
		private static bool CreateVectorFromInput(string input, Type vectorType, out object output); // 0x0000000181121B00-0x00000001811220C0
	
		// Extension methods
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, string info, string postfix = null); // 0x0000000181121A60-0x0000000181121B00
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, int info, string postfix = null); // 0x00000001811219D0-0x0000000181121A60
	}
}
