using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

// Docs: https://developer.apple.com/documentation/weatherkitrestapi/request-authentication-for-weatherkit-rest-api
// Also check https://dev.iachieved.it/iachievedit/weatherkit-rest-api/ for step-by-step instructions.

var teamId = "..."; // Your 10-character Team ID from your developer account.
var keyId = "..."; // A 10-character key identifier (from Keys page).
var serviceId = "..."; // A registered Service ID (from Identifiers page).
var keyText = $@"
-----BEGIN PRIVATE KEY-----
...
...
...
-----END PRIVATE KEY-----
"; // This is key itself. Content of AuthKey_XXX.p8 file that you downloaded after creating the key.

// Now you can generate the JWT. Feel free to modify TTL according to your needs.
var jwt = GenerateJwt(TimeSpan.FromDays(365));

Console.WriteLine("Generated JWT:");
Console.WriteLine(jwt);

string GenerateJwt(TimeSpan ttl)
{
    var jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);

    var header = new
    {
        alg = "ES256",
        kid = keyId,
        id = $"{teamId}.{serviceId}",
    };

    var body = new
    {
        iss = teamId,
        iat = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
        exp = DateTimeOffset.UtcNow.Add(ttl).ToUnixTimeSeconds(),
        sub = serviceId,
    };

    var headerText = Base64UrlEncoder.Encode(JsonSerializer.Serialize(header, jsonOptions));
    var bodyText = Base64UrlEncoder.Encode(JsonSerializer.Serialize(body, jsonOptions));

    var ecdsaKey = ECDsa.Create();
    ecdsaKey.ImportFromPem(keyText);
    var ecdcaSecurityKey = new ECDsaSecurityKey(ecdsaKey);
    var signingCredentials = new SigningCredentials(ecdcaSecurityKey, header.alg);

    var sig = JwtTokenUtilities.CreateEncodedSignature($"{headerText}.{bodyText}", signingCredentials);

    return $"{headerText}.{bodyText}.{sig}";
}