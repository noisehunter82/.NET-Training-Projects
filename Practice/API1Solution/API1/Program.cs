using API1;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

app.MapGet("/", () => "Payment API running!");
app.MapPost("/process-payment", (PaymentRequest payment) =>
{
    // Simulate payment processing logic
    if (payment.Amount <= 0 || payment.Currency.Length < 3)
    {
        return Results.BadRequest("Invalid payment details.");
    }
    // In a real application, you would integrate with a payment gateway here
    var maskedCard = CardUtliity.MaskCardNumber(payment.CardNumber);
    PaymentResponse response = new("Payment processed successfully", maskedCard);

    return Results.Ok<PaymentResponse>(response);
});

app.Run();

public record PaymentRequest(decimal Amount, string Currency, string CardNumber);
public record PaymentResponse(string Status, string MaskedCard);

[JsonSerializable(typeof(PaymentRequest))]
[JsonSerializable(typeof(PaymentResponse))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
