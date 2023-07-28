using System;

namespace EventDriven.EventBus.Abstractions;

// TODO: Comment
/// <summary>
/// Do later ...
/// </summary>
public class TopicInfoAttribute
{
    // TODO: Comment
    public string Topic { get; }
    // TODO: Comment
    public string? Prefix { get; }
    // TODO: Comment
    public string? Suffix { get; }

    // TODO: Comment
    /// <summary>
    /// Do later ...
    /// </summary>
    /// <param name="topic"></param>
    /// <param name="prefix"></param>
    /// <param name="suffix"></param>
    public TopicInfoAttribute(string topic, string? prefix, string? suffix)
    {
        if (string.IsNullOrWhiteSpace(topic))
            throw new ArgumentNullException(nameof(topic));
        Topic = topic;
        Prefix = prefix;
        Suffix = suffix;
    }
}