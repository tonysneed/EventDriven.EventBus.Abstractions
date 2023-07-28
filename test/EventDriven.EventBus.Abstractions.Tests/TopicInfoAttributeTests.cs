using System;
using Xunit;

namespace EventDriven.EventBus.Abstractions.Tests;

public class TopicInfoAttributeTests
{
    [Theory]
    [InlineData("my-topic", "my-prefix", "my-suffix")]
    public void Attribute_Ctor_Should_Create_Instance_With_Topic_Name(string topic, string prefix, string suffix)
    {
        // Arrange, Act
        var topicAttribute = new TopicInfoAttribute(topic, prefix, suffix);
        
        // Assert
        Assert.Equal(topic, topicAttribute.Topic);
        Assert.Equal(prefix, topicAttribute.Prefix);
        Assert.Equal(suffix, topicAttribute.Suffix);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Attribute_Ctor_Should_Throw_Exception_If_Name_Is_Null_Or_Empty(string? topic)
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            new TopicInfoAttribute(topic!, null, null);
        });
    }
}