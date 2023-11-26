using System.Text.Json.Serialization;

namespace WebFileExplorer;

[JsonSerializable(typeof(Todo[]))]
[JsonSerializable(typeof(Version))]
[JsonSerializable(typeof(byte[]))]
[JsonSerializable(typeof(string[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}
