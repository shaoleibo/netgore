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
/// Provides a strongly-typed structure for the database table `event_counters_npc`.
/// </summary>
public class EventCountersNpcTable : IEventCountersNpcTable, NetGore.IO.IPersistable
{
/// <summary>
/// Array of the database column names.
/// </summary>
 static  readonly System.String[] _dbColumns = new string[] {"counter", "npc_event_counter_id", "npc_template_id" };
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
 static  readonly System.String[] _dbColumnsKeys = new string[] {"npc_event_counter_id", "npc_template_id" };
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
public const System.String TableName = "event_counters_npc";
/// <summary>
/// The number of columns in the database table that this class represents.
/// </summary>
public const System.Int32 ColumnCount = 3;
/// <summary>
/// The field that maps onto the database column `counter`.
/// </summary>
System.Int64 _counter;
/// <summary>
/// The field that maps onto the database column `npc_event_counter_id`.
/// </summary>
System.Byte _nPCEventCounterID;
/// <summary>
/// The field that maps onto the database column `npc_template_id`.
/// </summary>
System.UInt16 _nPCTemplateID;
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
/// Gets or sets the value for the field that maps onto the database column `npc_event_counter_id`.
/// The underlying database type is `tinyint(3) unsigned`.The database column contains the comment: 
/// "The ID of the event that the counter is for.".
/// </summary>
[System.ComponentModel.Description("The ID of the event that the counter is for.")]
[NetGore.SyncValueAttribute()]
public System.Byte NPCEventCounterID
{
get
{
return (System.Byte)_nPCEventCounterID;
}
set
{
this._nPCEventCounterID = (System.Byte)value;
}
}
/// <summary>
/// Gets or sets the value for the field that maps onto the database column `npc_template_id`.
/// The underlying database type is `smallint(5) unsigned`.The database column contains the comment: 
/// "The character template of the NPC the event occured on.".
/// </summary>
[System.ComponentModel.Description("The character template of the NPC the event occured on.")]
[NetGore.SyncValueAttribute()]
public DemoGame.CharacterTemplateID NPCTemplateID
{
get
{
return (DemoGame.CharacterTemplateID)_nPCTemplateID;
}
set
{
this._nPCTemplateID = (System.UInt16)value;
}
}

/// <summary>
/// Creates a deep copy of this table. All the values will be the same
/// but they will be contained in a different object instance.
/// </summary>
/// <returns>
/// A deep copy of this table.
/// </returns>
public virtual IEventCountersNpcTable DeepCopy()
{
return new EventCountersNpcTable(this);
}
/// <summary>
/// Initializes a new instance of the <see cref="EventCountersNpcTable"/> class.
/// </summary>
public EventCountersNpcTable()
{
}
/// <summary>
/// Initializes a new instance of the <see cref="EventCountersNpcTable"/> class.
/// </summary>
/// <param name="counter">The initial value for the corresponding property.</param>
/// <param name="nPCEventCounterID">The initial value for the corresponding property.</param>
/// <param name="nPCTemplateID">The initial value for the corresponding property.</param>
public EventCountersNpcTable(System.Int64 @counter, System.Byte @nPCEventCounterID, DemoGame.CharacterTemplateID @nPCTemplateID)
{
this.Counter = (System.Int64)@counter;
this.NPCEventCounterID = (System.Byte)@nPCEventCounterID;
this.NPCTemplateID = (DemoGame.CharacterTemplateID)@nPCTemplateID;
}
/// <summary>
/// Initializes a new instance of the <see cref="EventCountersNpcTable"/> class.
/// </summary>
/// <param name="source">IEventCountersNpcTable to copy the initial values from.</param>
public EventCountersNpcTable(IEventCountersNpcTable source)
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
public static void CopyValues(IEventCountersNpcTable source, System.Collections.Generic.IDictionary<System.String,System.Object> dic)
{
dic["counter"] = (System.Int64)source.Counter;
dic["npc_event_counter_id"] = (System.Byte)source.NPCEventCounterID;
dic["npc_template_id"] = (DemoGame.CharacterTemplateID)source.NPCTemplateID;
}

/// <summary>
/// Copies the values from the given <paramref name="source"/> into this EventCountersNpcTable.
/// </summary>
/// <param name="source">The IEventCountersNpcTable to copy the values from.</param>
public void CopyValuesFrom(IEventCountersNpcTable source)
{
this.Counter = (System.Int64)source.Counter;
this.NPCEventCounterID = (System.Byte)source.NPCEventCounterID;
this.NPCTemplateID = (DemoGame.CharacterTemplateID)source.NPCTemplateID;
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

case "npc_event_counter_id":
return NPCEventCounterID;

case "npc_template_id":
return NPCTemplateID;

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

case "npc_event_counter_id":
this.NPCEventCounterID = (System.Byte)value;
break;

case "npc_template_id":
this.NPCTemplateID = (DemoGame.CharacterTemplateID)value;
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

case "npc_event_counter_id":
return new ColumnMetadata("npc_event_counter_id", "The ID of the event that the counter is for.", "tinyint(3) unsigned", null, typeof(System.Byte), false, true, false);

case "npc_template_id":
return new ColumnMetadata("npc_template_id", "The character template of the NPC the event occured on.", "smallint(5) unsigned", null, typeof(System.UInt16), false, true, false);

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
