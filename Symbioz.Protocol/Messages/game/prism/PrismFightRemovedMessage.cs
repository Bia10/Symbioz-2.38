


















using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Protocol.Types;
using SSync.IO;
using SSync.Messages;

namespace Symbioz.Protocol.Messages
{

public class PrismFightRemovedMessage : Message
{

public const ushort Id = 6453;
public override ushort MessageId
{
    get { return Id; }
}

public ushort subAreaId;
        

public PrismFightRemovedMessage()
{
}

public PrismFightRemovedMessage(ushort subAreaId)
        {
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhShort(subAreaId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}