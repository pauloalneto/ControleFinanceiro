using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ControleFinanceiro.Common.Api
{
    public class DecimalPtBrConverter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {

            return reader.TokenType switch
            {
                JsonTokenType.Number => reader.GetDecimal(),
                JsonTokenType.Null => 0.0m,
                JsonTokenType.String => Decimal.TryParse(reader.GetString().Replace("R$ ", "").Replace("%", ""), out var parsed) ? parsed : 0.0m,
                _ => throw new ArgumentOutOfRangeException(nameof(reader), reader.TokenType,
                "Cannot parse unexpected JSON token type.")
            };
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString().Replace(".", ","));
        }
    }
}
