﻿namespace EmailServiceIntermediate.Models;

/// <summary>
/// Table for message files
/// </summary>
public partial class File : IEntity
{
    /// <summary>
    /// Id of file
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Content of file
    /// </summary>
    public byte[] Content { get; set; }

    public virtual ICollection<IncomingMessage> IncomingMessages { get; set; } = new List<IncomingMessage>();

    public virtual ICollection<OutgoingMessage> OutgoingMessages { get; set; } = new List<OutgoingMessage>();
}
