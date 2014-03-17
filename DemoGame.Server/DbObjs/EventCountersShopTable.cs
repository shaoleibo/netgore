/********************************************************************
                   DO NOT MANUALLY EDIT THIS FILE!

This file was automatically generated using the DbClassCreator
program. The only time you should ever alter this file is if you are
using an automated code formatter. The DbClassCreator will overwrite
this file every time it is run, so all manual changes will be lost.
If there is something in this file that you wish to change, you should
be able to do it through the DbClassCreator arguments.

Make sure that you re-run the DbClassCreator every time you alter your
game's database.

For more information on the DbClassCreator, please see:
    http://www.netgore.com/wiki/DbClassCreator
********************************************************************/

using System;
using System.Linq;
using NetGore;
using NetGore.IO;
using System.Collections.Generic;
using System.Collections;
using NetGore.Db;
using DemoGame.DbObjs;
namespace DemoGame.Server.DbObjs
{
/// <summary>
/// Provides a strongly-typed structure for the database table `event_counters_shop`.
/// </summary>
public class EventCountersShopTable : IEventCountersShopTable, NetGore.IO.IPersistable
{
/// <summary>
/// Array of the database column names.
/// </summary>
 static  readonly System.String[] _dbColumns = new string[] {"counter", "shop_event_counter_id", "shop_id" };
/// <summary>
/// Gets an IEnumerable of strings containing the names of the database columns for the table that this class represents.
/// </summary>
public static System.Collections.Generic.IEnumerable<System.String> DbColumns
{
get
{
return (System.Collections.Generic.IEnumerable<System.String>)_dbColumns;
}
}
/// <summary>
/// Array of the database column names for columns that are primary keys.
/// </summary>
 static  readonly System.String[] _dbColumnsKeys = new string[] {"shop_event_counter_id", "shop_id" };
/// <summary>
/// Gets an IEnumerable of strings containing the names of the database columns that are primary keys.
/// </summary>
public static System.Collections.Generic.IEnumerable<System.String> DbKeyColumns
{
get
{
return (System.Collections.Generic.IEnumerable<System.String>)_dbColumnsKeys;
}
}
/// <summary>
/// Array of the database column names for columns that are not primary keys.
/// </summary>
 static  readonly System.String[] _dbColumnsNonKey = new string[] {"counter" };
/// <summary>
/// Gets an IEnumerable of strings containing the names of the database columns that are not primary keys.
/// </summary>
public static System.Collections.Generic.IEnumerable<System.String> DbNonKeyColumns
{
get
{
return (System.Collections.Generic.IEnumerable<System.String>)_dbColumnsNonKey;
}
}
/// <summary>
/// The name of the database table that this class represents.
/// </summary>
public const System.String TableName = "event_counters_shop";
/// <summary>
/// The number of columns in the database table that this class represents.
/// </summary>
public const System.Int32 ColumnCount = 3;
/// <summary>
/// The field that maps onto the database column `counter`.
/// </summary>
System.Int64 _counter;
/// <summary>
/// The field that maps onto the database column `shop_event_counter_id`.
/// </summary>
System.Byte _shopEventCounterId;
/// <summary>
/// The field that maps onto the database column `shop_id`.
/// </summary>
System.UInt16 _shopID;
/// <summary>
/// Gets or sets the value for the field that maps onto the database column `counter`.
/// The underlying database type is `bigint(20)`.The database column contains the comment: 
/// "The event counter.".
/// </summary>
[System.ComponentModel.Description("The event counter.")]
[NetGore.SyncValueAttribute()]
public System.Int64 Counter
{
get
{
return (System.Int64)_counter;
}
set
{
this._counter = (System.Int64)value;
}
}
/// <summary>
/// Gets or sets the value for the field that maps onto the database column `shop_event_counter_id`.
/// The underlying database type is `tinyint(3) unsigned`.The database column contains the comment: 
/// "The ID of the event that the counter is for.".
/// </summary>
[System.ComponentModel.Description("The ID of the event that the counter is for.")]
[NetGore.SyncValueAttribute()]
public System.Byte ShopEventCounterId
{
get
{
return (System.Byte)_shopEventCounterId;
}
set
{
this._shopEventCounterId = (System.Byte)value;
}
}
/// <summary>
/// Gets or sets the value for the field that maps onto the database column `shop_id`.
/// The underlying database type is `smallint(5) unsigned`.The database column contains the comment: 
/// "The shop the event occured on.".
/// </summary>
[System.ComponentModel.Description("The shop the event occured on.")]
[NetGore.SyncValueAttribute()]
public NetGore.Features.Shops.ShopID ShopID
{
get
{
return (NetGore.Features.Shops.ShopID)_shopID;
}
set
{
this._shopID = (System.UInt16)value;
}
}

/// <summary>
/// Creates a deep copy of this table. All the values will be the same
/// but they will be contained in a different object instance.
/// </summary>
/// <returns>
/// A deep copy of this table.
/// </returns>
public virtual IEventCountersShopTable DeepCopy()
{
return new EventCountersShopTable(this);
}
/// <summary>
/// Initializes a new instance of the <see cref="EventCountersShopTable"/> class.
/// </summary>
public EventCountersShopTable()
{
}
/// <summary>
/// Initializes a new instance of the <see cref="EventCountersShopTable"/> class.
/// </summary>
/// <param name="counter">The initial value for the corresponding property.</param>
/// <param name="shopEventCounterId">The initial value for the corresponding property.</param>
/// <param name="shopID">The initial value for the corresponding property.</param>
public EventCountersShopTable(System.Int64 @counter, System.Byte @shopEventCounterId, NetGore.Features.Shops.ShopID @shopID)
{
this.Counter = (System.Int64)@counter;
this.ShopEventCounterId = (System.Byte)@shopEventCounterId;
this.ShopID = (NetGore.Features.Shops.ShopID)@shopID;
}
/// <summary>
/// Initializes a new instance of the <see cref="EventCountersShopTable"/> class.
/// </summary>
/// <param name="source">IEventCountersShopTable to copy the initial values from.</param>
public EventCountersShopTable(IEventCountersShopTable source)
{
CopyValuesFrom(source);
}
/// <summary>
/// Copies the column values into the given Dictionary using the database column name
/// with a prefixed @ as the key. The keys must already exist in the Dictionary;
/// this method will not create them if they are missing.
/// </summary>
/// <param name="dic">The Dictionary to copy the values into.</param>
public void CopyValues(System.Collections.Generic.IDictionary<System.String,System.Object> dic)
{
CopyValues(this, dic);
}
/// <summary>
/// Copies the column values into the given Dictionary using the database column name
/// with a prefixed @ as the key. The keys must already exist in the Dictionary;
/// this method will not create them if they are missing.
/// </summary>
/// <param name="source">The object to copy the values from.</param>
/// <param name="dic">The Dictionary to copy the values into.</param>
public static void CopyValues(IEventCountersShopTable source, System.Collections.Generic.IDictionary<System.String,System.Object> dic)
{
dic["counter"] = (System.Int64)source.Counter;
dic["shop_event_counter_id"] = (System.Byte)source.ShopEventCounterId;
dic["shop_id"] = (NetGore.Features.Shops.ShopID)source.ShopID;
}

/// <summary>
/// Copies the values from the given <paramref name="source"/> into this EventCountersShopTable.
/// </summary>
/// <param name="source">The IEventCountersShopTable to copy the values from.</param>
public void CopyValuesFrom(IEventCountersShopTable source)
{
this.Counter = (System.Int64)source.Counter;
this.ShopEventCounterId = (System.Byte)source.ShopEventCounterId;
this.ShopID = (NetGore.Features.Shops.ShopID)source.ShopID;
}

/// <summary>
/// Gets the value of a column by the database column's name.
/// </summary>
/// <param name="columnName">The database name of the column to get the value for.</param>
/// <returns>
/// The value of the column with the name <paramref name="columnName"/>.
/// </returns>
public System.Object GetValue(System.String columnName)
{
switch (columnName)
{
case "counter":
return Counter;

case "shop_event_counter_id":
return ShopEventCounterId;

case "shop_id":
return ShopID;

default:
throw new ArgumentException("Field not found.","columnName");
}
}

/// <summary>
/// Sets the <paramref name="value"/> of a column by the database column's name.
/// </summary>
/// <param name="columnName">The database name of the column to get the <paramref name="value"/> for.</param>
/// <param name="value">Value to assign to the column.</param>
public void SetValue(System.String columnName, System.Object value)
{
switch (columnName)
{
case "counter":
this.Counter = (System.Int64)value;
break;

case "shop_event_counter_id":
this.ShopEventCounterId = (System.Byte)value;
break;

case "shop_id":
this.ShopID = (NetGore.Features.Shops.ShopID)value;
break;

default:
throw new ArgumentException("Field not found.","columnName");
}
}

/// <summary>
/// Gets the data for the database column that this table represents.
/// </summary>
/// <param name="columnName">The database name of the column to get the data for.</param>
/// <returns>
/// The data for the database column with the name <paramref name="columnName"/>.
/// </returns>
public static ColumnMetadata GetColumnData(System.String columnName)
{
switch (columnName)
{
case "counter":
return new ColumnMetadata("counter", "The event counter.", "bigint(20)", null, typeof(System.Int64), false, false, false);

case "shop_event_counter_id":
return new ColumnMetadata("shop_event_counter_id", "The ID of the event that the counter is for.", "tinyint(3) unsigned", null, typeof(System.Byte), false, true, false);

case "shop_id":
return new ColumnMetadata("shop_id", "The shop the event occured on.", "smallint(5) unsigned", null, typeof(System.UInt16), false, true, false);

default:
throw new ArgumentException("Field not found.","columnName");
}
}

/// <summary>
/// Reads the state of the object from an <see cref="IValueReader"/>.
/// </summary>
/// <param name="reader">The <see cref="IValueReader"/> to read the values from.</param>
public virtual void ReadState(NetGore.IO.IValueReader reader)
{
NetGore.IO.PersistableHelper.Read(this, reader);
}

/// <summary>
/// Writes the state of the object to an <see cref="IValueWriter"/>.
/// </summary>
/// <param name="writer">The <see cref="IValueWriter"/> to write the values to.</param>
public virtual void WriteState(NetGore.IO.IValueWriter writer)
{
NetGore.IO.PersistableHelper.Write(this, writer);
}

}

}
