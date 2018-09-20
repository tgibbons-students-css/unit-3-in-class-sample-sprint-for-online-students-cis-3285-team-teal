using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sermo.UI.Contracts
{
    public interface IRoomViewModelWriter //Changes for Sprint #1--Abby Sova
                                           //Changes Sprint 2--“I want to serve hundreds of users concurrently.”
                                           //Changes Sprint 2--Abby Sova
    {
        void CreateRoom(RoomViewModel roomViewModel);

        void AddMessage(MessageViewModel messageViewModel);
    }
}
