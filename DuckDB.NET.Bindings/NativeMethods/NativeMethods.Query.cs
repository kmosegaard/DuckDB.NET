﻿using System;
using System.Runtime.InteropServices;

namespace DuckDB.NET;

public partial class NativeMethods
{
    public static class Query
    {
        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_query")]
        public static extern DuckDBState DuckDBQuery(DuckDBNativeConnection connection, string query, out DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_query")]
        public static extern DuckDBState DuckDBQuery(DuckDBNativeConnection connection, SafeUnmanagedMemoryHandle query, out DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_destroy_result")]
        public static extern void DuckDBDestroyResult([In, Out] ref DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_column_name")]
        public static extern IntPtr DuckDBColumnName([In, Out] ref DuckDBResult result, long col);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_column_type")]
        public static extern DuckDBType DuckDBColumnType([In, Out] ref DuckDBResult result, long col);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_column_logical_type")]
        public static extern DuckDBLogicalType DuckDBColumnLogicalType([In, Out] ref DuckDBResult result, long col);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_column_count")]
        public static extern long DuckDBColumnCount([In, Out] ref DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_row_count")]
        public static extern long DuckDBRowCount([In, Out] ref DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_rows_changed")]
        public static extern long DuckDBRowsChanged([In, Out] ref DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_column_data")]
        public static extern IntPtr DuckDBColumnData([In, Out] ref DuckDBResult result, long col);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_nullmask_data")]
        public static extern IntPtr DuckDBNullmaskData([In, Out] ref DuckDBResult result, long col);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_result_error")]
        public static extern IntPtr DuckDBResultError([In, Out] ref DuckDBResult result);
    }
}