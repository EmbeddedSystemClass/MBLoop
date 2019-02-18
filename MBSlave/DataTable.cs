using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FieldTalk.Modbus.Slave;

namespace MBSlave {
  class DataTable : MbusDataTableInterface {
    public delegate void LogDelegate(string msg);
    public event LogDelegate OnLog;

    private const int STARTADD = 200;
    private const int DATALEN = 32;
    private short[] data = Enumerable.Repeat((short) 0, DATALEN).ToArray();

    protected override bool readHoldingRegistersTable(Int32 startRef, Int16[] regArr) {
      if (startRef < STARTADD || startRef > STARTADD + DATALEN || startRef + regArr.Length > STARTADD + DATALEN) {
        OnLog?.Invoke($"Read ERR St: {startRef}, Sz: {regArr.Length}");
        return false;
      }
      for (int idx = 0; idx < regArr.Length; idx++)
        regArr[idx] = data[idx];
      OnLog?.Invoke($"Read St: {startRef}, Sz: {regArr.Length}, Data: {string.Join(",", regArr)}");
      return true;
    }

    protected override bool writeHoldingRegistersTable(int startRef, short[] regArr) {
      if (startRef < STARTADD || startRef > STARTADD + DATALEN || startRef + regArr.Length > STARTADD + DATALEN) {
        OnLog?.Invoke($"Write ERR St: {startRef}, Sz: {regArr.Length}");
        return false;
      }
      for (int idx = 0; idx < regArr.Length; idx++)
        data[idx] = regArr[idx];
      OnLog?.Invoke($"Write St: {startRef}, Sz: {regArr.Length}, Data: {string.Join(",", regArr)}");
      return true;
    }

    protected override bool readInputDiscretesTable(int startRef, bool[] bitArr){
      OnLog?.Invoke($"readInputDiscretesTable: {startRef}/{bitArr.Length}");
      return true;
    }

    protected override bool readInputRegistersTable(int startRef, short[] regArr){
      OnLog?.Invoke($"readInputRegistersTable: {startRef}/{regArr.Length}");
      return true;
    }

    protected override bool readCoilsTable(int startRef, bool[] bitArr){
      OnLog?.Invoke($"readCoilsTable: {startRef}/{bitArr.Length}");
      return true;
    }

    protected override bool writeCoilsTable(int startRef, bool[] bitArr){
      OnLog?.Invoke($"writeCoilsTable: {startRef}/{bitArr.Length}");
      return true;
    }

  }
}
