


















using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Protocol.Types;
using SSync.IO;
using SSync.Messages;

namespace Symbioz.Protocol.Messages
{

public class FighterStatsListMessage : Message
{

public const ushort Id = 6322;
public override ushort MessageId
{
    get { return Id; }
}

public Types.CharacterCharacteristicsInformations stats;
        

public FighterStatsListMessage()
{
}

public FighterStatsListMessage(Types.CharacterCharacteristicsInformations stats)
        {
            this.stats = stats;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

stats.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

stats = new Types.CharacterCharacteristicsInformations();
            stats.Deserialize(reader);
            

}


}


}