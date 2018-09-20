using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sermo.Data.Contracts;
using Sermo.UI.Contracts;

namespace Sermo.Infrastructure.Contracts
{
    public interface IViewModelMapper //Changes Sprint 2--“I want to serve hundreds of users concurrently.”
                                      //Changes Sprint 2--Abby Sova
    {
        RoomViewModel MapRoomRecordToRoomViewModel(RoomRecord roomRecord);
        RoomRecord MapRoomViewModelToRoomRecord(RoomViewModel roomViewModel);
        
        MessageViewModel MapMessageRecordToMessageViewModel(MessageRecord messageRecord);
        MessageRecord MapMessageViewModelToMessageRecord(MessageViewModel messageViewModel);
    }
}
