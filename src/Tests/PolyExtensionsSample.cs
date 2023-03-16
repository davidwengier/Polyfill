[TestFixture]
[DebuggerNonUserCode]
class PolyExtensionsSample
{
#if !PolyOmitMemoryExtensions
    [Test]
    public void SpanContains() =>
        Assert.True("value".AsSpan().Contains('e'));

    [Test]
    public void SpanSequenceEqual() =>
        Assert.True("value".AsSpan().SequenceEqual("value"));

    [Test]
    public void SpanStringBuilderAppend()
    {
        var builder = new StringBuilder();
        builder.Append("value".AsSpan());
        Assert.AreEqual("value", builder.ToString());
    }
#endif

    [Test]
    public void EndsWith()
    {
        Assert.True("value".EndsWith('e'));
        Assert.False("".EndsWith('e'));
    }

    [Test]
    public void StartsWith()
    {
        Assert.True("value".StartsWith('v'));
        Assert.False("".StartsWith('v'));
    }
}
