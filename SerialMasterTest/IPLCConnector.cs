using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialMasterTest {
  public enum MBDataBitsEnum {
    SER_DATABITS_7 = 7,
    SER_DATABITS_8 = 8
  }
  public enum MBStopBitsEnum {
    SER_STOPBITS_1 = 1,
    SER_STOPBITS_2 = 2
  }
  public enum MBParityEnum {
    SER_PARITY_NONE = 0,
    SER_PARITY_EVEN = 1,
    SER_PARITY_ODD = 2
  }
  // possible communication protocols
  public enum ProtocolTypeEnum { TCP, UDP, Serial };
  public class BaseCommConfig {
    public string addressMajor = "";  // IP address in TCP/UDP, Com port in serial
    public int addressMinor = 0;      // port in TCP/UDP, baudrate in serial
    public int devId;
    public string name;
  }

  [Serializable]
  public class TCPCommConfig : BaseCommConfig {
    public int timeout = 100;
    public int retryCnt = 3;
    public int pollDelay = 20;
  }

  [Serializable]
  public class SerialCommConfig : BaseCommConfig {
    public MBDataBitsEnum dataBits = MBDataBitsEnum.SER_DATABITS_8;
    public MBStopBitsEnum stopBits = MBStopBitsEnum.SER_STOPBITS_1;
    public MBParityEnum parity = MBParityEnum.SER_PARITY_NONE;
    public int timeout = 100;
    public int retryCnt = 3;
    public int pollDelay = 20;
  }

}
