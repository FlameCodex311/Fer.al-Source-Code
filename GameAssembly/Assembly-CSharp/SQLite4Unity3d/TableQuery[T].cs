/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public class TableQuery<T> : BaseTableQuery, IEnumerable<T> // TypeDefIndex: 15473
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private SQLiteConnection <Connection>k__BackingField;
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TableMapping <Table>k__BackingField;
		private Expression _where;
		private List<Ordering> _orderBys;
		private int? _limit;
		private int? _offset;
		private BaseTableQuery _joinInner;
		private Expression _joinInnerKeySelector;
		private BaseTableQuery _joinOuter;
		private Expression _joinOuterKeySelector;
		private Expression _joinSelector;
		private Expression _selector;
		private bool _deferred;
	
		// Properties
		public SQLiteConnection Connection { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; }
		public TableMapping Table { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; }
	
		// Nested types
		private class CompileResult // TypeDefIndex: 15474
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private string <CommandText>k__BackingField;
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private object <Value>k__BackingField;
	
			// Properties
			public string CommandText { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; }
			public object Value { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; }
	
			// Constructors
			public CompileResult();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15475
		{
			// Fields
			public static readonly <>c<T> <>9;
			public static Func<BaseTableQuery.Ordering, string> <>9__35_0;
			public static Func<CompileResult<T>, string> <>9__37_0;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal string <GenerateCommand>b__35_0(BaseTableQuery.Ordering o);
			internal string <CompileExpr>b__37_0(CompileResult<T> a);
		}
	
		// Constructors
		private TableQuery(SQLiteConnection conn, TableMapping table);
		public TableQuery(SQLiteConnection conn);
	
		// Methods
		public TableQuery<U> Clone<U>();
		public TableQuery<T> Where(Expression<Func<T, bool>> predExpr);
		public TableQuery<T> Take(int n);
		public TableQuery<T> Skip(int n);
		public T ElementAt(int index);
		public TableQuery<T> Deferred();
		public TableQuery<T> OrderBy<U>(Expression<Func<T, U>> orderExpr);
		public TableQuery<T> OrderByDescending<U>(Expression<Func<T, U>> orderExpr);
		public TableQuery<T> ThenBy<U>(Expression<Func<T, U>> orderExpr);
		public TableQuery<T> ThenByDescending<U>(Expression<Func<T, U>> orderExpr);
		private TableQuery<T> AddOrderBy<U>(Expression<Func<T, U>> orderExpr, bool asc);
		private void AddWhere(Expression pred);
		public TableQuery<TResult> Join<TInner, TKey, TResult>(TableQuery<TInner> inner, Expression<Func<T, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<T, TInner, TResult>> resultSelector);
		public TableQuery<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);
		private SQLiteCommand GenerateCommand(string selectionList);
		private CompileResult CompileExpr(Expression expr, List<object> queryArgs);
		private static object ConvertTo(object obj, Type t);
		private string CompileNullBinaryExpression(BinaryExpression expression, CompileResult parameter);
		private string GetSqlName(Expression expr);
		public int Count();
		public int Count(Expression<Func<T, bool>> predExpr);
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public T First();
		public T FirstOrDefault();
	}
}
