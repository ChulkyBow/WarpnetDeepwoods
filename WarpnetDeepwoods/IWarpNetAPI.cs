﻿using System;

namespace WarpnetDeepwoods
{
    public interface IWarpNetAPI
    {
        void AddDestination(string ID, string Location, int X, int Y, bool DefaultEnabled, string Label, bool OverrideMapProperty);
        void RemoveDestination(string ID);
        void SetDestinationEnabled(string ID, bool Enabled);
        void SetDestinationLocation(string ID, string Location);
        void SetDestinationPosition(string ID, int X, int Y);
        void SetDestinationLabel(string ID, string Label);
        void SetDestinationOverrideMap(string ID, bool OverrideMapProperty);
        void AddWarpItem(int ObjectID, string Destination, string Color, bool IgnoreDisabled);
        void RemoveWarpItem(int ObjectID);
        void SetWarpItemDestination(int ObjectID, string Destination);
        void SetWarpItemColor(int ObjectID, string Color);
        void SetWarpItemIgnoreDisabled(int ObjectID, bool IgnoreDIsabled);
        void AddCustomDestinationHandler(string ID, Action<string> Warp, Func<string, bool> GetEnabled, Func<string, string> GetLabel);
        void AddCustomDestinationHandler(string ID, Action<string> Warp, bool Enabled, string Label);
        void RemoveCustomDestinationHandler(string ID);
        bool CanWarpTo(string ID);
        bool DestinationExists(string ID);
        bool DestinationIsCustomHandler(string ID);
        bool WarpTo(string ID);
        void ShowWarpMenu(bool Force = false);
        void ShowWarpMenu(string Exclude);
        string[] GetDestinations();
        string[] GetItems();
    }
}
