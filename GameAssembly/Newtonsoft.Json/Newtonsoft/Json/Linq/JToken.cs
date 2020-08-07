/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180248D70-0x0000000180248DC0
	public abstract class JToken : IJEnumerable<JToken>, IJsonLineInfo, ICloneable // TypeDefIndex: 8146
	{
		// Fields
		private JContainer _parent; // 0x10
		private JToken _previous; // 0x18
		private JToken _next; // 0x20
		private object _annotations; // 0x28
		private static readonly JTokenType[] BooleanTypes; // 0x00
		private static readonly JTokenType[] NumberTypes; // 0x08
		private static readonly JTokenType[] StringTypes; // 0x10
		private static readonly JTokenType[] GuidTypes; // 0x18
		private static readonly JTokenType[] TimeSpanTypes; // 0x20
		private static readonly JTokenType[] UriTypes; // 0x28
		private static readonly JTokenType[] CharTypes; // 0x30
		private static readonly JTokenType[] DateTimeTypes; // 0x38
		private static readonly JTokenType[] BytesTypes; // 0x40
	
		// Properties
		public JContainer Parent { [DebuggerStepThrough] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; internal set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public JToken Root { get; } // 0x0000000181842250-0x0000000181842280 
		public abstract JTokenType Type { get; }
		public abstract bool HasValues { get; }
		public JToken Next { get; internal set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public JToken Previous { get; internal set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string Path { get; } // 0x0000000181841FD0-0x0000000181842250 
		public virtual JToken First { get; } // 0x0000000181841E90-0x0000000181841F30 
		public virtual JToken Last { get; } // 0x0000000181841F30-0x0000000181841FD0 
		int IJsonLineInfo.LineNumber { get; } // 0x000000018183FBE0-0x000000018183FC30 
		int IJsonLineInfo.LinePosition { get; } // 0x000000018183FC30-0x000000018183FC80 
	
		// Nested types
		private class LineInfoAnnotation // TypeDefIndex: 8147
		{
			// Fields
			internal readonly int LineNumber; // 0x10
			internal readonly int LinePosition; // 0x14
	
			// Constructors
			public LineInfoAnnotation(int lineNumber, int linePosition); // 0x00000001804A4420-0x00000001804A4460
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetAncestors>d__41 // TypeDefIndex: 8148
		{
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AfterSelf>d__42 // TypeDefIndex: 8149
		{
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <BeforeSelf>d__43 // TypeDefIndex: 8150
		{
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Annotations>d__171<T> // TypeDefIndex: 8151
			where T : class
		{
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Annotations>d__172 // TypeDefIndex: 8152
		{
		}
	
		// Constructors
		internal JToken(); // 0x0000000180373240-0x0000000180373250
		static JToken(); // 0x0000000181841610-0x0000000181841E90
	
		// Methods
		internal abstract JToken CloneToken();
		internal abstract bool DeepEquals(JToken node);
		public static bool DeepEquals(JToken t1, JToken t2); // 0x000000018183F850-0x000000018183F880
		public virtual JEnumerable<JToken> Children(); // 0x000000018183F770-0x000000018183F7D0
		public void Remove(); // 0x0000000181840000-0x0000000181840080
		public void Replace(JToken value); // 0x0000000181840080-0x0000000181840110
		public abstract void WriteTo(JsonWriter writer, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ JsonConverter[] converters);
		public override string ToString(); // 0x00000001818414E0-0x0000000181841530
		public string ToString(Formatting formatting, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ JsonConverter[] converters); // 0x0000000181841260-0x00000001818414E0
		private static JValue EnsureValue(JToken value); // 0x000000018183F880-0x000000018183FA10
		private static string GetType(JToken token); // 0x000000018183FA10-0x000000018183FBA0
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable); // 0x0000000181841530-0x0000000181841610
		public static explicit operator bool(JToken value); // 0x00000001818470C0-0x00000001818472A0
		public static explicit operator DateTimeOffset(JToken value); // 0x0000000181844580-0x0000000181844880
		public static explicit operator bool?(JToken value); // 0x00000001818453C0-0x0000000181845620
		public static explicit operator long(JToken value); // 0x00000001818426C0-0x00000001818428A0
		public static explicit operator DateTime?(JToken value); // 0x0000000181842A80-0x0000000181842D50
		public static explicit operator DateTimeOffset?(JToken value); // 0x0000000181846190-0x0000000181846560
		public static explicit operator decimal?(JToken value); // 0x0000000181843B70-0x0000000181843E10
		public static explicit operator double?(JToken value); // 0x0000000181845F20-0x0000000181846190
		public static explicit operator char?(JToken value); // 0x0000000181843210-0x0000000181843470
		public static explicit operator int(JToken value); // 0x0000000181847570-0x0000000181847750
		public static explicit operator short(JToken value); // 0x0000000181844A60-0x0000000181844C40
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator ushort(JToken value); // 0x00000001818467B0-0x0000000181846990
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator char(JToken value); // 0x0000000181842280-0x0000000181842460
		public static explicit operator byte(JToken value); // 0x00000001818443A0-0x0000000181844580
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator sbyte(JToken value); // 0x0000000181843030-0x0000000181843210
		public static explicit operator int?(JToken value); // 0x0000000181845620-0x0000000181845880
		public static explicit operator short?(JToken value); // 0x0000000181845AE0-0x0000000181845D40
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator ushort?(JToken value); // 0x0000000181846990-0x0000000181846BF0
		public static explicit operator byte?(JToken value); // 0x0000000181845880-0x0000000181845AE0
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator sbyte?(JToken value); // 0x0000000181844C40-0x0000000181844EA0
		public static explicit operator DateTime(JToken value); // 0x0000000181846560-0x00000001818467B0
		public static explicit operator long?(JToken value); // 0x0000000181843650-0x00000001818438C0
		public static explicit operator float?(JToken value); // 0x0000000181845160-0x00000001818453C0
		public static explicit operator decimal(JToken value); // 0x0000000181843E10-0x0000000181844000
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator uint?(JToken value); // 0x0000000181846E60-0x00000001818470C0
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator ulong?(JToken value); // 0x0000000181846BF0-0x0000000181846E60
		public static explicit operator double(JToken value); // 0x0000000181843470-0x0000000181843650
		public static explicit operator float(JToken value); // 0x0000000181845D40-0x0000000181845F20
		public static explicit operator string(JToken value); // 0x0000000181844EA0-0x0000000181845160
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator uint(JToken value); // 0x0000000181844880-0x0000000181844A60
		[CLSCompliant] // 0x00000001801CE510-0x00000001801CE530
		public static explicit operator ulong(JToken value); // 0x00000001818428A0-0x0000000181842A80
		public static explicit operator Guid(JToken value); // 0x00000001818472A0-0x0000000181847570
		public static explicit operator Guid?(JToken value); // 0x0000000181844000-0x00000001818443A0
		public static explicit operator TimeSpan(JToken value); // 0x0000000181842460-0x00000001818426C0
		public static explicit operator TimeSpan?(JToken value); // 0x0000000181842D50-0x0000000181843030
		public static explicit operator Uri(JToken value); // 0x00000001818438C0-0x0000000181843B70
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818402E0-0x0000000181840320
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator(); // 0x0000000181840280-0x00000001818402E0
		internal abstract int GetDeepHashCode();
		public JsonReader CreateReader(); // 0x000000018183F7D0-0x000000018183F850
		public object ToObject(Type objectType); // 0x0000000181840460-0x0000000181841260
		public object ToObject(Type objectType, JsonSerializer jsonSerializer); // 0x0000000181840320-0x0000000181840460
		public static JToken ReadFrom(JsonReader reader); // 0x000000018183FC80-0x000000018183FCE0
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings); // 0x000000018183FCE0-0x0000000181840000
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings); // 0x0000000181840190-0x0000000181840280
		internal void SetLineInfo(int lineNumber, int linePosition); // 0x0000000181840110-0x0000000181840190
		bool IJsonLineInfo.HasLineInfo(); // 0x000000018183FBA0-0x000000018183FBE0
		object ICloneable.Clone(); // 0x000000018037F800-0x000000018037F820
		public JToken DeepClone(); // 0x000000018037F800-0x000000018037F820
		public void AddAnnotation(object annotation); // 0x000000018183F4B0-0x000000018183F770
		public T Annotation<T>()
			where T : class;
	}
}
