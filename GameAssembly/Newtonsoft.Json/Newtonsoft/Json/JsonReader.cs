/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class JsonReader : IDisposable // TypeDefIndex: 7978
	{
		// Fields
		private JsonToken _tokenType; // 0x10
		private object _value; // 0x18
		internal char _quoteChar; // 0x20
		internal State _currentState; // 0x24
		private JsonPosition _currentPosition; // 0x28
		private CultureInfo _culture; // 0x40
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
		private int? _maxDepth; // 0x4C
		private bool _hasExceededMaxDepth; // 0x54
		internal DateParseHandling _dateParseHandling; // 0x58
		internal FloatParseHandling _floatParseHandling; // 0x5C
		private string _dateFormatString; // 0x60
		private List<JsonPosition> _stack; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <CloseInput>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <SupportMultipleContent>k__BackingField; // 0x71
	
		// Properties
		protected State CurrentState { get; } // 0x0000000180491DB0-0x0000000180491DC0 
		public bool CloseInput { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180522FA0-0x0000000180522FB0 0x0000000180522FF0-0x0000000180523000
		public bool SupportMultipleContent { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180B929C0-0x0000000180B929D0 0x0000000180B92D60-0x0000000180B92D70
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x0000000180379ED0-0x0000000180379EE0 0x0000000180C692E0-0x0000000180C69350
		public DateParseHandling DateParseHandling { get; set; } // 0x0000000180693DB0-0x0000000180693DC0 0x0000000180C69270-0x0000000180C692E0
		public FloatParseHandling FloatParseHandling { get; set; } // 0x00000001804D2E40-0x00000001804D2E50 0x0000000180C69350-0x0000000180C693C0
		public string DateFormatString { get; set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public int? MaxDepth { get; set; } // 0x0000000180C69140-0x0000000180C69150 0x0000000180C693C0-0x0000000180C69450
		public virtual JsonToken TokenType { get; } // 0x0000000180387590-0x0000000180387930 
		public virtual object Value { get; } // 0x0000000180372430-0x0000000180372440 
		public virtual Type ValueType { get; } // 0x0000000180C69250-0x0000000180C69270 
		public virtual int Depth { get; } // 0x0000000180C690D0-0x0000000180C69140 
		public virtual string Path { get; } // 0x0000000180C69150-0x0000000180C69250 
		public CultureInfo Culture { get; set; } // 0x0000000180C69070-0x0000000180C690D0 0x00000001804CD6C0-0x00000001804CD6D0
	
		// Nested types
		protected internal enum State // TypeDefIndex: 7979
		{
			Start = 0,
			Complete = 1,
			Property = 2,
			ObjectStart = 3,
			Object = 4,
			ArrayStart = 5,
			Array = 6,
			Closed = 7,
			PostValue = 8,
			ConstructorStart = 9,
			Constructor = 10,
			Error = 11,
			Finished = 12
		}
	
		// Constructors
		protected JsonReader(); // 0x0000000180C69040-0x0000000180C69070
	
		// Methods
		internal JsonPosition GetPosition(int depth); // 0x0000000180C65520-0x0000000180C655C0
		private void Push(JsonContainerType value); // 0x0000000180C65800-0x0000000180C65AA0
		private JsonContainerType Pop(); // 0x0000000180C65710-0x0000000180C65800
		private JsonContainerType Peek(); // 0x000000018043C680-0x000000018043C690
		public abstract bool Read();
		public virtual int? ReadAsInt32(); // 0x0000000180C670C0-0x0000000180C673A0
		internal int? ReadInt32String(string s); // 0x0000000180C68460-0x0000000180C68680
		public virtual string ReadAsString(); // 0x0000000180C673A0-0x0000000180C67760
		public virtual byte[] ReadAsBytes(); // 0x0000000180C660B0-0x0000000180C66530
		internal byte[] ReadArrayIntoByteArray(); // 0x0000000180C65B70-0x0000000180C65DE0
		public virtual double? ReadAsDouble(); // 0x0000000180C66DF0-0x0000000180C670C0
		internal double? ReadDoubleString(string s); // 0x0000000180C68200-0x0000000180C68460
		public virtual bool? ReadAsBoolean(); // 0x0000000180C65DE0-0x0000000180C660B0
		internal bool? ReadBooleanString(string s); // 0x0000000180C67760-0x0000000180C67940
		public virtual decimal? ReadAsDecimal(); // 0x0000000180C66B00-0x0000000180C66DF0
		internal decimal? ReadDecimalString(string s); // 0x0000000180C67F70-0x0000000180C68200
		public virtual DateTime? ReadAsDateTime(); // 0x0000000180C66830-0x0000000180C66B00
		internal DateTime? ReadDateTimeString(string s); // 0x0000000180C67C90-0x0000000180C67F70
		public virtual DateTimeOffset? ReadAsDateTimeOffset(); // 0x0000000180C66530-0x0000000180C66830
		internal DateTimeOffset? ReadDateTimeOffsetString(string s); // 0x0000000180C67940-0x0000000180C67C90
		internal void ReaderReadAndAssert(); // 0x0000000180C688E0-0x0000000180C68940
		internal JsonReaderException CreateUnexpectedEndException(); // 0x0000000180C65450-0x0000000180C65490
		internal void ReadIntoWrappedTypeObject(); // 0x0000000180C68680-0x0000000180C688E0
		public void Skip(); // 0x0000000180C68C80-0x0000000180C68D30
		protected void SetToken(JsonToken newToken); // 0x0000000180C68C60-0x0000000180C68C80
		protected void SetToken(JsonToken newToken, object value); // 0x0000000180C68C40-0x0000000180C68C60
		internal void SetToken(JsonToken newToken, object value, bool updateIndex); // 0x0000000180C68AA0-0x0000000180C68C40
		internal void SetPostValueState(bool updateIndex); // 0x0000000180C68960-0x0000000180C68990
		private void UpdateScopeWithFinishedValue(); // 0x0000000180C68DA0-0x0000000180C68DB0
		private void ValidateEnd(JsonToken endToken); // 0x0000000180C68DB0-0x0000000180C69040
		protected void SetStateBasedOnCurrent(); // 0x0000000180C68990-0x0000000180C68AA0
		private void SetFinished(); // 0x0000000180C68940-0x0000000180C68960
		private JsonContainerType GetTypeForCloseToken(JsonToken token); // 0x0000000180C655C0-0x0000000180C656B0
		void IDisposable.Dispose(); // 0x0000000180C68D30-0x0000000180C68DA0
		protected virtual void Dispose(bool disposing); // 0x0000000180C65490-0x0000000180C654B0
		public virtual void Close(); // 0x0000000180C65430-0x0000000180C65450
		internal void ReadAndAssert(); // 0x0000000180C65AA0-0x0000000180C65B10
		internal bool ReadAndMoveToContent(); // 0x0000000180C65B10-0x0000000180C65B70
		internal bool MoveToContent(); // 0x0000000180C656B0-0x0000000180C65710
		private JsonToken GetContentToken(); // 0x0000000180C654B0-0x0000000180C65520
	}
}
