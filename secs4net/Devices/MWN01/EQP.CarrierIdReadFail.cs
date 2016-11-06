﻿using Cim.Eap.Tx;
using Secs4Net;
namespace Cim.Eap {
    partial class Driver {
        void EQP_CarrierIDReadFail(SecsMessage msg) {
            EAP.Report(new CarrierIDReport { 
                LoadPortId = GetPortID(msg.SecsItem.Items[2].Items[0].Items[1].Items[0].GetValue<byte>())
            });
        }
    }
}