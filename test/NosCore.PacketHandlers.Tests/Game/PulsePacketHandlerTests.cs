﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.GameObject.Networking;
using NosCore.GameObject.Networking.ClientSession;
using NosCore.PacketHandlers.Game;
using NosCore.Packets.ClientPackets.Movement;
using NosCore.Tests.Shared;

namespace NosCore.PacketHandlers.Tests.Game
{
    [TestClass]
    public class PulsePacketHandlerTests
    {
        private PulsePacketHandler? _pulsePacketHandler;


        private ClientSession? _session;

        [TestInitialize]
        public async Task SetupAsync()
        {
            _pulsePacketHandler = new PulsePacketHandler();
            Broadcaster.Reset();
            await TestHelpers.ResetAsync().ConfigureAwait(false);
            _session = await TestHelpers.Instance.GenerateSessionAsync().ConfigureAwait(false);
        }

        [TestMethod]
        public async Task Test_Pulse_PacketAsync()
        {
            var pulsePacket = new PulsePacket
            {
                Tick = 0
            };

            for (var i = 60; i < 600; i += 60)
            {
                pulsePacket = new PulsePacket
                {
                    Tick = i
                };
                await _pulsePacketHandler!.ExecuteAsync(pulsePacket, _session!).ConfigureAwait(false);
            }

            Assert.IsTrue(_session?.LastPulse == pulsePacket.Tick);
        }
    }
}