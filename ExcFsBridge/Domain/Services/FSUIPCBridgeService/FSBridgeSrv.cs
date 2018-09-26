using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using FSUIPC;

namespace ExcFsBridge.Domain.Services.FSUIPCBridgeService
{
    /// <summary>
    /// The Interface defining methods for Create Employee and Read All Employees  
    /// </summary>
    public interface IFSBridgeSrv
    {
        void Start();
        void Stop();       
    }
    public class FSBridgeSrv
    {
        // Private Static Members
        private static readonly string AppTitle = "FSUIPCClientApplication_CSharp";

        // Create the Offsets we're interested in for this Application
        private Offset<int> airspeed = new Offset<int>(0x02BC);  // Basic integer read example
        private Offset<int> avionics = new Offset<int>(0x2E80);  // Basic integer read and write example
        private Offset<byte[]> fsLocalDateTime = new Offset<byte[]>(0x0238, 10); // Example of reading an arbitary set of bytes. 
        private Offset<string> aircraftType = new Offset<string>("AircraftInfo", 0x3160, 24); // Example of string and use of a group
        private Offset<BitArray> lights = new Offset<BitArray>(0x0D0C, 2); // Example of BitArray used to manage a bit field type offset.
        private Offset<Double> compass = new Offset<double>(0x02CC); // Example for disconnecting/reconnecting
        private Offset<short> pause = new Offset<short>(0x0262, true); // Example of a write only offset.
        private Offset<short> com2bcd = new Offset<short>(0x3118); // Example of reading a frequency coded in Binary Coded Decimal
        private Offset<long> playerLatitude = new Offset<long>(0x0560); // Offset for Lat/Lon features
        private Offset<long> playerLongitude = new Offset<long>(0x0568); // Offset for Lat/Lon features
        private Offset<short> onGround = new Offset<short>(0x0366); // Offset for Lat/Lon features
        private Offset<short> magVar = new Offset<short>(0x02A0); // Offset for Lat/Lon features
        private Offset<uint> playerHeadingTrue = new Offset<uint>(0x0580); // Offset for moving the plane
        private Offset<long> playerAltitude = new Offset<long>(0x0570); // Offset for moving the plane
        private Offset<short> slewMode = new Offset<short>(0x05DC, true); // Offset for moving the plane
        private Offset<int> sendControl = new Offset<int>(0x3110, true); // Offset for moving the plane

        private readonly int REFRESH_SCENERY = 65562; // Control number to refresh the scenery

        private FsLatLonPoint EGLL; // Holds the position of London Heathrow (EGLL)
        private FsLatLonQuadrilateral runwayQuad; // defines the four corners of the runway (27L at EGLL)
        private AITrafficServices AI; // Holds a reference to the AI Traffic Services object


        /// <summary>
        /// 
        /// </summary>
        public FSBridgeSrv()
        {

        }

    

    }
}
