namespace OpenDotaApi.Utilities
{
    public interface IJsonDeserialize
    {
        public T Deserialize<T>(string url);
    }
}