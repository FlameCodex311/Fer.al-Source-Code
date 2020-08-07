/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public static class DebugConsole // TypeDefIndex: 16257
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
		public static Dictionary<object, List<ConsoleMethodInfo>> ButtonMethods { get; } // 0x0000000180668D00-0x0000000180668D60 
		public static Dictionary<object, List<ConsoleFieldInfo>> ButtonFields { get; } // 0x0000000180668CA0-0x0000000180668D00 
		public static Dictionary<string, ConsoleMethodInfo> Methods { get; } // 0x0000000180668D60-0x0000000180668DC0 
	
		// Nested types
		public delegate bool ParseFunction(string input, out object output); // TypeDefIndex: 16258; 0x00000001804A53D0-0x00000001804A58D0
	
		// Constructors
		static DebugConsole(); // 0x0000000180668A10-0x0000000180668CA0
	
		// Methods
		private static void InitDebugConsole(); // 0x0000000180667150-0x0000000180668080
		[ConsoleCommand] // 0x00000001801D0F80-0x00000001801D0FD0
		public static string LogAllCommands(); // 0x0000000180668080-0x00000001806680B0
		[ConsoleCommand] // 0x00000001801D1130-0x00000001801D1180
		public static string LogSystemInfo(); // 0x00000001806680B0-0x00000001806680E0
		public static void AddCommandInstance(string command, string description, string methodName, object instance); // 0x00000001803774A0-0x00000001803774B0
		public static void AddCommandStatic(string command, string description, string methodName, Type ownerType); // 0x00000001803774A0-0x00000001803774B0
		public static void RemoveCommand(string command); // 0x00000001803774A0-0x00000001803774B0
		private static void AddCommand(string command, string description, string methodName, Type ownerType, object instance = null); // 0x0000000180666100-0x0000000180666340
		private static void AddCommand(string command, string description, MethodInfo method, object instance = null); // 0x0000000180665770-0x0000000180666100
		public static string ExecuteCommand(string command); // 0x0000000180666FE0-0x0000000180667010
		public static void AddDebugButtons(object inObject); // 0x00000001803774A0-0x00000001803774B0
		public static void AddDebugButton<T>(T inDelegate, string inButtonText, object inId, string inButtonGroup = "General" /* Metadata: 0x007BBA4A */, bool inCloseOnClick = false /* Metadata: 0x007BBA55 */)
			where T : Delegate;
		public static void RemoveDebugButtons(object inId); // 0x00000001803774A0-0x00000001803774B0
		private static void AddDebugButtonMethod(MethodInfo inMethod, DebugButtonAttribute inAttribute, object inTarget, object inId = null); // 0x00000001803774A0-0x00000001803774B0
		public static void AddDebugField(string inFieldName, object inTarget, string inFieldText, object inId, string inGroup = "General" /* Metadata: 0x007BBA56 */, bool inReadonly = false /* Metadata: 0x007BBA61 */); // 0x00000001803774A0-0x00000001803774B0
		private static void AddDebugButtonField(FieldInfo inField, DebugFieldAttribute inAttribute, object inTarget, object inId); // 0x0000000180666630-0x0000000180666900
		private static void AddDebugButtonField(PropertyInfo inProperty, DebugFieldAttribute inAttribute, object inTarget, object inId); // 0x0000000180666340-0x0000000180666630
		private static int IndexOfDelimiter(char c); // 0x0000000180667040-0x0000000180667150
		private static int IndexOfChar(string command, char c, int startIndex); // 0x0000000180667010-0x0000000180667040
		private static bool ParseString(string input, out object output); // 0x00000001806686A0-0x00000001806686C0
		private static bool ParseBool(string input, out object output); // 0x00000001806680E0-0x00000001806681E0
		private static bool ParseInt(string input, out object output); // 0x00000001806684C0-0x0000000180668530
		private static bool ParseUInt(string input, out object output); // 0x00000001806686C0-0x0000000180668730
		private static bool ParseLong(string input, out object output); // 0x0000000180668530-0x00000001806685B0
		private static bool ParseULong(string input, out object output); // 0x0000000180668730-0x00000001806687B0
		private static bool ParseByte(string input, out object output); // 0x00000001806681E0-0x0000000180668250
		private static bool ParseSByte(string input, out object output); // 0x00000001806685B0-0x0000000180668620
		private static bool ParseShort(string input, out object output); // 0x0000000180668620-0x00000001806686A0
		private static bool ParseUShort(string input, out object output); // 0x00000001806687B0-0x0000000180668830
		private static bool ParseChar(string input, out object output); // 0x0000000180668250-0x00000001806682E0
		private static bool ParseFloat(string input, out object output); // 0x0000000180668420-0x00000001806684A0
		private static bool ParseDouble(string input, out object output); // 0x0000000180668380-0x0000000180668420
		private static bool ParseDecimal(string input, out object output); // 0x00000001806682E0-0x0000000180668380
		private static bool ParseVector2(string input, out object output); // 0x0000000180668830-0x00000001806688D0
		private static bool ParseVector3(string input, out object output); // 0x00000001806688D0-0x0000000180668970
		private static bool ParseVector4(string input, out object output); // 0x0000000180668970-0x0000000180668A10
		private static bool ParseGameObject(string input, out object output); // 0x00000001806684A0-0x00000001806684C0
		private static bool CreateVectorFromInput(string input, Type vectorType, out object output); // 0x0000000180666A30-0x0000000180666FE0
	
		// Extension methods
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, string info, string postfix = null); // 0x0000000180666990-0x0000000180666A30
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, int info, string postfix = null); // 0x0000000180666900-0x0000000180666990
	}
}
