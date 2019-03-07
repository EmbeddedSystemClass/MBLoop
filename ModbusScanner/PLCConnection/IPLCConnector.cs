using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBMaster.PLCConnection {
  // possible communication protocols
  public enum ProtocolTypeEnum { TCP, UDP, Serial };

  public interface IPLCConnector {
    bool Connect(ProtocolTypeEnum protocolType, BaseCommConfig commCfg, out string errorStr);
    void Disconnect();
    bool ReadRegisters(int start, int count, short[] values);
    bool ReadRegisters(int start, int count, int[] values);
    bool WriteRegister(int regNum, short value);
    bool WriteRegisters(int start, int count, short[] values);
  }

  public static class PLCConnectorFactory {
    public static IPLCConnector GetConnector(ProtocolTypeEnum protocolType) {
      switch (protocolType) {
        case ProtocolTypeEnum.TCP:
        case ProtocolTypeEnum.UDP:
          return new PLCConnector();
        default:
          return null;
      }
    }
  }
}
