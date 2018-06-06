namespace WebServer.Server.HTTP
{
    using Validation;

    public class HttpHeader
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public HttpHeader(string key, string value)
        {
            Validation.ThrowIfNullOrEmpty(key, nameof(key));
            Validation.ThrowIfNullOrEmpty(value, nameof(value));

            this.Key = key;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Key + ": " + this.Value;
        }
    }
}