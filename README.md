# WeatherKit Helper

Helper library for REST interaction with WeatherKit: get available datasets, weather data, weather alerts and attribution data.

**Attention:** Apple Developer Account required!

[![NuGet](https://img.shields.io/nuget/v/WeatherKitHelper.svg)](https://www.nuget.org/packages/WeatherKitHelper/) ![.NET 9.0](https://img.shields.io/badge/.NET-9.0-512BD4) ![MIT License](https://img.shields.io/github/license/justdmitry/WeatherKitHelper)

## Installation

Use NuGet package [WeatherKitHelper](https://www.nuget.org/packages/WeatherKitHelper/).

## Dependencies

* Microsoft.Extensions.Http, v10.0.2

## Development & Testing

Tests can be run with `dotnet test` in `WeatherKitHelper.Tests`.

## Demo

Use `Util.TokenGenerator` to create JWT token.

Use `WeatherKitHelper.Demo` to make some calls (don't forget to put your token into appsettings file).

## Useful links

1. [WeatherKit REST API docs](https://developer.apple.com/documentation/weatherkitrestapi)