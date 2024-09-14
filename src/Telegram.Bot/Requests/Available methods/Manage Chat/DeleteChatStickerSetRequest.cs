﻿namespace Telegram.Bot.Requests;

/// <summary>Use this method to delete a group sticker set from a supergroup. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Use the field <em>CanSetStickerSet</em> optionally returned in <see cref="TelegramBotClientExtensions.GetChatAsync">GetChat</see> requests to check if the bot can use this method.<para>Returns: </para></summary>
public partial class DeleteChatStickerSetRequest() : RequestBase<bool>("deleteChatStickerSet"), IChatTargetable
{
    /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format <c>@supergroupusername</c>)</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required ChatId ChatId { get; set; }
}
