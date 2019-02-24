# Telegram.Bot.Extensions.Polling [![NuGet](https://img.shields.io/nuget/v/Telegram.Bot.Extensions.Polling.svg)](https://www.nuget.org/packages/Telegram.Bot.Extensions.Polling/)

Provides `ITelegramBotClient` extensions for polling updates.

## Usage

```csharp
using Telegram.Bot.Extensions.Polling;

Bot.StartReceiving(new DefaultUpdateHandler(HandleUpdateAsync, HandleErrorAsync));
// or
await Bot.ReceiveAsync(new DefaultUpdateHandler(HandleUpdateAsync, HandleErrorAsync));

async Task HandleUpdateAsync(Update update)
{
    if (update.Message is Message message)
    {
        await Bot.SendTextMessageAsync(message.Chat, "Hello");
    }
}

async Task HandleErrorAsync(Exception exception)
{
    if (exception is ApiRequestException apiRequestException)
    {
        await Bot.SendTextMessageAsync(123, apiRequestException.ToString());
    }
}
```

## Update streams

With .Net Core 3.0+ comes support for an `IAsyncEnumerable<Update>` to stream Updates as they are received.

The package also exposes a more advanced `QueuedUpdateReceiver`, that enqueues Updates.

```csharp
using Telegram.Bot.Extensions.Polling;

QueuedUpdateReceiver updateReceiver = new QueuedUpdateReceiver(Bot);

updateReceiver.StartReceiving();

await foreach (Update update in updateReceiver.YieldUpdatesAsync())
{
    if (update.Message is Message message)
    {
        await Bot.SendTextMessageAsync(message.Chat, $"Still have to process {updateReceiver.PendingUpdates} updates");
    }
}
```