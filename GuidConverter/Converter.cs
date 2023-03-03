namespace Pihalve.GuidConverter;

public class Converter
{
    public ConversionResult? Convert(string input)
    {
        if (!Guid.TryParse(input, out Guid inputGuid))
        {
            if (input.Length != 24)
            {
                return null;
            }

            var bytes = new Span<byte>(new byte[16]);
            if (!System.Convert.TryFromBase64String(input, bytes, out _))
            {
                return null;
            }

            inputGuid = new Guid(bytes);
        }

        var mongoDbOutput = System.Convert.ToBase64String(inputGuid.ToByteArray());
        var normalOutput = new Guid(System.Convert.FromBase64String(mongoDbOutput));

        return new ConversionResult
        {
            MongoDb = mongoDbOutput,
            Normal = normalOutput
        };
    }
}
