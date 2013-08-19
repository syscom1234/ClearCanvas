﻿#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using ClearCanvas.Dicom;
using ClearCanvas.ImageServer.Model;

namespace ClearCanvas.ImageServer.Core.Events
{
    /// <summary>
    /// EventArgs for when a new SOP Instance has been processed
    /// </summary>
    /// <remarks>
    /// The following example code shows how to define an extension that wil receive NewSopEventArgs events.
    /// Just create a class that implements <see cref="IEventHandler{TImageServerEventArgs}"/> and add
    /// the appropriate ExtensionOf attribute as shown below.  In this event case, it will be called each
    /// time a new SOP Instance UID is processed by the ImageServer.
    /// <code>
    /// [ExtensionOf(typeof(EventExtensionPoint<NewSopEventArgs>))]
    /// public class NewSopEventHandler : IEventHandler<NewSopEventArgs> 
    /// {
    ///    public void EventHandler(object sender, NewSopEventArgs e)
    ///    {
    ///    }
    /// }
    /// </code>
    /// </remarks>
    public class NewSopEventArgs : ImageServerEventArgs
    {
        public DicomFile File { get; set; }
        public ServerPartition ServerPartitionEntry { get; set; }
        public WorkQueueUid WorkQueueUidEntry { get; set; }
        public WorkQueue WorkQueueEntry { get; set; }
        public ulong FileLength { get; set; }
    }
}